
namespace 問題38
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
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.textBox_male = new System.Windows.Forms.TextBox();
            this.textBox_female = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(12, 51);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(60, 24);
            this.radioButton_Male.TabIndex = 0;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "男性";
            this.radioButton_Male.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton_Male.UseVisualStyleBackColor = true;
            this.radioButton_Male.CheckedChanged += new System.EventHandler(this.radioButton_Male_CheckedChanged);
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(12, 109);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(60, 24);
            this.radioButton_female.TabIndex = 1;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "女性";
            this.radioButton_female.UseVisualStyleBackColor = true;
            this.radioButton_female.CheckedChanged += new System.EventHandler(this.radioButton_female_CheckedChanged);
            // 
            // textBox_male
            // 
            this.textBox_male.Location = new System.Drawing.Point(99, 50);
            this.textBox_male.Name = "textBox_male";
            this.textBox_male.ReadOnly = true;
            this.textBox_male.Size = new System.Drawing.Size(125, 27);
            this.textBox_male.TabIndex = 2;
            // 
            // textBox_female
            // 
            this.textBox_female.Location = new System.Drawing.Point(99, 108);
            this.textBox_female.Name = "textBox_female";
            this.textBox_female.ReadOnly = true;
            this.textBox_female.Size = new System.Drawing.Size(125, 27);
            this.textBox_female.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 166);
            this.Controls.Add(this.textBox_female);
            this.Controls.Add(this.textBox_male);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_Male);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_male;
        private System.Windows.Forms.TextBox textBox_female;
    }
}

