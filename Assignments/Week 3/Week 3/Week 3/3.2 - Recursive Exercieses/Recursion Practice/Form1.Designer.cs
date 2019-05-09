namespace Recursion_Practice
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
            this.BtnSquSum = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RbB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbE = new System.Windows.Forms.RadioButton();
            this.RbD = new System.Windows.Forms.RadioButton();
            this.RbC = new System.Windows.Forms.RadioButton();
            this.RbA = new System.Windows.Forms.RadioButton();
            this.RbF = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSquSum
            // 
            this.BtnSquSum.Location = new System.Drawing.Point(270, 169);
            this.BtnSquSum.Name = "BtnSquSum";
            this.BtnSquSum.Size = new System.Drawing.Size(129, 114);
            this.BtnSquSum.TabIndex = 0;
            this.BtnSquSum.Text = "Perform";
            this.BtnSquSum.UseVisualStyleBackColor = true;
            this.BtnSquSum.Click += new System.EventHandler(this.BtnSquSum_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 39);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Location = new System.Drawing.Point(548, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(288, 292);
            this.listBox1.TabIndex = 4;
            // 
            // RbB
            // 
            this.RbB.AutoSize = true;
            this.RbB.Location = new System.Drawing.Point(6, 80);
            this.RbB.Name = "RbB";
            this.RbB.Size = new System.Drawing.Size(403, 36);
            this.RbB.TabIndex = 6;
            this.RbB.TabStop = true;
            this.RbB.Text = "B - Sum Of 1st n Element of Array";
            this.RbB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbF);
            this.groupBox1.Controls.Add(this.RbE);
            this.groupBox1.Controls.Add(this.RbD);
            this.groupBox1.Controls.Add(this.RbC);
            this.groupBox1.Controls.Add(this.RbA);
            this.groupBox1.Controls.Add(this.BtnSquSum);
            this.groupBox1.Controls.Add(this.RbB);
            this.groupBox1.Location = new System.Drawing.Point(28, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 312);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // RbE
            // 
            this.RbE.AutoSize = true;
            this.RbE.Location = new System.Drawing.Point(6, 205);
            this.RbE.Name = "RbE";
            this.RbE.Size = new System.Drawing.Size(144, 36);
            this.RbE.TabIndex = 10;
            this.RbE.TabStop = true;
            this.RbE.Text = "E - All Big";
            this.RbE.UseVisualStyleBackColor = true;
            // 
            // RbD
            // 
            this.RbD.AutoSize = true;
            this.RbD.Location = new System.Drawing.Point(6, 163);
            this.RbD.Name = "RbD";
            this.RbD.Size = new System.Drawing.Size(220, 36);
            this.RbD.TabIndex = 9;
            this.RbD.TabStop = true;
            this.RbD.Text = "D - Sum Of Digit";
            this.RbD.UseVisualStyleBackColor = true;
            // 
            // RbC
            // 
            this.RbC.AutoSize = true;
            this.RbC.Location = new System.Drawing.Point(6, 122);
            this.RbC.Name = "RbC";
            this.RbC.Size = new System.Drawing.Size(210, 36);
            this.RbC.TabIndex = 8;
            this.RbC.TabStop = true;
            this.RbC.Text = "C - Max in array";
            this.RbC.UseVisualStyleBackColor = true;
            // 
            // RbA
            // 
            this.RbA.AutoSize = true;
            this.RbA.Location = new System.Drawing.Point(6, 38);
            this.RbA.Name = "RbA";
            this.RbA.Size = new System.Drawing.Size(218, 36);
            this.RbA.TabIndex = 7;
            this.RbA.TabStop = true;
            this.RbA.Text = "A - Squares Sum";
            this.RbA.UseVisualStyleBackColor = true;
            // 
            // RbF
            // 
            this.RbF.AutoSize = true;
            this.RbF.Location = new System.Drawing.Point(6, 247);
            this.RbF.Name = "RbF";
            this.RbF.Size = new System.Drawing.Size(210, 36);
            this.RbF.TabIndex = 11;
            this.RbF.TabStop = true;
            this.RbF.Text = "F - Is Ascending";
            this.RbF.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 393);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Recursion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSquSum;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton RbB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbA;
        private System.Windows.Forms.RadioButton RbC;
        private System.Windows.Forms.RadioButton RbD;
        private System.Windows.Forms.RadioButton RbE;
        private System.Windows.Forms.RadioButton RbF;
    }
}

