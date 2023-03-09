namespace 問題17
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
            buttonPlusOrMinus = new Button();
            textBoxInput = new TextBox();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // buttonPlusOrMinus
            // 
            buttonPlusOrMinus.Location = new Point(176, 118);
            buttonPlusOrMinus.Name = "buttonPlusOrMinus";
            buttonPlusOrMinus.Size = new Size(143, 35);
            buttonPlusOrMinus.TabIndex = 0;
            buttonPlusOrMinus.Text = "判定";
            buttonPlusOrMinus.UseVisualStyleBackColor = true;
            buttonPlusOrMinus.Click += buttonPlusOrMinus_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(21, 50);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 1;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(176, 50);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(100, 23);
            textBoxOutput.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 166);
            Controls.Add(textBoxOutput);
            Controls.Add(textBoxInput);
            Controls.Add(buttonPlusOrMinus);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPlusOrMinus;
        private TextBox textBoxInput;
        private TextBox textBoxOutput;
    }
}