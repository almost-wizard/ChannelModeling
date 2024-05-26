namespace ChannelModeling.Components
{
    partial class ErrorSequenceImplementation
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PackageSequenceLabel = new System.Windows.Forms.Label();
            this.BitsSequenceLabel = new System.Windows.Forms.Label();
            this.IntervalSequenceLabel = new System.Windows.Forms.Label();
            this.ErrorProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProbabilityLabel = new System.Windows.Forms.Label();
            this.SimulateErrorSequenceButton = new System.Windows.Forms.Button();
            this.InterferenceGeneratorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrorSequenceModelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.ErrorSequenceModelGroupBox.Controls.Add(this.splitContainer1);
            this.ErrorSequenceModelGroupBox.Location = new System.Drawing.Point(8, 112);
            this.ErrorSequenceModelGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorSequenceModelGroupBox.Name = "ErrorSequenceModelGroupBox";
            this.ErrorSequenceModelGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorSequenceModelGroupBox.Size = new System.Drawing.Size(790, 314);
            this.ErrorSequenceModelGroupBox.TabIndex = 15;
            this.ErrorSequenceModelGroupBox.TabStop = false;
            this.ErrorSequenceModelGroupBox.Text = "Результат";
            this.ErrorSequenceModelGroupBox.Visible = false;
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
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.PackageSequenceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.BitsSequenceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.IntervalSequenceLabel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer1.Size = new System.Drawing.Size(775, 103);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 11;
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
            this.ErrorProbabilityTextBox.Location = new System.Drawing.Point(646, 5);
            this.ErrorProbabilityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorProbabilityTextBox.Name = "ErrorProbabilityTextBox";
            this.ErrorProbabilityTextBox.Size = new System.Drawing.Size(151, 23);
            this.ErrorProbabilityTextBox.TabIndex = 14;
            this.ErrorProbabilityTextBox.Text = "0,5";
            // 
            // ErrorProbabilityLabel
            // 
            this.ErrorProbabilityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProbabilityLabel.AutoSize = true;
            this.ErrorProbabilityLabel.Location = new System.Drawing.Point(398, 8);
            this.ErrorProbabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorProbabilityLabel.Name = "ErrorProbabilityLabel";
            this.ErrorProbabilityLabel.Size = new System.Drawing.Size(240, 17);
            this.ErrorProbabilityLabel.TabIndex = 13;
            this.ErrorProbabilityLabel.Text = "Вероятность появления ошибки:";
            // 
            // SimulateErrorSequenceButton
            // 
            this.SimulateErrorSequenceButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SimulateErrorSequenceButton.Location = new System.Drawing.Point(303, 467);
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
            // ErrorSequenceImplementation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PackageLengthTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SequenceLenthTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ErrorSequenceModelGroupBox);
            this.Controls.Add(this.ErrorProbabilityTextBox);
            this.Controls.Add(this.ErrorProbabilityLabel);
            this.Controls.Add(this.SimulateErrorSequenceButton);
            this.Controls.Add(this.InterferenceGeneratorComboBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ErrorSequenceImplementation";
            this.Size = new System.Drawing.Size(807, 513);
            this.Load += new System.EventHandler(this.ErrorSequenceImplementation_Load);
            this.ErrorSequenceModelGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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
    }
}
