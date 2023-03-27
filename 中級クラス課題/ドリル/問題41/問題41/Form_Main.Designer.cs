
namespace 問題41
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
            this.buttonToAdd = new System.Windows.Forms.Button();
            this.buttonToRemove = new System.Windows.Forms.Button();
            this.textBoxToAddOrRemove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DisplayComboBox
            // 
            this.DisplayComboBox.FormattingEnabled = true;
            this.DisplayComboBox.Location = new System.Drawing.Point(9, 96);
            this.DisplayComboBox.Name = "DisplayComboBox";
            this.DisplayComboBox.Size = new System.Drawing.Size(151, 28);
            this.DisplayComboBox.TabIndex = 0;
            // 
            // buttonToAdd
            // 
            this.buttonToAdd.Location = new System.Drawing.Point(125, 156);
            this.buttonToAdd.Name = "buttonToAdd";
            this.buttonToAdd.Size = new System.Drawing.Size(94, 29);
            this.buttonToAdd.TabIndex = 1;
            this.buttonToAdd.Text = "追加";
            this.buttonToAdd.UseVisualStyleBackColor = true;
            this.buttonToAdd.Click += new System.EventHandler(this.buttonToAdd_Click);
            // 
            // buttonToRemove
            // 
            this.buttonToRemove.Location = new System.Drawing.Point(256, 156);
            this.buttonToRemove.Name = "buttonToRemove";
            this.buttonToRemove.Size = new System.Drawing.Size(94, 29);
            this.buttonToRemove.TabIndex = 2;
            this.buttonToRemove.Text = "削除";
            this.buttonToRemove.UseVisualStyleBackColor = true;
            this.buttonToRemove.Click += new System.EventHandler(this.buttonToRemove_Click);
            // 
            // textBoxToAddOrRemove
            // 
            this.textBoxToAddOrRemove.Location = new System.Drawing.Point(9, 37);
            this.textBoxToAddOrRemove.Name = "textBoxToAddOrRemove";
            this.textBoxToAddOrRemove.Size = new System.Drawing.Size(125, 27);
            this.textBoxToAddOrRemove.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 207);
            this.Controls.Add(this.textBoxToAddOrRemove);
            this.Controls.Add(this.buttonToRemove);
            this.Controls.Add(this.buttonToAdd);
            this.Controls.Add(this.DisplayComboBox);
            this.Name = "Form_Main";
            this.Text = "問題41";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DisplayComboBox;
        private System.Windows.Forms.Button buttonToAdd;
        private System.Windows.Forms.Button buttonToRemove;
        private System.Windows.Forms.TextBox textBoxToAddOrRemove;
    }
}

