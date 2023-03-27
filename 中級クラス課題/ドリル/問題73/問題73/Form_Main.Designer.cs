namespace 問題73
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
            button = new Button();
            DateLabel = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(74, 73);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 0;
            button.Text = "表示";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(74, 26);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(43, 15);
            DateLabel.TabIndex = 1;
            DateLabel.Text = "年月日";
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 118);
            Controls.Add(DateLabel);
            Controls.Add(button);
            Name = "Form_Main";
            Text = "問題73";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label DateLabel;
    }
}