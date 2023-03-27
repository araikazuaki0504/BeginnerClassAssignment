
namespace 問題39
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
            this.groupBox_ChildOrAdult = new System.Windows.Forms.GroupBox();
            this.radioButton_chlid = new System.Windows.Forms.RadioButton();
            this.radioButton_adult = new System.Windows.Forms.RadioButton();
            this.groupBox_destination = new System.Windows.Forms.GroupBox();
            this.radioButton_For_Ueno = new System.Windows.Forms.RadioButton();
            this.radioButton_For_Tokyo = new System.Windows.Forms.RadioButton();
            this.radioButton_For_Shinagawa = new System.Windows.Forms.RadioButton();
            this.radioButton_For_Shibuya = new System.Windows.Forms.RadioButton();
            this.radioButton_For_Ikebukuro = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.groupBox_ChildOrAdult.SuspendLayout();
            this.groupBox_destination.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ChildOrAdult
            // 
            this.groupBox_ChildOrAdult.Controls.Add(this.radioButton_chlid);
            this.groupBox_ChildOrAdult.Controls.Add(this.radioButton_adult);
            this.groupBox_ChildOrAdult.Location = new System.Drawing.Point(12, 12);
            this.groupBox_ChildOrAdult.Name = "groupBox_ChildOrAdult";
            this.groupBox_ChildOrAdult.Size = new System.Drawing.Size(129, 222);
            this.groupBox_ChildOrAdult.TabIndex = 0;
            this.groupBox_ChildOrAdult.TabStop = false;
            this.groupBox_ChildOrAdult.Text = "大人・子供";
            // 
            // radioButton_chlid
            // 
            this.radioButton_chlid.AutoSize = true;
            this.radioButton_chlid.Location = new System.Drawing.Point(6, 94);
            this.radioButton_chlid.Name = "radioButton_chlid";
            this.radioButton_chlid.Size = new System.Drawing.Size(60, 24);
            this.radioButton_chlid.TabIndex = 2;
            this.radioButton_chlid.TabStop = true;
            this.radioButton_chlid.Text = "子供";
            this.radioButton_chlid.UseVisualStyleBackColor = true;
            // 
            // radioButton_adult
            // 
            this.radioButton_adult.AutoSize = true;
            this.radioButton_adult.Location = new System.Drawing.Point(6, 54);
            this.radioButton_adult.Name = "radioButton_adult";
            this.radioButton_adult.Size = new System.Drawing.Size(60, 24);
            this.radioButton_adult.TabIndex = 1;
            this.radioButton_adult.TabStop = true;
            this.radioButton_adult.Text = "大人";
            this.radioButton_adult.UseVisualStyleBackColor = true;
            // 
            // groupBox_destination
            // 
            this.groupBox_destination.Controls.Add(this.radioButton_For_Ueno);
            this.groupBox_destination.Controls.Add(this.radioButton_For_Tokyo);
            this.groupBox_destination.Controls.Add(this.radioButton_For_Shinagawa);
            this.groupBox_destination.Controls.Add(this.radioButton_For_Shibuya);
            this.groupBox_destination.Controls.Add(this.radioButton_For_Ikebukuro);
            this.groupBox_destination.Location = new System.Drawing.Point(169, 15);
            this.groupBox_destination.Name = "groupBox_destination";
            this.groupBox_destination.Size = new System.Drawing.Size(198, 219);
            this.groupBox_destination.TabIndex = 1;
            this.groupBox_destination.TabStop = false;
            this.groupBox_destination.Text = "行き先";
            // 
            // radioButton_For_Ueno
            // 
            this.radioButton_For_Ueno.AutoSize = true;
            this.radioButton_For_Ueno.Location = new System.Drawing.Point(85, 90);
            this.radioButton_For_Ueno.Name = "radioButton_For_Ueno";
            this.radioButton_For_Ueno.Size = new System.Drawing.Size(60, 24);
            this.radioButton_For_Ueno.TabIndex = 4;
            this.radioButton_For_Ueno.TabStop = true;
            this.radioButton_For_Ueno.Text = "上野";
            this.radioButton_For_Ueno.UseVisualStyleBackColor = true;
            // 
            // radioButton_For_Tokyo
            // 
            this.radioButton_For_Tokyo.AutoSize = true;
            this.radioButton_For_Tokyo.Location = new System.Drawing.Point(85, 51);
            this.radioButton_For_Tokyo.Name = "radioButton_For_Tokyo";
            this.radioButton_For_Tokyo.Size = new System.Drawing.Size(60, 24);
            this.radioButton_For_Tokyo.TabIndex = 3;
            this.radioButton_For_Tokyo.TabStop = true;
            this.radioButton_For_Tokyo.Text = "東京";
            this.radioButton_For_Tokyo.UseVisualStyleBackColor = true;
            // 
            // radioButton_For_Shinagawa
            // 
            this.radioButton_For_Shinagawa.AutoSize = true;
            this.radioButton_For_Shinagawa.Location = new System.Drawing.Point(6, 129);
            this.radioButton_For_Shinagawa.Name = "radioButton_For_Shinagawa";
            this.radioButton_For_Shinagawa.Size = new System.Drawing.Size(60, 24);
            this.radioButton_For_Shinagawa.TabIndex = 2;
            this.radioButton_For_Shinagawa.TabStop = true;
            this.radioButton_For_Shinagawa.Text = "品川";
            this.radioButton_For_Shinagawa.UseVisualStyleBackColor = true;
            // 
            // radioButton_For_Shibuya
            // 
            this.radioButton_For_Shibuya.AutoSize = true;
            this.radioButton_For_Shibuya.Location = new System.Drawing.Point(6, 90);
            this.radioButton_For_Shibuya.Name = "radioButton_For_Shibuya";
            this.radioButton_For_Shibuya.Size = new System.Drawing.Size(60, 24);
            this.radioButton_For_Shibuya.TabIndex = 1;
            this.radioButton_For_Shibuya.TabStop = true;
            this.radioButton_For_Shibuya.Text = "渋谷";
            this.radioButton_For_Shibuya.UseVisualStyleBackColor = true;
            // 
            // radioButton_For_Ikebukuro
            // 
            this.radioButton_For_Ikebukuro.AutoSize = true;
            this.radioButton_For_Ikebukuro.Location = new System.Drawing.Point(6, 51);
            this.radioButton_For_Ikebukuro.Name = "radioButton_For_Ikebukuro";
            this.radioButton_For_Ikebukuro.Size = new System.Drawing.Size(60, 24);
            this.radioButton_For_Ikebukuro.TabIndex = 0;
            this.radioButton_For_Ikebukuro.TabStop = true;
            this.radioButton_For_Ikebukuro.Text = "池袋";
            this.radioButton_For_Ikebukuro.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(273, 254);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(94, 29);
            this.button.TabIndex = 2;
            this.button.Text = "運賃表示";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 293);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBox_destination);
            this.Controls.Add(this.groupBox_ChildOrAdult);
            this.Name = "Form_Main";
            this.Text = "問題39";
            this.groupBox_ChildOrAdult.ResumeLayout(false);
            this.groupBox_ChildOrAdult.PerformLayout();
            this.groupBox_destination.ResumeLayout(false);
            this.groupBox_destination.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ChildOrAdult;
        private System.Windows.Forms.RadioButton radioButton_chlid;
        private System.Windows.Forms.RadioButton radioButton_adult;
        private System.Windows.Forms.GroupBox groupBox_destination;
        private System.Windows.Forms.RadioButton radioButton_For_Ueno;
        private System.Windows.Forms.RadioButton radioButton_For_Tokyo;
        private System.Windows.Forms.RadioButton radioButton_For_Shinagawa;
        private System.Windows.Forms.RadioButton radioButton_For_Shibuya;
        private System.Windows.Forms.RadioButton radioButton_For_Ikebukuro;
        private System.Windows.Forms.Button button;
    }
}

