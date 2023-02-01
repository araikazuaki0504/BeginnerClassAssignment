
namespace _2_2b
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
            this.Ask_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.pushBotton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ask_label
            // 
            this.Ask_label.Location = new System.Drawing.Point(10, 22);
            this.Ask_label.Name = "Ask_label";
            this.Ask_label.Size = new System.Drawing.Size(138, 42);
            this.Ask_label.TabIndex = 0;
            this.Ask_label.Text = "名前を入力してください";
            this.Ask_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(154, 33);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(151, 23);
            this.Name_textBox.TabIndex = 1;
            // 
            // pushBotton
            // 
            this.pushBotton.Location = new System.Drawing.Point(154, 77);
            this.pushBotton.Name = "pushBotton";
            this.pushBotton.Size = new System.Drawing.Size(101, 29);
            this.pushBotton.TabIndex = 2;
            this.pushBotton.Text = "おみくじを引く";
            this.pushBotton.UseVisualStyleBackColor = true;
            this.pushBotton.Click += new System.EventHandler(this.pushBotton_Click);
            // 
            // _2_2b_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 121);
            this.Controls.Add(this.pushBotton);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Ask_label);
            this.Name = "_2_2b_Form";
            this.Text = "2-2b";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ask_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Button pushBotton;
    }
}

