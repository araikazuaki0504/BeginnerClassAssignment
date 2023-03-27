
namespace 問題46
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
            this.SizeUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SizeUpButton
            // 
            this.SizeUpButton.Location = new System.Drawing.Point(12, 12);
            this.SizeUpButton.Name = "SizeUpButton";
            this.SizeUpButton.Size = new System.Drawing.Size(20, 13);
            this.SizeUpButton.TabIndex = 0;
            this.SizeUpButton.Text = "サイズUP";
            this.SizeUpButton.UseVisualStyleBackColor = true;
            this.SizeUpButton.Click += new System.EventHandler(this.SizeUpButton_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SizeUpButton);
            this.Name = "Form_Main";
            this.Text = "問題46";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SizeUpButton;
    }
}

