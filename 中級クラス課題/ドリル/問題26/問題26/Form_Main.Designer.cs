namespace 問題26
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
            buttonLinked = new Button();
            textBoxLeft = new TextBox();
            textBoxRight = new TextBox();
            OutputText_label = new Label();
            SuspendLayout();
            // 
            // buttonLinked
            // 
            buttonLinked.Location = new Point(196, 155);
            buttonLinked.Name = "buttonLinked";
            buttonLinked.Size = new Size(75, 23);
            buttonLinked.TabIndex = 0;
            buttonLinked.Text = "連結";
            buttonLinked.UseVisualStyleBackColor = true;
            buttonLinked.Click += button_Left_Click;
            // 
            // textBoxLeft
            // 
            textBoxLeft.Location = new Point(12, 61);
            textBoxLeft.Name = "textBoxLeft";
            textBoxLeft.Size = new Size(100, 23);
            textBoxLeft.TabIndex = 1;
            // 
            // textBoxRight
            // 
            textBoxRight.Location = new Point(171, 61);
            textBoxRight.Name = "textBoxRight";
            textBoxRight.Size = new Size(100, 23);
            textBoxRight.TabIndex = 2;
            // 
            // OutputText_label
            // 
            OutputText_label.AutoSize = true;
            OutputText_label.Location = new Point(16, 99);
            OutputText_label.Name = "OutputText_label";
            OutputText_label.Size = new Size(0, 15);
            OutputText_label.TabIndex = 3;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 181);
            Controls.Add(OutputText_label);
            Controls.Add(textBoxRight);
            Controls.Add(textBoxLeft);
            Controls.Add(buttonLinked);
            Name = "Form_Main";
            Text = "問題26";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLinked;
        private TextBox textBoxLeft;
        private TextBox textBoxRight;
        private Label OutputText_label;
    }
}