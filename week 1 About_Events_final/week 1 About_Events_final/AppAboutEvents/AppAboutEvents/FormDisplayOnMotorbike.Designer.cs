namespace AppAboutEvents
{
    partial class FormDisplayOnMotorbike
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
            this.lblNameOfDriver = new System.Windows.Forms.Label();
            this.lblCurrentSpeed = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameOfDriver
            // 
            this.lblNameOfDriver.AutoSize = true;
            this.lblNameOfDriver.Location = new System.Drawing.Point(32, 22);
            this.lblNameOfDriver.Name = "lblNameOfDriver";
            this.lblNameOfDriver.Size = new System.Drawing.Size(64, 25);
            this.lblNameOfDriver.TabIndex = 0;
            this.lblNameOfDriver.Text = "label1";
            // 
            // lblCurrentSpeed
            // 
            this.lblCurrentSpeed.AutoSize = true;
            this.lblCurrentSpeed.Location = new System.Drawing.Point(31, 63);
            this.lblCurrentSpeed.Name = "lblCurrentSpeed";
            this.lblCurrentSpeed.Size = new System.Drawing.Size(64, 25);
            this.lblCurrentSpeed.TabIndex = 1;
            this.lblCurrentSpeed.Text = "label2";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(27, 105);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(64, 25);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Text = "label3";
            // 
            // FormDisplayOnMotorbike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(658, 162);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblCurrentSpeed);
            this.Controls.Add(this.lblNameOfDriver);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDisplayOnMotorbike";
            this.Text = "FormDisplayOnMotorbike";
            this.Load += new System.EventHandler(this.FormDisplayOnMotorbike_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameOfDriver;
        private System.Windows.Forms.Label lblCurrentSpeed;
        private System.Windows.Forms.Label lblWarning;
    }
}