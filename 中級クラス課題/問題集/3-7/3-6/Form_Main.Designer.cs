
namespace _3_6
{
<<<<<<< HEAD:中級クラス課題/問題集/3-7/3-6/Form_Main.Designer.cs
    partial class Form_Main
=======
    partial class _3_7_Form
>>>>>>> 751d62ba30b5294fdd3226aa1f3235c86459eb60:中級クラス課題/問題集/3-7/3-6/Form1.Designer.cs
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
            this.Display_listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.Read_button = new System.Windows.Forms.Button();
            this.Write_button = new System.Windows.Forms.Button();
            this.File_Read_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.File_Write_Dialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // Display_listView
            // 
            this.Display_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.Display_listView.FullRowSelect = true;
            this.Display_listView.GridLines = true;
            this.Display_listView.HideSelection = false;
            this.Display_listView.Location = new System.Drawing.Point(12, 12);
            this.Display_listView.Name = "Display_listView";
            this.Display_listView.Size = new System.Drawing.Size(356, 363);
            this.Display_listView.TabIndex = 0;
            this.Display_listView.UseCompatibleStateImageBehavior = false;
            this.Display_listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "郵便番号";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "住所";
            this.columnHeader2.Width = 250;
            // 
            // Read_button
            // 
            this.Read_button.Location = new System.Drawing.Point(158, 395);
            this.Read_button.Name = "Read_button";
            this.Read_button.Size = new System.Drawing.Size(94, 29);
            this.Read_button.TabIndex = 1;
            this.Read_button.Text = "読み込み";
            this.Read_button.UseVisualStyleBackColor = true;
            this.Read_button.Click += new System.EventHandler(this.Read_button_Click);
            // 
            // Write_button
            // 
            this.Write_button.Location = new System.Drawing.Point(274, 395);
            this.Write_button.Name = "Write_button";
            this.Write_button.Size = new System.Drawing.Size(94, 29);
            this.Write_button.TabIndex = 2;
            this.Write_button.Text = "書き込み";
            this.Write_button.UseVisualStyleBackColor = true;
            this.Write_button.Click += new System.EventHandler(this.Write_button_Click);
            // 
            // File_Read_Dialog
            // 
            this.File_Read_Dialog.FileName = "openFileDialog1";
            this.File_Read_Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.File_Read_Dialog_FileOk);
            // 
            // File_Write_Dialog
            // 
            this.File_Write_Dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.File_Write_Dialog_FileOk);
            // 
            // _3_7_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 439);
            this.Controls.Add(this.Write_button);
            this.Controls.Add(this.Read_button);
            this.Controls.Add(this.Display_listView);
            this.Name = "_3_7_Form";
            this.Text = "3-7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Display_listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Read_button;
        private System.Windows.Forms.Button Write_button;
        private System.Windows.Forms.OpenFileDialog File_Read_Dialog;
        private System.Windows.Forms.SaveFileDialog File_Write_Dialog;
    }
}

