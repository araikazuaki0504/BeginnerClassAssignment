namespace 問題71
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
            DisplayNumber = new Label();
            InputTextBox = new TextBox();
            SuspendLayout();
            // 
            // SumButton
            // 
            SumButton.Location = new Point(22, 76);
            SumButton.Name = "SumButton";
            SumButton.Size = new Size(75, 23);
            SumButton.TabIndex = 0;
            SumButton.Text = "合計を表示";
            SumButton.UseVisualStyleBackColor = true;
            SumButton.Click += SumButton_Click;
            // 
            // DisplayNumber
            // 
            DisplayNumber.AutoSize = true;
            DisplayNumber.Location = new Point(149, 25);
            DisplayNumber.Name = "DisplayNumber";
            DisplayNumber.Size = new Size(13, 15);
            DisplayNumber.TabIndex = 1;
            DisplayNumber.Text = "0";
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(22, 22);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(100, 23);
            InputTextBox.TabIndex = 2;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 110);
            Controls.Add(InputTextBox);
            Controls.Add(DisplayNumber);
            Controls.Add(SumButton);
            Name = "Form_Main";
            Text = "問題71";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SumButton;
        private Label DisplayNumber;
        private TextBox InputTextBox;
    }
}