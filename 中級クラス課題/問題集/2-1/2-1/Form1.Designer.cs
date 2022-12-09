
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
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ask_lable
            // 
            this.Ask_lable.Location = new System.Drawing.Point(11, 29);
            this.Ask_lable.Name = "Ask_lable";
            this.Ask_lable.Size = new System.Drawing.Size(137, 61);
            this.Ask_lable.TabIndex = 0;
            this.Ask_lable.Text = "年齢はいくつですか？";
            this.Ask_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputAge
            // 
            this.inputAge.Location = new System.Drawing.Point(167, 47);
            this.inputAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputAge.Name = "inputAge";
            this.inputAge.Size = new System.Drawing.Size(173, 27);
            this.inputAge.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(347, 84);
            this.button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(102, 37);
            this.button.TabIndex = 2;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // _2_1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 141);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inputAge);
            this.Controls.Add(this.Ask_lable);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_2_1Form";
            this.Text = "2-1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ask_lable;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.Button button;
    }
}

