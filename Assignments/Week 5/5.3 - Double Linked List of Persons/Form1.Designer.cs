namespace _5._1___Linked_List_of_Persons
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.GbOptions = new System.Windows.Forms.GroupBox();
            this.BtnPersonNth = new System.Windows.Forms.Button();
            this.BtnCount = new System.Windows.Forms.Button();
            this.BtnDeletePerson = new System.Windows.Forms.Button();
            this.BtnNewPerson = new System.Windows.Forms.Button();
            this.TbName = new System.Windows.Forms.TextBox();
            this.GbOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 28;
            this.listBox1.Location = new System.Drawing.Point(14, 13);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 228);
            this.listBox1.TabIndex = 0;
            // 
            // GbOptions
            // 
            this.GbOptions.Controls.Add(this.BtnPersonNth);
            this.GbOptions.Controls.Add(this.BtnCount);
            this.GbOptions.Controls.Add(this.BtnDeletePerson);
            this.GbOptions.Controls.Add(this.BtnNewPerson);
            this.GbOptions.Location = new System.Drawing.Point(297, 13);
            this.GbOptions.Name = "GbOptions";
            this.GbOptions.Size = new System.Drawing.Size(200, 269);
            this.GbOptions.TabIndex = 3;
            this.GbOptions.TabStop = false;
            this.GbOptions.Text = "Options";
            this.GbOptions.UseCompatibleTextRendering = true;
            // 
            // BtnPersonNth
            // 
            this.BtnPersonNth.Location = new System.Drawing.Point(7, 158);
            this.BtnPersonNth.Margin = new System.Windows.Forms.Padding(4);
            this.BtnPersonNth.Name = "BtnPersonNth";
            this.BtnPersonNth.Size = new System.Drawing.Size(186, 40);
            this.BtnPersonNth.TabIndex = 7;
            this.BtnPersonNth.Text = "Person at Nth";
            this.BtnPersonNth.UseVisualStyleBackColor = true;
            this.BtnPersonNth.Click += new System.EventHandler(this.BtnPersonNth_Click);
            // 
            // BtnCount
            // 
            this.BtnCount.Location = new System.Drawing.Point(7, 220);
            this.BtnCount.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(186, 40);
            this.BtnCount.TabIndex = 6;
            this.BtnCount.Text = "Count";
            this.BtnCount.UseVisualStyleBackColor = true;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // BtnDeletePerson
            // 
            this.BtnDeletePerson.Location = new System.Drawing.Point(7, 96);
            this.BtnDeletePerson.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDeletePerson.Name = "BtnDeletePerson";
            this.BtnDeletePerson.Size = new System.Drawing.Size(186, 40);
            this.BtnDeletePerson.TabIndex = 5;
            this.BtnDeletePerson.Text = "Delete A Person";
            this.BtnDeletePerson.UseVisualStyleBackColor = true;
            this.BtnDeletePerson.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnNewPerson
            // 
            this.BtnNewPerson.Location = new System.Drawing.Point(7, 34);
            this.BtnNewPerson.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewPerson.Name = "BtnNewPerson";
            this.BtnNewPerson.Size = new System.Drawing.Size(186, 40);
            this.BtnNewPerson.TabIndex = 4;
            this.BtnNewPerson.Text = "Add New Person";
            this.BtnNewPerson.UseVisualStyleBackColor = true;
            this.BtnNewPerson.Click += new System.EventHandler(this.BtnNewPerson_Click);
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(81, 252);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(125, 34);
            this.TbName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 295);
            this.Controls.Add(this.GbOptions);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Linked List of Persons";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GbOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox GbOptions;
        private System.Windows.Forms.Button BtnNewPerson;
        private System.Windows.Forms.Button BtnDeletePerson;
        private System.Windows.Forms.Button BtnCount;
        private System.Windows.Forms.Button BtnPersonNth;
        private System.Windows.Forms.TextBox TbName;
    }
}

