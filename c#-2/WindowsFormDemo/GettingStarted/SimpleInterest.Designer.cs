namespace GettingStarted
{
    partial class SimpleInterest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.silbl = new System.Windows.Forms.Label();
            this.principle = new System.Windows.Forms.TextBox();
            this.roi = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Principle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Rate Of Interest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Time:";
            // 
            // silbl
            // 
            this.silbl.AutoSize = true;
            this.silbl.Location = new System.Drawing.Point(323, 362);
            this.silbl.Name = "silbl";
            this.silbl.Size = new System.Drawing.Size(0, 20);
            this.silbl.TabIndex = 3;
            // 
            // principle
            // 
            this.principle.Location = new System.Drawing.Point(465, 65);
            this.principle.Name = "principle";
            this.principle.Size = new System.Drawing.Size(100, 26);
            this.principle.TabIndex = 4;
            this.principle.TextChanged += new System.EventHandler(this.principle_TextChanged);
            // 
            // roi
            // 
            this.roi.Location = new System.Drawing.Point(465, 119);
            this.roi.Name = "roi";
            this.roi.Size = new System.Drawing.Size(100, 26);
            this.roi.TabIndex = 5;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(465, 190);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(100, 26);
            this.time.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimpleInterest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.roi);
            this.Controls.Add(this.principle);
            this.Controls.Add(this.silbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SimpleInterest";
            this.Text = "Simple Interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label silbl;
        private System.Windows.Forms.TextBox principle;
        private System.Windows.Forms.TextBox roi;
        private System.Windows.Forms.TextBox time;
        private System.Windows.Forms.Button button1;
    }
}