namespace 問題15
{
    partial class Form
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
            textBoxFirst = new TextBox();
            textBoxSecond = new TextBox();
            labelOperate = new Label();
            labelEqual = new Label();
            textBoxAns = new TextBox();
            buttonDiv = new Button();
            buttonTimes = new Button();
            SuspendLayout();
            // 
            // textBoxFirst
            // 
            textBoxFirst.Location = new Point(12, 80);
            textBoxFirst.Name = "textBoxFirst";
            textBoxFirst.Size = new Size(100, 23);
            textBoxFirst.TabIndex = 0;
            // 
            // textBoxSecond
            // 
            textBoxSecond.Location = new Point(192, 80);
            textBoxSecond.Name = "textBoxSecond";
            textBoxSecond.Size = new Size(100, 23);
            textBoxSecond.TabIndex = 1;
            // 
            // labelOperate
            // 
            labelOperate.AutoSize = true;
            labelOperate.Location = new Point(148, 83);
            labelOperate.Name = "labelOperate";
            labelOperate.Size = new Size(0, 15);
            labelOperate.TabIndex = 2;
            // 
            // labelEqual
            // 
            labelEqual.AutoSize = true;
            labelEqual.Location = new Point(316, 83);
            labelEqual.Name = "labelEqual";
            labelEqual.Size = new Size(15, 15);
            labelEqual.TabIndex = 3;
            labelEqual.Text = "=";
            // 
            // textBoxAns
            // 
            textBoxAns.Location = new Point(354, 80);
            textBoxAns.Name = "textBoxAns";
            textBoxAns.ReadOnly = true;
            textBoxAns.Size = new Size(100, 23);
            textBoxAns.TabIndex = 4;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(368, 178);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 23);
            buttonDiv.TabIndex = 5;
            buttonDiv.Text = "割る";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonTimes
            // 
            buttonTimes.Location = new Point(368, 149);
            buttonTimes.Name = "buttonTimes";
            buttonTimes.Size = new Size(75, 23);
            buttonTimes.TabIndex = 6;
            buttonTimes.Text = "掛ける";
            buttonTimes.UseVisualStyleBackColor = true;
            buttonTimes.Click += buttonTimes_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 213);
            Controls.Add(buttonTimes);
            Controls.Add(buttonDiv);
            Controls.Add(textBoxAns);
            Controls.Add(labelEqual);
            Controls.Add(labelOperate);
            Controls.Add(textBoxSecond);
            Controls.Add(textBoxFirst);
            Name = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxFirst;
        private TextBox textBoxSecond;
        private Label labelOperate;
        private Label labelEqual;
        private TextBox textBoxAns;
        private Button buttonDiv;
        private Button buttonTimes;
    }
}