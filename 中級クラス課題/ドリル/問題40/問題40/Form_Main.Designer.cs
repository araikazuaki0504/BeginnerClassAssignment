
namespace 問題40
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
            this.DisplayComboBox = new System.Windows.Forms.ComboBox();
            this.textBox_ToAdd = new System.Windows.Forms.TextBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayComboBox
            // 
            this.DisplayComboBox.FormattingEnabled = true;
            this.DisplayComboBox.Location = new System.Drawing.Point(12, 116);
            this.DisplayComboBox.Name = "DisplayComboBox";
            this.DisplayComboBox.Size = new System.Drawing.Size(151, 28);
            this.DisplayComboBox.TabIndex = 0;
            // 
            // textBox_ToAdd
            // 
            this.textBox_ToAdd.Location = new System.Drawing.Point(12, 47);
            this.textBox_ToAdd.Name = "textBox_ToAdd";
            this.textBox_ToAdd.Size = new System.Drawing.Size(120, 27);
            this.textBox_ToAdd.TabIndex = 1;
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(205, 115);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(94, 29);
            this.Add_button.TabIndex = 2;
            this.Add_button.Text = "追加";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 166);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.textBox_ToAdd);
            this.Controls.Add(this.DisplayComboBox);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DisplayComboBox;
        private System.Windows.Forms.TextBox textBox_ToAdd;
        private System.Windows.Forms.Button Add_button;
    }
}

