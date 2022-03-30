namespace Furniture_System
{
    partial class Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Back = new System.Windows.Forms.Button();
            this.TabControl_Cus = new MetroFramework.Controls.MetroTabControl();
            this.Cus_Info = new MetroFramework.Controls.MetroTabPage();
            this.metroGrid_Cus = new MetroFramework.Controls.MetroGrid();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new MetroFramework.Controls.MetroTextBox();
            this.lbl_SearchCus = new System.Windows.Forms.Label();
            this.Edit_Cus = new MetroFramework.Controls.MetroTabPage();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_remove = new MetroFramework.Controls.MetroButton();
            this.btn_clear = new MetroFramework.Controls.MetroButton();
            this.metroGrid_CusDetails = new MetroFramework.Controls.MetroGrid();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.txt_search2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Customer_No = new MetroFramework.Controls.MetroTextBox();
            this.txt_AdrsL3 = new MetroFramework.Controls.MetroTextBox();
            this.txt_AdrsL2 = new MetroFramework.Controls.MetroTextBox();
            this.txt_AdrsL1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_NIC = new MetroFramework.Controls.MetroTextBox();
            this.txt_Lname = new MetroFramework.Controls.MetroTextBox();
            this.txt_Fname = new MetroFramework.Controls.MetroTextBox();
            this.lbl_CusDetails = new System.Windows.Forms.Label();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.TabControl_Cus.SuspendLayout();
            this.Cus_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Cus)).BeginInit();
            this.Edit_Cus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_CusDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(16, 74);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(30, 34);
            this.btn_Back.TabIndex = 6;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // TabControl_Cus
            // 
            this.TabControl_Cus.Controls.Add(this.Cus_Info);
            this.TabControl_Cus.Controls.Add(this.Edit_Cus);
            this.TabControl_Cus.Location = new System.Drawing.Point(0, 114);
            this.TabControl_Cus.Name = "TabControl_Cus";
            this.TabControl_Cus.SelectedIndex = 0;
            this.TabControl_Cus.Size = new System.Drawing.Size(1020, 494);
            this.TabControl_Cus.TabIndex = 5;
            this.TabControl_Cus.UseSelectable = true;
            // 
            // Cus_Info
            // 
            this.Cus_Info.Controls.Add(this.metroGrid_Cus);
            this.Cus_Info.Controls.Add(this.btn_search);
            this.Cus_Info.Controls.Add(this.txt_search);
            this.Cus_Info.Controls.Add(this.lbl_SearchCus);
            this.Cus_Info.HorizontalScrollbarBarColor = true;
            this.Cus_Info.HorizontalScrollbarHighlightOnWheel = false;
            this.Cus_Info.HorizontalScrollbarSize = 10;
            this.Cus_Info.Location = new System.Drawing.Point(4, 38);
            this.Cus_Info.Name = "Cus_Info";
            this.Cus_Info.Size = new System.Drawing.Size(1012, 452);
            this.Cus_Info.TabIndex = 0;
            this.Cus_Info.Text = "Customer Info   ";
            this.Cus_Info.VerticalScrollbarBarColor = true;
            this.Cus_Info.VerticalScrollbarHighlightOnWheel = false;
            this.Cus_Info.VerticalScrollbarSize = 10;
            // 
            // metroGrid_Cus
            // 
            this.metroGrid_Cus.AllowUserToResizeRows = false;
            this.metroGrid_Cus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Cus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_Cus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_Cus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Cus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_Cus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_Cus.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_Cus.EnableHeadersVisualStyles = false;
            this.metroGrid_Cus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_Cus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Cus.Location = new System.Drawing.Point(7, 80);
            this.metroGrid_Cus.Name = "metroGrid_Cus";
            this.metroGrid_Cus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Cus.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_Cus.RowHeadersWidth = 51;
            this.metroGrid_Cus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_Cus.RowTemplate.Height = 24;
            this.metroGrid_Cus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_Cus.Size = new System.Drawing.Size(1002, 372);
            this.metroGrid_Cus.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(373, 19);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(27, 26);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            // 
            // 
            // 
            this.txt_search.CustomButton.Image = null;
            this.txt_search.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_search.CustomButton.Name = "";
            this.txt_search.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search.CustomButton.TabIndex = 1;
            this.txt_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search.CustomButton.UseSelectable = true;
            this.txt_search.CustomButton.Visible = false;
            this.txt_search.Lines = new string[0];
            this.txt_search.Location = new System.Drawing.Point(159, 19);
            this.txt_search.MaxLength = 32767;
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PromptText = "Customer Name";
            this.txt_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search.SelectedText = "";
            this.txt_search.SelectionLength = 0;
            this.txt_search.SelectionStart = 0;
            this.txt_search.ShortcutsEnabled = true;
            this.txt_search.Size = new System.Drawing.Size(208, 25);
            this.txt_search.TabIndex = 3;
            this.txt_search.UseSelectable = true;
            this.txt_search.WaterMark = "Customer Name";
            this.txt_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_SearchCus
            // 
            this.lbl_SearchCus.AutoSize = true;
            this.lbl_SearchCus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SearchCus.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchCus.Location = new System.Drawing.Point(9, 23);
            this.lbl_SearchCus.Name = "lbl_SearchCus";
            this.lbl_SearchCus.Size = new System.Drawing.Size(135, 21);
            this.lbl_SearchCus.TabIndex = 2;
            this.lbl_SearchCus.Text = "Search Customer :";
            // 
            // Edit_Cus
            // 
            this.Edit_Cus.Controls.Add(this.btn_update);
            this.Edit_Cus.Controls.Add(this.btn_remove);
            this.Edit_Cus.Controls.Add(this.btn_clear);
            this.Edit_Cus.Controls.Add(this.metroGrid_CusDetails);
            this.Edit_Cus.Controls.Add(this.btn_search2);
            this.Edit_Cus.Controls.Add(this.txt_search2);
            this.Edit_Cus.Controls.Add(this.txt_Customer_No);
            this.Edit_Cus.Controls.Add(this.txt_AdrsL3);
            this.Edit_Cus.Controls.Add(this.txt_AdrsL2);
            this.Edit_Cus.Controls.Add(this.txt_AdrsL1);
            this.Edit_Cus.Controls.Add(this.txt_NIC);
            this.Edit_Cus.Controls.Add(this.txt_Lname);
            this.Edit_Cus.Controls.Add(this.txt_Fname);
            this.Edit_Cus.Controls.Add(this.lbl_CusDetails);
            this.Edit_Cus.HorizontalScrollbarBarColor = true;
            this.Edit_Cus.HorizontalScrollbarHighlightOnWheel = false;
            this.Edit_Cus.HorizontalScrollbarSize = 10;
            this.Edit_Cus.Location = new System.Drawing.Point(4, 38);
            this.Edit_Cus.Name = "Edit_Cus";
            this.Edit_Cus.Size = new System.Drawing.Size(1012, 452);
            this.Edit_Cus.TabIndex = 1;
            this.Edit_Cus.Text = "Edit Customer   ";
            this.Edit_Cus.VerticalScrollbarBarColor = true;
            this.Edit_Cus.VerticalScrollbarHighlightOnWheel = false;
            this.Edit_Cus.VerticalScrollbarSize = 10;
            // 
            // btn_update
            // 
            this.btn_update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_update.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_update.Location = new System.Drawing.Point(596, 360);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 53);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Update";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_remove.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_remove.Location = new System.Drawing.Point(729, 360);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(100, 53);
            this.btn_remove.TabIndex = 14;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseSelectable = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_clear.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_clear.Location = new System.Drawing.Point(863, 360);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 53);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseSelectable = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // metroGrid_CusDetails
            // 
            this.metroGrid_CusDetails.AllowUserToResizeRows = false;
            this.metroGrid_CusDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_CusDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_CusDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_CusDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_CusDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid_CusDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_CusDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid_CusDetails.EnableHeadersVisualStyles = false;
            this.metroGrid_CusDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_CusDetails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_CusDetails.Location = new System.Drawing.Point(319, 60);
            this.metroGrid_CusDetails.Name = "metroGrid_CusDetails";
            this.metroGrid_CusDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_CusDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid_CusDetails.RowHeadersWidth = 51;
            this.metroGrid_CusDetails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_CusDetails.RowTemplate.Height = 24;
            this.metroGrid_CusDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_CusDetails.Size = new System.Drawing.Size(677, 279);
            this.metroGrid_CusDetails.TabIndex = 12;
            this.metroGrid_CusDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CusDetails_CellClick);
            // 
            // btn_search2
            // 
            this.btn_search2.BackColor = System.Drawing.Color.Transparent;
            this.btn_search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search2.BackgroundImage")));
            this.btn_search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search2.FlatAppearance.BorderSize = 0;
            this.btn_search2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search2.Location = new System.Drawing.Point(969, 19);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(27, 26);
            this.btn_search2.TabIndex = 11;
            this.btn_search2.UseVisualStyleBackColor = false;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // txt_search2
            // 
            // 
            // 
            // 
            this.txt_search2.CustomButton.Image = null;
            this.txt_search2.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_search2.CustomButton.Name = "";
            this.txt_search2.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_search2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_search2.CustomButton.TabIndex = 1;
            this.txt_search2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_search2.CustomButton.UseSelectable = true;
            this.txt_search2.CustomButton.Visible = false;
            this.txt_search2.Lines = new string[0];
            this.txt_search2.Location = new System.Drawing.Point(755, 19);
            this.txt_search2.MaxLength = 32767;
            this.txt_search2.Name = "txt_search2";
            this.txt_search2.PasswordChar = '\0';
            this.txt_search2.PromptText = "Customer Name";
            this.txt_search2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_search2.SelectedText = "";
            this.txt_search2.SelectionLength = 0;
            this.txt_search2.SelectionStart = 0;
            this.txt_search2.ShortcutsEnabled = true;
            this.txt_search2.Size = new System.Drawing.Size(208, 25);
            this.txt_search2.TabIndex = 10;
            this.txt_search2.UseSelectable = true;
            this.txt_search2.WaterMark = "Customer Name";
            this.txt_search2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_search2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Customer_No
            // 
            // 
            // 
            // 
            this.txt_Customer_No.CustomButton.Image = null;
            this.txt_Customer_No.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_Customer_No.CustomButton.Name = "";
            this.txt_Customer_No.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Customer_No.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Customer_No.CustomButton.TabIndex = 1;
            this.txt_Customer_No.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Customer_No.CustomButton.UseSelectable = true;
            this.txt_Customer_No.CustomButton.Visible = false;
            this.txt_Customer_No.Lines = new string[0];
            this.txt_Customer_No.Location = new System.Drawing.Point(13, 344);
            this.txt_Customer_No.MaxLength = 32767;
            this.txt_Customer_No.Name = "txt_Customer_No";
            this.txt_Customer_No.PasswordChar = '\0';
            this.txt_Customer_No.PromptText = "Contact no";
            this.txt_Customer_No.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Customer_No.SelectedText = "";
            this.txt_Customer_No.SelectionLength = 0;
            this.txt_Customer_No.SelectionStart = 0;
            this.txt_Customer_No.ShortcutsEnabled = true;
            this.txt_Customer_No.Size = new System.Drawing.Size(196, 25);
            this.txt_Customer_No.TabIndex = 9;
            this.txt_Customer_No.UseSelectable = true;
            this.txt_Customer_No.WaterMark = "Contact no";
            this.txt_Customer_No.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Customer_No.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_AdrsL3
            // 
            // 
            // 
            // 
            this.txt_AdrsL3.CustomButton.Image = null;
            this.txt_AdrsL3.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_AdrsL3.CustomButton.Name = "";
            this.txt_AdrsL3.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_AdrsL3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_AdrsL3.CustomButton.TabIndex = 1;
            this.txt_AdrsL3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_AdrsL3.CustomButton.UseSelectable = true;
            this.txt_AdrsL3.CustomButton.Visible = false;
            this.txt_AdrsL3.Lines = new string[0];
            this.txt_AdrsL3.Location = new System.Drawing.Point(13, 300);
            this.txt_AdrsL3.MaxLength = 32767;
            this.txt_AdrsL3.Name = "txt_AdrsL3";
            this.txt_AdrsL3.PasswordChar = '\0';
            this.txt_AdrsL3.PromptText = "Address line 3";
            this.txt_AdrsL3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_AdrsL3.SelectedText = "";
            this.txt_AdrsL3.SelectionLength = 0;
            this.txt_AdrsL3.SelectionStart = 0;
            this.txt_AdrsL3.ShortcutsEnabled = true;
            this.txt_AdrsL3.Size = new System.Drawing.Size(274, 25);
            this.txt_AdrsL3.TabIndex = 8;
            this.txt_AdrsL3.UseSelectable = true;
            this.txt_AdrsL3.WaterMark = "Address line 3";
            this.txt_AdrsL3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_AdrsL3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_AdrsL2
            // 
            // 
            // 
            // 
            this.txt_AdrsL2.CustomButton.Image = null;
            this.txt_AdrsL2.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_AdrsL2.CustomButton.Name = "";
            this.txt_AdrsL2.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_AdrsL2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_AdrsL2.CustomButton.TabIndex = 1;
            this.txt_AdrsL2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_AdrsL2.CustomButton.UseSelectable = true;
            this.txt_AdrsL2.CustomButton.Visible = false;
            this.txt_AdrsL2.Lines = new string[0];
            this.txt_AdrsL2.Location = new System.Drawing.Point(13, 257);
            this.txt_AdrsL2.MaxLength = 32767;
            this.txt_AdrsL2.Name = "txt_AdrsL2";
            this.txt_AdrsL2.PasswordChar = '\0';
            this.txt_AdrsL2.PromptText = "Address line 2";
            this.txt_AdrsL2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_AdrsL2.SelectedText = "";
            this.txt_AdrsL2.SelectionLength = 0;
            this.txt_AdrsL2.SelectionStart = 0;
            this.txt_AdrsL2.ShortcutsEnabled = true;
            this.txt_AdrsL2.Size = new System.Drawing.Size(274, 25);
            this.txt_AdrsL2.TabIndex = 7;
            this.txt_AdrsL2.UseSelectable = true;
            this.txt_AdrsL2.WaterMark = "Address line 2";
            this.txt_AdrsL2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_AdrsL2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_AdrsL1
            // 
            // 
            // 
            // 
            this.txt_AdrsL1.CustomButton.Image = null;
            this.txt_AdrsL1.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.txt_AdrsL1.CustomButton.Name = "";
            this.txt_AdrsL1.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_AdrsL1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_AdrsL1.CustomButton.TabIndex = 1;
            this.txt_AdrsL1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_AdrsL1.CustomButton.UseSelectable = true;
            this.txt_AdrsL1.CustomButton.Visible = false;
            this.txt_AdrsL1.Lines = new string[0];
            this.txt_AdrsL1.Location = new System.Drawing.Point(13, 212);
            this.txt_AdrsL1.MaxLength = 32767;
            this.txt_AdrsL1.Name = "txt_AdrsL1";
            this.txt_AdrsL1.PasswordChar = '\0';
            this.txt_AdrsL1.PromptText = "Address line 1";
            this.txt_AdrsL1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_AdrsL1.SelectedText = "";
            this.txt_AdrsL1.SelectionLength = 0;
            this.txt_AdrsL1.SelectionStart = 0;
            this.txt_AdrsL1.ShortcutsEnabled = true;
            this.txt_AdrsL1.Size = new System.Drawing.Size(274, 25);
            this.txt_AdrsL1.TabIndex = 6;
            this.txt_AdrsL1.UseSelectable = true;
            this.txt_AdrsL1.WaterMark = "Address line 1";
            this.txt_AdrsL1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_AdrsL1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_NIC
            // 
            // 
            // 
            // 
            this.txt_NIC.CustomButton.Image = null;
            this.txt_NIC.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_NIC.CustomButton.Name = "";
            this.txt_NIC.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_NIC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NIC.CustomButton.TabIndex = 1;
            this.txt_NIC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NIC.CustomButton.UseSelectable = true;
            this.txt_NIC.CustomButton.Visible = false;
            this.txt_NIC.Enabled = false;
            this.txt_NIC.Lines = new string[0];
            this.txt_NIC.Location = new System.Drawing.Point(13, 166);
            this.txt_NIC.MaxLength = 32767;
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.PasswordChar = '\0';
            this.txt_NIC.PromptText = "NIC no";
            this.txt_NIC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NIC.SelectedText = "";
            this.txt_NIC.SelectionLength = 0;
            this.txt_NIC.SelectionStart = 0;
            this.txt_NIC.ShortcutsEnabled = true;
            this.txt_NIC.Size = new System.Drawing.Size(196, 25);
            this.txt_NIC.TabIndex = 5;
            this.txt_NIC.UseSelectable = true;
            this.txt_NIC.WaterMark = "NIC no";
            this.txt_NIC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NIC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Lname
            // 
            // 
            // 
            // 
            this.txt_Lname.CustomButton.Image = null;
            this.txt_Lname.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_Lname.CustomButton.Name = "";
            this.txt_Lname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Lname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Lname.CustomButton.TabIndex = 1;
            this.txt_Lname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Lname.CustomButton.UseSelectable = true;
            this.txt_Lname.CustomButton.Visible = false;
            this.txt_Lname.Lines = new string[0];
            this.txt_Lname.Location = new System.Drawing.Point(13, 122);
            this.txt_Lname.MaxLength = 32767;
            this.txt_Lname.Name = "txt_Lname";
            this.txt_Lname.PasswordChar = '\0';
            this.txt_Lname.PromptText = "Last name";
            this.txt_Lname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Lname.SelectedText = "";
            this.txt_Lname.SelectionLength = 0;
            this.txt_Lname.SelectionStart = 0;
            this.txt_Lname.ShortcutsEnabled = true;
            this.txt_Lname.Size = new System.Drawing.Size(196, 25);
            this.txt_Lname.TabIndex = 4;
            this.txt_Lname.UseSelectable = true;
            this.txt_Lname.WaterMark = "Last name";
            this.txt_Lname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Lname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Fname
            // 
            // 
            // 
            // 
            this.txt_Fname.CustomButton.Image = null;
            this.txt_Fname.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_Fname.CustomButton.Name = "";
            this.txt_Fname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Fname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Fname.CustomButton.TabIndex = 1;
            this.txt_Fname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Fname.CustomButton.UseSelectable = true;
            this.txt_Fname.CustomButton.Visible = false;
            this.txt_Fname.Lines = new string[0];
            this.txt_Fname.Location = new System.Drawing.Point(13, 79);
            this.txt_Fname.MaxLength = 32767;
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.PasswordChar = '\0';
            this.txt_Fname.PromptText = "First name";
            this.txt_Fname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Fname.SelectedText = "";
            this.txt_Fname.SelectionLength = 0;
            this.txt_Fname.SelectionStart = 0;
            this.txt_Fname.ShortcutsEnabled = true;
            this.txt_Fname.Size = new System.Drawing.Size(196, 25);
            this.txt_Fname.TabIndex = 3;
            this.txt_Fname.UseSelectable = true;
            this.txt_Fname.WaterMark = "First name";
            this.txt_Fname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Fname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_CusDetails
            // 
            this.lbl_CusDetails.AutoSize = true;
            this.lbl_CusDetails.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CusDetails.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CusDetails.Location = new System.Drawing.Point(9, 23);
            this.lbl_CusDetails.Name = "lbl_CusDetails";
            this.lbl_CusDetails.Size = new System.Drawing.Size(130, 21);
            this.lbl_CusDetails.TabIndex = 2;
            this.lbl_CusDetails.Text = "Customer Details";
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(52, 79);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(47, 23);
            this.lbl_Customer.TabIndex = 4;
            this.lbl_Customer.Text = "Back";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.TabControl_Cus);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Customer";
            this.Resizable = false;
            this.Text = "Customer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Customer_FormClosed);
            this.TabControl_Cus.ResumeLayout(false);
            this.Cus_Info.ResumeLayout(false);
            this.Cus_Info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Cus)).EndInit();
            this.Edit_Cus.ResumeLayout(false);
            this.Edit_Cus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_CusDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private MetroFramework.Controls.MetroTabControl TabControl_Cus;
        private MetroFramework.Controls.MetroTabPage Cus_Info;
        private MetroFramework.Controls.MetroTabPage Edit_Cus;
        private System.Windows.Forms.Label lbl_Customer;
        private MetroFramework.Controls.MetroTextBox txt_search;
        private System.Windows.Forms.Label lbl_SearchCus;
        private System.Windows.Forms.Button btn_search;
        private MetroFramework.Controls.MetroGrid metroGrid_Cus;
        private System.Windows.Forms.Button btn_search2;
        private MetroFramework.Controls.MetroTextBox txt_search2;
        private MetroFramework.Controls.MetroTextBox txt_Customer_No;
        private MetroFramework.Controls.MetroTextBox txt_AdrsL3;
        private MetroFramework.Controls.MetroTextBox txt_AdrsL2;
        private MetroFramework.Controls.MetroTextBox txt_AdrsL1;
        private MetroFramework.Controls.MetroTextBox txt_NIC;
        private MetroFramework.Controls.MetroTextBox txt_Lname;
        private MetroFramework.Controls.MetroTextBox txt_Fname;
        private System.Windows.Forms.Label lbl_CusDetails;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_remove;
        private MetroFramework.Controls.MetroButton btn_clear;
        private MetroFramework.Controls.MetroGrid metroGrid_CusDetails;
    }
}