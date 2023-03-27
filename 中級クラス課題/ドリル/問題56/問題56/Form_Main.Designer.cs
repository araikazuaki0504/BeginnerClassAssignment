namespace 問題56
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
            ReadButton = new Button();
            SuspendLayout();
            // 
            // ReadButton
            // 
            ReadButton.Location = new Point(42, 38);
            ReadButton.Name = "ReadButton";
            ReadButton.Size = new Size(79, 28);
            ReadButton.TabIndex = 0;
            ReadButton.Text = "読み込み";
            ReadButton.UseVisualStyleBackColor = true;
            ReadButton.Click += ReadButton_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(154, 105);
            Controls.Add(ReadButton);
            Name = "Form_Main";
            Text = "問題56";
            ResumeLayout(false);
        }

        #endregion

        private Button ReadButton;
    }
}