namespace 問題28
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DisplayButton = new Button();
            maleLabel = new Label();
            FemaleLabel = new Label();
            textBox_maleNum = new TextBox();
            textBox_femaleNum = new TextBox();
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(101, 150);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(75, 23);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "表示";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // maleLabel
            // 
            maleLabel.AutoSize = true;
            maleLabel.Location = new Point(12, 44);
            maleLabel.Name = "maleLabel";
            maleLabel.Size = new Size(19, 15);
            maleLabel.TabIndex = 1;
            maleLabel.Text = "男";
            // 
            // FemaleLabel
            // 
            FemaleLabel.AutoSize = true;
            FemaleLabel.Location = new Point(12, 90);
            FemaleLabel.Name = "FemaleLabel";
            FemaleLabel.Size = new Size(19, 15);
            FemaleLabel.TabIndex = 2;
            FemaleLabel.Text = "女";
            // 
            // textBox_maleNum
            // 
            textBox_maleNum.Location = new Point(76, 41);
            textBox_maleNum.Name = "textBox_maleNum";
            textBox_maleNum.Size = new Size(100, 23);
            textBox_maleNum.TabIndex = 3;
            // 
            // textBox_femaleNum
            // 
            textBox_femaleNum.Location = new Point(76, 82);
            textBox_femaleNum.Name = "textBox_femaleNum";
            textBox_femaleNum.Size = new Size(100, 23);
            textBox_femaleNum.TabIndex = 4;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 185);
            Controls.Add(textBox_femaleNum);
            Controls.Add(textBox_maleNum);
            Controls.Add(FemaleLabel);
            Controls.Add(maleLabel);
            Controls.Add(DisplayButton);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DisplayButton;
        private Label maleLabel;
        private Label FemaleLabel;
        private TextBox textBox_maleNum;
        private TextBox textBox_femaleNum;
    }
}