using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace Oscillator
{
    /// <summary>
    /// Генератор сигнала
    /// Sin, Square, Triangle, SawTooth.
    /// </summary>
    /// <remarks>
    /// Есть возможность изменить ISampleProvider
    /// Пример :
    /// ---------
    /// WaveOut _waveOutGene = new WaveOut();
    /// WaveGenerator wg = new SignalGenerator();
    /// wg.Type = ...
    /// wg.Frequency = ...
    /// wg ...
    /// _waveOutGene.Init(wg);
    /// _waveOutGene.Play();
    /// </remarks>
    public class SignalGenerator : ISampleProvider
    {
        // Формат сигнала
        private readonly WaveFormat waveFormat;

        // Математическая константа
        private const double TwoPi = 2*Math.PI;

        // Переменная генератора
        private int nSample;

        /// <summary>
        /// Инициализация нового экземпляра Генератора (По-умолчанию :: 44.1Khz, 2 канала, Sinus, Частота = 440, Уровень сигнала = 1)
        /// </summary>
        public SignalGenerator()
            : this(44100, 2)
        {

        }

        /// <summary>
        /// Инициализация нового экземпляра Генератора (UserDef SampleRate &amp; Channels)
        /// </summary>
        /// <param name="sampleRate">Желаемая частота дискретизации</param>
        /// <param name="channel">Количество каналов</param>
        public SignalGenerator(int sampleRate, int channel)
        {
            waveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channel);

            // По-умолчанию
            Type = SignalGeneratorType.Sin;
            Frequency = 440.0;
            Gain = 1;
            PhaseReverse = new bool[channel];
        }

        /// <summary>
        /// The waveformat для WaveProvider
        /// </summary>
        public WaveFormat WaveFormat
        {
            get { return waveFormat; }
        }

        /// <summary>
        /// Частота для Генератора. (20.0 - 30000.0 Hz)
        /// Sin, Square, Triangle, SawTooth.
        /// </summary>
        public double Frequency { get; set; }

        /// <summary>
        /// Уровень сигнала Генератора. (от 0.0 до 1.0)
        /// </summary>
        public double Gain { get; set; }

        /// <summary>
        /// PhaseReverse канала
        /// </summary>
        public bool[] PhaseReverse { get; private set; }

        /// <summary>
        /// Тип Генератора.
        /// </summary>
        public SignalGeneratorType Type { get; set; }

        /// <summary>
        /// Reads from this provider.
        /// </summary>
        public int Read(float[] buffer, int offset, int count)
        {
            int outIndex = offset;

            // текущие значения генератора
            double multiple;
            double sampleValue;
            double sampleSaw;

            // окончательный буффер
            for (int sampleCount = 0; sampleCount < count/waveFormat.Channels; sampleCount++)
            {
                switch (Type)
                {
                    case SignalGeneratorType.Sin:

                        // Sinus генератор

                        multiple = TwoPi*Frequency/waveFormat.SampleRate;
                        sampleValue = Gain*Math.Sin(nSample*multiple);

                        nSample++;

                        break;


                    case SignalGeneratorType.Square:

                        // Square генератор

                        multiple = 2*Frequency/waveFormat.SampleRate;
                        sampleSaw = ((nSample*multiple)%2) - 1;
                        sampleValue = sampleSaw > 0 ? Gain : -Gain;

                        nSample++;
                        break;

                    case SignalGeneratorType.Triangle:

                        // Triangle генератор

                        multiple = 2*Frequency/waveFormat.SampleRate;
                        sampleSaw = ((nSample*multiple)%2);
                        sampleValue = 2*sampleSaw;
                        if (sampleValue > 1)
                            sampleValue = 2 - sampleValue;
                        if (sampleValue < -1)
                            sampleValue = -2 - sampleValue;

                        sampleValue *= Gain;

                        nSample++;
                        break;

                    case SignalGeneratorType.SawTooth:

                        // SawTooth генератор

                        multiple = 2*Frequency/waveFormat.SampleRate;
                        sampleSaw = ((nSample*multiple)%2) - 1;
                        sampleValue = Gain*sampleSaw;

                        nSample++;
                        break;

                    default:
                        sampleValue = 0.0;
                        break;
                }

                // Phase Reverse для каждого канала
                for (int i = 0; i < waveFormat.Channels; i++)
                {
                    if (PhaseReverse[i])
                        buffer[outIndex++] = (float) -sampleValue;
                    else
                        buffer[outIndex++] = (float) sampleValue;
                }
            }
            return count;
        }
    }

    /// <summary>
    /// Тип генератора сигнала
    /// </summary>
    public enum SignalGeneratorType
    {
        /// <summary>
        /// Sine сигнал
        /// </summary>
        Sin,
        /// <summary>
        /// Square сигнал
        /// </summary>
        Square,
        /// <summary>
        /// Triangle сигнал
        /// </summary>
        Triangle,
        /// <summary>
        /// Sawtooth сигнал
        /// </summary>
        SawTooth,
    }
}
