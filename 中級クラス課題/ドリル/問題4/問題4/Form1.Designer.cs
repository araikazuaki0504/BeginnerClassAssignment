namespace 問題4
{
    partial class Form1
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            TextBoxALabel = new Label();
            TextBoxBLabel = new Label();
            ClickButton = new Button();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(12, 77);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(220, 77);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 1;
            // 
            // TextBoxALabel
            // 
            TextBoxALabel.AutoSize = true;
            TextBoxALabel.Location = new Point(12, 50);
            TextBoxALabel.Name = "TextBoxALabel";
            TextBoxALabel.Size = new Size(86, 15);
            TextBoxALabel.TabIndex = 2;
            TextBoxALabel.Text = "テキストボックスA";
            // 
            // TextBoxBLabel
            // 
            TextBoxBLabel.AutoSize = true;
            TextBoxBLabel.Location = new Point(220, 50);
            TextBoxBLabel.Name = "TextBoxBLabel";
            TextBoxBLabel.Size = new Size(85, 15);
            TextBoxBLabel.TabIndex = 3;
            TextBoxBLabel.Text = "テキストボックスB";
            // 
            // ClickButton
            // 
            ClickButton.Location = new Point(130, 133);
            ClickButton.Name = "ClickButton";
            ClickButton.Size = new Size(75, 23);
            ClickButton.TabIndex = 4;
            ClickButton.Text = "移動";
            ClickButton.UseVisualStyleBackColor = true;
            ClickButton.Click += displayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 182);
            Controls.Add(ClickButton);
            Controls.Add(TextBoxBLabel);
            Controls.Add(TextBoxALabel);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private Label TextBoxALabel;
        private Label TextBoxBLabel;
        private Button ClickButton;
    }
}