namespace 問題13
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
            labelPlus = new Label();
            labelEqual = new Label();
            textBoxAns = new TextBox();
            buttonPlus = new Button();
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
            // labelPlus
            // 
            labelPlus.AutoSize = true;
            labelPlus.Location = new Point(148, 83);
            labelPlus.Name = "labelPlus";
            labelPlus.Size = new Size(15, 15);
            labelPlus.TabIndex = 2;
            labelPlus.Text = "+";
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
            // buttonPlus
            // 
            buttonPlus.Location = new Point(368, 178);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(75, 23);
            buttonPlus.TabIndex = 5;
            buttonPlus.Text = "足す";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 213);
            Controls.Add(buttonPlus);
            Controls.Add(textBoxAns);
            Controls.Add(labelEqual);
            Controls.Add(labelPlus);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Name = "";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private Label labelPlus;
        private Label labelEqual;
        private TextBox textBoxAns;
        private Button buttonPlus;
    }
}