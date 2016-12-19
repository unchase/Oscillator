namespace Oscillator
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.groupBoxWavesMixer = new System.Windows.Forms.GroupBox();
            this.labelSaveSignalsSeconds = new System.Windows.Forms.Label();
            this.numericUpDownSaveSignalsSeconds = new System.Windows.Forms.NumericUpDown();
            this.buttonSaveSignals = new System.Windows.Forms.Button();
            this.buttonSignalsGenerate = new System.Windows.Forms.Button();
            this.groupBoxSignal2 = new System.Windows.Forms.GroupBox();
            this.label2SaveSignalSeconds = new System.Windows.Forms.Label();
            this.numericUpDown2SaveSignalSeconds = new System.Windows.Forms.NumericUpDown();
            this.button2SaveSignal = new System.Windows.Forms.Button();
            this.button2SignalGenerate = new System.Windows.Forms.Button();
            this.labelAmplitudeValue2 = new System.Windows.Forms.Label();
            this.trackBarAmplitude2 = new System.Windows.Forms.TrackBar();
            this.labelAmplitude2 = new System.Windows.Forms.Label();
            this.labelFrequencyValue2 = new System.Windows.Forms.Label();
            this.numericUpDownFrequencyValue2 = new System.Windows.Forms.NumericUpDown();
            this.trackBarFrequency2 = new System.Windows.Forms.TrackBar();
            this.labelFrequency2 = new System.Windows.Forms.Label();
            this.comboBoxWaveTypeSignal2 = new System.Windows.Forms.ComboBox();
            this.labelWaveTypeSignal2 = new System.Windows.Forms.Label();
            this.groupBoxSignal1 = new System.Windows.Forms.GroupBox();
            this.label1SaveSignalSeconds = new System.Windows.Forms.Label();
            this.numericUpDown1SaveSignalSeconds = new System.Windows.Forms.NumericUpDown();
            this.button1SaveSignal = new System.Windows.Forms.Button();
            this.button1SignalGenerate = new System.Windows.Forms.Button();
            this.labelAmplitudeValue1 = new System.Windows.Forms.Label();
            this.trackBarAmplitude1 = new System.Windows.Forms.TrackBar();
            this.labelAmplitude1 = new System.Windows.Forms.Label();
            this.numericUpDownFrequencyValue1 = new System.Windows.Forms.NumericUpDown();
            this.labelFrequencyValue1 = new System.Windows.Forms.Label();
            this.labelFrequency1 = new System.Windows.Forms.Label();
            this.trackBarFrequency1 = new System.Windows.Forms.TrackBar();
            this.comboBoxWaveTypeSignal1 = new System.Windows.Forms.ComboBox();
            this.labelWaveTypeSignal1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСигнал1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьСигнал2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьМиксованныйСигналWavToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxPhaseReverse1 = new System.Windows.Forms.GroupBox();
            this.groupBoxPhaseReverse2 = new System.Windows.Forms.GroupBox();
            this.checkBoxPhaseReverse1Left = new System.Windows.Forms.CheckBox();
            this.checkBoxPhaseReverse1Right = new System.Windows.Forms.CheckBox();
            this.checkBoxPhaseReverse2Left = new System.Windows.Forms.CheckBox();
            this.checkBoxPhaseReverse2Right = new System.Windows.Forms.CheckBox();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxWavesMixer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaveSignalsSeconds)).BeginInit();
            this.groupBoxSignal2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2SaveSignalSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmplitude2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequencyValue2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency2)).BeginInit();
            this.groupBoxSignal1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1SaveSignalSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmplitude1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequencyValue1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBoxPhaseReverse1.SuspendLayout();
            this.groupBoxPhaseReverse2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.groupBoxWavesMixer);
            this.groupBoxMain.Controls.Add(this.groupBoxSignal2);
            this.groupBoxMain.Controls.Add(this.groupBoxSignal1);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 27);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(605, 315);
            this.groupBoxMain.TabIndex = 0;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Параметры сигналов";
            // 
            // groupBoxWavesMixer
            // 
            this.groupBoxWavesMixer.Controls.Add(this.labelSaveSignalsSeconds);
            this.groupBoxWavesMixer.Controls.Add(this.numericUpDownSaveSignalsSeconds);
            this.groupBoxWavesMixer.Controls.Add(this.buttonSaveSignals);
            this.groupBoxWavesMixer.Controls.Add(this.buttonSignalsGenerate);
            this.groupBoxWavesMixer.Location = new System.Drawing.Point(6, 254);
            this.groupBoxWavesMixer.Name = "groupBoxWavesMixer";
            this.groupBoxWavesMixer.Size = new System.Drawing.Size(593, 55);
            this.groupBoxWavesMixer.TabIndex = 2;
            this.groupBoxWavesMixer.TabStop = false;
            this.groupBoxWavesMixer.Text = "Микшер";
            // 
            // labelSaveSignalsSeconds
            // 
            this.labelSaveSignalsSeconds.AutoSize = true;
            this.labelSaveSignalsSeconds.Location = new System.Drawing.Point(555, 24);
            this.labelSaveSignalsSeconds.Name = "labelSaveSignalsSeconds";
            this.labelSaveSignalsSeconds.Size = new System.Drawing.Size(25, 13);
            this.labelSaveSignalsSeconds.TabIndex = 3;
            this.labelSaveSignalsSeconds.Text = "сек";
            // 
            // numericUpDownSaveSignalsSeconds
            // 
            this.numericUpDownSaveSignalsSeconds.Location = new System.Drawing.Point(469, 22);
            this.numericUpDownSaveSignalsSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSaveSignalsSeconds.Name = "numericUpDownSaveSignalsSeconds";
            this.numericUpDownSaveSignalsSeconds.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownSaveSignalsSeconds.TabIndex = 2;
            this.numericUpDownSaveSignalsSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSaveSignals
            // 
            this.buttonSaveSignals.Location = new System.Drawing.Point(388, 19);
            this.buttonSaveSignals.Name = "buttonSaveSignals";
            this.buttonSaveSignals.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveSignals.TabIndex = 1;
            this.buttonSaveSignals.Text = "Сохранить";
            this.buttonSaveSignals.UseVisualStyleBackColor = true;
            this.buttonSaveSignals.Click += new System.EventHandler(this.buttonSaveSignals_Click);
            // 
            // buttonSignalsGenerate
            // 
            this.buttonSignalsGenerate.Location = new System.Drawing.Point(307, 19);
            this.buttonSignalsGenerate.Name = "buttonSignalsGenerate";
            this.buttonSignalsGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonSignalsGenerate.TabIndex = 0;
            this.buttonSignalsGenerate.Text = "Запуск";
            this.buttonSignalsGenerate.UseVisualStyleBackColor = true;
            this.buttonSignalsGenerate.Click += new System.EventHandler(this.buttonSignalsGenerate_Click);
            // 
            // groupBoxSignal2
            // 
            this.groupBoxSignal2.Controls.Add(this.groupBoxPhaseReverse2);
            this.groupBoxSignal2.Controls.Add(this.label2SaveSignalSeconds);
            this.groupBoxSignal2.Controls.Add(this.numericUpDown2SaveSignalSeconds);
            this.groupBoxSignal2.Controls.Add(this.button2SaveSignal);
            this.groupBoxSignal2.Controls.Add(this.button2SignalGenerate);
            this.groupBoxSignal2.Controls.Add(this.labelAmplitudeValue2);
            this.groupBoxSignal2.Controls.Add(this.trackBarAmplitude2);
            this.groupBoxSignal2.Controls.Add(this.labelAmplitude2);
            this.groupBoxSignal2.Controls.Add(this.labelFrequencyValue2);
            this.groupBoxSignal2.Controls.Add(this.numericUpDownFrequencyValue2);
            this.groupBoxSignal2.Controls.Add(this.trackBarFrequency2);
            this.groupBoxSignal2.Controls.Add(this.labelFrequency2);
            this.groupBoxSignal2.Controls.Add(this.comboBoxWaveTypeSignal2);
            this.groupBoxSignal2.Controls.Add(this.labelWaveTypeSignal2);
            this.groupBoxSignal2.Location = new System.Drawing.Point(307, 19);
            this.groupBoxSignal2.Name = "groupBoxSignal2";
            this.groupBoxSignal2.Size = new System.Drawing.Size(292, 229);
            this.groupBoxSignal2.TabIndex = 1;
            this.groupBoxSignal2.TabStop = false;
            this.groupBoxSignal2.Text = "Сигнал-2";
            // 
            // label2SaveSignalSeconds
            // 
            this.label2SaveSignalSeconds.AutoSize = true;
            this.label2SaveSignalSeconds.Location = new System.Drawing.Point(254, 204);
            this.label2SaveSignalSeconds.Name = "label2SaveSignalSeconds";
            this.label2SaveSignalSeconds.Size = new System.Drawing.Size(25, 13);
            this.label2SaveSignalSeconds.TabIndex = 12;
            this.label2SaveSignalSeconds.Text = "сек";
            // 
            // numericUpDown2SaveSignalSeconds
            // 
            this.numericUpDown2SaveSignalSeconds.Location = new System.Drawing.Point(168, 202);
            this.numericUpDown2SaveSignalSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2SaveSignalSeconds.Name = "numericUpDown2SaveSignalSeconds";
            this.numericUpDown2SaveSignalSeconds.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2SaveSignalSeconds.TabIndex = 11;
            this.numericUpDown2SaveSignalSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2SaveSignal
            // 
            this.button2SaveSignal.Location = new System.Drawing.Point(87, 199);
            this.button2SaveSignal.Name = "button2SaveSignal";
            this.button2SaveSignal.Size = new System.Drawing.Size(75, 23);
            this.button2SaveSignal.TabIndex = 10;
            this.button2SaveSignal.Text = "Сохранить";
            this.button2SaveSignal.UseVisualStyleBackColor = true;
            this.button2SaveSignal.Click += new System.EventHandler(this.button2SaveSignal_Click);
            // 
            // button2SignalGenerate
            // 
            this.button2SignalGenerate.Location = new System.Drawing.Point(6, 199);
            this.button2SignalGenerate.Name = "button2SignalGenerate";
            this.button2SignalGenerate.Size = new System.Drawing.Size(75, 23);
            this.button2SignalGenerate.TabIndex = 3;
            this.button2SignalGenerate.Text = "Запуск";
            this.button2SignalGenerate.UseVisualStyleBackColor = true;
            this.button2SignalGenerate.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelAmplitudeValue2
            // 
            this.labelAmplitudeValue2.AutoSize = true;
            this.labelAmplitudeValue2.Location = new System.Drawing.Point(185, 148);
            this.labelAmplitudeValue2.Name = "labelAmplitudeValue2";
            this.labelAmplitudeValue2.Size = new System.Drawing.Size(13, 13);
            this.labelAmplitudeValue2.TabIndex = 9;
            this.labelAmplitudeValue2.Text = "0";
            // 
            // trackBarAmplitude2
            // 
            this.trackBarAmplitude2.Location = new System.Drawing.Point(6, 148);
            this.trackBarAmplitude2.Maximum = 100;
            this.trackBarAmplitude2.Name = "trackBarAmplitude2";
            this.trackBarAmplitude2.Size = new System.Drawing.Size(176, 45);
            this.trackBarAmplitude2.TabIndex = 8;
            this.trackBarAmplitude2.Scroll += new System.EventHandler(this.trackBarAmplitude2_Scroll);
            // 
            // labelAmplitude2
            // 
            this.labelAmplitude2.AutoSize = true;
            this.labelAmplitude2.Location = new System.Drawing.Point(22, 132);
            this.labelAmplitude2.Name = "labelAmplitude2";
            this.labelAmplitude2.Size = new System.Drawing.Size(159, 13);
            this.labelAmplitude2.TabIndex = 7;
            this.labelAmplitude2.Text = "Амплитуда (уровень сигнала):";
            // 
            // labelFrequencyValue2
            // 
            this.labelFrequencyValue2.AutoSize = true;
            this.labelFrequencyValue2.Location = new System.Drawing.Point(254, 86);
            this.labelFrequencyValue2.Name = "labelFrequencyValue2";
            this.labelFrequencyValue2.Size = new System.Drawing.Size(19, 13);
            this.labelFrequencyValue2.TabIndex = 6;
            this.labelFrequencyValue2.Text = "Гц";
            // 
            // numericUpDownFrequencyValue2
            // 
            this.numericUpDownFrequencyValue2.Location = new System.Drawing.Point(188, 84);
            this.numericUpDownFrequencyValue2.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownFrequencyValue2.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFrequencyValue2.Name = "numericUpDownFrequencyValue2";
            this.numericUpDownFrequencyValue2.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownFrequencyValue2.TabIndex = 6;
            this.numericUpDownFrequencyValue2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFrequencyValue2.ValueChanged += new System.EventHandler(this.numericUpDownFrequencyValue2_ValueChanged);
            // 
            // trackBarFrequency2
            // 
            this.trackBarFrequency2.Location = new System.Drawing.Point(6, 84);
            this.trackBarFrequency2.Maximum = 30000;
            this.trackBarFrequency2.Minimum = 20;
            this.trackBarFrequency2.Name = "trackBarFrequency2";
            this.trackBarFrequency2.Size = new System.Drawing.Size(176, 45);
            this.trackBarFrequency2.TabIndex = 6;
            this.trackBarFrequency2.TickFrequency = 500;
            this.trackBarFrequency2.Value = 20;
            this.trackBarFrequency2.Scroll += new System.EventHandler(this.trackBarFrequency2_Scroll);
            // 
            // labelFrequency2
            // 
            this.labelFrequency2.AutoSize = true;
            this.labelFrequency2.Location = new System.Drawing.Point(22, 68);
            this.labelFrequency2.Name = "labelFrequency2";
            this.labelFrequency2.Size = new System.Drawing.Size(52, 13);
            this.labelFrequency2.TabIndex = 2;
            this.labelFrequency2.Text = "Частота:";
            // 
            // comboBoxWaveTypeSignal2
            // 
            this.comboBoxWaveTypeSignal2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWaveTypeSignal2.FormattingEnabled = true;
            this.comboBoxWaveTypeSignal2.Items.AddRange(new object[] {
            "Sin",
            "Square",
            "SawTooth",
            "Triangle"});
            this.comboBoxWaveTypeSignal2.Location = new System.Drawing.Point(66, 32);
            this.comboBoxWaveTypeSignal2.Name = "comboBoxWaveTypeSignal2";
            this.comboBoxWaveTypeSignal2.Size = new System.Drawing.Size(159, 21);
            this.comboBoxWaveTypeSignal2.TabIndex = 1;
            this.comboBoxWaveTypeSignal2.SelectedIndexChanged += new System.EventHandler(this.comboBoxWaveTypeSignal2_SelectedIndexChanged);
            // 
            // labelWaveTypeSignal2
            // 
            this.labelWaveTypeSignal2.AutoSize = true;
            this.labelWaveTypeSignal2.Location = new System.Drawing.Point(110, 16);
            this.labelWaveTypeSignal2.Name = "labelWaveTypeSignal2";
            this.labelWaveTypeSignal2.Size = new System.Drawing.Size(73, 13);
            this.labelWaveTypeSignal2.TabIndex = 0;
            this.labelWaveTypeSignal2.Text = "Тип сигнала:";
            // 
            // groupBoxSignal1
            // 
            this.groupBoxSignal1.Controls.Add(this.groupBoxPhaseReverse1);
            this.groupBoxSignal1.Controls.Add(this.label1SaveSignalSeconds);
            this.groupBoxSignal1.Controls.Add(this.numericUpDown1SaveSignalSeconds);
            this.groupBoxSignal1.Controls.Add(this.button1SaveSignal);
            this.groupBoxSignal1.Controls.Add(this.button1SignalGenerate);
            this.groupBoxSignal1.Controls.Add(this.labelAmplitudeValue1);
            this.groupBoxSignal1.Controls.Add(this.trackBarAmplitude1);
            this.groupBoxSignal1.Controls.Add(this.labelAmplitude1);
            this.groupBoxSignal1.Controls.Add(this.numericUpDownFrequencyValue1);
            this.groupBoxSignal1.Controls.Add(this.labelFrequencyValue1);
            this.groupBoxSignal1.Controls.Add(this.labelFrequency1);
            this.groupBoxSignal1.Controls.Add(this.trackBarFrequency1);
            this.groupBoxSignal1.Controls.Add(this.comboBoxWaveTypeSignal1);
            this.groupBoxSignal1.Controls.Add(this.labelWaveTypeSignal1);
            this.groupBoxSignal1.Location = new System.Drawing.Point(6, 19);
            this.groupBoxSignal1.Name = "groupBoxSignal1";
            this.groupBoxSignal1.Size = new System.Drawing.Size(292, 229);
            this.groupBoxSignal1.TabIndex = 0;
            this.groupBoxSignal1.TabStop = false;
            this.groupBoxSignal1.Text = "Сигнал-1";
            // 
            // label1SaveSignalSeconds
            // 
            this.label1SaveSignalSeconds.AutoSize = true;
            this.label1SaveSignalSeconds.Location = new System.Drawing.Point(259, 204);
            this.label1SaveSignalSeconds.Name = "label1SaveSignalSeconds";
            this.label1SaveSignalSeconds.Size = new System.Drawing.Size(25, 13);
            this.label1SaveSignalSeconds.TabIndex = 10;
            this.label1SaveSignalSeconds.Text = "сек";
            // 
            // numericUpDown1SaveSignalSeconds
            // 
            this.numericUpDown1SaveSignalSeconds.Location = new System.Drawing.Point(168, 202);
            this.numericUpDown1SaveSignalSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1SaveSignalSeconds.Name = "numericUpDown1SaveSignalSeconds";
            this.numericUpDown1SaveSignalSeconds.Size = new System.Drawing.Size(85, 20);
            this.numericUpDown1SaveSignalSeconds.TabIndex = 2;
            this.numericUpDown1SaveSignalSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1SaveSignal
            // 
            this.button1SaveSignal.Location = new System.Drawing.Point(87, 199);
            this.button1SaveSignal.Name = "button1SaveSignal";
            this.button1SaveSignal.Size = new System.Drawing.Size(75, 23);
            this.button1SaveSignal.TabIndex = 9;
            this.button1SaveSignal.Text = "Сохранить";
            this.button1SaveSignal.UseVisualStyleBackColor = true;
            this.button1SaveSignal.Click += new System.EventHandler(this.button1SaveSignal_Click);
            // 
            // button1SignalGenerate
            // 
            this.button1SignalGenerate.Location = new System.Drawing.Point(6, 199);
            this.button1SignalGenerate.Name = "button1SignalGenerate";
            this.button1SignalGenerate.Size = new System.Drawing.Size(75, 23);
            this.button1SignalGenerate.TabIndex = 2;
            this.button1SignalGenerate.Text = "Запуск";
            this.button1SignalGenerate.UseVisualStyleBackColor = true;
            this.button1SignalGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAmplitudeValue1
            // 
            this.labelAmplitudeValue1.AutoSize = true;
            this.labelAmplitudeValue1.Location = new System.Drawing.Point(188, 148);
            this.labelAmplitudeValue1.Name = "labelAmplitudeValue1";
            this.labelAmplitudeValue1.Size = new System.Drawing.Size(13, 13);
            this.labelAmplitudeValue1.TabIndex = 8;
            this.labelAmplitudeValue1.Text = "0";
            // 
            // trackBarAmplitude1
            // 
            this.trackBarAmplitude1.Location = new System.Drawing.Point(6, 148);
            this.trackBarAmplitude1.Maximum = 100;
            this.trackBarAmplitude1.Name = "trackBarAmplitude1";
            this.trackBarAmplitude1.Size = new System.Drawing.Size(176, 45);
            this.trackBarAmplitude1.TabIndex = 7;
            this.trackBarAmplitude1.Scroll += new System.EventHandler(this.trackBarAmplitude1_Scroll);
            // 
            // labelAmplitude1
            // 
            this.labelAmplitude1.AutoSize = true;
            this.labelAmplitude1.Location = new System.Drawing.Point(20, 132);
            this.labelAmplitude1.Name = "labelAmplitude1";
            this.labelAmplitude1.Size = new System.Drawing.Size(159, 13);
            this.labelAmplitude1.TabIndex = 6;
            this.labelAmplitude1.Text = "Амплитуда (уровень сигнала):";
            // 
            // numericUpDownFrequencyValue1
            // 
            this.numericUpDownFrequencyValue1.Location = new System.Drawing.Point(193, 84);
            this.numericUpDownFrequencyValue1.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numericUpDownFrequencyValue1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFrequencyValue1.Name = "numericUpDownFrequencyValue1";
            this.numericUpDownFrequencyValue1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownFrequencyValue1.TabIndex = 5;
            this.numericUpDownFrequencyValue1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownFrequencyValue1.ValueChanged += new System.EventHandler(this.numericUpDownFrequencyValue1_ValueChanged);
            // 
            // labelFrequencyValue1
            // 
            this.labelFrequencyValue1.AutoSize = true;
            this.labelFrequencyValue1.Location = new System.Drawing.Point(259, 86);
            this.labelFrequencyValue1.Name = "labelFrequencyValue1";
            this.labelFrequencyValue1.Size = new System.Drawing.Size(19, 13);
            this.labelFrequencyValue1.TabIndex = 4;
            this.labelFrequencyValue1.Text = "Гц";
            // 
            // labelFrequency1
            // 
            this.labelFrequency1.AutoSize = true;
            this.labelFrequency1.Location = new System.Drawing.Point(20, 68);
            this.labelFrequency1.Name = "labelFrequency1";
            this.labelFrequency1.Size = new System.Drawing.Size(52, 13);
            this.labelFrequency1.TabIndex = 3;
            this.labelFrequency1.Text = "Частота:";
            // 
            // trackBarFrequency1
            // 
            this.trackBarFrequency1.Location = new System.Drawing.Point(6, 84);
            this.trackBarFrequency1.Maximum = 30000;
            this.trackBarFrequency1.Minimum = 20;
            this.trackBarFrequency1.Name = "trackBarFrequency1";
            this.trackBarFrequency1.Size = new System.Drawing.Size(181, 45);
            this.trackBarFrequency1.TabIndex = 2;
            this.trackBarFrequency1.TickFrequency = 500;
            this.trackBarFrequency1.Value = 20;
            this.trackBarFrequency1.Scroll += new System.EventHandler(this.trackBarFrequency1_Scroll);
            // 
            // comboBoxWaveTypeSignal1
            // 
            this.comboBoxWaveTypeSignal1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWaveTypeSignal1.FormattingEnabled = true;
            this.comboBoxWaveTypeSignal1.Items.AddRange(new object[] {
            "Sin",
            "Square",
            "SawTooth",
            "Triangle"});
            this.comboBoxWaveTypeSignal1.Location = new System.Drawing.Point(67, 32);
            this.comboBoxWaveTypeSignal1.Name = "comboBoxWaveTypeSignal1";
            this.comboBoxWaveTypeSignal1.Size = new System.Drawing.Size(159, 21);
            this.comboBoxWaveTypeSignal1.TabIndex = 1;
            this.comboBoxWaveTypeSignal1.SelectedIndexChanged += new System.EventHandler(this.comboBoxWaveTypeSignal1_SelectedIndexChanged);
            // 
            // labelWaveTypeSignal1
            // 
            this.labelWaveTypeSignal1.AutoSize = true;
            this.labelWaveTypeSignal1.Location = new System.Drawing.Point(109, 16);
            this.labelWaveTypeSignal1.Name = "labelWaveTypeSignal1";
            this.labelWaveTypeSignal1.Size = new System.Drawing.Size(73, 13);
            this.labelWaveTypeSignal1.TabIndex = 0;
            this.labelWaveTypeSignal1.Text = "Тип сигнала:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьСигнал1ToolStripMenuItem,
            this.сохранитьСигнал2ToolStripMenuItem,
            this.сохранитьМиксованныйСигналWavToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьСигнал1ToolStripMenuItem
            // 
            this.сохранитьСигнал1ToolStripMenuItem.Name = "сохранитьСигнал1ToolStripMenuItem";
            this.сохранитьСигнал1ToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.сохранитьСигнал1ToolStripMenuItem.Text = "Сохранить \"Сигнал-1\" (wav)";
            this.сохранитьСигнал1ToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСигнал1ToolStripMenuItem_Click);
            // 
            // сохранитьСигнал2ToolStripMenuItem
            // 
            this.сохранитьСигнал2ToolStripMenuItem.Name = "сохранитьСигнал2ToolStripMenuItem";
            this.сохранитьСигнал2ToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.сохранитьСигнал2ToolStripMenuItem.Text = "Сохранить \"Сигнал-2\" (wav)";
            this.сохранитьСигнал2ToolStripMenuItem.Click += new System.EventHandler(this.сохранитьСигнал2ToolStripMenuItem_Click);
            // 
            // сохранитьМиксованныйСигналWavToolStripMenuItem
            // 
            this.сохранитьМиксованныйСигналWavToolStripMenuItem.Name = "сохранитьМиксованныйСигналWavToolStripMenuItem";
            this.сохранитьМиксованныйСигналWavToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.сохранитьМиксованныйСигналWavToolStripMenuItem.Text = "Сохранить миксованный сигнал (wav)";
            this.сохранитьМиксованныйСигналWavToolStripMenuItem.Click += new System.EventHandler(this.сохранитьМиксованныйСигналWavToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // groupBoxPhaseReverse1
            // 
            this.groupBoxPhaseReverse1.Controls.Add(this.checkBoxPhaseReverse1Right);
            this.groupBoxPhaseReverse1.Controls.Add(this.checkBoxPhaseReverse1Left);
            this.groupBoxPhaseReverse1.Location = new System.Drawing.Point(217, 110);
            this.groupBoxPhaseReverse1.Name = "groupBoxPhaseReverse1";
            this.groupBoxPhaseReverse1.Size = new System.Drawing.Size(75, 83);
            this.groupBoxPhaseReverse1.TabIndex = 11;
            this.groupBoxPhaseReverse1.TabStop = false;
            this.groupBoxPhaseReverse1.Text = "Динамик";
            // 
            // groupBoxPhaseReverse2
            // 
            this.groupBoxPhaseReverse2.Controls.Add(this.checkBoxPhaseReverse2Right);
            this.groupBoxPhaseReverse2.Controls.Add(this.checkBoxPhaseReverse2Left);
            this.groupBoxPhaseReverse2.Location = new System.Drawing.Point(217, 110);
            this.groupBoxPhaseReverse2.Name = "groupBoxPhaseReverse2";
            this.groupBoxPhaseReverse2.Size = new System.Drawing.Size(75, 83);
            this.groupBoxPhaseReverse2.TabIndex = 13;
            this.groupBoxPhaseReverse2.TabStop = false;
            this.groupBoxPhaseReverse2.Text = "Динамик";
            // 
            // checkBoxPhaseReverse1Left
            // 
            this.checkBoxPhaseReverse1Left.AutoSize = true;
            this.checkBoxPhaseReverse1Left.Checked = true;
            this.checkBoxPhaseReverse1Left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhaseReverse1Left.Location = new System.Drawing.Point(6, 28);
            this.checkBoxPhaseReverse1Left.Name = "checkBoxPhaseReverse1Left";
            this.checkBoxPhaseReverse1Left.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPhaseReverse1Left.TabIndex = 0;
            this.checkBoxPhaseReverse1Left.Text = "Левый";
            this.checkBoxPhaseReverse1Left.UseVisualStyleBackColor = true;
            this.checkBoxPhaseReverse1Left.CheckedChanged += new System.EventHandler(this.checkBoxPhaseReverse1Left_CheckedChanged);
            // 
            // checkBoxPhaseReverse1Right
            // 
            this.checkBoxPhaseReverse1Right.AutoSize = true;
            this.checkBoxPhaseReverse1Right.Checked = true;
            this.checkBoxPhaseReverse1Right.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhaseReverse1Right.Location = new System.Drawing.Point(6, 51);
            this.checkBoxPhaseReverse1Right.Name = "checkBoxPhaseReverse1Right";
            this.checkBoxPhaseReverse1Right.Size = new System.Drawing.Size(66, 17);
            this.checkBoxPhaseReverse1Right.TabIndex = 1;
            this.checkBoxPhaseReverse1Right.Text = "Правый";
            this.checkBoxPhaseReverse1Right.UseVisualStyleBackColor = true;
            this.checkBoxPhaseReverse1Right.CheckedChanged += new System.EventHandler(this.checkBoxPhaseReverse1Right_CheckedChanged);
            // 
            // checkBoxPhaseReverse2Left
            // 
            this.checkBoxPhaseReverse2Left.AutoSize = true;
            this.checkBoxPhaseReverse2Left.Checked = true;
            this.checkBoxPhaseReverse2Left.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhaseReverse2Left.Location = new System.Drawing.Point(6, 28);
            this.checkBoxPhaseReverse2Left.Name = "checkBoxPhaseReverse2Left";
            this.checkBoxPhaseReverse2Left.Size = new System.Drawing.Size(60, 17);
            this.checkBoxPhaseReverse2Left.TabIndex = 0;
            this.checkBoxPhaseReverse2Left.Text = "Левый";
            this.checkBoxPhaseReverse2Left.UseVisualStyleBackColor = true;
            this.checkBoxPhaseReverse2Left.CheckedChanged += new System.EventHandler(this.checkBoxPhaseReverse2Left_CheckedChanged);
            // 
            // checkBoxPhaseReverse2Right
            // 
            this.checkBoxPhaseReverse2Right.AutoSize = true;
            this.checkBoxPhaseReverse2Right.Checked = true;
            this.checkBoxPhaseReverse2Right.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxPhaseReverse2Right.Location = new System.Drawing.Point(6, 51);
            this.checkBoxPhaseReverse2Right.Name = "checkBoxPhaseReverse2Right";
            this.checkBoxPhaseReverse2Right.Size = new System.Drawing.Size(66, 17);
            this.checkBoxPhaseReverse2Right.TabIndex = 1;
            this.checkBoxPhaseReverse2Right.Text = "Правый";
            this.checkBoxPhaseReverse2Right.UseVisualStyleBackColor = true;
            this.checkBoxPhaseReverse2Right.CheckedChanged += new System.EventHandler(this.checkBoxPhaseReverse2Right_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 354);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Генератор гармонических сигналов";
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxWavesMixer.ResumeLayout(false);
            this.groupBoxWavesMixer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSaveSignalsSeconds)).EndInit();
            this.groupBoxSignal2.ResumeLayout(false);
            this.groupBoxSignal2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2SaveSignalSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmplitude2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequencyValue2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency2)).EndInit();
            this.groupBoxSignal1.ResumeLayout(false);
            this.groupBoxSignal1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1SaveSignalSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmplitude1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFrequencyValue1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFrequency1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxPhaseReverse1.ResumeLayout(false);
            this.groupBoxPhaseReverse1.PerformLayout();
            this.groupBoxPhaseReverse2.ResumeLayout(false);
            this.groupBoxPhaseReverse2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.GroupBox groupBoxSignal2;
        private System.Windows.Forms.GroupBox groupBoxSignal1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxWaveTypeSignal2;
        private System.Windows.Forms.Label labelWaveTypeSignal2;
        private System.Windows.Forms.ComboBox comboBoxWaveTypeSignal1;
        private System.Windows.Forms.Label labelWaveTypeSignal1;
        private System.Windows.Forms.Button button2SignalGenerate;
        private System.Windows.Forms.Button button1SignalGenerate;
        private System.Windows.Forms.Label labelFrequencyValue1;
        private System.Windows.Forms.Label labelFrequency1;
        private System.Windows.Forms.TrackBar trackBarFrequency1;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequencyValue1;
        private System.Windows.Forms.Label labelFrequencyValue2;
        private System.Windows.Forms.NumericUpDown numericUpDownFrequencyValue2;
        private System.Windows.Forms.TrackBar trackBarFrequency2;
        private System.Windows.Forms.Label labelFrequency2;
        private System.Windows.Forms.Label labelAmplitudeValue2;
        private System.Windows.Forms.TrackBar trackBarAmplitude2;
        private System.Windows.Forms.Label labelAmplitude2;
        private System.Windows.Forms.Label labelAmplitudeValue1;
        private System.Windows.Forms.TrackBar trackBarAmplitude1;
        private System.Windows.Forms.Label labelAmplitude1;
        private System.Windows.Forms.Button button2SaveSignal;
        private System.Windows.Forms.Button button1SaveSignal;
        private System.Windows.Forms.Label label2SaveSignalSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDown2SaveSignalSeconds;
        private System.Windows.Forms.Label label1SaveSignalSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDown1SaveSignalSeconds;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСигнал1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьСигнал2ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxWavesMixer;
        private System.Windows.Forms.Label labelSaveSignalsSeconds;
        private System.Windows.Forms.NumericUpDown numericUpDownSaveSignalsSeconds;
        private System.Windows.Forms.Button buttonSaveSignals;
        private System.Windows.Forms.Button buttonSignalsGenerate;
        private System.Windows.Forms.ToolStripMenuItem сохранитьМиксованныйСигналWavToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxPhaseReverse2;
        private System.Windows.Forms.CheckBox checkBoxPhaseReverse2Right;
        private System.Windows.Forms.CheckBox checkBoxPhaseReverse2Left;
        private System.Windows.Forms.GroupBox groupBoxPhaseReverse1;
        private System.Windows.Forms.CheckBox checkBoxPhaseReverse1Right;
        private System.Windows.Forms.CheckBox checkBoxPhaseReverse1Left;
    }
}

