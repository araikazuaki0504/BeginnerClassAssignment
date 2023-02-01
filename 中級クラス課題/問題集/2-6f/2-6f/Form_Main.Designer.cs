
namespace _2_6f
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
            this.Subject_comboBox = new System.Windows.Forms.ComboBox();
            this.NameAndPoint_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.Name_comboBox = new System.Windows.Forms.ComboBox();
            this.Display_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Subject_comboBox
            // 
            this.Subject_comboBox.FormattingEnabled = true;
            this.Subject_comboBox.Items.AddRange(new object[] {
            "国語",
            "数学",
            "英語"});
            this.Subject_comboBox.Location = new System.Drawing.Point(12, 12);
            this.Subject_comboBox.Name = "Subject_comboBox";
            this.Subject_comboBox.Size = new System.Drawing.Size(121, 23);
            this.Subject_comboBox.TabIndex = 0;
            // 
            // NameAndPoint_listView
            // 
            this.NameAndPoint_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.NameAndPoint_listView.FullRowSelect = true;
            this.NameAndPoint_listView.GridLines = true;
            this.NameAndPoint_listView.HideSelection = false;
            this.NameAndPoint_listView.Location = new System.Drawing.Point(78, 65);
            this.NameAndPoint_listView.Name = "NameAndPoint_listView";
            this.NameAndPoint_listView.Size = new System.Drawing.Size(185, 187);
            this.NameAndPoint_listView.TabIndex = 1;
            this.NameAndPoint_listView.UseCompatibleStateImageBehavior = false;
            this.NameAndPoint_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "点数";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 80;
            // 
            // Name_comboBox
            // 
            this.Name_comboBox.FormattingEnabled = true;
            this.Name_comboBox.Location = new System.Drawing.Point(12, 282);
            this.Name_comboBox.Name = "Name_comboBox";
            this.Name_comboBox.Size = new System.Drawing.Size(121, 23);
            this.Name_comboBox.TabIndex = 2;
            // 
            // Display_button
            // 
            this.Display_button.Location = new System.Drawing.Point(167, 282);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(128, 23);
            this.Display_button.TabIndex = 3;
            this.Display_button.Text = "表示";
            this.Display_button.UseVisualStyleBackColor = true;
            this.Display_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // _2_6f_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 318);
            this.Controls.Add(this.Display_button);
            this.Controls.Add(this.Name_comboBox);
            this.Controls.Add(this.NameAndPoint_listView);
            this.Controls.Add(this.Subject_comboBox);
            this.Name = "_2_6f_Form";
            this.Text = "2-6f";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Subject_comboBox;
        private System.Windows.Forms.ListView NameAndPoint_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox Name_comboBox;
        private System.Windows.Forms.Button Display_button;
    }
}

