namespace week_3._2._1
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
            this.tbin = new System.Windows.Forms.TextBox();
            this.tbout = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.Button();
            this.rbsquares = new System.Windows.Forms.RadioButton();
            this.rbdigits = new System.Windows.Forms.RadioButton();
            this.rbsum = new System.Windows.Forms.RadioButton();
            this.rbmx = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.rbasce = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbin
            // 
            this.tbin.Location = new System.Drawing.Point(49, 152);
            this.tbin.Name = "tbin";
            this.tbin.Size = new System.Drawing.Size(61, 24);
            this.tbin.TabIndex = 0;
            // 
            // tbout
            // 
            this.tbout.Location = new System.Drawing.Point(207, 152);
            this.tbout.Name = "tbout";
            this.tbout.Size = new System.Drawing.Size(61, 24);
            this.tbout.TabIndex = 1;
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(49, 182);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(75, 23);
            this.job.TabIndex = 2;
            this.job.Text = "button1";
            this.job.UseVisualStyleBackColor = true;
            this.job.Click += new System.EventHandler(this.job_Click);
            // 
            // rbsquares
            // 
            this.rbsquares.AutoSize = true;
            this.rbsquares.Location = new System.Drawing.Point(15, 22);
            this.rbsquares.Name = "rbsquares";
            this.rbsquares.Size = new System.Drawing.Size(104, 21);
            this.rbsquares.TabIndex = 3;
            this.rbsquares.TabStop = true;
            this.rbsquares.Text = "sumSquares";
            this.rbsquares.UseVisualStyleBackColor = true;
            this.rbsquares.CheckedChanged += new System.EventHandler(this.rbsquares_CheckedChanged);
            // 
            // rbdigits
            // 
            this.rbdigits.AutoSize = true;
            this.rbdigits.Location = new System.Drawing.Point(15, 76);
            this.rbdigits.Name = "rbdigits";
            this.rbdigits.Size = new System.Drawing.Size(88, 21);
            this.rbdigits.TabIndex = 4;
            this.rbdigits.TabStop = true;
            this.rbdigits.Text = "sumDigits";
            this.rbdigits.UseVisualStyleBackColor = true;
            this.rbdigits.CheckedChanged += new System.EventHandler(this.rbdigits_CheckedChanged);
            // 
            // rbsum
            // 
            this.rbsum.AutoSize = true;
            this.rbsum.Location = new System.Drawing.Point(15, 49);
            this.rbsum.Name = "rbsum";
            this.rbsum.Size = new System.Drawing.Size(55, 21);
            this.rbsum.TabIndex = 5;
            this.rbsum.TabStop = true;
            this.rbsum.Text = "sum";
            this.rbsum.UseVisualStyleBackColor = true;
            this.rbsum.CheckedChanged += new System.EventHandler(this.rbsum_CheckedChanged);
            // 
            // rbmx
            // 
            this.rbmx.AutoSize = true;
            this.rbmx.Location = new System.Drawing.Point(190, 22);
            this.rbmx.Name = "rbmx";
            this.rbmx.Size = new System.Drawing.Size(54, 21);
            this.rbmx.TabIndex = 6;
            this.rbmx.TabStop = true;
            this.rbmx.Text = "Max";
            this.rbmx.UseVisualStyleBackColor = true;
            this.rbmx.CheckedChanged += new System.EventHandler(this.rbmx_CheckedChanged);
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(190, 49);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(47, 21);
            this.rbBig.TabIndex = 7;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "Big";
            this.rbBig.UseVisualStyleBackColor = true;
            this.rbBig.CheckedChanged += new System.EventHandler(this.rbBig_CheckedChanged);
            // 
            // rbasce
            // 
            this.rbasce.AutoSize = true;
            this.rbasce.Location = new System.Drawing.Point(190, 76);
            this.rbasce.Name = "rbasce";
            this.rbasce.Size = new System.Drawing.Size(56, 21);
            this.rbasce.TabIndex = 8;
            this.rbasce.TabStop = true;
            this.rbasce.Text = "asec";
            this.rbasce.UseVisualStyleBackColor = true;
            this.rbasce.CheckedChanged += new System.EventHandler(this.rbasce_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 604);
            this.Controls.Add(this.rbasce);
            this.Controls.Add(this.rbBig);
            this.Controls.Add(this.rbmx);
            this.Controls.Add(this.rbsum);
            this.Controls.Add(this.rbdigits);
            this.Controls.Add(this.rbsquares);
            this.Controls.Add(this.job);
            this.Controls.Add(this.tbout);
            this.Controls.Add(this.tbin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbin;
        private System.Windows.Forms.TextBox tbout;
        private System.Windows.Forms.Button job;
        private System.Windows.Forms.RadioButton rbsquares;
        private System.Windows.Forms.RadioButton rbdigits;
        private System.Windows.Forms.RadioButton rbsum;
        private System.Windows.Forms.RadioButton rbmx;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.RadioButton rbasce;
    }
}

