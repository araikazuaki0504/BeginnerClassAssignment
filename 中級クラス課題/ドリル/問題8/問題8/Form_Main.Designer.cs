namespace 問題8
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
            ExchangeButton = new Button();
            LabelA = new Label();
            LabelB = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            SuspendLayout();
            // 
            // ExchangeButton
            // 
            ExchangeButton.Location = new Point(160, 171);
            ExchangeButton.Name = "ExchangeButton";
            ExchangeButton.Size = new Size(75, 23);
            ExchangeButton.TabIndex = 0;
            ExchangeButton.Text = "交換";
            ExchangeButton.UseVisualStyleBackColor = true;
            ExchangeButton.Click += ExchangeButton_Click;
            // 
            // LabelA
            // 
            LabelA.AutoSize = true;
            LabelA.Location = new Point(33, 67);
            LabelA.Name = "LabelA";
            LabelA.Size = new Size(86, 15);
            LabelA.TabIndex = 1;
            LabelA.Text = "テキストボックスA";
            // 
            // LabelB
            // 
            LabelB.AutoSize = true;
            LabelB.Location = new Point(275, 67);
            LabelB.Name = "LabelB";
            LabelB.Size = new Size(85, 15);
            LabelB.TabIndex = 2;
            LabelB.Text = "テキストボックスB";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(33, 110);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 3;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(275, 110);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 206);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(LabelB);
            Controls.Add(LabelA);
            Controls.Add(ExchangeButton);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExchangeButton;
        private Label LabelA;
        private Label LabelB;
        private TextBox textBoxA;
        private TextBox textBoxB;
    }
}