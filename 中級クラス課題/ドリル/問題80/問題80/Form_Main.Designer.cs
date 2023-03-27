namespace 問題80
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
            checkBox_AvailableButton = new CheckBox();
            button = new Button();
            SuspendLayout();
            // 
            // checkBox_AvailableButton
            // 
            checkBox_AvailableButton.AutoSize = true;
            checkBox_AvailableButton.Location = new Point(12, 51);
            checkBox_AvailableButton.Name = "checkBox_AvailableButton";
            checkBox_AvailableButton.Size = new Size(50, 19);
            checkBox_AvailableButton.TabIndex = 0;
            checkBox_AvailableButton.Text = "有効";
            checkBox_AvailableButton.UseVisualStyleBackColor = true;
            checkBox_AvailableButton.CheckedChanged += checkBox_AvailableButton_CheckedChanged;
            // 
            // button
            // 
            button.Enabled = false;
            button.Location = new Point(94, 48);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 1;
            button.Text = "表示";
            button.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(183, 100);
            Controls.Add(button);
            Controls.Add(checkBox_AvailableButton);
            Name = "Form_Main";
            Text = "問題80";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox_AvailableButton;
        private Button button;
    }
}