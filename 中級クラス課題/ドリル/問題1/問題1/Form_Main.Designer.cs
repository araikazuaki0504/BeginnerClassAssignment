namespace 問題1
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
            ClickButton = new Button();
            HelloLabel = new Label();
            SuspendLayout();
            // 
            // ClickButton
            // 
            ClickButton.Location = new Point(21, 12);
            ClickButton.Name = "ClickButton";
            ClickButton.Size = new Size(75, 23);
            ClickButton.TabIndex = 0;
            ClickButton.Text = "表示";
            ClickButton.UseVisualStyleBackColor = true;
            ClickButton.Click += Click_Button;
            // 
            // HelloLabel
            // 
            HelloLabel.AutoSize = true;
            HelloLabel.Location = new Point(39, 53);
            HelloLabel.Name = "HelloLabel";
            HelloLabel.Size = new Size(38, 15);
            HelloLabel.TabIndex = 1;
            HelloLabel.Text = "Hello!";
            HelloLabel.Visible = false;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(120, 105);
            Controls.Add(HelloLabel);
            Controls.Add(ClickButton);
            Name = "Form_Main";
            Text = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClickButton;
        private Label HelloLabel;
    }
}