
namespace 問題37
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
            this.checkBox_Male = new System.Windows.Forms.CheckBox();
            this.checkBox_Female = new System.Windows.Forms.CheckBox();
            this.textBox_Male = new System.Windows.Forms.TextBox();
            this.textBox_Female = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBox_Male
            // 
            this.checkBox_Male.AutoSize = true;
            this.checkBox_Male.Location = new System.Drawing.Point(12, 64);
            this.checkBox_Male.Name = "checkBox_Male";
            this.checkBox_Male.Size = new System.Drawing.Size(46, 24);
            this.checkBox_Male.TabIndex = 2;
            this.checkBox_Male.Text = "男";
            this.checkBox_Male.UseVisualStyleBackColor = true;
            this.checkBox_Male.CheckedChanged += new System.EventHandler(this.checkBox_Male_CheckedChanged);
            // 
            // checkBox_Female
            // 
            this.checkBox_Female.AutoSize = true;
            this.checkBox_Female.Location = new System.Drawing.Point(12, 127);
            this.checkBox_Female.Name = "checkBox_Female";
            this.checkBox_Female.Size = new System.Drawing.Size(46, 24);
            this.checkBox_Female.TabIndex = 3;
            this.checkBox_Female.Text = "女";
            this.checkBox_Female.UseVisualStyleBackColor = true;
            this.checkBox_Female.CheckedChanged += new System.EventHandler(this.checkBox_Female_CheckedChanged);
            // 
            // textBox_Male
            // 
            this.textBox_Male.Location = new System.Drawing.Point(101, 64);
            this.textBox_Male.Name = "textBox_Male";
            this.textBox_Male.ReadOnly = true;
            this.textBox_Male.Size = new System.Drawing.Size(125, 27);
            this.textBox_Male.TabIndex = 4;
            // 
            // textBox_Female
            // 
            this.textBox_Female.Location = new System.Drawing.Point(101, 124);
            this.textBox_Female.Name = "textBox_Female";
            this.textBox_Female.ReadOnly = true;
            this.textBox_Female.Size = new System.Drawing.Size(125, 27);
            this.textBox_Female.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 211);
            this.Controls.Add(this.textBox_Female);
            this.Controls.Add(this.textBox_Male);
            this.Controls.Add(this.checkBox_Female);
            this.Controls.Add(this.checkBox_Male);
            this.Name = "Form_Main";
            this.Text = "問題37";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Male;
        private System.Windows.Forms.CheckBox checkBox_Female;
        private System.Windows.Forms.TextBox textBox_Male;
        private System.Windows.Forms.TextBox textBox_Female;
    }
}

