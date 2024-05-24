namespace ChannelModeling
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SequenceLenthTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorSequenceModelGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BitsSequenceLabel = new System.Windows.Forms.Label();
            this.IntervalSequenceLabel = new System.Windows.Forms.Label();
            this.ErrorProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProbabilityLabel = new System.Windows.Forms.Label();
            this.SimulateErrorSequenceButton = new System.Windows.Forms.Button();
            this.InterferenceGeneratorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deviderToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PackageLengthTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ErrorSequenceModelGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(14, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 558);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PackageLengthTextBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.SequenceLenthTextBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.ErrorSequenceModelGroupBox);
            this.tabPage1.Controls.Add(this.ErrorProbabilityTextBox);
            this.tabPage1.Controls.Add(this.ErrorProbabilityLabel);
            this.tabPage1.Controls.Add(this.SimulateErrorSequenceButton);
            this.tabPage1.Controls.Add(this.InterferenceGeneratorComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(961, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Реализация последовательности ошибок";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SequenceLenthTextBox
            // 
            this.SequenceLenthTextBox.Location = new System.Drawing.Point(246, 59);
            this.SequenceLenthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SequenceLenthTextBox.Name = "SequenceLenthTextBox";
            this.SequenceLenthTextBox.Size = new System.Drawing.Size(151, 23);
            this.SequenceLenthTextBox.TabIndex = 7;
            this.SequenceLenthTextBox.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Длина последовательности:";
            // 
            // ErrorSequenceModelGroupBox
            // 
            this.ErrorSequenceModelGroupBox.Controls.Add(this.splitContainer1);
            this.ErrorSequenceModelGroupBox.Location = new System.Drawing.Point(40, 131);
            this.ErrorSequenceModelGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorSequenceModelGroupBox.Name = "ErrorSequenceModelGroupBox";
            this.ErrorSequenceModelGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorSequenceModelGroupBox.Size = new System.Drawing.Size(875, 319);
            this.ErrorSequenceModelGroupBox.TabIndex = 5;
            this.ErrorSequenceModelGroupBox.TabStop = false;
            this.ErrorSequenceModelGroupBox.Text = "Результат";
            this.ErrorSequenceModelGroupBox.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(7, 32);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.BitsSequenceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.IntervalSequenceLabel);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.splitContainer1.Size = new System.Drawing.Size(861, 85);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 11;
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
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Интервальное представление:";
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
            this.IntervalSequenceLabel.Location = new System.Drawing.Point(12, 38);
            this.IntervalSequenceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntervalSequenceLabel.Name = "IntervalSequenceLabel";
            this.IntervalSequenceLabel.Size = new System.Drawing.Size(72, 18);
            this.IntervalSequenceLabel.TabIndex = 10;
            this.IntervalSequenceLabel.Text = "sequence";
            // 
            // ErrorProbabilityTextBox
            // 
            this.ErrorProbabilityTextBox.Location = new System.Drawing.Point(764, 24);
            this.ErrorProbabilityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorProbabilityTextBox.Name = "ErrorProbabilityTextBox";
            this.ErrorProbabilityTextBox.Size = new System.Drawing.Size(151, 23);
            this.ErrorProbabilityTextBox.TabIndex = 4;
            this.ErrorProbabilityTextBox.Text = "0,5";
            // 
            // ErrorProbabilityLabel
            // 
            this.ErrorProbabilityLabel.AutoSize = true;
            this.ErrorProbabilityLabel.Location = new System.Drawing.Point(524, 28);
            this.ErrorProbabilityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorProbabilityLabel.Name = "ErrorProbabilityLabel";
            this.ErrorProbabilityLabel.Size = new System.Drawing.Size(240, 17);
            this.ErrorProbabilityLabel.TabIndex = 3;
            this.ErrorProbabilityLabel.Text = "Вероятность появления ошибки:";
            // 
            // SimulateErrorSequenceButton
            // 
            this.SimulateErrorSequenceButton.Location = new System.Drawing.Point(364, 468);
            this.SimulateErrorSequenceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SimulateErrorSequenceButton.Name = "SimulateErrorSequenceButton";
            this.SimulateErrorSequenceButton.Size = new System.Drawing.Size(226, 43);
            this.SimulateErrorSequenceButton.TabIndex = 2;
            this.SimulateErrorSequenceButton.Text = "Смоделировать";
            this.SimulateErrorSequenceButton.UseVisualStyleBackColor = true;
            this.SimulateErrorSequenceButton.Click += new System.EventHandler(this.CalculateErrorSequenceButton_Click);
            // 
            // InterferenceGeneratorComboBox
            // 
            this.InterferenceGeneratorComboBox.FormattingEnabled = true;
            this.InterferenceGeneratorComboBox.Location = new System.Drawing.Point(246, 24);
            this.InterferenceGeneratorComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InterferenceGeneratorComboBox.Name = "InterferenceGeneratorComboBox";
            this.InterferenceGeneratorComboBox.Size = new System.Drawing.Size(151, 23);
            this.InterferenceGeneratorComboBox.TabIndex = 1;
            this.InterferenceGeneratorComboBox.SelectedIndexChanged += new System.EventHandler(this.InterferenceGeneratorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Модель генерации ошибок:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(961, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Модель дискретного канала";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(961, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Модель канала ПД";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(997, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuToolStripMenuItem
            // 
            this.MenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetSeedToolStripMenuItem,
            this.ResetSeedToolStripMenuItem,
            this.deviderToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
            this.MenuToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.MenuToolStripMenuItem.Text = "Меню";
            // 
            // SetSeedToolStripMenuItem
            // 
            this.SetSeedToolStripMenuItem.Name = "SetSeedToolStripMenuItem";
            this.SetSeedToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.SetSeedToolStripMenuItem.Text = "Установить зерно генерации";
            this.SetSeedToolStripMenuItem.Click += new System.EventHandler(this.SetSeedToolStripMenuItem_Click);
            // 
            // ResetSeedToolStripMenuItem
            // 
            this.ResetSeedToolStripMenuItem.Name = "ResetSeedToolStripMenuItem";
            this.ResetSeedToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.ResetSeedToolStripMenuItem.Text = "Сбросить зерно генерации";
            this.ResetSeedToolStripMenuItem.Click += new System.EventHandler(this.ResetSeedToolStripMenuItem_Click);
            // 
            // deviderToolStripMenuItem
            // 
            this.deviderToolStripMenuItem.Name = "deviderToolStripMenuItem";
            this.deviderToolStripMenuItem.Size = new System.Drawing.Size(281, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.ExitToolStripMenuItem.Text = "Выйти";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // PackageLengthTextBox
            // 
            this.PackageLengthTextBox.Location = new System.Drawing.Point(246, 94);
            this.PackageLengthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PackageLengthTextBox.Name = "PackageLengthTextBox";
            this.PackageLengthTextBox.Size = new System.Drawing.Size(151, 23);
            this.PackageLengthTextBox.TabIndex = 9;
            this.PackageLengthTextBox.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длина пакета:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование КПД";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ErrorSequenceModelGroupBox.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator deviderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetSeedToolStripMenuItem;
        private System.Windows.Forms.ComboBox InterferenceGeneratorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SimulateErrorSequenceButton;
        private System.Windows.Forms.TextBox ErrorProbabilityTextBox;
        private System.Windows.Forms.Label ErrorProbabilityLabel;
        private System.Windows.Forms.GroupBox ErrorSequenceModelGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label IntervalSequenceLabel;
        private System.Windows.Forms.Label BitsSequenceLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SequenceLenthTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox PackageLengthTextBox;
        private System.Windows.Forms.Label label4;
    }
}

