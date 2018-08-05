using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Oscillator
{
    public partial class FormMain : Form
    {
        private readonly WaveOut driverOut1;

        private readonly WaveOut driverOut2;

        private readonly SignalGenerator wg1;

        private readonly SignalGenerator wg2;

        private bool audio1Started;

        private bool audio2Started;

        public FormMain()
        {
            InitializeComponent();
            comboBoxWaveTypeSignal1.SelectedIndex = 0;
            comboBoxWaveTypeSignal2.SelectedIndex = 0;
            trackBarAmplitude1.Value = 100;
            trackBarAmplitude2.Value = 100;
            
            labelAmplitudeValue1.Text = (trackBarAmplitude1.Value/100f).ToString();
            labelAmplitudeValue2.Text = (trackBarAmplitude2.Value / 100f).ToString();

            // Init Audio
            driverOut1 = new WaveOut {DesiredLatency = 100};
            driverOut2 = new WaveOut {DesiredLatency = 100};

            wg1 = new SignalGenerator();
            wg2 = new SignalGenerator();
            wg1.Gain = trackBarAmplitude1.Value/100f;
            wg2.Gain = trackBarAmplitude2.Value/100f;

            wg1.PhaseReverse[0] = checkBoxPhaseReverse1Left.Checked;
            wg1.PhaseReverse[1] = checkBoxPhaseReverse1Right.Checked;
            wg2.PhaseReverse[0] = checkBoxPhaseReverse2Left.Checked;
            wg2.PhaseReverse[1] = checkBoxPhaseReverse2Right.Checked;

            // Init Driver Audio
            driverOut1.Init(wg1);
            driverOut2.Init(wg2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (driverOut1 == null) return;
            if (!audio1Started)
            {
                driverOut1.Play();
                audio1Started = true;
                button1SignalGenerate.Text = "Остановить";
            }
            else
            {
                driverOut1.Stop();
                audio1Started = false;
                button1SignalGenerate.Text = "Запуск";
            }

            if (!audio1Started && !audio2Started || (!audio1Started && audio2Started) || (audio1Started && !audio2Started))
            {
                buttonSignalsGenerate.Text = "Запуск";
            }
            else
            {
                buttonSignalsGenerate.Text = "Остановить";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (driverOut2 == null) return;
            if (!audio2Started)
            {
                driverOut2.Play();
                audio2Started = true;
                button2SignalGenerate.Text = "Остановить";
            }
            else
            {
                driverOut2.Stop();
                audio2Started = false;
                button2SignalGenerate.Text = "Запуск";
            }

            if (!audio1Started && !audio2Started || (!audio1Started && audio2Started) || (audio1Started && !audio2Started))
            {
                buttonSignalsGenerate.Text = "Запуск";
            }
            else
            {
                buttonSignalsGenerate.Text = "Остановить";
            }
        }

        private void trackBarFrequency1_Scroll(object sender, EventArgs e)
        {
            wg1.Frequency = trackBarFrequency1.Value;
            numericUpDownFrequencyValue1.Value = trackBarFrequency1.Value;
        }

        private void numericUpDownFrequencyValue1_ValueChanged(object sender, EventArgs e)
        {
            wg1.Frequency = (int)numericUpDownFrequencyValue1.Value;
            trackBarFrequency1.Value = (int)numericUpDownFrequencyValue1.Value;
        }

        private void trackBarFrequency2_Scroll(object sender, EventArgs e)
        {
            wg2.Frequency = trackBarFrequency2.Value;
            numericUpDownFrequencyValue2.Value = trackBarFrequency2.Value;
        }

        private void numericUpDownFrequencyValue2_ValueChanged(object sender, EventArgs e)
        {
            wg2.Frequency = (int)numericUpDownFrequencyValue2.Value;
            trackBarFrequency2.Value = (int)numericUpDownFrequencyValue2.Value;
        }

        private void trackBarAmplitude1_Scroll(object sender, EventArgs e)
        {
            wg1.Gain = trackBarAmplitude1.Value/100f;
            labelAmplitudeValue1.Text = (trackBarAmplitude1.Value/100f).ToString();
        }

        private void trackBarAmplitude2_Scroll(object sender, EventArgs e)
        {
            wg2.Gain = trackBarAmplitude2.Value / 100f;
            labelAmplitudeValue2.Text = (trackBarAmplitude2.Value / 100f).ToString();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxWaveTypeSignal1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wg1 == null) return;
            switch (comboBoxWaveTypeSignal1.SelectedItem.ToString())
            {
                case "Sin":
                    wg1.Type = SignalGeneratorType.Sin;
                    break;
                case "Square":
                    wg1.Type = SignalGeneratorType.Square;
                    break;
                case "Triangle":
                    wg1.Type = SignalGeneratorType.Triangle;
                    break;
                case "SawTooth":
                    wg1.Type = SignalGeneratorType.SawTooth;
                    break;
                default:
                    wg1.Type = SignalGeneratorType.Sin;
                    break;
            }
        }

        private void comboBoxWaveTypeSignal2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wg2 == null) return;
            switch (comboBoxWaveTypeSignal2.SelectedItem.ToString())
            {
                case "Sin":
                    wg2.Type = SignalGeneratorType.Sin;
                    break;
                case "Square":
                    wg2.Type = SignalGeneratorType.Square;
                    break;
                case "Triangle":
                    wg2.Type = SignalGeneratorType.Triangle;
                    break;
                case "SawTooth":
                    wg2.Type = SignalGeneratorType.SawTooth;
                    break;
                default:
                    wg2.Type = SignalGeneratorType.Sin;
                    break;
            }
        }

        private void button1SaveSignal_Click(object sender, EventArgs e)
        {
            var saveSeconds = (int)numericUpDown1SaveSignalSeconds.Value;
            var sfd = new SaveFileDialog {Filter = "WAV Файл|*.wav"};
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var osp = new OffsetSampleProvider(wg1)
            {
                TakeSamples = wg1.WaveFormat.SampleRate * saveSeconds * wg1.WaveFormat.Channels
            };
            WaveFileWriter.CreateWaveFile16(sfd.FileName, osp);
        }

        private void button2SaveSignal_Click(object sender, EventArgs e)
        {
            var saveSeconds = (int)numericUpDown2SaveSignalSeconds.Value;
            var sfd = new SaveFileDialog {Filter = "WAV Файл|*.wav"};
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var osp = new OffsetSampleProvider(wg2)
            {
                TakeSamples = wg2.WaveFormat.SampleRate * saveSeconds * wg2.WaveFormat.Channels
            };
            WaveFileWriter.CreateWaveFile16(sfd.FileName, osp);
        }

        private void сохранитьСигнал1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1SaveSignal_Click(sender, e);
        }

        private void сохранитьСигнал2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button2SaveSignal_Click(sender, e);
        }

        private void buttonSignalsGenerate_Click(object sender, EventArgs e)
        {
            if (!audio1Started && !audio2Started)
            {
                button1_Click(sender, e);
                button2_Click(sender, e);
                buttonSignalsGenerate.Text = "Остановить";
            }
            else if (!audio1Started && audio2Started)
            {
                button1_Click(sender, e);
                buttonSignalsGenerate.Text = "Запуск";
            }
            else if (!audio2Started && audio1Started)
            {
                button2_Click(sender, e);
                buttonSignalsGenerate.Text = "Остановить";
            }
            else
            {
                button1_Click(sender, e);
                button2_Click(sender, e);
                buttonSignalsGenerate.Text = "Запуск";
            }
        }

        private void buttonSaveSignals_Click(object sender, EventArgs e)
        {
            var samplesList = new List<ISampleProvider> {wg1, wg2};

            var mixer = new MixingSampleProvider(samplesList);

            var waveOut = new WaveOut();
            waveOut.Init(mixer);
            //waveOut.Play();

            var saveSeconds = (int) numericUpDownSaveSignalsSeconds.Value;
            var sfd = new SaveFileDialog {Filter = "WAV Файл|*.wav"};
            if (sfd.ShowDialog() != DialogResult.OK) return;
            var osp = new OffsetSampleProvider(mixer)
            {
                TakeSamples = mixer.WaveFormat.SampleRate * saveSeconds * mixer.WaveFormat.Channels
            };
            WaveFileWriter.CreateWaveFile16(sfd.FileName, osp);
        }

        private void сохранитьМиксованныйСигналWavToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSaveSignals_Click(sender, e);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа предназначена для генерации гармонических сигналов с частотой от 20Гц до 30000Гц.\nАвтор: Чеботов Николай Валерьевич.\n2014 г.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxPhaseReverse1Left_CheckedChanged(object sender, EventArgs e)
        {
            wg1.PhaseReverse[0] = checkBoxPhaseReverse1Left.Checked;
        }

        private void checkBoxPhaseReverse1Right_CheckedChanged(object sender, EventArgs e)
        {
            wg1.PhaseReverse[1] = checkBoxPhaseReverse1Right.Checked;
        }

        private void checkBoxPhaseReverse2Left_CheckedChanged(object sender, EventArgs e)
        {
            wg2.PhaseReverse[0] = checkBoxPhaseReverse2Left.Checked;
        }

        private void checkBoxPhaseReverse2Right_CheckedChanged(object sender, EventArgs e)
        {
            wg2.PhaseReverse[1] = checkBoxPhaseReverse2Right.Checked;
        }

    }
}
