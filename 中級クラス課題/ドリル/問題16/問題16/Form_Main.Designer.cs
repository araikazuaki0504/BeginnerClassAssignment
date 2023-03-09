namespace 問題16
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
            buttonMean = new Button();
            labelMean = new Label();
            textBoxFirst = new TextBox();
            textBoxFourth = new TextBox();
            textBoxThird = new TextBox();
            textBoxSecond = new TextBox();
            textBoxMean = new TextBox();
            textBoxFifth = new TextBox();
            SuspendLayout();
            // 
            // buttonMean
            // 
            buttonMean.Location = new Point(268, 404);
            buttonMean.Name = "buttonMean";
            buttonMean.Size = new Size(75, 23);
            buttonMean.TabIndex = 0;
            buttonMean.Text = "平均";
            buttonMean.UseVisualStyleBackColor = true;
            buttonMean.Click += buttonMean_Click;
            // 
            // labelMean
            // 
            labelMean.AutoSize = true;
            labelMean.Location = new Point(164, 370);
            labelMean.Name = "labelMean";
            labelMean.Size = new Size(31, 15);
            labelMean.TabIndex = 1;
            labelMean.Text = "平均";
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(95, 12);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(100, 23);
            textBoxFirst.TabIndex = 2;
            // 
            // textBoxFourth
            // 
            textBoxFourth.Location = new Point(95, 226);
            textBoxFourth.Name = "textBoxFourth";
            textBoxFourth.Size = new Size(100, 23);
            textBoxFourth.TabIndex = 3;
            // 
            // textBoxThird
            // 
            textBoxThird.Location = new Point(95, 153);
            textBoxThird.Name = "textBoxThird";
            textBoxThird.Size = new Size(100, 23);
            textBoxThird.TabIndex = 4;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(95, 79);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(100, 23);
            textBoxSecond.TabIndex = 5;
            // 
            // textBoxMean
            // 
            textBoxMean.Location = new Point(243, 367);
            textBoxMean.Name = "textBoxMean";
            textBoxMean.ReadOnly = true;
            textBoxMean.Size = new Size(100, 23);
            textBoxMean.TabIndex = 6;
            // 
            // textBoxFifth
            // 
            textBoxFifth.Location = new Point(95, 302);
            textBoxFifth.Name = "textBoxFifth";
            textBoxFifth.Size = new Size(100, 23);
            textBoxFifth.TabIndex = 7;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 439);
            Controls.Add(textBoxFifth);
            Controls.Add(textBoxMean);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxThird);
            Controls.Add(textBoxFourth);
            Controls.Add(textBoxFirst);
            Controls.Add(labelMean);
            Controls.Add(buttonMean);
            Name = "Form_Main";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMean;
        private Label labelMean;
        private TextBox textBoxFirst;
        private TextBox textBoxFourth;
        private TextBox textBoxThird;
        private TextBox textBoxSecond;
        private TextBox textBoxMean;
        private TextBox textBoxFifth;
    }
}