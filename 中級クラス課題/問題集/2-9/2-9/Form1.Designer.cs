
namespace _2_9
{
    partial class _2_9_Form
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
            this.Ask_label = new System.Windows.Forms.Label();
            this.BrithDay_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HowLong_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ask_label
            // 
            this.Ask_label.AutoSize = true;
            this.Ask_label.Location = new System.Drawing.Point(12, 9);
            this.Ask_label.Name = "Ask_label";
            this.Ask_label.Size = new System.Drawing.Size(221, 15);
            this.Ask_label.TabIndex = 0;
            this.Ask_label.Text = "生年月日を入力して、ボタンを押してください。";
            // 
            // BrithDay_dateTimePicker
            // 
            this.BrithDay_dateTimePicker.Location = new System.Drawing.Point(12, 27);
            this.BrithDay_dateTimePicker.Name = "BrithDay_dateTimePicker";
            this.BrithDay_dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.BrithDay_dateTimePicker.TabIndex = 1;
            // 
            // HowLong_button
            // 
            this.HowLong_button.Location = new System.Drawing.Point(195, 56);
            this.HowLong_button.Name = "HowLong_button";
            this.HowLong_button.Size = new System.Drawing.Size(75, 23);
            this.HowLong_button.TabIndex = 2;
            this.HowLong_button.Text = "何日目?";
            this.HowLong_button.UseVisualStyleBackColor = true;
            this.HowLong_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _2_9_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 94);
            this.Controls.Add(this.HowLong_button);
            this.Controls.Add(this.BrithDay_dateTimePicker);
            this.Controls.Add(this.Ask_label);
            this.Name = "_2_9_Form";
            this.Text = "2-9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ask_label;
        private System.Windows.Forms.DateTimePicker BrithDay_dateTimePicker;
        private System.Windows.Forms.Button HowLong_button;
    }
}

