namespace 問題79
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
            button_LeftArrow = new Button();
            button_RightArrow = new Button();
            StarLabel = new Label();
            SuspendLayout();
            // 
            // button_LeftArrow
            // 
            button_LeftArrow.Location = new Point(25, 122);
            button_LeftArrow.Name = "button_LeftArrow";
            button_LeftArrow.Size = new Size(75, 23);
            button_LeftArrow.TabIndex = 0;
            button_LeftArrow.Text = "←";
            button_LeftArrow.UseVisualStyleBackColor = true;
            button_LeftArrow.Click += button_LeftArrow_Click;
            // 
            // button_RightArrow
            // 
            button_RightArrow.Location = new Point(167, 122);
            button_RightArrow.Name = "button_RightArrow";
            button_RightArrow.Size = new Size(75, 23);
            button_RightArrow.TabIndex = 1;
            button_RightArrow.Text = "→";
            button_RightArrow.UseVisualStyleBackColor = true;
            button_RightArrow.Click += button_RightArrow_Click;
            // 
            // StarLabel
            // 
            StarLabel.AutoSize = true;
            StarLabel.Location = new Point(118, 46);
            StarLabel.Name = "StarLabel";
            StarLabel.Size = new Size(19, 15);
            StarLabel.TabIndex = 2;
            StarLabel.Text = "★";
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 163);
            Controls.Add(StarLabel);
            Controls.Add(button_RightArrow);
            Controls.Add(button_LeftArrow);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_LeftArrow;
        private Button button_RightArrow;
        private Label StarLabel;
    }
}