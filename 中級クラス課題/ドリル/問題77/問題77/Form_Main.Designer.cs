namespace 問題77
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
            DisplayLabel = new Label();
            button = new Button();
            SuspendLayout();
            // 
            // DisplayLabel
            // 
            DisplayLabel.AutoSize = true;
            DisplayLabel.Location = new Point(26, 42);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(90, 15);
            DisplayLabel.TabIndex = 0;
            DisplayLabel.Text = "座標とサイズは？";
            // 
            // button
            // 
            button.Location = new Point(60, 84);
            button.Name = "button";
            button.Size = new Size(72, 24);
            button.TabIndex = 1;
            button.Text = "表示";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(192, 146);
            Controls.Add(button);
            Controls.Add(DisplayLabel);
            Name = "Form_Main";
            Text = "問題77";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DisplayLabel;
        private Button button;
    }
}