namespace week_5_2
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
            this.gbRV = new System.Windows.Forms.GroupBox();
            this.gbdisplay = new System.Windows.Forms.GroupBox();
            this.gbCarla = new System.Windows.Forms.GroupBox();
            this.gbjohn = new System.Windows.Forms.GroupBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.Label();
            this.reason = new System.Windows.Forms.Label();
            this.tbreason = new System.Windows.Forms.TextBox();
            this.rbJohn = new System.Windows.Forms.RadioButton();
            this.rbCarla = new System.Windows.Forms.RadioButton();
            this.rbany = new System.Windows.Forms.RadioButton();
            this.btntest = new System.Windows.Forms.Button();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.gbnext = new System.Windows.Forms.GroupBox();
            this.lblnamenext = new System.Windows.Forms.Label();
            this.lbltext = new System.Windows.Forms.Label();
            this.lbldoctrnext = new System.Windows.Forms.Label();
            this.btnNextJohn = new System.Windows.Forms.Button();
            this.btnNextCarla = new System.Windows.Forms.Button();
            this.lblNJohn = new System.Windows.Forms.Label();
            this.lblreJohn = new System.Windows.Forms.Label();
            this.lblReasonJhon = new System.Windows.Forms.Label();
            this.lblJohnName = new System.Windows.Forms.Label();
            this.lblReasonCarla = new System.Windows.Forms.Label();
            this.lblCarlaName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbRV.SuspendLayout();
            this.gbdisplay.SuspendLayout();
            this.gbCarla.SuspendLayout();
            this.gbjohn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbnext.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRV
            // 
            this.gbRV.BackColor = System.Drawing.Color.Yellow;
            this.gbRV.Controls.Add(this.tbreason);
            this.gbRV.Controls.Add(this.reason);
            this.gbRV.Controls.Add(this.name);
            this.gbRV.Controls.Add(this.groupBox1);
            this.gbRV.Controls.Add(this.btnRegister);
            this.gbRV.Controls.Add(this.tbname);
            this.gbRV.Location = new System.Drawing.Point(12, 12);
            this.gbRV.Name = "gbRV";
            this.gbRV.Size = new System.Drawing.Size(460, 283);
            this.gbRV.TabIndex = 0;
            this.gbRV.TabStop = false;
            this.gbRV.Text = "Registering Visitors";
            // 
            // gbdisplay
            // 
            this.gbdisplay.BackColor = System.Drawing.Color.Lime;
            this.gbdisplay.Controls.Add(this.gbnext);
            this.gbdisplay.Controls.Add(this.lbDisplay);
            this.gbdisplay.Controls.Add(this.btntest);
            this.gbdisplay.Location = new System.Drawing.Point(12, 301);
            this.gbdisplay.Name = "gbdisplay";
            this.gbdisplay.Size = new System.Drawing.Size(460, 277);
            this.gbdisplay.TabIndex = 1;
            this.gbdisplay.TabStop = false;
            this.gbdisplay.Text = "Display For Waiting Room";
            // 
            // gbCarla
            // 
            this.gbCarla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbCarla.Controls.Add(this.lblReasonCarla);
            this.gbCarla.Controls.Add(this.lblCarlaName);
            this.gbCarla.Controls.Add(this.label4);
            this.gbCarla.Controls.Add(this.label5);
            this.gbCarla.Controls.Add(this.btnNextCarla);
            this.gbCarla.Location = new System.Drawing.Point(496, 301);
            this.gbCarla.Name = "gbCarla";
            this.gbCarla.Size = new System.Drawing.Size(436, 277);
            this.gbCarla.TabIndex = 3;
            this.gbCarla.TabStop = false;
            this.gbCarla.Text = "Dr. Carla";
            // 
            // gbjohn
            // 
            this.gbjohn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gbjohn.Controls.Add(this.lblReasonJhon);
            this.gbjohn.Controls.Add(this.lblJohnName);
            this.gbjohn.Controls.Add(this.lblreJohn);
            this.gbjohn.Controls.Add(this.lblNJohn);
            this.gbjohn.Controls.Add(this.btnNextJohn);
            this.gbjohn.Location = new System.Drawing.Point(496, 12);
            this.gbjohn.Name = "gbjohn";
            this.gbjohn.Size = new System.Drawing.Size(436, 283);
            this.gbjohn.TabIndex = 2;
            this.gbjohn.TabStop = false;
            this.gbjohn.Text = "Dr. John";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(148, 38);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(214, 24);
            this.tbname.TabIndex = 0;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(312, 163);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 65);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbany);
            this.groupBox1.Controls.Add(this.rbCarla);
            this.groupBox1.Controls.Add(this.rbJohn);
            this.groupBox1.Location = new System.Drawing.Point(32, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "I prefer ";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(29, 41);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(43, 17);
            this.name.TabIndex = 3;
            this.name.Text = "Name";
            // 
            // reason
            // 
            this.reason.AutoSize = true;
            this.reason.Location = new System.Drawing.Point(29, 89);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(101, 17);
            this.reason.TabIndex = 4;
            this.reason.Text = "Reason for visit";
            // 
            // tbreason
            // 
            this.tbreason.Location = new System.Drawing.Point(148, 82);
            this.tbreason.Name = "tbreason";
            this.tbreason.Size = new System.Drawing.Size(214, 24);
            this.tbreason.TabIndex = 5;
            // 
            // rbJohn
            // 
            this.rbJohn.AutoSize = true;
            this.rbJohn.Location = new System.Drawing.Point(29, 23);
            this.rbJohn.Name = "rbJohn";
            this.rbJohn.Size = new System.Drawing.Size(82, 21);
            this.rbJohn.TabIndex = 0;
            this.rbJohn.TabStop = true;
            this.rbJohn.Text = "Dr. John";
            this.rbJohn.UseVisualStyleBackColor = true;
            // 
            // rbCarla
            // 
            this.rbCarla.AutoSize = true;
            this.rbCarla.Location = new System.Drawing.Point(29, 48);
            this.rbCarla.Name = "rbCarla";
            this.rbCarla.Size = new System.Drawing.Size(82, 21);
            this.rbCarla.TabIndex = 1;
            this.rbCarla.TabStop = true;
            this.rbCarla.Text = "Dr. Carla";
            this.rbCarla.UseVisualStyleBackColor = true;
            // 
            // rbany
            // 
            this.rbany.AutoSize = true;
            this.rbany.Location = new System.Drawing.Point(29, 73);
            this.rbany.Name = "rbany";
            this.rbany.Size = new System.Drawing.Size(53, 21);
            this.rbany.TabIndex = 2;
            this.rbany.TabStop = true;
            this.rbany.Text = "Any";
            this.rbany.UseVisualStyleBackColor = true;
            // 
            // btntest
            // 
            this.btntest.Location = new System.Drawing.Point(378, 244);
            this.btntest.Name = "btntest";
            this.btntest.Size = new System.Drawing.Size(75, 23);
            this.btntest.TabIndex = 0;
            this.btntest.Text = "test";
            this.btntest.UseVisualStyleBackColor = true;
            this.btntest.Click += new System.EventHandler(this.btntest_Click);
            // 
            // lbDisplay
            // 
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 16;
            this.lbDisplay.Location = new System.Drawing.Point(6, 23);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.Size = new System.Drawing.Size(448, 164);
            this.lbDisplay.TabIndex = 1;
            // 
            // gbnext
            // 
            this.gbnext.BackColor = System.Drawing.Color.Gainsboro;
            this.gbnext.Controls.Add(this.lbldoctrnext);
            this.gbnext.Controls.Add(this.lbltext);
            this.gbnext.Controls.Add(this.lblnamenext);
            this.gbnext.Location = new System.Drawing.Point(6, 193);
            this.gbnext.Name = "gbnext";
            this.gbnext.Size = new System.Drawing.Size(366, 72);
            this.gbnext.TabIndex = 2;
            this.gbnext.TabStop = false;
            this.gbnext.Text = "Next Patient";
            // 
            // lblnamenext
            // 
            this.lblnamenext.AutoSize = true;
            this.lblnamenext.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lblnamenext.Location = new System.Drawing.Point(6, 33);
            this.lblnamenext.Name = "lblnamenext";
            this.lblnamenext.Size = new System.Drawing.Size(20, 29);
            this.lblnamenext.TabIndex = 4;
            this.lblnamenext.Text = ".";
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbltext.Location = new System.Drawing.Point(138, 36);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(141, 21);
            this.lbltext.TabIndex = 5;
            this.lbltext.Text = ", please go to dr. ";
            // 
            // lbldoctrnext
            // 
            this.lbldoctrnext.AutoSize = true;
            this.lbldoctrnext.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lbldoctrnext.Location = new System.Drawing.Point(290, 33);
            this.lbldoctrnext.Name = "lbldoctrnext";
            this.lbldoctrnext.Size = new System.Drawing.Size(20, 29);
            this.lbldoctrnext.TabIndex = 6;
            this.lbldoctrnext.Text = ".";
            // 
            // btnNextJohn
            // 
            this.btnNextJohn.Location = new System.Drawing.Point(311, 82);
            this.btnNextJohn.Name = "btnNextJohn";
            this.btnNextJohn.Size = new System.Drawing.Size(101, 65);
            this.btnNextJohn.TabIndex = 2;
            this.btnNextJohn.Text = "Next";
            this.btnNextJohn.UseVisualStyleBackColor = true;
            this.btnNextJohn.Click += new System.EventHandler(this.btnNextJohn_Click);
            // 
            // btnNextCarla
            // 
            this.btnNextCarla.Location = new System.Drawing.Point(311, 138);
            this.btnNextCarla.Name = "btnNextCarla";
            this.btnNextCarla.Size = new System.Drawing.Size(101, 65);
            this.btnNextCarla.TabIndex = 3;
            this.btnNextCarla.Text = "Next";
            this.btnNextCarla.UseVisualStyleBackColor = true;
            this.btnNextCarla.Click += new System.EventHandler(this.btnNextCarla_Click);
            // 
            // lblNJohn
            // 
            this.lblNJohn.AutoSize = true;
            this.lblNJohn.Location = new System.Drawing.Point(35, 38);
            this.lblNJohn.Name = "lblNJohn";
            this.lblNJohn.Size = new System.Drawing.Size(43, 17);
            this.lblNJohn.TabIndex = 3;
            this.lblNJohn.Text = "Name";
            // 
            // lblreJohn
            // 
            this.lblreJohn.AutoSize = true;
            this.lblreJohn.Location = new System.Drawing.Point(35, 67);
            this.lblreJohn.Name = "lblreJohn";
            this.lblreJohn.Size = new System.Drawing.Size(101, 17);
            this.lblreJohn.TabIndex = 6;
            this.lblreJohn.Text = "Reason for visit";
            // 
            // lblReasonJhon
            // 
            this.lblReasonJhon.AutoSize = true;
            this.lblReasonJhon.Location = new System.Drawing.Point(172, 67);
            this.lblReasonJhon.Name = "lblReasonJhon";
            this.lblReasonJhon.Size = new System.Drawing.Size(101, 17);
            this.lblReasonJhon.TabIndex = 8;
            this.lblReasonJhon.Text = "Reason for visit";
            // 
            // lblJohnName
            // 
            this.lblJohnName.AutoSize = true;
            this.lblJohnName.Location = new System.Drawing.Point(172, 38);
            this.lblJohnName.Name = "lblJohnName";
            this.lblJohnName.Size = new System.Drawing.Size(43, 17);
            this.lblJohnName.TabIndex = 7;
            this.lblJohnName.Text = "Name";
            // 
            // lblReasonCarla
            // 
            this.lblReasonCarla.AutoSize = true;
            this.lblReasonCarla.Location = new System.Drawing.Point(172, 75);
            this.lblReasonCarla.Name = "lblReasonCarla";
            this.lblReasonCarla.Size = new System.Drawing.Size(101, 17);
            this.lblReasonCarla.TabIndex = 12;
            this.lblReasonCarla.Text = "Reason for visit";
            // 
            // lblCarlaName
            // 
            this.lblCarlaName.AutoSize = true;
            this.lblCarlaName.Location = new System.Drawing.Point(172, 46);
            this.lblCarlaName.Name = "lblCarlaName";
            this.lblCarlaName.Size = new System.Drawing.Size(43, 17);
            this.lblCarlaName.TabIndex = 11;
            this.lblCarlaName.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Reason for visit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 578);
            this.Controls.Add(this.gbCarla);
            this.Controls.Add(this.gbdisplay);
            this.Controls.Add(this.gbjohn);
            this.Controls.Add(this.gbRV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbRV.ResumeLayout(false);
            this.gbRV.PerformLayout();
            this.gbdisplay.ResumeLayout(false);
            this.gbCarla.ResumeLayout(false);
            this.gbCarla.PerformLayout();
            this.gbjohn.ResumeLayout(false);
            this.gbjohn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbnext.ResumeLayout(false);
            this.gbnext.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRV;
        private System.Windows.Forms.TextBox tbreason;
        private System.Windows.Forms.Label reason;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbany;
        private System.Windows.Forms.RadioButton rbCarla;
        private System.Windows.Forms.RadioButton rbJohn;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.GroupBox gbdisplay;
        private System.Windows.Forms.GroupBox gbCarla;
        private System.Windows.Forms.GroupBox gbjohn;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Button btntest;
        private System.Windows.Forms.GroupBox gbnext;
        private System.Windows.Forms.Label lbldoctrnext;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label lblnamenext;
        private System.Windows.Forms.Button btnNextCarla;
        private System.Windows.Forms.Label lblreJohn;
        private System.Windows.Forms.Label lblNJohn;
        private System.Windows.Forms.Button btnNextJohn;
        private System.Windows.Forms.Label lblReasonJhon;
        private System.Windows.Forms.Label lblJohnName;
        private System.Windows.Forms.Label lblReasonCarla;
        private System.Windows.Forms.Label lblCarlaName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

