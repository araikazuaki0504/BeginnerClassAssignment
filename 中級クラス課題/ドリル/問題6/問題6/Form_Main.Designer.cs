namespace 問題6
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
            textBox = new TextBox();
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(87, 122);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(75, 23);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "表示";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(74, 39);
            textBox.Name = "textBox";
            textBox.Size = new Size(100, 23);
            textBox.TabIndex = 1;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 202);
            Controls.Add(textBox);
            Controls.Add(DisplayButton);
            Name = "Form_Main";
            Text = "問題6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DisplayButton;
        private TextBox textBox;
    }
}