namespace AppAboutEvents
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
            this.btgnStartTheMotors = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnChangeSpeed = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btgnStartTheMotors
            // 
            this.btgnStartTheMotors.Location = new System.Drawing.Point(37, 12);
            this.btgnStartTheMotors.Name = "btgnStartTheMotors";
            this.btgnStartTheMotors.Size = new System.Drawing.Size(328, 56);
            this.btgnStartTheMotors.TabIndex = 0;
            this.btgnStartTheMotors.Text = "start the motors";
            this.btgnStartTheMotors.UseVisualStyleBackColor = true;
            this.btgnStartTheMotors.Click += new System.EventHandler(this.btnStartTheMotors_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Orange;
            this.groupBox1.Controls.Add(this.btnChangeSpeed);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "simulates Valentino Rossi accelerates or slows down";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(15, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 35);
            this.textBox1.TabIndex = 0;
            // 
            // btnChangeSpeed
            // 
            this.btnChangeSpeed.Location = new System.Drawing.Point(136, 38);
            this.btnChangeSpeed.Name = "btnChangeSpeed";
            this.btnChangeSpeed.Size = new System.Drawing.Size(252, 42);
            this.btnChangeSpeed.TabIndex = 1;
            this.btnChangeSpeed.Text = "accelerate or slow down";
            this.btnChangeSpeed.UseVisualStyleBackColor = true;
            this.btnChangeSpeed.Click += new System.EventHandler(this.btnChangeSpeed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 228);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btgnStartTheMotors);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btgnStartTheMotors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeSpeed;
        private System.Windows.Forms.TextBox textBox1;
    }
}

