namespace 問題19
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
            buttonCheck = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(156, 38);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(75, 23);
            buttonCheck.TabIndex = 0;
            buttonCheck.Text = "チェック";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 38);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 1;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(243, 103);
            Controls.Add(textBox);
            Controls.Add(buttonCheck);
            Name = "Form_Main";
            Text = "問題19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCheck;
        private TextBox textBox;
    }
}