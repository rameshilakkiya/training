namespace WorldCupT20
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.mplay = new System.Windows.Forms.TextBox();
            this.wo = new System.Windows.Forms.TextBox();
            this.lo = new System.Windows.Forms.TextBox();
            this.point = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "country name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "matches played: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "won: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "lost: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "points: ";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(218, 390);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 5;
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(447, 70);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(100, 26);
            this.cname.TabIndex = 6;
            // 
            // mplay
            // 
            this.mplay.Location = new System.Drawing.Point(447, 118);
            this.mplay.Name = "mplay";
            this.mplay.Size = new System.Drawing.Size(100, 26);
            this.mplay.TabIndex = 7;
            // 
            // wo
            // 
            this.wo.Location = new System.Drawing.Point(447, 172);
            this.wo.Name = "wo";
            this.wo.Size = new System.Drawing.Size(100, 26);
            this.wo.TabIndex = 8;
            // 
            // lo
            // 
            this.lo.Location = new System.Drawing.Point(447, 228);
            this.lo.Name = "lo";
            this.lo.Size = new System.Drawing.Size(100, 26);
            this.lo.TabIndex = 9;
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(447, 282);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(100, 26);
            this.point.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(626, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.point);
            this.Controls.Add(this.lo);
            this.Controls.Add(this.wo);
            this.Controls.Add(this.mplay);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "WorldCupT20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.TextBox mplay;
        private System.Windows.Forms.TextBox wo;
        private System.Windows.Forms.TextBox lo;
        private System.Windows.Forms.TextBox point;
        private System.Windows.Forms.Button button1;
    }
}

