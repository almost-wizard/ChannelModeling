namespace ChannelModeling.Components
{
    partial class ErrorSequence
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PackageLengthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SequenceLenthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorSequenceModelGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowChartsButton = new System.Windows.Forms.Button();
            this.ErrorDensityLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorsRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagesCountLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GroupingFactorLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ErrorsRateLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PackageIntervalSequenceLabel = new System.Windows.Forms.Label();
            this.PackageSequenceLabel = new System.Windows.Forms.Label();
            this.BitsSequenceLabel = new System.Windows.Forms.Label();
            this.IntervalSequenceLabel = new System.Windows.Forms.Label();
            this.ErrorProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProbabilityLabel = new System.Windows.Forms.Label();
            this.SimulateErrorSequenceButton = new System.Windows.Forms.Button();
            this.InterferenceGeneratorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BinominalGroupBox = new System.Windows.Forms.GroupBox();
            this.EliotModelBroupBox = new System.Windows.Forms.GroupBox();
            this.ErrorFreeSequensAVGLengthTextBox = new System.Windows.Forms.TextBox();
            this.ErrorSequensAVGLengthTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ErrorSequenceModelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.BinominalGroupBox.SuspendLayout();
            this.EliotModelBroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PackageLengthTextBox
            // 
            this.PackageLengthTextBox.Location = new System.Drawing.Point(212, 76);
            this.PackageLengthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PackageLengthTextBox.Name = "PackageLengthTextBox";
            this.PackageLengthTextBox.Size = new System.Drawing.Size(151, 23);
            this.PackageLengthTextBox.TabIndex = 19;
            this.PackageLengthTextBox.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Длина пакета:";
            // 
            // SequenceLenthTextBox
            // 
            this.SequenceLenthTextBox.Location = new System.Drawing.Point(212, 41);
            this.SequenceLenthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SequenceLenthTextBox.Name = "SequenceLenthTextBox";
            this.SequenceLenthTextBox.Size = new System.Drawing.Size(151, 23);
            this.SequenceLenthTextBox.TabIndex = 17;
            this.SequenceLenthTextBox.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 43);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Длина последовательности:";
            // 
            // ErrorSequenceModelGroupBox
            // 
            this.ErrorSequenceModelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorSequenceModelGroupBox.Controls.Add(this.ShowChartsButton);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.ErrorDensityLabel);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.label12);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.dataGridView1);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.PackagesCountLabel);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.label11);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.GroupingFactorLabel);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.label9);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.ErrorsRateLabel);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.label7);
            this.ErrorSequenceModelGroupBox.Controls.Add(this.splitContainer1);
            this.ErrorSequenceModelGroupBox.Location = new System.Drawing.Point(8, 112);
            this.ErrorSequenceModelGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorSequenceModelGroupBox.Name = "ErrorSequenceModelGroupBox";
            this.ErrorSequenceModelGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorSequenceModelGroupBox.Size = new System.Drawing.Size(790, 317);
            this.ErrorSequenceModelGroupBox.TabIndex = 15;
            this.ErrorSequenceModelGroupBox.TabStop = false;
            this.ErrorSequenceModelGroupBox.Text = "Результат";
            this.ErrorSequenceModelGroupBox.Visible = false;
            // 
            // ShowChartsButton
            // 
            this.ShowChartsButton.Location = new System.Drawing.Point(14, 277);
            this.ShowChartsButton.Name = "ShowChartsButton";
            this.ShowChartsButton.Size = new System.Drawing.Size(240, 34);
            this.ShowChartsButton.TabIndex = 20;
            this.ShowChartsButton.Text = "Показать графики";
            this.ShowChartsButton.UseVisualStyleBackColor = true;
            this.ShowChartsButton.Click += new System.EventHandler(this.ShowChartsButton_Click);
            // 
            // ErrorDensityLabel
            // 
            this.ErrorDensityLabel.AutoSize = true;
            this.ErrorDensityLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.ErrorDensityLabel.Location = new System.Drawing.Point(231, 219);
            this.ErrorDensityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorDensityLabel.Name = "ErrorDensityLabel";
            this.ErrorDensityLabel.Size = new System.Drawing.Size(16, 18);
            this.ErrorDensityLabel.TabIndex = 19;
            this.ErrorDensityLabel.Text = "k";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11F);
            this.label12.Location = new System.Drawing.Point(11, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Плотность ошибок:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Package,
            this.ErrorsRate});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(285, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.Size = new System.Drawing.Size(497, 130);
            this.dataGridView1.TabIndex = 17;
            // 
            // Package
            // 
            this.Package.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Package.HeaderText = "Пакет";
            this.Package.MinimumWidth = 9;
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            // 
            // ErrorsRate
            // 
            this.ErrorsRate.HeaderText = "Коэффициент ошибок";
            this.ErrorsRate.MinimumWidth = 180;
            this.ErrorsRate.Name = "ErrorsRate";
            this.ErrorsRate.ReadOnly = true;
            this.ErrorsRate.Width = 180;
            // 
            // PackagesCountLabel
            // 
            this.PackagesCountLabel.AutoSize = true;
            this.PackagesCountLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.PackagesCountLabel.Location = new System.Drawing.Point(231, 241);
            this.PackagesCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PackagesCountLabel.Name = "PackagesCountLabel";
            this.PackagesCountLabel.Size = new System.Drawing.Size(16, 18);
            this.PackagesCountLabel.TabIndex = 16;
            this.PackagesCountLabel.Text = "k";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 11F);
            this.label11.Location = new System.Drawing.Point(11, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "Количество пакетов:";
            // 
            // GroupingFactorLabel
            // 
            this.GroupingFactorLabel.AutoSize = true;
            this.GroupingFactorLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.GroupingFactorLabel.Location = new System.Drawing.Point(231, 198);
            this.GroupingFactorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GroupingFactorLabel.Name = "GroupingFactorLabel";
            this.GroupingFactorLabel.Size = new System.Drawing.Size(16, 18);
            this.GroupingFactorLabel.TabIndex = 14;
            this.GroupingFactorLabel.Text = "k";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11F);
            this.label9.Location = new System.Drawing.Point(11, 198);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Коэффициент группирования:";
            // 
            // ErrorsRateLabel
            // 
            this.ErrorsRateLabel.AutoSize = true;
            this.ErrorsRateLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.ErrorsRateLabel.Location = new System.Drawing.Point(231, 178);
            this.ErrorsRateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorsRateLabel.Name = "ErrorsRateLabel";
            this.ErrorsRateLabel.Size = new System.Drawing.Size(16, 18);
            this.ErrorsRateLabel.TabIndex = 12;
            this.ErrorsRateLabel.Text = "k";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11F);
            this.label7.Location = new System.Drawing.Point(11, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Коэффициент ошибок:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(7, 32);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.PackageIntervalSequenceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PackageSequenceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.BitsSequenceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.IntervalSequenceLabel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer1.Size = new System.Drawing.Size(775, 132);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11F);
            this.label8.Location = new System.Drawing.Point(4, 94);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Интервальное представление:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11F);
            this.label6.Location = new System.Drawing.Point(4, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "По пакетам:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F);
            this.label3.Location = new System.Drawing.Point(4, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Последовательность ошибок:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F);
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Интервальное представление:";
            // 
            // PackageIntervalSequenceLabel
            // 
            this.PackageIntervalSequenceLabel.AutoSize = true;
            this.PackageIntervalSequenceLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.PackageIntervalSequenceLabel.Location = new System.Drawing.Point(12, 94);
            this.PackageIntervalSequenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PackageIntervalSequenceLabel.Name = "PackageIntervalSequenceLabel";
            this.PackageIntervalSequenceLabel.Size = new System.Drawing.Size(72, 18);
            this.PackageIntervalSequenceLabel.TabIndex = 12;
            this.PackageIntervalSequenceLabel.Text = "sequence";
            // 
            // PackageSequenceLabel
            // 
            this.PackageSequenceLabel.AutoSize = true;
            this.PackageSequenceLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.PackageSequenceLabel.Location = new System.Drawing.Point(12, 66);
            this.PackageSequenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PackageSequenceLabel.Name = "PackageSequenceLabel";
            this.PackageSequenceLabel.Size = new System.Drawing.Size(72, 18);
            this.PackageSequenceLabel.TabIndex = 11;
            this.PackageSequenceLabel.Text = "sequence";
            // 
            // BitsSequenceLabel
            // 
            this.BitsSequenceLabel.AutoSize = true;
            this.BitsSequenceLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.BitsSequenceLabel.Location = new System.Drawing.Point(12, 8);
            this.BitsSequenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BitsSequenceLabel.Name = "BitsSequenceLabel";
            this.BitsSequenceLabel.Size = new System.Drawing.Size(72, 18);
            this.BitsSequenceLabel.TabIndex = 9;
            this.BitsSequenceLabel.Text = "sequence";
            // 
            // IntervalSequenceLabel
            // 
            this.IntervalSequenceLabel.AutoSize = true;
            this.IntervalSequenceLabel.Font = new System.Drawing.Font("Consolas", 11F);
            this.IntervalSequenceLabel.Location = new System.Drawing.Point(12, 37);
            this.IntervalSequenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntervalSequenceLabel.Name = "IntervalSequenceLabel";
            this.IntervalSequenceLabel.Size = new System.Drawing.Size(72, 18);
            this.IntervalSequenceLabel.TabIndex = 10;
            this.IntervalSequenceLabel.Text = "sequence";
            // 
            // ErrorProbabilityTextBox
            // 
            this.ErrorProbabilityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProbabilityTextBox.Location = new System.Drawing.Point(274, 13);
            this.ErrorProbabilityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorProbabilityTextBox.Name = "ErrorProbabilityTextBox";
            this.ErrorProbabilityTextBox.Size = new System.Drawing.Size(93, 23);
            this.ErrorProbabilityTextBox.TabIndex = 14;
            this.ErrorProbabilityTextBox.Text = "0,5";
            // 
            // ErrorProbabilityLabel
            // 
            this.ErrorProbabilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProbabilityLabel.AutoSize = true;
            this.ErrorProbabilityLabel.Location = new System.Drawing.Point(7, 16);
            this.ErrorProbabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorProbabilityLabel.Name = "ErrorProbabilityLabel";
            this.ErrorProbabilityLabel.Size = new System.Drawing.Size(240, 17);
            this.ErrorProbabilityLabel.TabIndex = 13;
            this.ErrorProbabilityLabel.Text = "Вероятность появления ошибки:";
            // 
            // SimulateErrorSequenceButton
            // 
            this.SimulateErrorSequenceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SimulateErrorSequenceButton.Location = new System.Drawing.Point(303, 454);
            this.SimulateErrorSequenceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SimulateErrorSequenceButton.Name = "SimulateErrorSequenceButton";
            this.SimulateErrorSequenceButton.Size = new System.Drawing.Size(200, 43);
            this.SimulateErrorSequenceButton.TabIndex = 12;
            this.SimulateErrorSequenceButton.Text = "Смоделировать";
            this.SimulateErrorSequenceButton.UseVisualStyleBackColor = true;
            this.SimulateErrorSequenceButton.Click += new System.EventHandler(this.SimulateErrorSequenceButton_Click);
            // 
            // InterferenceGeneratorComboBox
            // 
            this.InterferenceGeneratorComboBox.FormattingEnabled = true;
            this.InterferenceGeneratorComboBox.Location = new System.Drawing.Point(212, 6);
            this.InterferenceGeneratorComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InterferenceGeneratorComboBox.Name = "InterferenceGeneratorComboBox";
            this.InterferenceGeneratorComboBox.Size = new System.Drawing.Size(151, 23);
            this.InterferenceGeneratorComboBox.TabIndex = 11;
            this.InterferenceGeneratorComboBox.SelectedIndexChanged += new System.EventHandler(this.InterferenceGeneratorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Модель генерации ошибок:";
            // 
            // BinominalGroupBox
            // 
            this.BinominalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BinominalGroupBox.Controls.Add(this.ErrorProbabilityLabel);
            this.BinominalGroupBox.Controls.Add(this.ErrorProbabilityTextBox);
            this.BinominalGroupBox.Location = new System.Drawing.Point(415, 6);
            this.BinominalGroupBox.Name = "BinominalGroupBox";
            this.BinominalGroupBox.Size = new System.Drawing.Size(374, 98);
            this.BinominalGroupBox.TabIndex = 20;
            this.BinominalGroupBox.TabStop = false;
            // 
            // EliotModelBroupBox
            // 
            this.EliotModelBroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EliotModelBroupBox.Controls.Add(this.ErrorFreeSequensAVGLengthTextBox);
            this.EliotModelBroupBox.Controls.Add(this.ErrorSequensAVGLengthTextBox);
            this.EliotModelBroupBox.Controls.Add(this.label13);
            this.EliotModelBroupBox.Controls.Add(this.label10);
            this.EliotModelBroupBox.Location = new System.Drawing.Point(415, 6);
            this.EliotModelBroupBox.Name = "EliotModelBroupBox";
            this.EliotModelBroupBox.Size = new System.Drawing.Size(383, 95);
            this.EliotModelBroupBox.TabIndex = 15;
            this.EliotModelBroupBox.TabStop = false;
            // 
            // ErrorFreeSequensAVGLengthTextBox
            // 
            this.ErrorFreeSequensAVGLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorFreeSequensAVGLengthTextBox.Location = new System.Drawing.Point(283, 12);
            this.ErrorFreeSequensAVGLengthTextBox.Name = "ErrorFreeSequensAVGLengthTextBox";
            this.ErrorFreeSequensAVGLengthTextBox.Size = new System.Drawing.Size(93, 23);
            this.ErrorFreeSequensAVGLengthTextBox.TabIndex = 3;
            this.ErrorFreeSequensAVGLengthTextBox.Text = "5";
            // 
            // ErrorSequensAVGLengthTextBox
            // 
            this.ErrorSequensAVGLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorSequensAVGLengthTextBox.Location = new System.Drawing.Point(283, 41);
            this.ErrorSequensAVGLengthTextBox.Name = "ErrorSequensAVGLengthTextBox";
            this.ErrorSequensAVGLengthTextBox.Size = new System.Drawing.Size(93, 23);
            this.ErrorSequensAVGLengthTextBox.TabIndex = 2;
            this.ErrorSequensAVGLengthTextBox.Text = "5";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Средняя длина серии ошибок:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(272, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Средняя длина безошибочной серии:";
            // 
            // ErrorSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EliotModelBroupBox);
            this.Controls.Add(this.BinominalGroupBox);
            this.Controls.Add(this.PackageLengthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SequenceLenthTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrorSequenceModelGroupBox);
            this.Controls.Add(this.SimulateErrorSequenceButton);
            this.Controls.Add(this.InterferenceGeneratorComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ErrorSequence";
            this.Size = new System.Drawing.Size(807, 500);
            this.Load += new System.EventHandler(this.ErrorSequenceImplementation_Load);
            this.ErrorSequenceModelGroupBox.ResumeLayout(false);
            this.ErrorSequenceModelGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.BinominalGroupBox.ResumeLayout(false);
            this.BinominalGroupBox.PerformLayout();
            this.EliotModelBroupBox.ResumeLayout(false);
            this.EliotModelBroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PackageLengthTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SequenceLenthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox ErrorSequenceModelGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PackageSequenceLabel;
        private System.Windows.Forms.Label BitsSequenceLabel;
        private System.Windows.Forms.Label IntervalSequenceLabel;
        private System.Windows.Forms.TextBox ErrorProbabilityTextBox;
        private System.Windows.Forms.Label ErrorProbabilityLabel;
        private System.Windows.Forms.Button SimulateErrorSequenceButton;
        private System.Windows.Forms.ComboBox InterferenceGeneratorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GroupingFactorLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ErrorsRateLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PackageIntervalSequenceLabel;
        private System.Windows.Forms.Label PackagesCountLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn ErrorsRate;
        private System.Windows.Forms.Label ErrorDensityLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button ShowChartsButton;
        private System.Windows.Forms.GroupBox BinominalGroupBox;
        private System.Windows.Forms.GroupBox EliotModelBroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ErrorFreeSequensAVGLengthTextBox;
        private System.Windows.Forms.TextBox ErrorSequensAVGLengthTextBox;
    }
}
