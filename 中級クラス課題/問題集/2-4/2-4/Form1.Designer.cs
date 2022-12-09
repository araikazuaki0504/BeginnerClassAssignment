
namespace _2_4
{
    partial class _2_4_Form
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
            this.Ask_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.get_sarcedLot_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ask_label
            // 
            this.Ask_label.Location = new System.Drawing.Point(11, 36);
            this.Ask_label.Name = "Ask_label";
            this.Ask_label.Size = new System.Drawing.Size(121, 23);
            this.Ask_label.TabIndex = 0;
            this.Ask_label.Text = "名前を入力してください";
            this.Ask_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(162, 37);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(152, 23);
            this.Name_textBox.TabIndex = 1;
            // 
            // get_sarcedLot_button
            // 
            this.get_sarcedLot_button.Location = new System.Drawing.Point(111, 75);
            this.get_sarcedLot_button.Name = "get_sarcedLot_button";
            this.get_sarcedLot_button.Size = new System.Drawing.Size(93, 23);
            this.get_sarcedLot_button.TabIndex = 2;
            this.get_sarcedLot_button.Text = "おみくじを引く";
            this.get_sarcedLot_button.UseVisualStyleBackColor = true;
            this.get_sarcedLot_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _2_4_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 121);
            this.Controls.Add(this.get_sarcedLot_button);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Ask_label);
            this.Name = "_2_4_Form";
            this.Text = "2-4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ask_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button get_sarcedLot_button;
    }
}

