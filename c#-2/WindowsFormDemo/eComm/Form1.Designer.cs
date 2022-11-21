namespace eComm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.puramt = new System.Windows.Forms.Label();
            this.dis = new System.Windows.Forms.Label();
            this.neamt = new System.Windows.Forms.Label();
            this.pamt = new System.Windows.Forms.TextBox();
            this.y = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRENDS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Purchase Amount: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Are you a Prime Member: ";
            // 
            // puramt
            // 
            this.puramt.AutoSize = true;
            this.puramt.Location = new System.Drawing.Point(263, 287);
            this.puramt.Name = "puramt";
            this.puramt.Size = new System.Drawing.Size(0, 20);
            this.puramt.TabIndex = 3;
            // 
            // dis
            // 
            this.dis.AutoSize = true;
            this.dis.Location = new System.Drawing.Point(263, 326);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(0, 20);
            this.dis.TabIndex = 4;
            // 
            // neamt
            // 
            this.neamt.AutoSize = true;
            this.neamt.Location = new System.Drawing.Point(263, 373);
            this.neamt.Name = "neamt";
            this.neamt.Size = new System.Drawing.Size(0, 20);
            this.neamt.TabIndex = 5;
            // 
            // pamt
            // 
            this.pamt.Location = new System.Drawing.Point(468, 149);
            this.pamt.Name = "pamt";
            this.pamt.Size = new System.Drawing.Size(100, 26);
            this.pamt.TabIndex = 6;
            // 
            // y
            // 
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(468, 212);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(63, 24);
            this.y.TabIndex = 7;
            this.y.Text = "Yes";
            this.y.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(613, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 48);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.y);
            this.Controls.Add(this.pamt);
            this.Controls.Add(this.neamt);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.puramt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label puramt;
        private System.Windows.Forms.Label dis;
        private System.Windows.Forms.Label neamt;
        private System.Windows.Forms.TextBox pamt;
        private System.Windows.Forms.CheckBox y;
        private System.Windows.Forms.Button button1;
    }
}

