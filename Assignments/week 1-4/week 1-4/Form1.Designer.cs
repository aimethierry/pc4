namespace week_1_4
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
            this.tbhrs = new System.Windows.Forms.TextBox();
            this.tbmin = new System.Windows.Forms.TextBox();
            this.btnincrhr = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.tbsetmin = new System.Windows.Forms.TextBox();
            this.tbsethr = new System.Windows.Forms.TextBox();
            this.AddPerson = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbhrs
            // 
            this.tbhrs.Location = new System.Drawing.Point(600, 11);
            this.tbhrs.Name = "tbhrs";
            this.tbhrs.Size = new System.Drawing.Size(39, 24);
            this.tbhrs.TabIndex = 0;
            // 
            // tbmin
            // 
            this.tbmin.Location = new System.Drawing.Point(645, 11);
            this.tbmin.Name = "tbmin";
            this.tbmin.Size = new System.Drawing.Size(41, 24);
            this.tbmin.TabIndex = 1;
            this.tbmin.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnincrhr
            // 
            this.btnincrhr.Location = new System.Drawing.Point(349, 12);
            this.btnincrhr.Name = "btnincrhr";
            this.btnincrhr.Size = new System.Drawing.Size(138, 23);
            this.btnincrhr.TabIndex = 2;
            this.btnincrhr.Text = "Increase Hr";
            this.btnincrhr.UseVisualStyleBackColor = true;
            this.btnincrhr.Click += new System.EventHandler(this.btnincrhr_Click);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(349, 41);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(138, 23);
            this.min.TabIndex = 3;
            this.min.Text = "increase min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // tbsetmin
            // 
            this.tbsetmin.Location = new System.Drawing.Point(92, 27);
            this.tbsetmin.Name = "tbsetmin";
            this.tbsetmin.Size = new System.Drawing.Size(41, 24);
            this.tbsetmin.TabIndex = 5;
            // 
            // tbsethr
            // 
            this.tbsethr.Location = new System.Drawing.Point(47, 27);
            this.tbsethr.Name = "tbsethr";
            this.tbsethr.Size = new System.Drawing.Size(39, 24);
            this.tbsethr.TabIndex = 4;
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(57, 98);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(138, 23);
            this.AddPerson.TabIndex = 6;
            this.AddPerson.Text = "Add Person";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(12, 97);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(39, 24);
            this.tbname.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(227, 180);
            this.listBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.tbsetmin);
            this.Controls.Add(this.tbsethr);
            this.Controls.Add(this.min);
            this.Controls.Add(this.btnincrhr);
            this.Controls.Add(this.tbmin);
            this.Controls.Add(this.tbhrs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbhrs;
        private System.Windows.Forms.TextBox tbmin;
        private System.Windows.Forms.Button btnincrhr;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.TextBox tbsetmin;
        private System.Windows.Forms.TextBox tbsethr;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

