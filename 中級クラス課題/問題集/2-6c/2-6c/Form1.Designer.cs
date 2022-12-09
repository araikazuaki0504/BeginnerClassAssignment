
namespace _2_6c
{
    partial class _2_6C_Form
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
            this.Jap_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.Math_listView = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.Eng_listView = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.Display_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Jap_listView
            // 
            this.Jap_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Jap_listView.FullRowSelect = true;
            this.Jap_listView.GridLines = true;
            this.Jap_listView.HideSelection = false;
            this.Jap_listView.Location = new System.Drawing.Point(12, 12);
            this.Jap_listView.Name = "Jap_listView";
            this.Jap_listView.Size = new System.Drawing.Size(186, 290);
            this.Jap_listView.TabIndex = 0;
            this.Jap_listView.UseCompatibleStateImageBehavior = false;
            this.Jap_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "国語";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // Math_listView
            // 
            this.Math_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.Math_listView.FullRowSelect = true;
            this.Math_listView.GridLines = true;
            this.Math_listView.HideSelection = false;
            this.Math_listView.Location = new System.Drawing.Point(217, 12);
            this.Math_listView.Name = "Math_listView";
            this.Math_listView.Size = new System.Drawing.Size(186, 290);
            this.Math_listView.TabIndex = 1;
            this.Math_listView.UseCompatibleStateImageBehavior = false;
            this.Math_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "名前";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "数学";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 80;
            // 
            // Eng_listView
            // 
            this.Eng_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.Eng_listView.FullRowSelect = true;
            this.Eng_listView.GridLines = true;
            this.Eng_listView.HideSelection = false;
            this.Eng_listView.Location = new System.Drawing.Point(424, 12);
            this.Eng_listView.Name = "Eng_listView";
            this.Eng_listView.Size = new System.Drawing.Size(186, 290);
            this.Eng_listView.TabIndex = 2;
            this.Eng_listView.UseCompatibleStateImageBehavior = false;
            this.Eng_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "名前";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "英語";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // Display_button
            // 
            this.Display_button.Location = new System.Drawing.Point(241, 325);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(105, 34);
            this.Display_button.TabIndex = 3;
            this.Display_button.Text = "表示";
            this.Display_button.UseVisualStyleBackColor = true;
            this.Display_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _2_6C_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 371);
            this.Controls.Add(this.Display_button);
            this.Controls.Add(this.Eng_listView);
            this.Controls.Add(this.Math_listView);
            this.Controls.Add(this.Jap_listView);
            this.Name = "_2_6C_Form";
            this.Text = "2-6";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Jap_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView Math_listView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView Eng_listView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button Display_button;
    }
}

