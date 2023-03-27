namespace 問題76
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
            button = new Button();
            Label = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(74, 87);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 0;
            button.Text = "表示";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(74, 27);
            Label.Name = "Label";
            Label.Size = new Size(72, 15);
            Label.TabIndex = 1;
            Label.Text = "月末までは？";
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 129);
            Controls.Add(Label);
            Controls.Add(button);
            Name = "Form_Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private Label Label;
    }
}