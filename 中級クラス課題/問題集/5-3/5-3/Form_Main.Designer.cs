
namespace _5_3
{
<<<<<<< HEAD:中級クラス課題/問題集/5-3/5-3/Form_Main.Designer.cs
    partial class Form_Main
=======
    partial class _5_3_Form
>>>>>>> 751d62ba30b5294fdd3226aa1f3235c86459eb60:中級クラス課題/問題集/5-3/5-3/Form1.Designer.cs
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
            this.Display_button = new System.Windows.Forms.Button();
            this.Name_label = new System.Windows.Forms.Label();
            this.Month_lable = new System.Windows.Forms.Label();
            this.Day_lable = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Month_textBox = new System.Windows.Forms.TextBox();
            this.Day_textBox = new System.Windows.Forms.TextBox();
            this.WhatNameAndBirthday_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Display_button
            // 
            this.Display_button.Location = new System.Drawing.Point(167, 226);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(94, 29);
            this.Display_button.TabIndex = 0;
            this.Display_button.Text = "表示";
            this.Display_button.UseVisualStyleBackColor = true;
            this.Display_button.Click += new System.EventHandler(this.Display_button_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(13, 47);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(39, 20);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "氏名";
            // 
            // Month_lable
            // 
            this.Month_lable.AutoSize = true;
            this.Month_lable.Location = new System.Drawing.Point(13, 110);
            this.Month_lable.Name = "Month_lable";
            this.Month_lable.Size = new System.Drawing.Size(24, 20);
            this.Month_lable.TabIndex = 2;
            this.Month_lable.Text = "月";
            // 
            // Day_lable
            // 
            this.Day_lable.AutoSize = true;
            this.Day_lable.Location = new System.Drawing.Point(13, 173);
            this.Day_lable.Name = "Day_lable";
            this.Day_lable.Size = new System.Drawing.Size(24, 20);
            this.Day_lable.TabIndex = 3;
            this.Day_lable.Text = "日";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(73, 47);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(125, 27);
            this.Name_textBox.TabIndex = 4;
            // 
            // Month_textBox
            // 
            this.Month_textBox.Location = new System.Drawing.Point(73, 110);
            this.Month_textBox.Name = "Month_textBox";
            this.Month_textBox.Size = new System.Drawing.Size(125, 27);
            this.Month_textBox.TabIndex = 5;
            // 
            // Day_textBox
            // 
            this.Day_textBox.Location = new System.Drawing.Point(73, 173);
            this.Day_textBox.Name = "Day_textBox";
            this.Day_textBox.Size = new System.Drawing.Size(125, 27);
            this.Day_textBox.TabIndex = 6;
            // 
            // WhatNameAndBirthday_label
            // 
            this.WhatNameAndBirthday_label.AutoSize = true;
            this.WhatNameAndBirthday_label.Location = new System.Drawing.Point(51, 9);
            this.WhatNameAndBirthday_label.Name = "WhatNameAndBirthday_label";
            this.WhatNameAndBirthday_label.Size = new System.Drawing.Size(199, 20);
            this.WhatNameAndBirthday_label.TabIndex = 7;
            this.WhatNameAndBirthday_label.Text = "氏名、誕生日を入力してください";
            // 
            // _5_3_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 274);
            this.Controls.Add(this.WhatNameAndBirthday_label);
            this.Controls.Add(this.Day_textBox);
            this.Controls.Add(this.Month_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Day_lable);
            this.Controls.Add(this.Month_lable);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.Display_button);
            this.Name = "_5_3_Form";
            this.Text = "5-3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Display_button;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label Month_lable;
        private System.Windows.Forms.Label Day_lable;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.TextBox Month_textBox;
        private System.Windows.Forms.TextBox Day_textBox;
        private System.Windows.Forms.Label WhatNameAndBirthday_label;
    }
}

