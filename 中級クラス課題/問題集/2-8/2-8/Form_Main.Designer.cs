
namespace _2_8
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
            this.Money_label = new System.Windows.Forms.Label();
            this.OddOrEven_label = new System.Windows.Forms.Label();
            this.BetMoney_label = new System.Windows.Forms.Label();
            this.Daice_label = new System.Windows.Forms.Label();
            this.Money_textBox = new System.Windows.Forms.TextBox();
            this.BetMoney_textBox = new System.Windows.Forms.TextBox();
            this.OddOrEven_comboBox = new System.Windows.Forms.ComboBox();
            this.Daice_button = new System.Windows.Forms.Button();
            this.Result_label = new System.Windows.Forms.Label();
            this.WhatsNum_label = new System.Windows.Forms.Label();
            this.Start_button = new System.Windows.Forms.Button();
            this.Reset_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Yen_label1 = new System.Windows.Forms.Label();
            this.Yen_label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Money_label
            // 
            this.Money_label.Location = new System.Drawing.Point(12, 9);
            this.Money_label.Name = "Money_label";
            this.Money_label.Size = new System.Drawing.Size(152, 24);
            this.Money_label.TabIndex = 0;
            this.Money_label.Text = "所持金";
            this.Money_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OddOrEven_label
            // 
            this.OddOrEven_label.Location = new System.Drawing.Point(12, 85);
            this.OddOrEven_label.Name = "OddOrEven_label";
            this.OddOrEven_label.Size = new System.Drawing.Size(152, 24);
            this.OddOrEven_label.TabIndex = 1;
            this.OddOrEven_label.Text = "奇数か偶数か入力して下さい";
            this.OddOrEven_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BetMoney_label
            // 
            this.BetMoney_label.Location = new System.Drawing.Point(12, 47);
            this.BetMoney_label.Name = "BetMoney_label";
            this.BetMoney_label.Size = new System.Drawing.Size(152, 24);
            this.BetMoney_label.TabIndex = 2;
            this.BetMoney_label.Text = "掛け金を入力してください。";
            this.BetMoney_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Daice_label
            // 
            this.Daice_label.Location = new System.Drawing.Point(12, 123);
            this.Daice_label.Name = "Daice_label";
            this.Daice_label.Size = new System.Drawing.Size(152, 24);
            this.Daice_label.TabIndex = 3;
            this.Daice_label.Text = "サイコロを振ってください";
            this.Daice_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Money_textBox
            // 
            this.Money_textBox.Location = new System.Drawing.Point(180, 9);
            this.Money_textBox.Name = "Money_textBox";
            this.Money_textBox.ReadOnly = true;
            this.Money_textBox.Size = new System.Drawing.Size(162, 23);
            this.Money_textBox.TabIndex = 4;
            // 
            // BetMoney_textBox
            // 
            this.BetMoney_textBox.Enabled = false;
            this.BetMoney_textBox.Location = new System.Drawing.Point(180, 47);
            this.BetMoney_textBox.Name = "BetMoney_textBox";
            this.BetMoney_textBox.Size = new System.Drawing.Size(162, 23);
            this.BetMoney_textBox.TabIndex = 5;
            // 
            // OddOrEven_comboBox
            // 
            this.OddOrEven_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OddOrEven_comboBox.Enabled = false;
            this.OddOrEven_comboBox.FormattingEnabled = true;
            this.OddOrEven_comboBox.Items.AddRange(new object[] {
            "奇数",
            "偶数"});
            this.OddOrEven_comboBox.Location = new System.Drawing.Point(180, 87);
            this.OddOrEven_comboBox.Name = "OddOrEven_comboBox";
            this.OddOrEven_comboBox.Size = new System.Drawing.Size(118, 23);
            this.OddOrEven_comboBox.TabIndex = 6;
            // 
            // Daice_button
            // 
            this.Daice_button.Enabled = false;
            this.Daice_button.Location = new System.Drawing.Point(180, 123);
            this.Daice_button.Name = "Daice_button";
            this.Daice_button.Size = new System.Drawing.Size(118, 23);
            this.Daice_button.TabIndex = 7;
            this.Daice_button.Text = "サイコロを振る";
            this.Daice_button.UseVisualStyleBackColor = true;
            this.Daice_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Result_label
            // 
            this.Result_label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Result_label.Font = new System.Drawing.Font("Yu Gothic UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result_label.Location = new System.Drawing.Point(180, 166);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(188, 126);
            this.Result_label.TabIndex = 8;
            // 
            // WhatsNum_label
            // 
            this.WhatsNum_label.Location = new System.Drawing.Point(12, 218);
            this.WhatsNum_label.Name = "WhatsNum_label";
            this.WhatsNum_label.Size = new System.Drawing.Size(100, 23);
            this.WhatsNum_label.TabIndex = 9;
            this.WhatsNum_label.Text = "サイコロの目は...";
            // 
            // Start_button
            // 
            this.Start_button.Location = new System.Drawing.Point(17, 317);
            this.Start_button.Name = "Start_button";
            this.Start_button.Size = new System.Drawing.Size(100, 29);
            this.Start_button.TabIndex = 10;
            this.Start_button.Text = "ゲーム開始";
            this.Start_button.UseVisualStyleBackColor = true;
            this.Start_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reset_button
            // 
            this.Reset_button.Enabled = false;
            this.Reset_button.Location = new System.Drawing.Point(145, 317);
            this.Reset_button.Name = "Reset_button";
            this.Reset_button.Size = new System.Drawing.Size(100, 29);
            this.Reset_button.TabIndex = 11;
            this.Reset_button.Text = "リセット";
            this.Reset_button.UseVisualStyleBackColor = true;
            this.Reset_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(273, 317);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(100, 29);
            this.Cancel_button.TabIndex = 12;
            this.Cancel_button.Text = "終了";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // Yen_label1
            // 
            this.Yen_label1.AutoSize = true;
            this.Yen_label1.Location = new System.Drawing.Point(349, 13);
            this.Yen_label1.Name = "Yen_label1";
            this.Yen_label1.Size = new System.Drawing.Size(19, 15);
            this.Yen_label1.TabIndex = 13;
            this.Yen_label1.Text = "円";
            // 
            // Yen_label2
            // 
            this.Yen_label2.AutoSize = true;
            this.Yen_label2.Location = new System.Drawing.Point(349, 52);
            this.Yen_label2.Name = "Yen_label2";
            this.Yen_label2.Size = new System.Drawing.Size(19, 15);
            this.Yen_label2.TabIndex = 14;
            this.Yen_label2.Text = "円";
            // 
            // _2_8_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 358);
            this.Controls.Add(this.Yen_label2);
            this.Controls.Add(this.Yen_label1);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Reset_button);
            this.Controls.Add(this.Start_button);
            this.Controls.Add(this.WhatsNum_label);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.Daice_button);
            this.Controls.Add(this.OddOrEven_comboBox);
            this.Controls.Add(this.BetMoney_textBox);
            this.Controls.Add(this.Money_textBox);
            this.Controls.Add(this.Daice_label);
            this.Controls.Add(this.BetMoney_label);
            this.Controls.Add(this.OddOrEven_label);
            this.Controls.Add(this.Money_label);
            this.Name = "_2_8_Form";
            this.Text = "2-8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Money_label;
        private System.Windows.Forms.Label OddOrEven_label;
        private System.Windows.Forms.Label BetMoney_label;
        private System.Windows.Forms.Label Daice_label;
        private System.Windows.Forms.TextBox Money_textBox;
        private System.Windows.Forms.TextBox BetMoney_textBox;
        private System.Windows.Forms.ComboBox OddOrEven_comboBox;
        private System.Windows.Forms.Button Daice_button;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label WhatsNum_label;
        private System.Windows.Forms.Button Start_button;
        private System.Windows.Forms.Button Reset_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label Yen_label1;
        private System.Windows.Forms.Label Yen_label2;
    }
}

