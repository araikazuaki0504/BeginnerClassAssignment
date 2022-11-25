
namespace _2_1
{
    partial class queLabel
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "年齢はいくつですか？";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(146, 35);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(152, 23);
            this.inputAge.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(304, 63);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(89, 28);
            this.button.TabIndex = 2;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // queLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 106);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.label1);
            this.Name = "queLabel";
            this.Text = "2-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Button button;
    }
}

