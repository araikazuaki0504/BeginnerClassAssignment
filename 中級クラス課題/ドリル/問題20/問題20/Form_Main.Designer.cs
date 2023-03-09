namespace 問題20
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
            buttonCheck = new Button();
            textBoxFirst = new TextBox();
            textBoxFifth = new TextBox();
            textBoxFourth = new TextBox();
            textBoxThird = new TextBox();
            textBoxSecond = new TextBox();
            SuspendLayout();
            // 
            // buttonCheck
            // 
            buttonCheck.Location = new Point(161, 21);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(75, 23);
            buttonCheck.TabIndex = 0;
            buttonCheck.Text = "チェック";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(33, 22);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(100, 23);
            textBoxFirst.TabIndex = 1;
            // 
            // textBoxFifth
            // 
            textBoxFifth.Location = new Point(33, 258);
            textBoxFifth.Name = "textBoxFifth";
            textBoxFifth.Size = new Size(100, 23);
            textBoxFifth.TabIndex = 2;
            // 
            // textBoxFourth
            // 
            textBoxFourth.Location = new Point(33, 199);
            textBoxFourth.Name = "textBoxFourth";
            textBoxFourth.Size = new Size(100, 23);
            textBoxFourth.TabIndex = 3;
            // 
            // textBoxThird
            // 
            textBoxThird.Location = new Point(33, 140);
            textBoxThird.Name = "textBoxThird";
            textBoxThird.Size = new Size(100, 23);
            textBoxThird.TabIndex = 4;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(33, 81);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(100, 23);
            textBoxSecond.TabIndex = 5;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 316);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxThird);
            Controls.Add(textBoxFourth);
            Controls.Add(textBoxFifth);
            Controls.Add(textBoxFirst);
            Controls.Add(buttonCheck);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCheck;
        private TextBox textBoxFirst;
        private TextBox textBoxFifth;
        private TextBox textBoxFourth;
        private TextBox textBoxThird;
        private TextBox textBoxSecond;
    }
}