
namespace _2_5
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
            this.Name = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Month_textBox = new System.Windows.Forms.TextBox();
            this.Day_textBox = new System.Windows.Forms.TextBox();
            this.display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ask_label
            // 
            this.Ask_label.Location = new System.Drawing.Point(12, 21);
            this.Ask_label.Name = "Ask_label";
            this.Ask_label.Size = new System.Drawing.Size(188, 23);
            this.Ask_label.TabIndex = 0;
            this.Ask_label.Text = "氏名、誕生日を入力してください";
            this.Ask_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(12, 57);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 23);
            this.Name.TabIndex = 1;
            this.Name.Text = "氏名";
            this.Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(12, 137);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(55, 23);
            this.day.TabIndex = 2;
            this.day.Text = "日";
            this.day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(12, 99);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(55, 23);
            this.month.TabIndex = 3;
            this.month.Text = "月";
            this.month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(79, 57);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(100, 23);
            this.Name_textBox.TabIndex = 4;
            // 
            // Month_textBox
            // 
            this.Month_textBox.Location = new System.Drawing.Point(79, 99);
            this.Month_textBox.Name = "Month_textBox";
            this.Month_textBox.Size = new System.Drawing.Size(100, 23);
            this.Month_textBox.TabIndex = 5;
            // 
            // Day_textBox
            // 
            this.Day_textBox.Location = new System.Drawing.Point(79, 137);
            this.Day_textBox.Name = "Day_textBox";
            this.Day_textBox.Size = new System.Drawing.Size(100, 23);
            this.Day_textBox.TabIndex = 6;
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(112, 179);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(75, 23);
            this.display.TabIndex = 7;
            this.display.Text = "表示";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // _2_5_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 214);
            this.Controls.Add(this.display);
            this.Controls.Add(this.Day_textBox);
            this.Controls.Add(this.Month_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Ask_label);
            this.Name = "_2_5_Form";
            this.Text = "2-5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ask_label;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Label month;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Month_textBox;
        private System.Windows.Forms.TextBox Day_textBox;
        private System.Windows.Forms.Button display;
    }
}

