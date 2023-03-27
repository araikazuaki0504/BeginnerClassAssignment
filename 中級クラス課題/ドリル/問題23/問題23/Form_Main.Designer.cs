namespace 問題23
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
            textBox_Output = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // textBox_Output
            // 
            textBox_Output.Location = new Point(12, 12);
            textBox_Output.Multiline = true;
            textBox_Output.Name = "textBox_Output";
            textBox_Output.ReadOnly = true;
            textBox_Output.Size = new Size(401, 335);
            textBox_Output.TabIndex = 0;
            // 
            // button
            // 
            button.Location = new Point(321, 387);
            button.Name = "button";
            button.Size = new Size(92, 32);
            button.TabIndex = 1;
            button.Text = "表示";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 431);
            Controls.Add(button);
            Controls.Add(textBox_Output);
            Name = "Form_Main";
            Text = "問題23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Output;
        private Button button;
    }
}