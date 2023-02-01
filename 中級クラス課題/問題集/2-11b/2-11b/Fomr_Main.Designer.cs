
namespace _2_11b
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Lap_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.LapTime_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Time_label.Location = new System.Drawing.Point(12, 27);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(191, 86);
            this.Time_label.TabIndex = 0;
            this.Time_label.Text = "00:00";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(12, 139);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 1;
            this.Start_button.Text = "Start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(115, 139);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(75, 23);
            this.Stop_button.TabIndex = 2;
            this.Stop_button.Text = "Stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lap_button
            // 
            this.Lap_button.Enabled = false;
            this.Lap_button.Location = new System.Drawing.Point(218, 139);
            this.Lap_button.Name = "Lap_button";
            this.Lap_button.Size = new System.Drawing.Size(75, 23);
            this.Lap_button.TabIndex = 3;
            this.Lap_button.Text = "Lap";
            this.Lap_button.UseVisualStyleBackColor = true;
            this.Lap_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(321, 139);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 23);
            this.Reset_button.TabIndex = 4;
            this.Reset_button.Text = "Reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // LapTime_listBox
            // 
            this.LapTime_listBox.FormattingEnabled = true;
            this.LapTime_listBox.ItemHeight = 15;
            this.LapTime_listBox.Location = new System.Drawing.Point(218, 19);
            this.LapTime_listBox.Name = "LapTime_listBox";
            this.LapTime_listBox.Size = new System.Drawing.Size(178, 109);
            this.LapTime_listBox.TabIndex = 5;
            // 
            // _2_11b_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 178);
            this.Controls.Add(this.LapTime_listBox);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Lap_button);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Time_label);
            this.Name = "_2_11b_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button Lap_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.ListBox LapTime_listBox;
    }
}

