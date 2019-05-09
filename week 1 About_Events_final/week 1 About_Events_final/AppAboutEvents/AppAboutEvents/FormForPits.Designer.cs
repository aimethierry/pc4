namespace AppAboutEvents
{
    partial class FormForPits
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
            this.btnBeNotifiedAboutADriver = new System.Windows.Forms.Button();
            this.btnNoLongerNotifiedAboutADriver = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnBeNotifiedAboutADriver
            // 
            this.btnBeNotifiedAboutADriver.Location = new System.Drawing.Point(241, 17);
            this.btnBeNotifiedAboutADriver.Name = "btnBeNotifiedAboutADriver";
            this.btnBeNotifiedAboutADriver.Size = new System.Drawing.Size(212, 40);
            this.btnBeNotifiedAboutADriver.TabIndex = 0;
            this.btnBeNotifiedAboutADriver.Text = "Be notified about a driver";
            this.btnBeNotifiedAboutADriver.UseVisualStyleBackColor = true;
            this.btnBeNotifiedAboutADriver.Click += new System.EventHandler(this.btnBeNotifiedAboutADriver_Click);
            // 
            // btnNoLongerNotifiedAboutADriver
            // 
            this.btnNoLongerNotifiedAboutADriver.Location = new System.Drawing.Point(488, 17);
            this.btnNoLongerNotifiedAboutADriver.Name = "btnNoLongerNotifiedAboutADriver";
            this.btnNoLongerNotifiedAboutADriver.Size = new System.Drawing.Size(272, 38);
            this.btnNoLongerNotifiedAboutADriver.TabIndex = 1;
            this.btnNoLongerNotifiedAboutADriver.Text = "No longer notified about a driver";
            this.btnNoLongerNotifiedAboutADriver.UseVisualStyleBackColor = true;
            this.btnNoLongerNotifiedAboutADriver.Click += new System.EventHandler(this.btnNoLongerNotifiedAboutADriver_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 26);
            this.textBox1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(22, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(737, 284);
            this.listBox1.TabIndex = 3;
            // 
            // FormForPits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(813, 390);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNoLongerNotifiedAboutADriver);
            this.Controls.Add(this.btnBeNotifiedAboutADriver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormForPits";
            this.Text = "The monitor in the pits of the Yahama crew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeNotifiedAboutADriver;
        private System.Windows.Forms.Button btnNoLongerNotifiedAboutADriver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}