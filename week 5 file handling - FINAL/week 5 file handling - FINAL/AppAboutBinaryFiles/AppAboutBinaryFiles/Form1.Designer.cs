namespace AppAboutBinaryFiles
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
            this.btCreate = new System.Windows.Forms.Button();
            this.btSaveToBinaryFile = new System.Windows.Forms.Button();
            this.btLoadFromBinaryFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btCreate
            // 
            this.btCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreate.Location = new System.Drawing.Point(15, 12);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(92, 44);
            this.btCreate.TabIndex = 0;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // btSaveToBinaryFile
            // 
            this.btSaveToBinaryFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveToBinaryFile.Location = new System.Drawing.Point(146, 12);
            this.btSaveToBinaryFile.Name = "btSaveToBinaryFile";
            this.btSaveToBinaryFile.Size = new System.Drawing.Size(177, 44);
            this.btSaveToBinaryFile.TabIndex = 1;
            this.btSaveToBinaryFile.Text = "Save to binary file";
            this.btSaveToBinaryFile.UseVisualStyleBackColor = true;
            this.btSaveToBinaryFile.Click += new System.EventHandler(this.btSaveToBinaryFile_Click);
            // 
            // btLoadFromBinaryFile
            // 
            this.btLoadFromBinaryFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoadFromBinaryFile.Location = new System.Drawing.Point(362, 14);
            this.btLoadFromBinaryFile.Name = "btLoadFromBinaryFile";
            this.btLoadFromBinaryFile.Size = new System.Drawing.Size(206, 42);
            this.btLoadFromBinaryFile.TabIndex = 2;
            this.btLoadFromBinaryFile.Text = "Load from binary file";
            this.btLoadFromBinaryFile.UseVisualStyleBackColor = true;
            this.btLoadFromBinaryFile.Click += new System.EventHandler(this.btLoadFromBinaryFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(12, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(556, 220);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 332);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btLoadFromBinaryFile);
            this.Controls.Add(this.btSaveToBinaryFile);
            this.Controls.Add(this.btCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btSaveToBinaryFile;
        private System.Windows.Forms.Button btLoadFromBinaryFile;
        private System.Windows.Forms.ListBox listBox1;
    }
}

