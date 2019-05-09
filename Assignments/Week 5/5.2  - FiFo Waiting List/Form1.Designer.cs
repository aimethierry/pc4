namespace _5._2____FiFo_Waiting_List
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
            this.GbRegistration = new System.Windows.Forms.GroupBox();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.GbChoosingDoctor = new System.Windows.Forms.GroupBox();
            this.RbNoPreference = new System.Windows.Forms.RadioButton();
            this.RbDr_Carla = new System.Windows.Forms.RadioButton();
            this.RbDr_John = new System.Windows.Forms.RadioButton();
            this.TbReason = new System.Windows.Forms.TextBox();
            this.TbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GbWaitingRoom = new System.Windows.Forms.GroupBox();
            this.LbPeopleinQueue = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.GbDr_John = new System.Windows.Forms.GroupBox();
            this.BtnJohnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDrJohnStatus = new System.Windows.Forms.Label();
            this.lblNrJohn = new System.Windows.Forms.Label();
            this.GbDr_Carla = new System.Windows.Forms.GroupBox();
            this.BtnCarlaNext = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDrCarlaStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalNr = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNrCarl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNrNoPref = new System.Windows.Forms.Label();
            this.GbRegistration.SuspendLayout();
            this.GbChoosingDoctor.SuspendLayout();
            this.GbWaitingRoom.SuspendLayout();
            this.GbDr_John.SuspendLayout();
            this.GbDr_Carla.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbRegistration
            // 
            this.GbRegistration.BackColor = System.Drawing.Color.Yellow;
            this.GbRegistration.Controls.Add(this.BtnRegister);
            this.GbRegistration.Controls.Add(this.GbChoosingDoctor);
            this.GbRegistration.Controls.Add(this.TbReason);
            this.GbRegistration.Controls.Add(this.TbName);
            this.GbRegistration.Controls.Add(this.label2);
            this.GbRegistration.Controls.Add(this.label1);
            this.GbRegistration.Location = new System.Drawing.Point(12, 12);
            this.GbRegistration.Name = "GbRegistration";
            this.GbRegistration.Size = new System.Drawing.Size(475, 342);
            this.GbRegistration.TabIndex = 0;
            this.GbRegistration.TabStop = false;
            this.GbRegistration.Text = "Registering vistor";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(305, 219);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(133, 80);
            this.BtnRegister.TabIndex = 5;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // GbChoosingDoctor
            // 
            this.GbChoosingDoctor.Controls.Add(this.RbNoPreference);
            this.GbChoosingDoctor.Controls.Add(this.RbDr_Carla);
            this.GbChoosingDoctor.Controls.Add(this.RbDr_John);
            this.GbChoosingDoctor.Location = new System.Drawing.Point(23, 165);
            this.GbChoosingDoctor.Name = "GbChoosingDoctor";
            this.GbChoosingDoctor.Size = new System.Drawing.Size(250, 156);
            this.GbChoosingDoctor.TabIndex = 4;
            this.GbChoosingDoctor.TabStop = false;
            this.GbChoosingDoctor.Text = "I prefer practitioner";
            // 
            // RbNoPreference
            // 
            this.RbNoPreference.AutoSize = true;
            this.RbNoPreference.Checked = true;
            this.RbNoPreference.Location = new System.Drawing.Point(36, 114);
            this.RbNoPreference.Name = "RbNoPreference";
            this.RbNoPreference.Size = new System.Drawing.Size(193, 36);
            this.RbNoPreference.TabIndex = 2;
            this.RbNoPreference.TabStop = true;
            this.RbNoPreference.Text = "No Preference";
            this.RbNoPreference.UseVisualStyleBackColor = true;
            // 
            // RbDr_Carla
            // 
            this.RbDr_Carla.AutoSize = true;
            this.RbDr_Carla.Location = new System.Drawing.Point(36, 38);
            this.RbDr_Carla.Name = "RbDr_Carla";
            this.RbDr_Carla.Size = new System.Drawing.Size(130, 36);
            this.RbDr_Carla.TabIndex = 1;
            this.RbDr_Carla.Text = "Dr. Carla";
            this.RbDr_Carla.UseVisualStyleBackColor = true;
            // 
            // RbDr_John
            // 
            this.RbDr_John.AutoSize = true;
            this.RbDr_John.Location = new System.Drawing.Point(36, 76);
            this.RbDr_John.Name = "RbDr_John";
            this.RbDr_John.Size = new System.Drawing.Size(128, 36);
            this.RbDr_John.TabIndex = 0;
            this.RbDr_John.Text = "Dr. John";
            this.RbDr_John.UseVisualStyleBackColor = true;
            // 
            // TbReason
            // 
            this.TbReason.Location = new System.Drawing.Point(223, 103);
            this.TbReason.Name = "TbReason";
            this.TbReason.Size = new System.Drawing.Size(234, 39);
            this.TbReason.TabIndex = 3;
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(223, 50);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(100, 39);
            this.TbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reason for visit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // GbWaitingRoom
            // 
            this.GbWaitingRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GbWaitingRoom.Controls.Add(this.lblCount);
            this.GbWaitingRoom.Controls.Add(this.label4);
            this.GbWaitingRoom.Controls.Add(this.LbPeopleinQueue);
            this.GbWaitingRoom.Location = new System.Drawing.Point(515, 12);
            this.GbWaitingRoom.Name = "GbWaitingRoom";
            this.GbWaitingRoom.Size = new System.Drawing.Size(484, 342);
            this.GbWaitingRoom.TabIndex = 1;
            this.GbWaitingRoom.TabStop = false;
            this.GbWaitingRoom.Text = "Display for Waiting Room";
            // 
            // LbPeopleinQueue
            // 
            this.LbPeopleinQueue.FormattingEnabled = true;
            this.LbPeopleinQueue.ItemHeight = 32;
            this.LbPeopleinQueue.Location = new System.Drawing.Point(23, 93);
            this.LbPeopleinQueue.Name = "LbPeopleinQueue";
            this.LbPeopleinQueue.Size = new System.Drawing.Size(434, 228);
            this.LbPeopleinQueue.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(322, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of People in Queue:";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(422, 44);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 32);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "--";
            // 
            // GbDr_John
            // 
            this.GbDr_John.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GbDr_John.Controls.Add(this.lblNrJohn);
            this.GbDr_John.Controls.Add(this.lblDrJohnStatus);
            this.GbDr_John.Controls.Add(this.label3);
            this.GbDr_John.Controls.Add(this.BtnJohnNext);
            this.GbDr_John.Controls.Add(this.label8);
            this.GbDr_John.Location = new System.Drawing.Point(526, 115);
            this.GbDr_John.Name = "GbDr_John";
            this.GbDr_John.Size = new System.Drawing.Size(434, 187);
            this.GbDr_John.TabIndex = 1;
            this.GbDr_John.TabStop = false;
            this.GbDr_John.Text = "Dr. John";
            // 
            // BtnJohnNext
            // 
            this.BtnJohnNext.Location = new System.Drawing.Point(24, 126);
            this.BtnJohnNext.Name = "BtnJohnNext";
            this.BtnJohnNext.Size = new System.Drawing.Size(383, 45);
            this.BtnJohnNext.TabIndex = 6;
            this.BtnJohnNext.Text = "Next";
            this.BtnJohnNext.UseVisualStyleBackColor = true;
            this.BtnJohnNext.Click += new System.EventHandler(this.BtnJohnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Status: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "Number of Personal Paitient:";
            // 
            // lblDrJohnStatus
            // 
            this.lblDrJohnStatus.AutoSize = true;
            this.lblDrJohnStatus.Location = new System.Drawing.Point(126, 78);
            this.lblDrJohnStatus.Name = "lblDrJohnStatus";
            this.lblDrJohnStatus.Size = new System.Drawing.Size(0, 32);
            this.lblDrJohnStatus.TabIndex = 8;
            // 
            // lblNrJohn
            // 
            this.lblNrJohn.AutoSize = true;
            this.lblNrJohn.Location = new System.Drawing.Point(372, 35);
            this.lblNrJohn.Name = "lblNrJohn";
            this.lblNrJohn.Size = new System.Drawing.Size(35, 32);
            this.lblNrJohn.TabIndex = 14;
            this.lblNrJohn.Text = "--";
            // 
            // GbDr_Carla
            // 
            this.GbDr_Carla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.GbDr_Carla.Controls.Add(this.lblNrCarl);
            this.GbDr_Carla.Controls.Add(this.label10);
            this.GbDr_Carla.Controls.Add(this.lblDrCarlaStatus);
            this.GbDr_Carla.Controls.Add(this.label5);
            this.GbDr_Carla.Controls.Add(this.BtnCarlaNext);
            this.GbDr_Carla.Location = new System.Drawing.Point(23, 115);
            this.GbDr_Carla.Name = "GbDr_Carla";
            this.GbDr_Carla.Size = new System.Drawing.Size(434, 187);
            this.GbDr_Carla.TabIndex = 1;
            this.GbDr_Carla.TabStop = false;
            this.GbDr_Carla.Text = "Dr. Carla";
            this.GbDr_Carla.Enter += new System.EventHandler(this.GbDr_Carla_Enter);
            // 
            // BtnCarlaNext
            // 
            this.BtnCarlaNext.Location = new System.Drawing.Point(22, 126);
            this.BtnCarlaNext.Name = "BtnCarlaNext";
            this.BtnCarlaNext.Size = new System.Drawing.Size(383, 45);
            this.BtnCarlaNext.TabIndex = 7;
            this.BtnCarlaNext.Text = "Next";
            this.BtnCarlaNext.UseVisualStyleBackColor = true;
            this.BtnCarlaNext.Click += new System.EventHandler(this.BtnCarlaNext_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status: ";
            // 
            // lblDrCarlaStatus
            // 
            this.lblDrCarlaStatus.AutoSize = true;
            this.lblDrCarlaStatus.Location = new System.Drawing.Point(113, 78);
            this.lblDrCarlaStatus.Name = "lblDrCarlaStatus";
            this.lblDrCarlaStatus.Size = new System.Drawing.Size(0, 32);
            this.lblDrCarlaStatus.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label6.Location = new System.Drawing.Point(244, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(404, 36);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total Number of People in Queue:";
            // 
            // lblTotalNr
            // 
            this.lblTotalNr.AutoSize = true;
            this.lblTotalNr.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTotalNr.Location = new System.Drawing.Point(708, 31);
            this.lblTotalNr.Name = "lblTotalNr";
            this.lblTotalNr.Size = new System.Drawing.Size(35, 36);
            this.lblTotalNr.TabIndex = 12;
            this.lblTotalNr.Text = "--";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Controls.Add(this.lblNrNoPref);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblTotalNr);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.GbDr_Carla);
            this.groupBox1.Controls.Add(this.GbDr_John);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(987, 323);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Practitaioner Section";
            // 
            // lblNrCarl
            // 
            this.lblNrCarl.AutoSize = true;
            this.lblNrCarl.Location = new System.Drawing.Point(370, 35);
            this.lblNrCarl.Name = "lblNrCarl";
            this.lblNrCarl.Size = new System.Drawing.Size(35, 32);
            this.lblNrCarl.TabIndex = 16;
            this.lblNrCarl.Text = "--";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 32);
            this.label10.TabIndex = 15;
            this.label10.Text = "Number of Personal Paitient:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label11.Location = new System.Drawing.Point(244, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(458, 36);
            this.label11.TabIndex = 13;
            this.label11.Text = "Number of People with No Preference:";
            // 
            // lblNrNoPref
            // 
            this.lblNrNoPref.AutoSize = true;
            this.lblNrNoPref.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblNrNoPref.Location = new System.Drawing.Point(708, 67);
            this.lblNrNoPref.Name = "lblNrNoPref";
            this.lblNrNoPref.Size = new System.Drawing.Size(35, 36);
            this.lblNrNoPref.TabIndex = 14;
            this.lblNrNoPref.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1013, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbWaitingRoom);
            this.Controls.Add(this.GbRegistration);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Health center";
            this.GbRegistration.ResumeLayout(false);
            this.GbRegistration.PerformLayout();
            this.GbChoosingDoctor.ResumeLayout(false);
            this.GbChoosingDoctor.PerformLayout();
            this.GbWaitingRoom.ResumeLayout(false);
            this.GbWaitingRoom.PerformLayout();
            this.GbDr_John.ResumeLayout(false);
            this.GbDr_John.PerformLayout();
            this.GbDr_Carla.ResumeLayout(false);
            this.GbDr_Carla.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbRegistration;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.GroupBox GbChoosingDoctor;
        private System.Windows.Forms.RadioButton RbNoPreference;
        private System.Windows.Forms.RadioButton RbDr_Carla;
        private System.Windows.Forms.RadioButton RbDr_John;
        private System.Windows.Forms.TextBox TbReason;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GbWaitingRoom;
        private System.Windows.Forms.ListBox LbPeopleinQueue;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GbDr_John;
        private System.Windows.Forms.Label lblNrJohn;
        private System.Windows.Forms.Label lblDrJohnStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnJohnNext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GbDr_Carla;
        private System.Windows.Forms.Label lblNrCarl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDrCarlaStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCarlaNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalNr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNrNoPref;
        private System.Windows.Forms.Label label11;
    }
}

