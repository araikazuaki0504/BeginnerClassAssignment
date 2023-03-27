namespace 問題2
{
    partial class Form
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
            XButton = new Button();
            YButton = new Button();
            ClickButtonNameLabel = new Label();
            SuspendLayout();
            // 
            // XButton
            // 
            XButton.Location = new Point(12, 137);
            XButton.Name = "XButton";
            XButton.Size = new Size(75, 23);
            XButton.TabIndex = 0;
            XButton.Text = "X";
            XButton.UseVisualStyleBackColor = true;
            XButton.Click += XButton_Click;
            // 
            // YButton
            // 
            YButton.Location = new Point(289, 137);
            YButton.Name = "YButton";
            YButton.Size = new Size(75, 23);
            YButton.TabIndex = 1;
            YButton.Text = "Y";
            YButton.UseVisualStyleBackColor = true;
            YButton.Click += YButton_Click;
            // 
            // ClickButtonNameLabel
            // 
            ClickButtonNameLabel.AutoSize = true;
            ClickButtonNameLabel.Location = new Point(160, 58);
            ClickButtonNameLabel.Name = "ClickButtonNameLabel";
            ClickButtonNameLabel.Size = new Size(0, 15);
            ClickButtonNameLabel.TabIndex = 2;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 189);
            Controls.Add(ClickButtonNameLabel);
            Controls.Add(YButton);
            Controls.Add(XButton);
            Name = "Form_Main";
            Text = "問題2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button XButton;
        private Button YButton;
        private Label ClickButtonNameLabel;
    }
}