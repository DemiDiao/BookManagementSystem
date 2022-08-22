namespace BookBizMS.GUI
{
    partial class MISManage
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
            this.Backbutton = new System.Windows.Forms.Button();
            this.buttonUserManage = new System.Windows.Forms.Button();
            this.buttonEmployeeManage = new System.Windows.Forms.Button();
            this.labelAppName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.Backbutton.ForeColor = System.Drawing.Color.Ivory;
            this.Backbutton.Location = new System.Drawing.Point(617, 317);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(142, 44);
            this.Backbutton.TabIndex = 9;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // buttonUserManage
            // 
            this.buttonUserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonUserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUserManage.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonUserManage.ForeColor = System.Drawing.Color.Ivory;
            this.buttonUserManage.Location = new System.Drawing.Point(154, 227);
            this.buttonUserManage.Name = "buttonUserManage";
            this.buttonUserManage.Size = new System.Drawing.Size(188, 44);
            this.buttonUserManage.TabIndex = 10;
            this.buttonUserManage.Text = "Manage User";
            this.buttonUserManage.UseVisualStyleBackColor = false;
            this.buttonUserManage.Click += new System.EventHandler(this.buttonUserManage_Click);
            // 
            // buttonEmployeeManage
            // 
            this.buttonEmployeeManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonEmployeeManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeManage.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonEmployeeManage.ForeColor = System.Drawing.Color.Ivory;
            this.buttonEmployeeManage.Location = new System.Drawing.Point(420, 227);
            this.buttonEmployeeManage.Name = "buttonEmployeeManage";
            this.buttonEmployeeManage.Size = new System.Drawing.Size(195, 44);
            this.buttonEmployeeManage.TabIndex = 11;
            this.buttonEmployeeManage.Text = "Manage Employee";
            this.buttonEmployeeManage.UseVisualStyleBackColor = false;
            this.buttonEmployeeManage.Click += new System.EventHandler(this.buttonEmployeeManage_Click);
            // 
            // labelAppName
            // 
            this.labelAppName.Font = new System.Drawing.Font("Arial Black", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)), true);
            this.labelAppName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAppName.Location = new System.Drawing.Point(34, 56);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(712, 118);
            this.labelAppName.TabIndex = 12;
            this.labelAppName.Text = "BookBiz Management System";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAppName.UseCompatibleTextRendering = true;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)), true);
            this.buttonExit.ForeColor = System.Drawing.Color.Ivory;
            this.buttonExit.Location = new System.Drawing.Point(617, 385);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(142, 40);
            this.buttonExit.TabIndex = 104;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MISManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelAppName);
            this.Controls.Add(this.buttonEmployeeManage);
            this.Controls.Add(this.buttonUserManage);
            this.Controls.Add(this.Backbutton);
            this.Name = "MISManage";
            this.Text = "MISForm";
            this.Load += new System.EventHandler(this.MISManage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button buttonUserManage;
        private System.Windows.Forms.Button buttonEmployeeManage;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Button buttonExit;
    }
}