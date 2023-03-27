namespace 問題78
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
            ExpandButton = new Button();
            SuspendLayout();
            // 
            // ExpandButton
            // 
            ExpandButton.Location = new Point(12, 12);
            ExpandButton.Name = "ExpandButton";
            ExpandButton.Size = new Size(75, 28);
            ExpandButton.TabIndex = 0;
            ExpandButton.Text = "拡大";
            ExpandButton.UseVisualStyleBackColor = true;
            ExpandButton.Click += ExpandButton_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 303);
            Controls.Add(ExpandButton);
            Name = "Form_Main";
            Text = "問題78";
            ResumeLayout(false);
        }

        #endregion

        private Button ExpandButton;
    }
}