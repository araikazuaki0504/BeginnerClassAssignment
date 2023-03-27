
namespace 問題44
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
            this.ToRightArrow = new System.Windows.Forms.Button();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.ToLeftArrow = new System.Windows.Forms.Button();
            this.listBox_view = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ToRightArrow
            // 
            this.ToRightArrow.Location = new System.Drawing.Point(171, 30);
            this.ToRightArrow.Name = "ToRightArrow";
            this.ToRightArrow.Size = new System.Drawing.Size(94, 29);
            this.ToRightArrow.TabIndex = 0;
            this.ToRightArrow.Text = "→";
            this.ToRightArrow.UseVisualStyleBackColor = true;
            this.ToRightArrow.Click += new System.EventHandler(this.ToRightArrow_Click);
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Items.AddRange(new object[] {
            "東京",
            "大阪",
            "愛知",
            "福岡",
            "沖縄"});
            this.comboBox_City.Location = new System.Drawing.Point(15, 31);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(133, 28);
            this.comboBox_City.TabIndex = 1;
            // 
            // ToLeftArrow
            // 
            this.ToLeftArrow.Location = new System.Drawing.Point(171, 74);
            this.ToLeftArrow.Name = "ToLeftArrow";
            this.ToLeftArrow.Size = new System.Drawing.Size(94, 29);
            this.ToLeftArrow.TabIndex = 2;
            this.ToLeftArrow.Text = "←";
            this.ToLeftArrow.UseVisualStyleBackColor = true;
            this.ToLeftArrow.Click += new System.EventHandler(this.ToLeftArrow_Click);
            // 
            // listBox_view
            // 
            this.listBox_view.FormattingEnabled = true;
            this.listBox_view.ItemHeight = 20;
            this.listBox_view.Location = new System.Drawing.Point(296, 30);
            this.listBox_view.Name = "listBox_view";
            this.listBox_view.Size = new System.Drawing.Size(150, 104);
            this.listBox_view.TabIndex = 3;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 150);
            this.Controls.Add(this.listBox_view);
            this.Controls.Add(this.ToLeftArrow);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.ToRightArrow);
            this.Name = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ToRightArrow;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Button ToLeftArrow;
        private System.Windows.Forms.ListBox listBox_view;
    }
}

