namespace ChannelModeling.Controls
{
    partial class DataChannel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorProbabilityTextBox = new System.Windows.Forms.TextBox();
            this.GroupCoefficientTextBox = new System.Windows.Forms.TextBox();
            this.PackageLengthTextBox = new System.Windows.Forms.TextBox();
            this.PackageCountTextBox = new System.Windows.Forms.TextBox();
            this.TransitionMatrixGroupBox = new System.Windows.Forms.GroupBox();
            this.TransitionMatrixLablel = new System.Windows.Forms.Label();
            this.BlockErrorsSequanceGroupBox = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label5 = new System.Windows.Forms.Label();
            this.ErrorsPackageSequence = new System.Windows.Forms.Label();
            this.SimulateTwoLevelChannelButton = new System.Windows.Forms.Button();
            this.TransitionMatrixGroupBox.SuspendLayout();
            this.BlockErrorsSequanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вероятность ошибки двоичного символа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Коэффициент группирования:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Длина пакета:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество пакетов:";
            // 
            // ErrorProbabilityTextBox
            // 
            this.ErrorProbabilityTextBox.Location = new System.Drawing.Point(308, 13);
            this.ErrorProbabilityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ErrorProbabilityTextBox.Name = "ErrorProbabilityTextBox";
            this.ErrorProbabilityTextBox.Size = new System.Drawing.Size(121, 23);
            this.ErrorProbabilityTextBox.TabIndex = 4;
            this.ErrorProbabilityTextBox.Text = "0,1";
            // 
            // GroupCoefficientTextBox
            // 
            this.GroupCoefficientTextBox.Location = new System.Drawing.Point(308, 50);
            this.GroupCoefficientTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.GroupCoefficientTextBox.Name = "GroupCoefficientTextBox";
            this.GroupCoefficientTextBox.Size = new System.Drawing.Size(121, 23);
            this.GroupCoefficientTextBox.TabIndex = 5;
            this.GroupCoefficientTextBox.Text = "0,4";
            // 
            // PackageLengthTextBox
            // 
            this.PackageLengthTextBox.Location = new System.Drawing.Point(308, 89);
            this.PackageLengthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PackageLengthTextBox.Name = "PackageLengthTextBox";
            this.PackageLengthTextBox.Size = new System.Drawing.Size(121, 23);
            this.PackageLengthTextBox.TabIndex = 6;
            this.PackageLengthTextBox.Text = "20";
            // 
            // PackageCountTextBox
            // 
            this.PackageCountTextBox.Location = new System.Drawing.Point(308, 126);
            this.PackageCountTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PackageCountTextBox.Name = "PackageCountTextBox";
            this.PackageCountTextBox.Size = new System.Drawing.Size(121, 23);
            this.PackageCountTextBox.TabIndex = 7;
            this.PackageCountTextBox.Text = "20";
            // 
            // TransitionMatrixGroupBox
            // 
            this.TransitionMatrixGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TransitionMatrixGroupBox.Controls.Add(this.TransitionMatrixLablel);
            this.TransitionMatrixGroupBox.Location = new System.Drawing.Point(461, 13);
            this.TransitionMatrixGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TransitionMatrixGroupBox.Name = "TransitionMatrixGroupBox";
            this.TransitionMatrixGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TransitionMatrixGroupBox.Size = new System.Drawing.Size(326, 144);
            this.TransitionMatrixGroupBox.TabIndex = 8;
            this.TransitionMatrixGroupBox.TabStop = false;
            this.TransitionMatrixGroupBox.Text = "Матрица переходных состояний";
            this.TransitionMatrixGroupBox.Visible = false;
            // 
            // TransitionMatrixLablel
            // 
            this.TransitionMatrixLablel.AutoSize = true;
            this.TransitionMatrixLablel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransitionMatrixLablel.Location = new System.Drawing.Point(4, 19);
            this.TransitionMatrixLablel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransitionMatrixLablel.Name = "TransitionMatrixLablel";
            this.TransitionMatrixLablel.Size = new System.Drawing.Size(88, 17);
            this.TransitionMatrixLablel.TabIndex = 0;
            this.TransitionMatrixLablel.Text = "transition";
            // 
            // BlockErrorsSequanceGroupBox
            // 
            this.BlockErrorsSequanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BlockErrorsSequanceGroupBox.Controls.Add(this.splitContainer1);
            this.BlockErrorsSequanceGroupBox.Location = new System.Drawing.Point(8, 200);
            this.BlockErrorsSequanceGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BlockErrorsSequanceGroupBox.Name = "BlockErrorsSequanceGroupBox";
            this.BlockErrorsSequanceGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BlockErrorsSequanceGroupBox.Size = new System.Drawing.Size(779, 214);
            this.BlockErrorsSequanceGroupBox.TabIndex = 9;
            this.BlockErrorsSequanceGroupBox.TabStop = false;
            this.BlockErrorsSequanceGroupBox.Text = "Результаты";
            this.BlockErrorsSequanceGroupBox.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(9, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.ErrorsPackageSequence);
            this.splitContainer1.Size = new System.Drawing.Size(770, 76);
            this.splitContainer1.SplitterDistance = 167;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Последовательность:";
            // 
            // ErrorsPackageSequence
            // 
            this.ErrorsPackageSequence.AutoSize = true;
            this.ErrorsPackageSequence.Location = new System.Drawing.Point(22, 10);
            this.ErrorsPackageSequence.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorsPackageSequence.Name = "ErrorsPackageSequence";
            this.ErrorsPackageSequence.Size = new System.Drawing.Size(72, 17);
            this.ErrorsPackageSequence.TabIndex = 0;
            this.ErrorsPackageSequence.Text = "sequence";
            // 
            // SimulateTwoLevelChannelButton
            // 
            this.SimulateTwoLevelChannelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SimulateTwoLevelChannelButton.Location = new System.Drawing.Point(303, 467);
            this.SimulateTwoLevelChannelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SimulateTwoLevelChannelButton.Name = "SimulateTwoLevelChannelButton";
            this.SimulateTwoLevelChannelButton.Size = new System.Drawing.Size(200, 43);
            this.SimulateTwoLevelChannelButton.TabIndex = 10;
            this.SimulateTwoLevelChannelButton.Text = "Смоделировать";
            this.SimulateTwoLevelChannelButton.UseVisualStyleBackColor = true;
            this.SimulateTwoLevelChannelButton.Click += new System.EventHandler(this.SimulateTwoLevelChannelButton_Click);
            // 
            // TwoLevelChannelImplementetion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SimulateTwoLevelChannelButton);
            this.Controls.Add(this.BlockErrorsSequanceGroupBox);
            this.Controls.Add(this.TransitionMatrixGroupBox);
            this.Controls.Add(this.PackageCountTextBox);
            this.Controls.Add(this.PackageLengthTextBox);
            this.Controls.Add(this.GroupCoefficientTextBox);
            this.Controls.Add(this.ErrorProbabilityTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TwoLevelChannelImplementetion";
            this.Size = new System.Drawing.Size(807, 513);
            this.TransitionMatrixGroupBox.ResumeLayout(false);
            this.TransitionMatrixGroupBox.PerformLayout();
            this.BlockErrorsSequanceGroupBox.ResumeLayout(false);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ErrorProbabilityTextBox;
        private System.Windows.Forms.TextBox GroupCoefficientTextBox;
        private System.Windows.Forms.TextBox PackageLengthTextBox;
        private System.Windows.Forms.TextBox PackageCountTextBox;
        private System.Windows.Forms.GroupBox TransitionMatrixGroupBox;
        private System.Windows.Forms.Label TransitionMatrixLablel;
        private System.Windows.Forms.GroupBox BlockErrorsSequanceGroupBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button SimulateTwoLevelChannelButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ErrorsPackageSequence;
    }
}
