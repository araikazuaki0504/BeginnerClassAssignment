
namespace _2_1
{
    partial class _2_1Form
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
            this.Ask_lable = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ask_lable
            // 
            this.Ask_lable.Location = new System.Drawing.Point(10, 22);
            this.Ask_lable.Name = "Ask_lable";
            this.Ask_lable.Size = new System.Drawing.Size(120, 46);
            this.Ask_lable.TabIndex = 0;
            this.Ask_lable.Text = "年齢はいくつですか？";
            this.Ask_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(146, 35);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(152, 23);
            this.inputAge.TabIndex = 1;
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(304, 63);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(89, 28);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.button_Click);
            // 
            // _2_1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 106);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.Ask_lable);
            this.Name = "_2_1Form";
            this.Text = "2-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ask_lable;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Button OK_button;
    }
}

