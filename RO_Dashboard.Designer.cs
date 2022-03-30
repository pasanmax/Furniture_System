namespace Furniture_System
{
    partial class RO_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RO_Dashboard));
            this.lbl_Welcome_Name = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Log_Out = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_Print_Bill = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Welcome_Name
            // 
            this.lbl_Welcome_Name.AutoSize = true;
            this.lbl_Welcome_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome_Name.Font = new System.Drawing.Font("Corbel Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome_Name.Location = new System.Drawing.Point(673, 42);
            this.lbl_Welcome_Name.Name = "lbl_Welcome_Name";
            this.lbl_Welcome_Name.Size = new System.Drawing.Size(0, 40);
            this.lbl_Welcome_Name.TabIndex = 171;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Welcome.Font = new System.Drawing.Font("Corbel Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(620, 42);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(45, 40);
            this.lbl_Welcome.TabIndex = 170;
            this.lbl_Welcome.Text = "Hi";
            // 
            // lbl_Log_Out
            // 
            this.lbl_Log_Out.AutoSize = true;
            this.lbl_Log_Out.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Log_Out.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Log_Out.Location = new System.Drawing.Point(896, 131);
            this.lbl_Log_Out.Name = "lbl_Log_Out";
            this.lbl_Log_Out.Size = new System.Drawing.Size(66, 21);
            this.lbl_Log_Out.TabIndex = 169;
            this.lbl_Log_Out.Text = "Log Out";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_logout.BackgroundImage")));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Location = new System.Drawing.Point(970, 129);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(27, 26);
            this.btn_logout.TabIndex = 168;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_Print_Bill
            // 
            this.btn_Print_Bill.ActiveControl = null;
            this.btn_Print_Bill.Location = new System.Drawing.Point(23, 168);
            this.btn_Print_Bill.Name = "btn_Print_Bill";
            this.btn_Print_Bill.Size = new System.Drawing.Size(222, 120);
            this.btn_Print_Bill.TabIndex = 167;
            this.btn_Print_Bill.Text = "Print Receipt";
            this.btn_Print_Bill.UseSelectable = true;
            this.btn_Print_Bill.Click += new System.EventHandler(this.btn_Print_Bill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(589, 474);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 172;
            this.pictureBox1.TabStop = false;
            // 
            // RO_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Welcome_Name);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.lbl_Log_Out);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Print_Bill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RO_Dashboard";
            this.Resizable = false;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RO_Dashboard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome_Name;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_Log_Out;
        private System.Windows.Forms.Button btn_logout;
        private MetroFramework.Controls.MetroTile btn_Print_Bill;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}