
namespace _5_2
{
    partial class _5_2_Form
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
            this.OK_button.Location = new System.Drawing.Point(238, 77);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(94, 29);
            this.OK_button.TabIndex = 0;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // HowOld_label
            // 
            this.HowOld_label.AutoSize = true;
            this.HowOld_label.Location = new System.Drawing.Point(12, 36);
            this.HowOld_label.Name = "HowOld_label";
            this.HowOld_label.Size = new System.Drawing.Size(121, 20);
            this.HowOld_label.TabIndex = 1;
            this.HowOld_label.Text = "年齢はいくつですか";
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(139, 33);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(125, 27);
            this.inputAge.TabIndex = 2;
            // 
            // _5_2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 129);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.HowOld_label);
            this.Controls.Add(this.OK_button);
            this.Name = "_5_2_Form";
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

