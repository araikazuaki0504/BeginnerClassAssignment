namespace 問題27
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
            displayButton = new Button();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            LastNameLabel1 = new Label();
            FirstNamelabel = new Label();
            SuspendLayout();
            // 
            // displayButton
            // 
            displayButton.Location = new Point(185, 154);
            displayButton.Name = "displayButton";
            displayButton.Size = new Size(89, 23);
            displayButton.TabIndex = 0;
            displayButton.Text = "表示";
            displayButton.UseVisualStyleBackColor = true;
            displayButton.Click += displayButton_Click;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(106, 42);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(106, 107);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 2;
            // 
            // LastNameLabel1
            // 
            LastNameLabel1.AutoSize = true;
            LastNameLabel1.Location = new Point(12, 50);
            LastNameLabel1.Name = "LastNameLabel1";
            LastNameLabel1.Size = new Size(19, 15);
            LastNameLabel1.TabIndex = 3;
            LastNameLabel1.Text = "氏";
            // 
            // FirstNamelabel
            // 
            FirstNamelabel.AutoSize = true;
            FirstNamelabel.Location = new Point(12, 115);
            FirstNamelabel.Name = "FirstNamelabel";
            FirstNamelabel.Size = new Size(19, 15);
            FirstNamelabel.TabIndex = 4;
            FirstNamelabel.Text = "名";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 195);
            Controls.Add(FirstNamelabel);
            Controls.Add(LastNameLabel1);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxLastName);
            Controls.Add(displayButton);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button displayButton;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label LastNameLabel1;
        private Label FirstNamelabel;
    }
}