
namespace _2_11a
{
    partial class _2_11a_Form
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
            this.Time_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Stop_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Time_label
            // 
            this.Time_label.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Time_label.Location = new System.Drawing.Point(49, 9);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(238, 127);
            this.Time_label.TabIndex = 0;
            this.Time_label.Text = "00:00";
            this.Time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(12, 139);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(75, 23);
            this.Start_button.TabIndex = 1;
            this.Start_button.Text = "start";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop_button
            // 
            this.Stop_button.Location = new System.Drawing.Point(129, 139);
            this.Stop_button.Name = "Stop_button";
            this.Stop_button.Size = new System.Drawing.Size(75, 23);
            this.Stop_button.TabIndex = 2;
            this.Stop_button.Text = "stop";
            this.Stop_button.UseVisualStyleBackColor = true;
            this.Stop_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Location = new System.Drawing.Point(246, 139);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(75, 23);
            this.Reset_button.TabIndex = 3;
            this.Reset_button.Text = "reset";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _2_11a_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 172);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Stop_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.Time_label);
            this.Name = "_2_11a_Form";
            this.Text = "2-11a";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Stop_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Timer timer1;
    }
}

