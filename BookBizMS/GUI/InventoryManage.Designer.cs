namespace BookBizMS.GUI
{
    partial class InventoryManage
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
            this.labelAppName = new System.Windows.Forms.Label();
            this.buttonAuthorManage = new System.Windows.Forms.Button();
            this.buttonUserBook = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.buttonSearchBook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonExit.ForeColor = System.Drawing.Color.Ivory;
            this.buttonExit.Location = new System.Drawing.Point(590, 369);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(142, 40);
            this.buttonExit.TabIndex = 109;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelAppName
            // 
            this.labelAppName.Font = new System.Drawing.Font("Arial Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)), true);
            this.labelAppName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAppName.Location = new System.Drawing.Point(51, 30);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(712, 118);
            this.labelAppName.TabIndex = 108;
            this.labelAppName.Text = "BookBiz Management System";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAppName.UseCompatibleTextRendering = true;
            // 
            // buttonAuthorManage
            // 
            this.buttonAuthorManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonAuthorManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthorManage.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonAuthorManage.ForeColor = System.Drawing.Color.Ivory;
            this.buttonAuthorManage.Location = new System.Drawing.Point(539, 225);
            this.buttonAuthorManage.Name = "buttonAuthorManage";
            this.buttonAuthorManage.Size = new System.Drawing.Size(193, 44);
            this.buttonAuthorManage.TabIndex = 107;
            this.buttonAuthorManage.Text = "Manage Author";
            this.buttonAuthorManage.UseVisualStyleBackColor = false;
            this.buttonAuthorManage.Click += new System.EventHandler(this.buttonAuthorManage_Click);
            // 
            // buttonUserBook
            // 
            this.buttonUserBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonUserBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserBook.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonUserBook.ForeColor = System.Drawing.Color.Ivory;
            this.buttonUserBook.Location = new System.Drawing.Point(311, 225);
            this.buttonUserBook.Name = "buttonUserBook";
            this.buttonUserBook.Size = new System.Drawing.Size(186, 44);
            this.buttonUserBook.TabIndex = 106;
            this.buttonUserBook.Text = "Manage Book";
            this.buttonUserBook.UseVisualStyleBackColor = false;
            this.buttonUserBook.Click += new System.EventHandler(this.buttonUserBook_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.Backbutton.ForeColor = System.Drawing.Color.Ivory;
            this.Backbutton.Location = new System.Drawing.Point(590, 301);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(142, 44);
            this.Backbutton.TabIndex = 105;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // buttonSearchBook
            // 
            this.buttonSearchBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonSearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchBook.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonSearchBook.ForeColor = System.Drawing.Color.Ivory;
            this.buttonSearchBook.Location = new System.Drawing.Point(84, 225);
            this.buttonSearchBook.Name = "buttonSearchBook";
            this.buttonSearchBook.Size = new System.Drawing.Size(186, 44);
            this.buttonSearchBook.TabIndex = 110;
            this.buttonSearchBook.Text = "Search Book";
            this.buttonSearchBook.UseVisualStyleBackColor = false;
            this.buttonSearchBook.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // InventoryManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSearchBook);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.buttonAuthorManage);
            this.Controls.Add(this.buttonUserBook);
            this.Controls.Add(this.Backbutton);
            this.Name = "InventoryManage";
            this.Text = "InventoryManage";
            this.Load += new System.EventHandler(this.InventoryManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Button buttonAuthorManage;
        private System.Windows.Forms.Button buttonUserBook;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button buttonSearchBook;
    }
}