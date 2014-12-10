namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aNumberText = new System.Windows.Forms.TextBox();
            this.twoTimes = new System.Windows.Forms.TextBox();
            this.showTwoTimes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberText
            // 
            this.numberText.AutoSize = true;
            this.numberText.Location = new System.Drawing.Point(41, 42);
            this.numberText.Name = "numberText";
            this.numberText.Size = new System.Drawing.Size(54, 13);
            this.numberText.TabIndex = 0;
            this.numberText.Text = "A Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Two Times Number";
            // 
            // aNumberText
            // 
            this.aNumberText.Location = new System.Drawing.Point(130, 42);
            this.aNumberText.Name = "aNumberText";
            this.aNumberText.Size = new System.Drawing.Size(100, 20);
            this.aNumberText.TabIndex = 2;
            // 
            // twoTimes
            // 
            this.twoTimes.Location = new System.Drawing.Point(130, 86);
            this.twoTimes.Name = "twoTimes";
            this.twoTimes.Size = new System.Drawing.Size(100, 20);
            this.twoTimes.TabIndex = 3;
            // 
            // showTwoTimes
            // 
            this.showTwoTimes.Location = new System.Drawing.Point(112, 138);
            this.showTwoTimes.Name = "showTwoTimes";
            this.showTwoTimes.Size = new System.Drawing.Size(118, 23);
            this.showTwoTimes.TabIndex = 4;
            this.showTwoTimes.Text = "Show Two Times";
            this.showTwoTimes.UseVisualStyleBackColor = true;
            this.showTwoTimes.Click += new System.EventHandler(this.showTwoTimes_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.showTwoTimes);
            this.Controls.Add(this.twoTimes);
            this.Controls.Add(this.aNumberText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberText);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label level1;
        private System.Windows.Forms.Label level2;
        private System.Windows.Forms.TextBox twoTimesValueTextBox;
        private System.Windows.Forms.TextBox aNumberTextBox;
        private System.Windows.Forms.Button showTwoTimesButton;
        private System.Windows.Forms.Label numberText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aNumberText;
        private System.Windows.Forms.TextBox twoTimes;
        private System.Windows.Forms.Button showTwoTimes;
    }
}

