namespace GettingStarted
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
            this.result = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.opr = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Number: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(216, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter an Operator: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(168, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Another Number: ";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(388, 356);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 25);
            this.result.TabIndex = 3;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(471, 134);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(100, 26);
            this.num1.TabIndex = 4;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            // 
            // opr
            // 
            this.opr.Location = new System.Drawing.Point(471, 195);
            this.opr.Name = "opr";
            this.opr.Size = new System.Drawing.Size(100, 26);
            this.opr.TabIndex = 5;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(471, 253);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 26);
            this.num2.TabIndex = 6;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.Location = new System.Drawing.Point(622, 253);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(141, 50);
            this.btn.TabIndex = 7;
            this.btn.Text = "Calculate";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(351, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.opr);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox opr;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label4;
    }
}

