namespace 問題72
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
            SumButton = new Button();
            TextBoxToSumNum = new TextBox();
            DisplayNumber = new Label();
            SuspendLayout();
            // 
            // SumButton
            // 
            SumButton.Location = new Point(12, 75);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(75, 23);
            SumButton.TabIndex = 0;
            SumButton.Text = "合計を表示";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // TextBoxToSumNum
            // 
            TextBoxToSumNum.Location = new Point(12, 23);
            TextBoxToSumNum.Name = "TextBoxToSumNum";
            TextBoxToSumNum.Size = new Size(100, 23);
            TextBoxToSumNum.TabIndex = 1;
            // 
            // DisplayNumber
            // 
            DisplayNumber.AutoSize = true;
            DisplayNumber.Location = new Point(131, 26);
            DisplayNumber.Name = "DisplayNumber";
            DisplayNumber.Size = new Size(13, 15);
            DisplayNumber.TabIndex = 2;
            DisplayNumber.Text = "0";
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(191, 110);
            Controls.Add(DisplayNumber);
            Controls.Add(TextBoxToSumNum);
            Controls.Add(SumButton);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SumButton;
        private TextBox TextBoxToSumNum;
        private Label DisplayNumber;
    }
}