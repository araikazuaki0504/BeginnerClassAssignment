namespace 問題24
{
    partial class Main_Form
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
            button = new Button();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(299, 434);
            button.Name = "button";
            button.Size = new Size(100, 32);
            button.TabIndex = 0;
            button.Text = "表示";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(12, 12);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.ReadOnly = true;
            textBoxOutput.Size = new Size(387, 416);
            textBoxOutput.TabIndex = 1;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 478);
            Controls.Add(textBoxOutput);
            Controls.Add(button);
            Name = "Main_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private TextBox textBoxOutput;
    }
}