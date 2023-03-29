namespace 問題14
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
            textBoxFirst = new TextBox();
            textBoxSecond = new TextBox();
            labelMinus = new Label();
            labelEqual = new Label();
            textBoxAns = new TextBox();
            buttonMinus = new Button();
            SuspendLayout();
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(12, 80);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(100, 23);
            textBoxFirst.TabIndex = 0;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(192, 80);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(100, 23);
            textBoxSecond.TabIndex = 1;
            // 
            // labelMinus
            // 
            labelMinus.AutoSize = true;
            labelMinus.Location = new Point(148, 83);
            labelMinus.Name = "labelMinus";
            labelMinus.Size = new Size(12, 15);
            labelMinus.TabIndex = 2;
            labelMinus.Text = "-";
            // 
            // labelEqual
            // 
            labelEqual.AutoSize = true;
            labelEqual.Location = new Point(316, 83);
            labelEqual.Name = "labelEqual";
            labelEqual.Size = new Size(15, 15);
            labelEqual.TabIndex = 3;
            labelEqual.Text = "=";
            // 
            // textBoxAns
            // 
            textBoxAns.Location = new Point(354, 80);
            textBoxAns.Name = "textBoxAns";
            textBoxAns.ReadOnly = true;
            textBoxAns.Size = new Size(100, 23);
            textBoxAns.TabIndex = 4;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(368, 178);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 23);
            buttonMinus.TabIndex = 5;
            buttonMinus.Text = "引く";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonPlus_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 213);
            Controls.Add(buttonMinus);
            Controls.Add(textBoxAns);
            Controls.Add(labelEqual);
            Controls.Add(labelMinus);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private Label labelMinus;
        private Label labelEqual;
        private TextBox textBoxAns;
        private Button buttonMinus;
    }
}