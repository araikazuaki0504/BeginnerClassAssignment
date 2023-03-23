namespace 問題7
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
            ExchangeButton = new Button();
            LeftLabel = new Label();
            RightLabel = new Label();
            SuspendLayout();
            // 
            // ExchangeButton
            // 
            ExchangeButton.Location = new Point(109, 129);
            ExchangeButton.Name = "ExchangeButton";
            ExchangeButton.Size = new Size(75, 23);
            ExchangeButton.TabIndex = 0;
            ExchangeButton.Text = "交換";
            ExchangeButton.UseVisualStyleBackColor = true;
            ExchangeButton.Click += ExchangeButton_Click;
            // 
            // LeftLabel
            // 
            LeftLabel.AutoSize = true;
            LeftLabel.Location = new Point(50, 58);
            LeftLabel.Name = "LeftLabel";
            LeftLabel.Size = new Size(19, 15);
            LeftLabel.TabIndex = 1;
            LeftLabel.Text = "春";
            // 
            // RightLabel
            // 
            RightLabel.AutoSize = true;
            RightLabel.Location = new Point(232, 58);
            RightLabel.Name = "RightLabel";
            RightLabel.Size = new Size(19, 15);
            RightLabel.TabIndex = 2;
            RightLabel.Text = "赤";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 168);
            Controls.Add(RightLabel);
            Controls.Add(LeftLabel);
            Controls.Add(ExchangeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExchangeButton;
        private Label LeftLabel;
        private Label RightLabel;
    }
}