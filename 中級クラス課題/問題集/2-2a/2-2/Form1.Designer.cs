
namespace _2_2
{
    partial class _2_2_Form
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
            this.Display_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Display_button
            // 
            this.Display_button.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Display_button.Location = new System.Drawing.Point(12, 12);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(317, 116);
            this.Display_button.TabIndex = 0;
            this.Display_button.Text = "おみくじを引く";
            this.Display_button.UseVisualStyleBackColor = true;
            this.Display_button.Click += new System.EventHandler(this.Display_button_Click);
            // 
            // _2_2_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 145);
            this.Controls.Add(this.Display_button);
            this.Name = "_2_2_Form";
            this.Text = "2-2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Display_button;
    }
}

