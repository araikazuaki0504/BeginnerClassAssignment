
namespace WinFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.Tax_price = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.plus = new System.Windows.Forms.Button();
            this.init = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "合計";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "税込み";
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(82, 31);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(65, 23);
            this.Sum.TabIndex = 2;
            this.Sum.Text = "0";
            // 
            // Tax_price
            // 
            this.Tax_price.Location = new System.Drawing.Point(82, 73);
            this.Tax_price.Name = "Tax_price";
            this.Tax_price.Size = new System.Drawing.Size(65, 23);
            this.Tax_price.TabIndex = 3;
            this.Tax_price.Text = "0";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(153, 28);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(130, 23);
            this.Price.TabIndex = 4;
            this.Price.Text = "0";
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(208, 73);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 23);
            this.plus.TabIndex = 5;
            this.plus.Text = "加算";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // init
            // 
            this.init.Location = new System.Drawing.Point(208, 103);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(75, 23);
            this.init.TabIndex = 6;
            this.init.Text = "初期化";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(208, 133);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "終了";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 163);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.init);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Tax_price);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Label Tax_price;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.Button cancel;
    }
}

