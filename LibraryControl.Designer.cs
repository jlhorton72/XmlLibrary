namespace _7LibraryXML
{
    partial class LibraryControl
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
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lstBxBook = new System.Windows.Forms.ListBox();
            this.lstBxInventory = new System.Windows.Forms.ListBox();
            this.lstBxSearch = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckOut.ForeColor = System.Drawing.Color.Blue;
            this.btnCheckOut.Location = new System.Drawing.Point(122, 460);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(152, 46);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Book Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReturn.ForeColor = System.Drawing.Color.Blue;
            this.btnReturn.Location = new System.Drawing.Point(701, 460);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(152, 46);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Book Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInventory.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.Blue;
            this.lblInventory.Location = new System.Drawing.Point(84, 30);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(196, 24);
            this.lblInventory.TabIndex = 3;
            this.lblInventory.Text = "Search Inventory by:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBook.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBook.ForeColor = System.Drawing.Color.Blue;
            this.lblBook.Location = new System.Drawing.Point(620, 123);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(106, 24);
            this.lblBook.TabIndex = 4;
            this.lblBook.Text = "Book Info:";
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Fuchsia;
            this.btnAccept.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.ForeColor = System.Drawing.Color.Blue;
            this.btnAccept.Location = new System.Drawing.Point(418, 498);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(152, 46);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = false;
            // 
            // lstBxBook
            // 
            this.lstBxBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstBxBook.ForeColor = System.Drawing.Color.Navy;
            this.lstBxBook.FormattingEnabled = true;
            this.lstBxBook.ItemHeight = 19;
            this.lstBxBook.Location = new System.Drawing.Point(611, 182);
            this.lstBxBook.Name = "lstBxBook";
            this.lstBxBook.Size = new System.Drawing.Size(282, 194);
            this.lstBxBook.TabIndex = 6;
            // 
            // lstBxInventory
            // 
            this.lstBxInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstBxInventory.ForeColor = System.Drawing.Color.Navy;
            this.lstBxInventory.FormattingEnabled = true;
            this.lstBxInventory.ItemHeight = 19;
            this.lstBxInventory.Location = new System.Drawing.Point(88, 182);
            this.lstBxInventory.Name = "lstBxInventory";
            this.lstBxInventory.Size = new System.Drawing.Size(245, 194);
            this.lstBxInventory.TabIndex = 7;
            this.lstBxInventory.SelectedIndexChanged += new System.EventHandler(this.lstBxInventory_SelectedIndexChanged);
            // 
            // lstBxSearch
            // 
            this.lstBxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstBxSearch.ForeColor = System.Drawing.Color.Navy;
            this.lstBxSearch.FormattingEnabled = true;
            this.lstBxSearch.ItemHeight = 19;
            this.lstBxSearch.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Subject",
            "ISBN"});
            this.lstBxSearch.Location = new System.Drawing.Point(133, 67);
            this.lstBxSearch.Name = "lstBxSearch";
            this.lstBxSearch.Size = new System.Drawing.Size(147, 80);
            this.lstBxSearch.TabIndex = 8;
            this.lstBxSearch.SelectedIndexChanged += new System.EventHandler(this.lstBxSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Author:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Subject:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(532, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "ISBN #:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date in Library:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "# of Copies:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(498, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "# Copies Out:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LibraryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(999, 571);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstBxSearch);
            this.Controls.Add(this.lstBxInventory);
            this.Controls.Add(this.lstBxBook);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblBook);
            this.Controls.Add(this.lblInventory);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCheckOut);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Aqua;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LibraryControl";
            this.Text = "Library Controls";
            this.Load += new System.EventHandler(this.LibraryControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.ListBox lstBxBook;
        private System.Windows.Forms.ListBox lstBxInventory;
        private System.Windows.Forms.ListBox lstBxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

