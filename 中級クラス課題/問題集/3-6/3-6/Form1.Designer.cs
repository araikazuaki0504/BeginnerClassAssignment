
namespace _2_4
{
    partial class Form1
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
            this.Display_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.SarcedLot_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display_label
            // 
            this.Display_label.Location = new System.Drawing.Point(11, 36);
            this.Display_label.Name = "Display_label";
            this.Display_label.Size = new System.Drawing.Size(121, 23);
            this.Display_label.TabIndex = 0;
            this.Display_label.Text = "名前を入力してください";
            this.Display_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(162, 37);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(152, 23);
            this.Name_textBox.TabIndex = 1;
            // 
            // SarcedLot_button
            // 
            this.SarcedLot_button.Location = new System.Drawing.Point(111, 75);
            this.SarcedLot_button.Name = "SarcedLot_button";
            this.SarcedLot_button.Size = new System.Drawing.Size(93, 23);
            this.SarcedLot_button.TabIndex = 2;
            this.SarcedLot_button.Text = "おみくじを引く";
            this.SarcedLot_button.UseVisualStyleBackColor = true;
            this.SarcedLot_button.Click += new System.EventHandler(this.SarcedLot_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 121);
            this.Controls.Add(this.SarcedLot_button);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Display_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Display_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button SarcedLot_button;
    }
}

