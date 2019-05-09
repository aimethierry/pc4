namespace Assignment3._2
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
            this.btnsumsquares = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.btnmax = new System.Windows.Forms.Button();
            this.btnsumofdigits = new System.Windows.Forms.Button();
            this.btnallbig = new System.Windows.Forms.Button();
            this.btnisascending = new System.Windows.Forms.Button();
            this.tbvalue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsumsquares
            // 
            this.btnsumsquares.Location = new System.Drawing.Point(80, 12);
            this.btnsumsquares.Name = "btnsumsquares";
            this.btnsumsquares.Size = new System.Drawing.Size(163, 91);
            this.btnsumsquares.TabIndex = 0;
            this.btnsumsquares.Text = "Sum of Squares";
            this.btnsumsquares.UseVisualStyleBackColor = true;
            this.btnsumsquares.Click += new System.EventHandler(this.btnsumsquares_Click);
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(364, 12);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(153, 91);
            this.btnsum.TabIndex = 1;
            this.btnsum.Text = "Sum";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // btnmax
            // 
            this.btnmax.Location = new System.Drawing.Point(80, 127);
            this.btnmax.Name = "btnmax";
            this.btnmax.Size = new System.Drawing.Size(163, 82);
            this.btnmax.TabIndex = 2;
            this.btnmax.Text = "Max";
            this.btnmax.UseVisualStyleBackColor = true;
            this.btnmax.Click += new System.EventHandler(this.btnmax_Click);
            // 
            // btnsumofdigits
            // 
            this.btnsumofdigits.Location = new System.Drawing.Point(364, 127);
            this.btnsumofdigits.Name = "btnsumofdigits";
            this.btnsumofdigits.Size = new System.Drawing.Size(153, 82);
            this.btnsumofdigits.TabIndex = 3;
            this.btnsumofdigits.Text = "Sum of Digits";
            this.btnsumofdigits.UseVisualStyleBackColor = true;
            this.btnsumofdigits.Click += new System.EventHandler(this.btnsumofdigits_Click);
            // 
            // btnallbig
            // 
            this.btnallbig.Location = new System.Drawing.Point(80, 263);
            this.btnallbig.Name = "btnallbig";
            this.btnallbig.Size = new System.Drawing.Size(163, 76);
            this.btnallbig.TabIndex = 4;
            this.btnallbig.Text = "All Big";
            this.btnallbig.UseVisualStyleBackColor = true;
            this.btnallbig.Click += new System.EventHandler(this.btnallbig_Click);
            // 
            // btnisascending
            // 
            this.btnisascending.Location = new System.Drawing.Point(364, 263);
            this.btnisascending.Name = "btnisascending";
            this.btnisascending.Size = new System.Drawing.Size(153, 76);
            this.btnisascending.TabIndex = 5;
            this.btnisascending.Text = "Is Ascending";
            this.btnisascending.UseVisualStyleBackColor = true;
            this.btnisascending.Click += new System.EventHandler(this.btnisascending_Click);
            // 
            // tbvalue
            // 
            this.tbvalue.Location = new System.Drawing.Point(80, 375);
            this.tbvalue.Name = "tbvalue";
            this.tbvalue.Size = new System.Drawing.Size(205, 22);
            this.tbvalue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbvalue);
            this.Controls.Add(this.btnisascending);
            this.Controls.Add(this.btnallbig);
            this.Controls.Add(this.btnsumofdigits);
            this.Controls.Add(this.btnmax);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btnsumsquares);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsumsquares;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button btnmax;
        private System.Windows.Forms.Button btnsumofdigits;
        private System.Windows.Forms.Button btnallbig;
        private System.Windows.Forms.Button btnisascending;
        private System.Windows.Forms.TextBox tbvalue;
    }
}

