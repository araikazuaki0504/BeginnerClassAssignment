
namespace _2_3
{
    partial class _2_3_Form
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
            this.display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(201, 90);
            this.display.TabIndex = 0;
            this.display.Text = "表示";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.button_Click);
            // 
            // _2_3_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 116);
            this.Controls.Add(this.display);
            this.Name = "_2_3_Form";
            this.Text = "2-3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button display;
    }
}

