
namespace _2_12a
{
    partial class _2_12a_Form
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
            this.Address_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.Read_button = new System.Windows.Forms.Button();
            this.Write_button = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // Address_listView
            // 
            this.Address_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Address_listView.FullRowSelect = true;
            this.Address_listView.GridLines = true;
            this.Address_listView.HideSelection = false;
            this.Address_listView.Location = new System.Drawing.Point(12, 12);
            this.Address_listView.Name = "Address_listView";
            this.Address_listView.Size = new System.Drawing.Size(404, 426);
            this.Address_listView.TabIndex = 0;
            this.Address_listView.UseCompatibleStateImageBehavior = false;
            this.Address_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "郵便番号";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "住所";
            this.columnHeader2.Width = 300;
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(248, 453);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(75, 23);
            this.Read_button.TabIndex = 1;
            this.Read_button.Text = "読み込み";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Write_button
            // 
            this.Write_button.Location = new System.Drawing.Point(341, 453);
            this.Write_button.Name = "Write_button";
            this.Write_button.Size = new System.Drawing.Size(75, 23);
            this.Write_button.TabIndex = 2;
            this.Write_button.Text = "書き込み";
            this.Write_button.UseVisualStyleBackColor = true;
            this.Write_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // _2_12a_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 484);
            this.Controls.Add(this.Write_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Address_listView);
            this.Name = "_2_12a_Form";
            this.Text = "2_12a";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Address_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Write_button;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

