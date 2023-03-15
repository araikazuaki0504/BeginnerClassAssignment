namespace 問題61
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
            WriteButton = new Button();
            SuspendLayout();
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(52, 49);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(71, 29);
            WriteButton.TabIndex = 0;
            WriteButton.Text = "詠み込み";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(179, 130);
            Controls.Add(WriteButton);
            Name = "Form_Main";
            ResumeLayout(false);
        }

        #endregion

        private Button WriteButton;
    }
}