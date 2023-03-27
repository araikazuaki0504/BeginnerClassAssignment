namespace 問題63
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
            WriteButton = new Button();
            listBox = new ListBox();
            SuspendLayout();
            // 
            // WriteButton
            // 
            WriteButton.Location = new Point(65, 224);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(75, 23);
            WriteButton.TabIndex = 1;
            WriteButton.Text = "書き込み";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Items.AddRange(new object[] { "IF太郎", "IF花子", "IF次郎", "IF良子", "IF三郎" });
            listBox.Location = new Point(12, 12);
            listBox.Name = "listBox";
            listBox.Size = new Size(175, 199);
            listBox.TabIndex = 2;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(199, 268);
            Controls.Add(listBox);
            Controls.Add(WriteButton);
            Name = "Form_Main";
            ResumeLayout(false);
        }

        #endregion
        private Button WriteButton;
        private ListBox listBox;
    }
}