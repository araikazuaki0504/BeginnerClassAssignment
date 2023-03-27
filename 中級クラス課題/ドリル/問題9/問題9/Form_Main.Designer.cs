namespace 問題9
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
            CalButton = new Button();
            SuspendLayout();
            // 
            // CalButton
            // 
            CalButton.Location = new Point(144, 105);
            CalButton.Name = "CalButton";
            CalButton.Size = new Size(75, 23);
            CalButton.TabIndex = 0;
            CalButton.Text = "計算";
            CalButton.UseVisualStyleBackColor = true;
            CalButton.Click += CalButton_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 241);
            Controls.Add(CalButton);
            Name = "Form_Main";
            ResumeLayout(false);
        }

        #endregion

        private Button CalButton;
    }
}