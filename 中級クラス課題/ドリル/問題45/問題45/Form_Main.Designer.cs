
namespace 問題45
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
            this.buttonToMove = new System.Windows.Forms.Button();
            this.MovingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToMove
            // 
            this.buttonToMove.Location = new System.Drawing.Point(427, 409);
            this.buttonToMove.Name = "buttonToMove";
            this.buttonToMove.Size = new System.Drawing.Size(94, 29);
            this.buttonToMove.TabIndex = 0;
            this.buttonToMove.Text = "移動";
            this.buttonToMove.UseVisualStyleBackColor = true;
            this.buttonToMove.Click += new System.EventHandler(this.buttonToMove_Click);
            // 
            // MovingLabel
            // 
            this.MovingLabel.AutoSize = true;
            this.MovingLabel.Location = new System.Drawing.Point(12, 9);
            this.MovingLabel.Name = "MovingLabel";
            this.MovingLabel.Size = new System.Drawing.Size(43, 20);
            this.MovingLabel.TabIndex = 1;
            this.MovingLabel.Text = "ラベル";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.MovingLabel);
            this.Controls.Add(this.buttonToMove);
            this.Name = "Form_Main";
            this.Text = "問題45";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToMove;
        private System.Windows.Forms.Label MovingLabel;
    }
}

