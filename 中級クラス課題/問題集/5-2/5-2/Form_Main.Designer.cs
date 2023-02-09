
namespace _5_2
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
            this.OK_button = new System.Windows.Forms.Button();
            this.HowOld_label = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(208, 58);
            this.OK_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(82, 22);
            this.OK_button.TabIndex = 0;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // HowOld_label
            // 
            this.HowOld_label.AutoSize = true;
            this.HowOld_label.Location = new System.Drawing.Point(10, 27);
            this.HowOld_label.Name = "HowOld_label";
            this.HowOld_label.Size = new System.Drawing.Size(97, 15);
            this.HowOld_label.TabIndex = 1;
            this.HowOld_label.Text = "年齢はいくつですか";
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(122, 25);
            this.inputAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(110, 23);
            this.inputAge.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 97);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.HowOld_label);
            this.Controls.Add(this.OK_button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.Text = "5-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK_button;
        private System.Windows.Forms.Label HowOld_label;
        private System.Windows.Forms.TextBox inputAge;
    }
}

