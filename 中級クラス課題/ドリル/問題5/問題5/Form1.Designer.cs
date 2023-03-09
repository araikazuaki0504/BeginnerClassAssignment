namespace 問題5
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
            DisplayButton = new Button();
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(61, 76);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(75, 23);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "表示";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 175);
            Controls.Add(DisplayButton);
            Name = "Form";
            Text = "Form";
            ResumeLayout(false);
        }

        #endregion

        private Button DisplayButton;
    }
}