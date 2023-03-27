
namespace 問題42
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
            this.buttonToAdd = new System.Windows.Forms.Button();
            this.textBoxToAdd = new System.Windows.Forms.TextBox();
            this.listBox_View = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonToAdd
            // 
            this.buttonToAdd.Location = new System.Drawing.Point(103, 371);
            this.buttonToAdd.Name = "buttonToAdd";
            this.buttonToAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonToAdd.TabIndex = 0;
            this.buttonToAdd.Text = "追加";
            this.buttonToAdd.UseVisualStyleBackColor = true;
            this.buttonToAdd.Click += new System.EventHandler(this.buttonToAdd_Click);
            // 
            // textBoxToAdd
            // 
            this.textBoxToAdd.Location = new System.Drawing.Point(12, 36);
            this.textBoxToAdd.Name = "textBoxToAdd";
            this.textBoxToAdd.Size = new System.Drawing.Size(125, 27);
            this.textBoxToAdd.TabIndex = 1;
            // 
            // listBox_View
            // 
            this.listBox_View.FormattingEnabled = true;
            this.listBox_View.ItemHeight = 20;
            this.listBox_View.Location = new System.Drawing.Point(12, 86);
            this.listBox_View.Name = "listBox_View";
            this.listBox_View.Size = new System.Drawing.Size(185, 264);
            this.listBox_View.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 415);
            this.Controls.Add(this.listBox_View);
            this.Controls.Add(this.textBoxToAdd);
            this.Controls.Add(this.buttonToAdd);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToAdd;
        private System.Windows.Forms.TextBox textBoxToAdd;
        private System.Windows.Forms.ListBox listBox_View;
    }
}

