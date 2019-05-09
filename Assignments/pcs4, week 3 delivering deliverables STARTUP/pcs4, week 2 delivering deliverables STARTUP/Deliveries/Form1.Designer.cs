namespace Deliveries
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
            this.btLoad = new System.Windows.Forms.Button();
            this.btSortByWeight = new System.Windows.Forms.Button();
            this.btSortByName = new System.Windows.Forms.Button();
            this.btSortById = new System.Windows.Forms.Button();
            this.btSortByAddress = new System.Windows.Forms.Button();
            this.btSortForPostman = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OFDPersons = new System.Windows.Forms.OpenFileDialog();
            this.OFDDeliverables = new System.Windows.Forms.OpenFileDialog();
            this.btnsearchbinary = new System.Windows.Forms.Button();
            this.tbid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btnnamesearch = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(179, 15);
            this.btLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(87, 28);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "LOAD ALL";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btSortByWeight
            // 
            this.btSortByWeight.Location = new System.Drawing.Point(19, 51);
            this.btSortByWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSortByWeight.Name = "btSortByWeight";
            this.btSortByWeight.Size = new System.Drawing.Size(247, 28);
            this.btSortByWeight.TabIndex = 1;
            this.btSortByWeight.Text = "SORT BY WEIGHT";
            this.btSortByWeight.UseVisualStyleBackColor = true;
            this.btSortByWeight.Click += new System.EventHandler(this.btSortByWeight_Click);
            // 
            // btSortByName
            // 
            this.btSortByName.Location = new System.Drawing.Point(19, 109);
            this.btSortByName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSortByName.Name = "btSortByName";
            this.btSortByName.Size = new System.Drawing.Size(247, 28);
            this.btSortByName.TabIndex = 2;
            this.btSortByName.Text = "SORT BY BUYER\'S NAME";
            this.btSortByName.UseVisualStyleBackColor = true;
            this.btSortByName.Click += new System.EventHandler(this.btSortByName_Click);
            // 
            // btSortById
            // 
            this.btSortById.Location = new System.Drawing.Point(19, 167);
            this.btSortById.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSortById.Name = "btSortById";
            this.btSortById.Size = new System.Drawing.Size(247, 28);
            this.btSortById.TabIndex = 3;
            this.btSortById.Text = "SORT BY ID";
            this.btSortById.UseVisualStyleBackColor = true;
            this.btSortById.Click += new System.EventHandler(this.btSortById_Click);
            // 
            // btSortByAddress
            // 
            this.btSortByAddress.Location = new System.Drawing.Point(19, 225);
            this.btSortByAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSortByAddress.Name = "btSortByAddress";
            this.btSortByAddress.Size = new System.Drawing.Size(247, 28);
            this.btSortByAddress.TabIndex = 4;
            this.btSortByAddress.Text = "SORT BY ADDRESS";
            this.btSortByAddress.UseVisualStyleBackColor = true;
            this.btSortByAddress.Click += new System.EventHandler(this.btSortByAddress_Click);
            // 
            // btSortForPostman
            // 
            this.btSortForPostman.Location = new System.Drawing.Point(19, 283);
            this.btSortForPostman.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btSortForPostman.Name = "btSortForPostman";
            this.btSortForPostman.Size = new System.Drawing.Size(247, 28);
            this.btSortForPostman.TabIndex = 5;
            this.btSortForPostman.Text = "SORT FOR THE POSTMAN";
            this.btSortForPostman.UseVisualStyleBackColor = true;
            this.btSortForPostman.Click += new System.EventHandler(this.btSortForPostman_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(296, 15);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(831, 379);
            this.listBox1.TabIndex = 6;
            // 
            // OFDPersons
            // 
            this.OFDPersons.FileName = "OFDPersons";
            // 
            // OFDDeliverables
            // 
            this.OFDDeliverables.FileName = "openFileDialog1";
            // 
            // btnsearchbinary
            // 
            this.btnsearchbinary.Location = new System.Drawing.Point(463, 401);
            this.btnsearchbinary.Name = "btnsearchbinary";
            this.btnsearchbinary.Size = new System.Drawing.Size(75, 23);
            this.btnsearchbinary.TabIndex = 7;
            this.btnsearchbinary.Text = "search binary\r\n";
            this.btnsearchbinary.UseVisualStyleBackColor = true;
            this.btnsearchbinary.Click += new System.EventHandler(this.btnsearchbinary_Click);
            // 
            // tbid
            // 
            this.tbid.Location = new System.Drawing.Point(337, 401);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(120, 24);
            this.tbid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(922, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "name";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(970, 404);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(156, 24);
            this.tbname.TabIndex = 11;
            // 
            // btnnamesearch
            // 
            this.btnnamesearch.Location = new System.Drawing.Point(970, 434);
            this.btnnamesearch.Name = "btnnamesearch";
            this.btnnamesearch.Size = new System.Drawing.Size(75, 23);
            this.btnnamesearch.TabIndex = 10;
            this.btnnamesearch.Text = "search binary\r\n";
            this.btnnamesearch.UseVisualStyleBackColor = true;
            this.btnnamesearch.Click += new System.EventHandler(this.btnnamesearch_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1051, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Get ALL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 469);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.btnnamesearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.btnsearchbinary);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btSortForPostman);
            this.Controls.Add(this.btSortByAddress);
            this.Controls.Add(this.btSortById);
            this.Controls.Add(this.btSortByName);
            this.Controls.Add(this.btSortByWeight);
            this.Controls.Add(this.btLoad);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSortByWeight;
        private System.Windows.Forms.Button btSortByName;
        private System.Windows.Forms.Button btSortById;
        private System.Windows.Forms.Button btSortByAddress;
        private System.Windows.Forms.Button btSortForPostman;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog OFDPersons;
        private System.Windows.Forms.OpenFileDialog OFDDeliverables;
        private System.Windows.Forms.Button btnsearchbinary;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btnnamesearch;
        private System.Windows.Forms.Button button1;
    }
}

