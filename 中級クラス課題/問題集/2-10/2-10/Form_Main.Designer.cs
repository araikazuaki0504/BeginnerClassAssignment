
namespace _2_10
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
            this.BirthDay_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WhatsDayOfWeek_button = new System.Windows.Forms.Button();
            this.WhatsYourBirthDay_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BirthDay_dateTimePicker
            // 
            this.BirthDay_dateTimePicker.Location = new System.Drawing.Point(32, 37);
            this.BirthDay_dateTimePicker.Name = "BirthDay_dateTimePicker";
            this.BirthDay_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.BirthDay_dateTimePicker.TabIndex = 0;
            // 
            // WhatsDayOfWeek_button
            // 
            this.WhatsDayOfWeek_button.Location = new System.Drawing.Point(188, 82);
            this.WhatsDayOfWeek_button.Name = "WhatsDayOfWeek_button";
            this.WhatsDayOfWeek_button.Size = new System.Drawing.Size(88, 23);
            this.WhatsDayOfWeek_button.TabIndex = 1;
            this.WhatsDayOfWeek_button.Text = "何曜日";
            this.WhatsDayOfWeek_button.UseVisualStyleBackColor = true;
            this.WhatsDayOfWeek_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // WhatsYourBirthDay_label
            // 
            this.WhatsYourBirthDay_label.Location = new System.Drawing.Point(13, 13);
            this.WhatsYourBirthDay_label.Name = "WhatsYourBirthDay_label";
            this.WhatsYourBirthDay_label.Size = new System.Drawing.Size(177, 21);
            this.WhatsYourBirthDay_label.TabIndex = 2;
            this.WhatsYourBirthDay_label.Text = "生年月日を入力してください。";
            // 
            // _2_10_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 120);
            this.Controls.Add(this.WhatsYourBirthDay_label);
            this.Controls.Add(this.WhatsDayOfWeek_button);
            this.Controls.Add(this.BirthDay_dateTimePicker);
            this.Name = "_2_10_Form";
            this.Text = "2-10";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker BirthDay_dateTimePicker;
        private System.Windows.Forms.Button WhatsDayOfWeek_button;
        private System.Windows.Forms.Label WhatsYourBirthDay_label;
    }
}

