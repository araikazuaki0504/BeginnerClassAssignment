
namespace _2_6a
{
    partial class _2_6_Form
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
            this.Name_listBox = new System.Windows.Forms.ListBox();
            this.Display_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_listBox
            // 
            this.Name_listBox.FormattingEnabled = true;
            this.Name_listBox.ItemHeight = 15;
            this.Name_listBox.Location = new System.Drawing.Point(12, 12);
            this.Name_listBox.Name = "Name_listBox";
            this.Name_listBox.Size = new System.Drawing.Size(234, 199);
            this.Name_listBox.TabIndex = 0;
            // 
            // Display_button
            // 
            this.Display_button.Location = new System.Drawing.Point(85, 217);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(86, 35);
            this.Display_button.TabIndex = 1;
            this.Display_button.Text = "表示";
            this.Display_button.UseVisualStyleBackColor = true;
            this.Display_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _2_6_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 264);
            this.Controls.Add(this.Display_button);
            this.Controls.Add(this.Name_listBox);
            this.Name = "_2_6_Form";
            this.Text = "2-6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Name_listBox;
        private System.Windows.Forms.Button Display_button;
    }
}

