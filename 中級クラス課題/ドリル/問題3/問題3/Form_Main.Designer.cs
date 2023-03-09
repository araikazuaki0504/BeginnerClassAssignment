namespace 問題3
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
            inputTextLabel = new Label();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // ClickButton
            // 
            ClickButton.Location = new Point(265, 233);
            ClickButton.Name = "ClickButton";
            ClickButton.Size = new Size(124, 52);
            ClickButton.TabIndex = 0;
            ClickButton.Text = "表示";
            ClickButton.UseVisualStyleBackColor = true;
            ClickButton.Click += ClickButton_Click;
            // 
            // inputTextLabel
            // 
            inputTextLabel.AutoSize = true;
            inputTextLabel.Location = new Point(265, 89);
            inputTextLabel.Name = "inputTextLabel";
            inputTextLabel.Size = new Size(0, 15);
            inputTextLabel.TabIndex = 1;
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 86);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 2;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 297);
            Controls.Add(textBox);
            Controls.Add(inputTextLabel);
            Controls.Add(ClickButton);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ClickButton;
        private Label inputTextLabel;
        private TextBox textBox;
    }
}