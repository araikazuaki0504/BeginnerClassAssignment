
namespace _2_7
{
    partial class _2_7_Form
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
            this.inputNum_textBox = new System.Windows.Forms.TextBox();
            this.Please_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Check_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNum_textBox
            // 
            this.inputNum_textBox.Enabled = false;
            this.inputNum_textBox.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNum_textBox.Location = new System.Drawing.Point(91, 74);
            this.inputNum_textBox.Multiline = true;
            this.inputNum_textBox.Name = "inputNum_textBox";
            this.inputNum_textBox.Size = new System.Drawing.Size(162, 167);
            this.inputNum_textBox.TabIndex = 0;
            // 
            // Please_label
            // 
            this.Please_label.Location = new System.Drawing.Point(75, 29);
            this.Please_label.Name = "Please_label";
            this.Please_label.Size = new System.Drawing.Size(194, 23);
            this.Please_label.TabIndex = 1;
            this.Please_label.Text = "1~99までの整数を入力してください。";
            this.Please_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(31, 262);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(99, 29);
            this.Start_button.TabIndex = 2;
            this.Start_button.Text = "開始";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check_button
            // 
            this.Check_button.Enabled = false;
            this.Check_button.Location = new System.Drawing.Point(204, 262);
            this.Check_button.Name = "Check_button";
            this.Check_button.Size = new System.Drawing.Size(99, 29);
            this.Check_button.TabIndex = 3;
            this.Check_button.Text = "判定";
            this.Check_button.UseVisualStyleBackColor = true;
            this.Check_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // _2_7_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 315);
            this.Controls.Add(this.Check_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Please_label);
            this.Controls.Add(this.inputNum_textBox);
            this.Name = "_2_7_Form";
            this.Text = "2-7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNum_textBox;
        private System.Windows.Forms.Label Please_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Check_button;
    }
}

