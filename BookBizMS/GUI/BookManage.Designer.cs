namespace BookBizMS.GUI
{
    partial class BookManage
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearchRelationship = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.labelInventory = new System.Windows.Forms.Label();
            this.textBoxInventory = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.textBoxYearPublished = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.textBoxPublisher = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.textBoxISBNNumber = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.labelYearPublished = new System.Windows.Forms.Label();
            this.labelBookName = new System.Windows.Forms.Label();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.labelBookID = new System.Windows.Forms.Label();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.buttonAddRelationship = new System.Windows.Forms.Button();
            this.labelAuthor2 = new System.Windows.Forms.Label();
            this.textBoxAuthorID2 = new System.Windows.Forms.TextBox();
            this.labelBookID2 = new System.Windows.Forms.Label();
            this.textBoxBookID2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.comboBoxChoice = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.listBookAuthors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maskedTextBoxPrice = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonExit.ForeColor = System.Drawing.Color.Ivory;
            this.buttonExit.Location = new System.Drawing.Point(636, 365);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(121, 40);
            this.buttonExit.TabIndex = 126;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(47, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(711, 2);
            this.label2.TabIndex = 125;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonSearchRelationship
            // 
            this.buttonSearchRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchRelationship.Location = new System.Drawing.Point(636, 246);
            this.buttonSearchRelationship.Name = "buttonSearchRelationship";
            this.buttonSearchRelationship.Size = new System.Drawing.Size(121, 48);
            this.buttonSearchRelationship.TabIndex = 112;
            this.buttonSearchRelationship.Text = "Search Relationship";
            this.buttonSearchRelationship.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSearchRelationship.UseVisualStyleBackColor = true;
            this.buttonSearchRelationship.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.Backbutton.ForeColor = System.Drawing.Color.Ivory;
            this.Backbutton.Location = new System.Drawing.Point(636, 309);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(121, 43);
            this.Backbutton.TabIndex = 105;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory.Location = new System.Drawing.Point(480, 92);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(64, 15);
            this.labelInventory.TabIndex = 148;
            this.labelInventory.Text = "Inventory";
            // 
            // textBoxInventory
            // 
            this.textBoxInventory.AcceptsTab = true;
            this.textBoxInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInventory.Location = new System.Drawing.Point(480, 107);
            this.textBoxInventory.Name = "textBoxInventory";
            this.textBoxInventory.Size = new System.Drawing.Size(117, 21);
            this.textBoxInventory.TabIndex = 147;
            this.textBoxInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(333, 92);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 15);
            this.labelPrice.TabIndex = 146;
            this.labelPrice.Text = "Price";
            // 
            // textBoxYearPublished
            // 
            this.textBoxYearPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxYearPublished.Location = new System.Drawing.Point(49, 107);
            this.textBoxYearPublished.Name = "textBoxYearPublished";
            this.textBoxYearPublished.Size = new System.Drawing.Size(107, 21);
            this.textBoxYearPublished.TabIndex = 144;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublisher.Location = new System.Drawing.Point(184, 89);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(68, 15);
            this.labelPublisher.TabIndex = 143;
            this.labelPublisher.Text = "Publisher";
            // 
            // textBoxPublisher
            // 
            this.textBoxPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPublisher.Location = new System.Drawing.Point(181, 107);
            this.textBoxPublisher.Name = "textBoxPublisher";
            this.textBoxPublisher.Size = new System.Drawing.Size(119, 21);
            this.textBoxPublisher.TabIndex = 142;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelISBN.Location = new System.Drawing.Point(184, 43);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(94, 15);
            this.labelISBN.TabIndex = 141;
            this.labelISBN.Text = "ISBN Number";
            // 
            // textBoxISBNNumber
            // 
            this.textBoxISBNNumber.AcceptsTab = true;
            this.textBoxISBNNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxISBNNumber.Location = new System.Drawing.Point(184, 61);
            this.textBoxISBNNumber.Name = "textBoxISBNNumber";
            this.textBoxISBNNumber.Size = new System.Drawing.Size(119, 21);
            this.textBoxISBNNumber.TabIndex = 140;
            this.textBoxISBNNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategory.Location = new System.Drawing.Point(474, 43);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(63, 15);
            this.labelCategory.TabIndex = 139;
            this.labelCategory.Text = "Category";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCategory.Location = new System.Drawing.Point(477, 61);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(120, 21);
            this.textBoxCategory.TabIndex = 138;
            // 
            // labelYearPublished
            // 
            this.labelYearPublished.AutoSize = true;
            this.labelYearPublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearPublished.Location = new System.Drawing.Point(46, 92);
            this.labelYearPublished.Name = "labelYearPublished";
            this.labelYearPublished.Size = new System.Drawing.Size(104, 15);
            this.labelYearPublished.TabIndex = 137;
            this.labelYearPublished.Text = "Year Published";
            // 
            // labelBookName
            // 
            this.labelBookName.AutoSize = true;
            this.labelBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookName.Location = new System.Drawing.Point(330, 43);
            this.labelBookName.Name = "labelBookName";
            this.labelBookName.Size = new System.Drawing.Size(81, 15);
            this.labelBookName.TabIndex = 136;
            this.labelBookName.Text = "Book Name";
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookName.Location = new System.Drawing.Point(333, 61);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(119, 21);
            this.textBoxBookName.TabIndex = 134;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Location = new System.Drawing.Point(637, 61);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(121, 40);
            this.buttonAddBook.TabIndex = 135;
            this.buttonAddBook.Text = " Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookID.Location = new System.Drawing.Point(49, 43);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(57, 15);
            this.labelBookID.TabIndex = 133;
            this.labelBookID.Text = "Book ID";
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.AcceptsTab = true;
            this.textBoxBookID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID.Location = new System.Drawing.Point(49, 61);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(107, 21);
            this.textBoxBookID.TabIndex = 132;
            this.textBoxBookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonAddRelationship
            // 
            this.buttonAddRelationship.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRelationship.Location = new System.Drawing.Point(637, 173);
            this.buttonAddRelationship.Name = "buttonAddRelationship";
            this.buttonAddRelationship.Size = new System.Drawing.Size(121, 48);
            this.buttonAddRelationship.TabIndex = 149;
            this.buttonAddRelationship.Text = "Add Relationship";
            this.buttonAddRelationship.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddRelationship.UseVisualStyleBackColor = true;
            this.buttonAddRelationship.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelAuthor2
            // 
            this.labelAuthor2.AutoSize = true;
            this.labelAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthor2.Location = new System.Drawing.Point(330, 173);
            this.labelAuthor2.Name = "labelAuthor2";
            this.labelAuthor2.Size = new System.Drawing.Size(66, 15);
            this.labelAuthor2.TabIndex = 153;
            this.labelAuthor2.Text = "Author ID";
            // 
            // textBoxAuthorID2
            // 
            this.textBoxAuthorID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAuthorID2.Location = new System.Drawing.Point(333, 191);
            this.textBoxAuthorID2.Name = "textBoxAuthorID2";
            this.textBoxAuthorID2.Size = new System.Drawing.Size(264, 21);
            this.textBoxAuthorID2.TabIndex = 152;
            // 
            // labelBookID2
            // 
            this.labelBookID2.AutoSize = true;
            this.labelBookID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBookID2.Location = new System.Drawing.Point(49, 173);
            this.labelBookID2.Name = "labelBookID2";
            this.labelBookID2.Size = new System.Drawing.Size(57, 15);
            this.labelBookID2.TabIndex = 151;
            this.labelBookID2.Text = "Book ID";
            // 
            // textBoxBookID2
            // 
            this.textBoxBookID2.AcceptsTab = true;
            this.textBoxBookID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookID2.Location = new System.Drawing.Point(49, 191);
            this.textBoxBookID2.Name = "textBoxBookID2";
            this.textBoxBookID2.Size = new System.Drawing.Size(254, 21);
            this.textBoxBookID2.TabIndex = 150;
            this.textBoxBookID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(47, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(711, 2);
            this.label4.TabIndex = 154;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(333, 245);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(67, 15);
            this.labelInfo.TabIndex = 159;
            this.labelInfo.Text = "input Info";
            // 
            // comboBoxChoice
            // 
            this.comboBoxChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChoice.FormattingEnabled = true;
            this.comboBoxChoice.Items.AddRange(new object[] {
            "BookID",
            "AuthorID"});
            this.comboBoxChoice.Location = new System.Drawing.Point(52, 263);
            this.comboBoxChoice.Name = "comboBoxChoice";
            this.comboBoxChoice.Size = new System.Drawing.Size(248, 20);
            this.comboBoxChoice.TabIndex = 155;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 157;
            this.label5.Text = "Search By";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInput.Location = new System.Drawing.Point(336, 263);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(266, 21);
            this.textBoxInput.TabIndex = 158;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBookAuthors
            // 
            this.listBookAuthors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3});
            this.listBookAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBookAuthors.GridLines = true;
            this.listBookAuthors.HideSelection = false;
            this.listBookAuthors.Location = new System.Drawing.Point(47, 309);
            this.listBookAuthors.Name = "listBookAuthors";
            this.listBookAuthors.Size = new System.Drawing.Size(550, 96);
            this.listBookAuthors.TabIndex = 160;
            this.listBookAuthors.UseCompatibleStateImageBehavior = false;
            this.listBookAuthors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book ID";
            this.columnHeader1.Width = 278;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Author ID";
            this.columnHeader3.Width = 266;
            // 
            // maskedTextBoxPrice
            // 
            this.maskedTextBoxPrice.Location = new System.Drawing.Point(333, 107);
            this.maskedTextBoxPrice.Mask = "0000000.00";
            this.maskedTextBoxPrice.Name = "maskedTextBoxPrice";
            this.maskedTextBoxPrice.Size = new System.Drawing.Size(119, 21);
            this.maskedTextBoxPrice.TabIndex = 161;
            this.maskedTextBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BookManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBoxPrice);
            this.Controls.Add(this.listBookAuthors);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxChoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAuthor2);
            this.Controls.Add(this.textBoxAuthorID2);
            this.Controls.Add(this.labelBookID2);
            this.Controls.Add(this.textBoxBookID2);
            this.Controls.Add(this.buttonAddRelationship);
            this.Controls.Add(this.labelInventory);
            this.Controls.Add(this.textBoxInventory);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxYearPublished);
            this.Controls.Add(this.labelPublisher);
            this.Controls.Add(this.textBoxPublisher);
            this.Controls.Add(this.labelISBN);
            this.Controls.Add(this.textBoxISBNNumber);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.labelYearPublished);
            this.Controls.Add(this.labelBookName);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.labelBookID);
            this.Controls.Add(this.textBoxBookID);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSearchRelationship);
            this.Controls.Add(this.Backbutton);
            this.Name = "BookManage";
            this.Text = "BookManage";
            this.Load += new System.EventHandler(this.BookManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearchRelationship;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.TextBox textBoxInventory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox textBoxYearPublished;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.TextBox textBoxPublisher;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox textBoxISBNNumber;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.Label labelYearPublished;
        private System.Windows.Forms.Label labelBookName;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Button buttonAddRelationship;
        private System.Windows.Forms.Label labelAuthor2;
        private System.Windows.Forms.TextBox textBoxAuthorID2;
        private System.Windows.Forms.Label labelBookID2;
        private System.Windows.Forms.TextBox textBoxBookID2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox comboBoxChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.ListView listBookAuthors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrice;
    }
}