namespace 問題18
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
            buttonCompare = new Button();
            textBoxFirst = new TextBox();
            textBoxSecond = new TextBox();
            textBoxMax = new TextBox();
            SuspendLayout();
            // 
            // buttonCompare
            // 
            buttonCompare.Location = new Point(216, 159);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new Size(75, 23);
            buttonCompare.TabIndex = 0;
            buttonCompare.Text = "比較";
            buttonCompare.UseVisualStyleBackColor = true;
            buttonCompare.Click += buttonCompare_Click;
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(12, 57);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(100, 23);
            textBoxFirst.TabIndex = 1;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(187, 57);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(100, 23);
            textBoxSecond.TabIndex = 2;
            // 
            // textBoxMax
            // 
            textBoxMax.Location = new Point(98, 119);
            textBoxMax.Name = "textBoxMax";
            textBoxMax.ReadOnly = true;
            textBoxMax.Size = new Size(100, 23);
            textBoxMax.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 194);
            Controls.Add(textBoxMax);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Controls.Add(buttonCompare);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCompare;
        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private TextBox textBoxMax;
    }
}