namespace 問題25
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
            textBox_Left = new TextBox();
            textBox_Right = new TextBox();
            OutputTextLabel = new Label();
            SuspendLayout();
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(205, 132);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(75, 23);
            DisplayButton.TabIndex = 0;
            DisplayButton.Text = "連結";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += DisplayButton_Click;
            // 
            // textBox_Left
            // 
            textBox_Left.Location = new Point(13, 45);
            textBox_Left.Name = "textBox_Left";
            textBox_Left.Size = new Size(100, 23);
            textBox_Left.TabIndex = 1;
            // 
            // textBox_Right
            // 
            textBox_Right.Location = new Point(180, 45);
            textBox_Right.Name = "textBox_Right";
            textBox_Right.Size = new Size(100, 23);
            textBox_Right.TabIndex = 2;
            // 
            // OutputTextLabel
            // 
            OutputTextLabel.AutoSize = true;
            OutputTextLabel.Location = new Point(13, 104);
            OutputTextLabel.Name = "OutputTextLabel";
            OutputTextLabel.Size = new Size(0, 15);
            OutputTextLabel.TabIndex = 3;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 166);
            Controls.Add(OutputTextLabel);
            Controls.Add(textBox_Right);
            Controls.Add(textBox_Left);
            Controls.Add(DisplayButton);
            Name = "Form_Main";
            Text = "問題25";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DisplayButton;
        private TextBox textBox_Left;
        private TextBox textBox_Right;
        private Label OutputTextLabel;
    }
}