namespace Furniture_System
{
    partial class OSMO_Print_Bill
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OSMO_Print_Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Customer_DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Furniture_System.DataSet1();
            this.DataTable_FullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Furniture_System.DataSet2();
            this.DataTable_InsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new Furniture_System.DataSet3();
            this.TabControl_Reports = new MetroFramework.Controls.MetroTabControl();
            this.Print_Receipt = new MetroFramework.Controls.MetroTabPage();
            this.lbl_Str_Ld_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Sub_Tot = new System.Windows.Forms.Label();
            this.lbl_Tot_Full = new System.Windows.Forms.Label();
            this.lbl_Tot_Down = new System.Windows.Forms.Label();
            this.btn_clear_all = new MetroFramework.Controls.MetroButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_NIC = new MetroFramework.Controls.MetroTextBox();
            this.txt_Receipt_No = new MetroFramework.Controls.MetroTextBox();
            this.btn_Print = new MetroFramework.Controls.MetroButton();
            this.btn_Add_Item = new MetroFramework.Controls.MetroButton();
            this.btn_clear_Load = new MetroFramework.Controls.MetroButton();
            this.txt_Discount_Pcnt = new MetroFramework.Controls.MetroTextBox();
            this.txt_No_of_Ins = new MetroFramework.Controls.MetroTextBox();
            this.txt_Downpayment = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.lbl_uPrice = new System.Windows.Forms.Label();
            this.cmb_Str_Ldr_Name = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Quantity = new MetroFramework.Controls.MetroComboBox();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.cmb_Item_Name = new MetroFramework.Controls.MetroComboBox();
            this.cmb_Payment_Type = new MetroFramework.Controls.MetroComboBox();
            this.lbl_Payment_Type = new System.Windows.Forms.Label();
            this.metroGrid_Rec_Itms = new MetroFramework.Controls.MetroGrid();
            this.Load_or_Store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Downpayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.No_of_Installments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_AddItems = new System.Windows.Forms.Label();
            this.View_Receipts = new MetroFramework.Controls.MetroTabPage();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.reportViewer_View_Receipts = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_View_Receipt_No = new MetroFramework.Controls.MetroTextBox();
            this.lbl_View_Rec = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.Customer_DetailTableAdapter = new Furniture_System.DataSet1TableAdapters.Customer_DetailTableAdapter();
            this.DataTable_FullTableAdapter = new Furniture_System.DataSet2TableAdapters.DataTable_FullTableAdapter();
            this.DataTable_InsTableAdapter = new Furniture_System.DataSet3TableAdapters.DataTable_InsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_FullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            this.TabControl_Reports.SuspendLayout();
            this.Print_Receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Rec_Itms)).BeginInit();
            this.View_Receipts.SuspendLayout();
            this.SuspendLayout();
            // 
            // Customer_DetailBindingSource
            // 
            this.Customer_DetailBindingSource.DataMember = "Customer_Detail";
            this.Customer_DetailBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_FullBindingSource
            // 
            this.DataTable_FullBindingSource.DataMember = "DataTable_Full";
            this.DataTable_FullBindingSource.DataSource = this.DataSet2;
            // 
            // DataSet2
            // 
            this.DataSet2.DataSetName = "DataSet2";
            this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_InsBindingSource
            // 
            this.DataTable_InsBindingSource.DataMember = "DataTable_Ins";
            this.DataTable_InsBindingSource.DataSource = this.DataSet3;
            // 
            // DataSet3
            // 
            this.DataSet3.DataSetName = "DataSet3";
            this.DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TabControl_Reports
            // 
            this.TabControl_Reports.Controls.Add(this.Print_Receipt);
            this.TabControl_Reports.Controls.Add(this.View_Receipts);
            this.TabControl_Reports.Location = new System.Drawing.Point(0, 113);
            this.TabControl_Reports.Name = "TabControl_Reports";
            this.TabControl_Reports.SelectedIndex = 0;
            this.TabControl_Reports.Size = new System.Drawing.Size(1046, 585);
            this.TabControl_Reports.TabIndex = 17;
            this.TabControl_Reports.UseSelectable = true;
            // 
            // Print_Receipt
            // 
            this.Print_Receipt.Controls.Add(this.lbl_Str_Ld_Name);
            this.Print_Receipt.Controls.Add(this.label1);
            this.Print_Receipt.Controls.Add(this.label2);
            this.Print_Receipt.Controls.Add(this.label3);
            this.Print_Receipt.Controls.Add(this.lbl_Sub_Tot);
            this.Print_Receipt.Controls.Add(this.lbl_Tot_Full);
            this.Print_Receipt.Controls.Add(this.lbl_Tot_Down);
            this.Print_Receipt.Controls.Add(this.btn_clear_all);
            this.Print_Receipt.Controls.Add(this.btn_search);
            this.Print_Receipt.Controls.Add(this.txt_NIC);
            this.Print_Receipt.Controls.Add(this.txt_Receipt_No);
            this.Print_Receipt.Controls.Add(this.btn_Print);
            this.Print_Receipt.Controls.Add(this.btn_Add_Item);
            this.Print_Receipt.Controls.Add(this.btn_clear_Load);
            this.Print_Receipt.Controls.Add(this.txt_Discount_Pcnt);
            this.Print_Receipt.Controls.Add(this.txt_No_of_Ins);
            this.Print_Receipt.Controls.Add(this.txt_Downpayment);
            this.Print_Receipt.Controls.Add(this.lbl_Item_Name);
            this.Print_Receipt.Controls.Add(this.lbl_uPrice);
            this.Print_Receipt.Controls.Add(this.cmb_Str_Ldr_Name);
            this.Print_Receipt.Controls.Add(this.cmb_Quantity);
            this.Print_Receipt.Controls.Add(this.lbl_Quantity);
            this.Print_Receipt.Controls.Add(this.cmb_Item_Name);
            this.Print_Receipt.Controls.Add(this.cmb_Payment_Type);
            this.Print_Receipt.Controls.Add(this.lbl_Payment_Type);
            this.Print_Receipt.Controls.Add(this.metroGrid_Rec_Itms);
            this.Print_Receipt.Controls.Add(this.lbl_AddItems);
            this.Print_Receipt.HorizontalScrollbarBarColor = true;
            this.Print_Receipt.HorizontalScrollbarHighlightOnWheel = false;
            this.Print_Receipt.HorizontalScrollbarSize = 10;
            this.Print_Receipt.Location = new System.Drawing.Point(4, 38);
            this.Print_Receipt.Name = "Print_Receipt";
            this.Print_Receipt.Size = new System.Drawing.Size(1038, 543);
            this.Print_Receipt.TabIndex = 0;
            this.Print_Receipt.Text = "Print Receipt   ";
            this.Print_Receipt.VerticalScrollbarBarColor = true;
            this.Print_Receipt.VerticalScrollbarHighlightOnWheel = false;
            this.Print_Receipt.VerticalScrollbarSize = 10;
            // 
            // lbl_Str_Ld_Name
            // 
            this.lbl_Str_Ld_Name.AutoSize = true;
            this.lbl_Str_Ld_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Str_Ld_Name.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Str_Ld_Name.Location = new System.Drawing.Point(678, 361);
            this.lbl_Str_Ld_Name.Name = "lbl_Str_Ld_Name";
            this.lbl_Str_Ld_Name.Size = new System.Drawing.Size(0, 21);
            this.lbl_Str_Ld_Name.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(762, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 153;
            this.label1.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(762, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 152;
            this.label2.Text = "Total Full Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(762, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 151;
            this.label3.Text = "Total Downpayment";
            // 
            // lbl_Sub_Tot
            // 
            this.lbl_Sub_Tot.AutoSize = true;
            this.lbl_Sub_Tot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sub_Tot.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sub_Tot.ForeColor = System.Drawing.Color.Red;
            this.lbl_Sub_Tot.Location = new System.Drawing.Point(915, 441);
            this.lbl_Sub_Tot.Name = "lbl_Sub_Tot";
            this.lbl_Sub_Tot.Size = new System.Drawing.Size(0, 18);
            this.lbl_Sub_Tot.TabIndex = 150;
            // 
            // lbl_Tot_Full
            // 
            this.lbl_Tot_Full.AutoSize = true;
            this.lbl_Tot_Full.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tot_Full.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tot_Full.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tot_Full.Location = new System.Drawing.Point(915, 421);
            this.lbl_Tot_Full.Name = "lbl_Tot_Full";
            this.lbl_Tot_Full.Size = new System.Drawing.Size(0, 18);
            this.lbl_Tot_Full.TabIndex = 149;
            // 
            // lbl_Tot_Down
            // 
            this.lbl_Tot_Down.AutoSize = true;
            this.lbl_Tot_Down.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tot_Down.Font = new System.Drawing.Font("Corbel", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tot_Down.ForeColor = System.Drawing.Color.Red;
            this.lbl_Tot_Down.Location = new System.Drawing.Point(915, 399);
            this.lbl_Tot_Down.Name = "lbl_Tot_Down";
            this.lbl_Tot_Down.Size = new System.Drawing.Size(0, 18);
            this.lbl_Tot_Down.TabIndex = 148;
            // 
            // btn_clear_all
            // 
            this.btn_clear_all.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_clear_all.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_clear_all.Location = new System.Drawing.Point(909, 473);
            this.btn_clear_all.Name = "btn_clear_all";
            this.btn_clear_all.Size = new System.Drawing.Size(100, 53);
            this.btn_clear_all.TabIndex = 147;
            this.btn_clear_all.Text = "Clear All";
            this.btn_clear_all.UseSelectable = true;
            this.btn_clear_all.Click += new System.EventHandler(this.btn_clear_all_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(955, 20);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(27, 26);
            this.btn_search.TabIndex = 146;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_NIC
            // 
            // 
            // 
            // 
            this.txt_NIC.CustomButton.Image = null;
            this.txt_NIC.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_NIC.CustomButton.Name = "";
            this.txt_NIC.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_NIC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_NIC.CustomButton.TabIndex = 1;
            this.txt_NIC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_NIC.CustomButton.UseSelectable = true;
            this.txt_NIC.CustomButton.Visible = false;
            this.txt_NIC.Lines = new string[0];
            this.txt_NIC.Location = new System.Drawing.Point(730, 20);
            this.txt_NIC.MaxLength = 32767;
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.PasswordChar = '\0';
            this.txt_NIC.PromptText = "Customer NIC";
            this.txt_NIC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_NIC.SelectedText = "";
            this.txt_NIC.SelectionLength = 0;
            this.txt_NIC.SelectionStart = 0;
            this.txt_NIC.ShortcutsEnabled = true;
            this.txt_NIC.Size = new System.Drawing.Size(208, 25);
            this.txt_NIC.TabIndex = 145;
            this.txt_NIC.UseSelectable = true;
            this.txt_NIC.WaterMark = "Customer NIC";
            this.txt_NIC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_NIC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Receipt_No
            // 
            // 
            // 
            // 
            this.txt_Receipt_No.CustomButton.Image = null;
            this.txt_Receipt_No.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_Receipt_No.CustomButton.Name = "";
            this.txt_Receipt_No.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Receipt_No.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Receipt_No.CustomButton.TabIndex = 1;
            this.txt_Receipt_No.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Receipt_No.CustomButton.UseSelectable = true;
            this.txt_Receipt_No.CustomButton.Visible = false;
            this.txt_Receipt_No.Lines = new string[0];
            this.txt_Receipt_No.Location = new System.Drawing.Point(482, 20);
            this.txt_Receipt_No.MaxLength = 32767;
            this.txt_Receipt_No.Name = "txt_Receipt_No";
            this.txt_Receipt_No.PasswordChar = '\0';
            this.txt_Receipt_No.PromptText = "Receipt No";
            this.txt_Receipt_No.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Receipt_No.SelectedText = "";
            this.txt_Receipt_No.SelectionLength = 0;
            this.txt_Receipt_No.SelectionStart = 0;
            this.txt_Receipt_No.ShortcutsEnabled = true;
            this.txt_Receipt_No.Size = new System.Drawing.Size(208, 25);
            this.txt_Receipt_No.TabIndex = 144;
            this.txt_Receipt_No.UseSelectable = true;
            this.txt_Receipt_No.WaterMark = "Receipt No";
            this.txt_Receipt_No.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Receipt_No.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Print
            // 
            this.btn_Print.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Print.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_Print.Location = new System.Drawing.Point(427, 473);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(131, 53);
            this.btn_Print.TabIndex = 143;
            this.btn_Print.Text = "Print Receipt";
            this.btn_Print.UseSelectable = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Add_Item
            // 
            this.btn_Add_Item.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Add_Item.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_Add_Item.Location = new System.Drawing.Point(611, 473);
            this.btn_Add_Item.Name = "btn_Add_Item";
            this.btn_Add_Item.Size = new System.Drawing.Size(131, 53);
            this.btn_Add_Item.TabIndex = 142;
            this.btn_Add_Item.Text = "Add Item";
            this.btn_Add_Item.UseSelectable = true;
            this.btn_Add_Item.Click += new System.EventHandler(this.btn_Add_Item_Click);
            // 
            // btn_clear_Load
            // 
            this.btn_clear_Load.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_clear_Load.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_clear_Load.Location = new System.Drawing.Point(776, 473);
            this.btn_clear_Load.Name = "btn_clear_Load";
            this.btn_clear_Load.Size = new System.Drawing.Size(100, 53);
            this.btn_clear_Load.TabIndex = 141;
            this.btn_clear_Load.Text = "Clear";
            this.btn_clear_Load.UseSelectable = true;
            this.btn_clear_Load.Click += new System.EventHandler(this.btn_clear_Load_Click);
            // 
            // txt_Discount_Pcnt
            // 
            // 
            // 
            // 
            this.txt_Discount_Pcnt.CustomButton.Image = null;
            this.txt_Discount_Pcnt.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_Discount_Pcnt.CustomButton.Name = "";
            this.txt_Discount_Pcnt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Discount_Pcnt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Discount_Pcnt.CustomButton.TabIndex = 1;
            this.txt_Discount_Pcnt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Discount_Pcnt.CustomButton.UseSelectable = true;
            this.txt_Discount_Pcnt.CustomButton.Visible = false;
            this.txt_Discount_Pcnt.Lines = new string[0];
            this.txt_Discount_Pcnt.Location = new System.Drawing.Point(148, 480);
            this.txt_Discount_Pcnt.MaxLength = 32767;
            this.txt_Discount_Pcnt.Name = "txt_Discount_Pcnt";
            this.txt_Discount_Pcnt.PasswordChar = '\0';
            this.txt_Discount_Pcnt.PromptText = "Discount Percentage";
            this.txt_Discount_Pcnt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Discount_Pcnt.SelectedText = "";
            this.txt_Discount_Pcnt.SelectionLength = 0;
            this.txt_Discount_Pcnt.SelectionStart = 0;
            this.txt_Discount_Pcnt.ShortcutsEnabled = true;
            this.txt_Discount_Pcnt.Size = new System.Drawing.Size(208, 25);
            this.txt_Discount_Pcnt.TabIndex = 140;
            this.txt_Discount_Pcnt.UseSelectable = true;
            this.txt_Discount_Pcnt.WaterMark = "Discount Percentage";
            this.txt_Discount_Pcnt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Discount_Pcnt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_No_of_Ins
            // 
            // 
            // 
            // 
            this.txt_No_of_Ins.CustomButton.Image = null;
            this.txt_No_of_Ins.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_No_of_Ins.CustomButton.Name = "";
            this.txt_No_of_Ins.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_No_of_Ins.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_No_of_Ins.CustomButton.TabIndex = 1;
            this.txt_No_of_Ins.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_No_of_Ins.CustomButton.UseSelectable = true;
            this.txt_No_of_Ins.CustomButton.Visible = false;
            this.txt_No_of_Ins.Lines = new string[0];
            this.txt_No_of_Ins.Location = new System.Drawing.Point(148, 432);
            this.txt_No_of_Ins.MaxLength = 32767;
            this.txt_No_of_Ins.Name = "txt_No_of_Ins";
            this.txt_No_of_Ins.PasswordChar = '\0';
            this.txt_No_of_Ins.PromptText = "No of Installments";
            this.txt_No_of_Ins.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_No_of_Ins.SelectedText = "";
            this.txt_No_of_Ins.SelectionLength = 0;
            this.txt_No_of_Ins.SelectionStart = 0;
            this.txt_No_of_Ins.ShortcutsEnabled = true;
            this.txt_No_of_Ins.Size = new System.Drawing.Size(208, 25);
            this.txt_No_of_Ins.TabIndex = 139;
            this.txt_No_of_Ins.UseSelectable = true;
            this.txt_No_of_Ins.WaterMark = "No of Installments";
            this.txt_No_of_Ins.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_No_of_Ins.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Downpayment
            // 
            // 
            // 
            // 
            this.txt_Downpayment.CustomButton.Image = null;
            this.txt_Downpayment.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_Downpayment.CustomButton.Name = "";
            this.txt_Downpayment.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Downpayment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Downpayment.CustomButton.TabIndex = 1;
            this.txt_Downpayment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Downpayment.CustomButton.UseSelectable = true;
            this.txt_Downpayment.CustomButton.Visible = false;
            this.txt_Downpayment.Lines = new string[0];
            this.txt_Downpayment.Location = new System.Drawing.Point(148, 388);
            this.txt_Downpayment.MaxLength = 32767;
            this.txt_Downpayment.Name = "txt_Downpayment";
            this.txt_Downpayment.PasswordChar = '\0';
            this.txt_Downpayment.PromptText = "Down payment";
            this.txt_Downpayment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Downpayment.SelectedText = "";
            this.txt_Downpayment.SelectionLength = 0;
            this.txt_Downpayment.SelectionStart = 0;
            this.txt_Downpayment.ShortcutsEnabled = true;
            this.txt_Downpayment.Size = new System.Drawing.Size(208, 25);
            this.txt_Downpayment.TabIndex = 138;
            this.txt_Downpayment.UseSelectable = true;
            this.txt_Downpayment.WaterMark = "Down payment";
            this.txt_Downpayment.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Downpayment.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.AutoSize = true;
            this.lbl_Item_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Item_Name.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item_Name.Location = new System.Drawing.Point(391, 366);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(0, 21);
            this.lbl_Item_Name.TabIndex = 136;
            // 
            // lbl_uPrice
            // 
            this.lbl_uPrice.AutoSize = true;
            this.lbl_uPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbl_uPrice.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uPrice.Location = new System.Drawing.Point(391, 392);
            this.lbl_uPrice.Name = "lbl_uPrice";
            this.lbl_uPrice.Size = new System.Drawing.Size(0, 21);
            this.lbl_uPrice.TabIndex = 134;
            this.lbl_uPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb_Str_Ldr_Name
            // 
            this.cmb_Str_Ldr_Name.FormattingEnabled = true;
            this.cmb_Str_Ldr_Name.ItemHeight = 24;
            this.cmb_Str_Ldr_Name.Location = new System.Drawing.Point(675, 318);
            this.cmb_Str_Ldr_Name.Name = "cmb_Str_Ldr_Name";
            this.cmb_Str_Ldr_Name.Size = new System.Drawing.Size(150, 30);
            this.cmb_Str_Ldr_Name.TabIndex = 133;
            this.cmb_Str_Ldr_Name.UseSelectable = true;
            this.cmb_Str_Ldr_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Str_Ldr_Name_SelectedIndexChanged);
            // 
            // cmb_Quantity
            // 
            this.cmb_Quantity.FormattingEnabled = true;
            this.cmb_Quantity.ItemHeight = 24;
            this.cmb_Quantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50"});
            this.cmb_Quantity.Location = new System.Drawing.Point(944, 318);
            this.cmb_Quantity.Name = "cmb_Quantity";
            this.cmb_Quantity.Size = new System.Drawing.Size(81, 30);
            this.cmb_Quantity.TabIndex = 132;
            this.cmb_Quantity.UseSelectable = true;
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Quantity.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.Location = new System.Drawing.Point(876, 324);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(62, 18);
            this.lbl_Quantity.TabIndex = 131;
            this.lbl_Quantity.Text = "Quantity";
            // 
            // cmb_Item_Name
            // 
            this.cmb_Item_Name.FormattingEnabled = true;
            this.cmb_Item_Name.ItemHeight = 24;
            this.cmb_Item_Name.Location = new System.Drawing.Point(389, 318);
            this.cmb_Item_Name.Name = "cmb_Item_Name";
            this.cmb_Item_Name.Size = new System.Drawing.Size(158, 30);
            this.cmb_Item_Name.TabIndex = 130;
            this.cmb_Item_Name.UseSelectable = true;
            this.cmb_Item_Name.SelectedIndexChanged += new System.EventHandler(this.cmb_Item_Name_SelectedIndexChanged);
            // 
            // cmb_Payment_Type
            // 
            this.cmb_Payment_Type.FormattingEnabled = true;
            this.cmb_Payment_Type.ItemHeight = 24;
            this.cmb_Payment_Type.Items.AddRange(new object[] {
            "Full Payment",
            "Installment Payment"});
            this.cmb_Payment_Type.Location = new System.Drawing.Point(148, 318);
            this.cmb_Payment_Type.Name = "cmb_Payment_Type";
            this.cmb_Payment_Type.Size = new System.Drawing.Size(208, 30);
            this.cmb_Payment_Type.TabIndex = 129;
            this.cmb_Payment_Type.UseSelectable = true;
            this.cmb_Payment_Type.SelectedIndexChanged += new System.EventHandler(this.cmb_Payment_Type_SelectedIndexChanged);
            // 
            // lbl_Payment_Type
            // 
            this.lbl_Payment_Type.AutoSize = true;
            this.lbl_Payment_Type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Payment_Type.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Payment_Type.Location = new System.Drawing.Point(25, 323);
            this.lbl_Payment_Type.Name = "lbl_Payment_Type";
            this.lbl_Payment_Type.Size = new System.Drawing.Size(108, 21);
            this.lbl_Payment_Type.TabIndex = 128;
            this.lbl_Payment_Type.Text = "Payment Type";
            // 
            // metroGrid_Rec_Itms
            // 
            this.metroGrid_Rec_Itms.AllowUserToResizeRows = false;
            this.metroGrid_Rec_Itms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Rec_Itms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_Rec_Itms.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_Rec_Itms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Rec_Itms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_Rec_Itms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid_Rec_Itms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Load_or_Store,
            this.Payment_Type,
            this.Item_Code,
            this.Item_Name,
            this.Quantity,
            this.Unit_Price,
            this.Downpayment,
            this.No_of_Installments});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_Rec_Itms.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_Rec_Itms.EnableHeadersVisualStyles = false;
            this.metroGrid_Rec_Itms.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_Rec_Itms.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Rec_Itms.Location = new System.Drawing.Point(18, 62);
            this.metroGrid_Rec_Itms.Name = "metroGrid_Rec_Itms";
            this.metroGrid_Rec_Itms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Rec_Itms.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid_Rec_Itms.RowHeadersWidth = 51;
            this.metroGrid_Rec_Itms.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_Rec_Itms.RowTemplate.Height = 24;
            this.metroGrid_Rec_Itms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_Rec_Itms.Size = new System.Drawing.Size(1007, 240);
            this.metroGrid_Rec_Itms.TabIndex = 127;
            // 
            // Load_or_Store
            // 
            this.Load_or_Store.HeaderText = "Load or Store";
            this.Load_or_Store.MinimumWidth = 6;
            this.Load_or_Store.Name = "Load_or_Store";
            this.Load_or_Store.Width = 125;
            // 
            // Payment_Type
            // 
            this.Payment_Type.HeaderText = "Payment Type";
            this.Payment_Type.MinimumWidth = 6;
            this.Payment_Type.Name = "Payment_Type";
            this.Payment_Type.Width = 125;
            // 
            // Item_Code
            // 
            this.Item_Code.HeaderText = "Item Code";
            this.Item_Code.MinimumWidth = 6;
            this.Item_Code.Name = "Item_Code";
            this.Item_Code.Width = 125;
            // 
            // Item_Name
            // 
            this.Item_Name.HeaderText = "Item Name";
            this.Item_Name.MinimumWidth = 6;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Unit_Price
            // 
            this.Unit_Price.HeaderText = "Unit Price";
            this.Unit_Price.MinimumWidth = 6;
            this.Unit_Price.Name = "Unit_Price";
            this.Unit_Price.Width = 125;
            // 
            // Downpayment
            // 
            this.Downpayment.HeaderText = "Downpayment";
            this.Downpayment.MinimumWidth = 6;
            this.Downpayment.Name = "Downpayment";
            this.Downpayment.Width = 125;
            // 
            // No_of_Installments
            // 
            this.No_of_Installments.HeaderText = "No of Installments";
            this.No_of_Installments.MinimumWidth = 6;
            this.No_of_Installments.Name = "No_of_Installments";
            this.No_of_Installments.Width = 125;
            // 
            // lbl_AddItems
            // 
            this.lbl_AddItems.AutoSize = true;
            this.lbl_AddItems.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AddItems.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AddItems.Location = new System.Drawing.Point(9, 23);
            this.lbl_AddItems.Name = "lbl_AddItems";
            this.lbl_AddItems.Size = new System.Drawing.Size(154, 21);
            this.lbl_AddItems.TabIndex = 126;
            this.lbl_AddItems.Text = "Add Items to Receipt";
            // 
            // View_Receipts
            // 
            this.View_Receipts.Controls.Add(this.btn_search2);
            this.View_Receipts.Controls.Add(this.reportViewer_View_Receipts);
            this.View_Receipts.Controls.Add(this.txt_View_Receipt_No);
            this.View_Receipts.Controls.Add(this.lbl_View_Rec);
            this.View_Receipts.HorizontalScrollbarBarColor = true;
            this.View_Receipts.HorizontalScrollbarHighlightOnWheel = false;
            this.View_Receipts.HorizontalScrollbarSize = 10;
            this.View_Receipts.Location = new System.Drawing.Point(4, 38);
            this.View_Receipts.Name = "View_Receipts";
            this.View_Receipts.Size = new System.Drawing.Size(1038, 543);
            this.View_Receipts.TabIndex = 1;
            this.View_Receipts.Text = "View Receipts   ";
            this.View_Receipts.VerticalScrollbarBarColor = true;
            this.View_Receipts.VerticalScrollbarHighlightOnWheel = false;
            this.View_Receipts.VerticalScrollbarSize = 10;
            // 
            // btn_search2
            // 
            this.btn_search2.BackColor = System.Drawing.Color.Transparent;
            this.btn_search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search2.BackgroundImage")));
            this.btn_search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search2.FlatAppearance.BorderSize = 0;
            this.btn_search2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search2.Location = new System.Drawing.Point(992, 21);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(27, 26);
            this.btn_search2.TabIndex = 147;
            this.btn_search2.UseVisualStyleBackColor = false;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // reportViewer_View_Receipts
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Customer_DetailBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataTable_FullBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.DataTable_InsBindingSource;
            this.reportViewer_View_Receipts.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_View_Receipts.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_View_Receipts.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer_View_Receipts.LocalReport.ReportEmbeddedResource = "Furniture_System.Report_Receipt.rdlc";
            this.reportViewer_View_Receipts.Location = new System.Drawing.Point(3, 69);
            this.reportViewer_View_Receipts.Name = "reportViewer_View_Receipts";
            this.reportViewer_View_Receipts.ServerReport.BearerToken = null;
            this.reportViewer_View_Receipts.Size = new System.Drawing.Size(1035, 474);
            this.reportViewer_View_Receipts.TabIndex = 146;
            // 
            // txt_View_Receipt_No
            // 
            // 
            // 
            // 
            this.txt_View_Receipt_No.CustomButton.Image = null;
            this.txt_View_Receipt_No.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_View_Receipt_No.CustomButton.Name = "";
            this.txt_View_Receipt_No.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_View_Receipt_No.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_View_Receipt_No.CustomButton.TabIndex = 1;
            this.txt_View_Receipt_No.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_View_Receipt_No.CustomButton.UseSelectable = true;
            this.txt_View_Receipt_No.CustomButton.Visible = false;
            this.txt_View_Receipt_No.Lines = new string[0];
            this.txt_View_Receipt_No.Location = new System.Drawing.Point(765, 21);
            this.txt_View_Receipt_No.MaxLength = 32767;
            this.txt_View_Receipt_No.Name = "txt_View_Receipt_No";
            this.txt_View_Receipt_No.PasswordChar = '\0';
            this.txt_View_Receipt_No.PromptText = "Receipt No";
            this.txt_View_Receipt_No.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_View_Receipt_No.SelectedText = "";
            this.txt_View_Receipt_No.SelectionLength = 0;
            this.txt_View_Receipt_No.SelectionStart = 0;
            this.txt_View_Receipt_No.ShortcutsEnabled = true;
            this.txt_View_Receipt_No.Size = new System.Drawing.Size(208, 25);
            this.txt_View_Receipt_No.TabIndex = 145;
            this.txt_View_Receipt_No.UseSelectable = true;
            this.txt_View_Receipt_No.WaterMark = "Receipt No";
            this.txt_View_Receipt_No.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_View_Receipt_No.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_View_Rec
            // 
            this.lbl_View_Rec.AutoSize = true;
            this.lbl_View_Rec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_Rec.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Rec.Location = new System.Drawing.Point(9, 23);
            this.lbl_View_Rec.Name = "lbl_View_Rec";
            this.lbl_View_Rec.Size = new System.Drawing.Size(106, 21);
            this.lbl_View_Rec.TabIndex = 127;
            this.lbl_View_Rec.Text = "View Receipts";
            // 
            // btn_Back
            // 
            this.btn_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Back.BackgroundImage")));
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(16, 73);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(30, 34);
            this.btn_Back.TabIndex = 18;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(52, 78);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(47, 23);
            this.lbl_Customer.TabIndex = 16;
            this.lbl_Customer.Text = "Back";
            // 
            // Customer_DetailTableAdapter
            // 
            this.Customer_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_FullTableAdapter
            // 
            this.DataTable_FullTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_InsTableAdapter
            // 
            this.DataTable_InsTableAdapter.ClearBeforeFill = true;
            // 
            // OSMO_Print_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.TabControl_Reports);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OSMO_Print_Bill";
            this.Resizable = false;
            this.Text = "Print Receipt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OSMO_Print_Bill_FormClosing);
            this.Load += new System.EventHandler(this.OSMO_Print_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_FullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            this.TabControl_Reports.ResumeLayout(false);
            this.Print_Receipt.ResumeLayout(false);
            this.Print_Receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Rec_Itms)).EndInit();
            this.View_Receipts.ResumeLayout(false);
            this.View_Receipts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl_Reports;
        private MetroFramework.Controls.MetroTabPage Print_Receipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Sub_Tot;
        private System.Windows.Forms.Label lbl_Tot_Full;
        private System.Windows.Forms.Label lbl_Tot_Down;
        private MetroFramework.Controls.MetroButton btn_clear_all;
        private System.Windows.Forms.Button btn_search;
        private MetroFramework.Controls.MetroTextBox txt_NIC;
        private MetroFramework.Controls.MetroTextBox txt_Receipt_No;
        private MetroFramework.Controls.MetroButton btn_Print;
        private MetroFramework.Controls.MetroButton btn_Add_Item;
        private MetroFramework.Controls.MetroButton btn_clear_Load;
        private MetroFramework.Controls.MetroTextBox txt_Discount_Pcnt;
        private MetroFramework.Controls.MetroTextBox txt_No_of_Ins;
        private MetroFramework.Controls.MetroTextBox txt_Downpayment;
        private System.Windows.Forms.Label lbl_Item_Name;
        private System.Windows.Forms.Label lbl_uPrice;
        private MetroFramework.Controls.MetroComboBox cmb_Str_Ldr_Name;
        private MetroFramework.Controls.MetroComboBox cmb_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private MetroFramework.Controls.MetroComboBox cmb_Item_Name;
        private MetroFramework.Controls.MetroComboBox cmb_Payment_Type;
        private System.Windows.Forms.Label lbl_Payment_Type;
        private MetroFramework.Controls.MetroGrid metroGrid_Rec_Itms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Load_or_Store;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Downpayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_of_Installments;
        private System.Windows.Forms.Label lbl_AddItems;
        private MetroFramework.Controls.MetroTabPage View_Receipts;
        private System.Windows.Forms.Button btn_search2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_View_Receipts;
        private MetroFramework.Controls.MetroTextBox txt_View_Receipt_No;
        private System.Windows.Forms.Label lbl_View_Rec;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Label lbl_Str_Ld_Name;
        private System.Windows.Forms.BindingSource Customer_DetailBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource DataTable_FullBindingSource;
        private DataSet2 DataSet2;
        private System.Windows.Forms.BindingSource DataTable_InsBindingSource;
        private DataSet3 DataSet3;
        private DataSet1TableAdapters.Customer_DetailTableAdapter Customer_DetailTableAdapter;
        private DataSet2TableAdapters.DataTable_FullTableAdapter DataTable_FullTableAdapter;
        private DataSet3TableAdapters.DataTable_InsTableAdapter DataTable_InsTableAdapter;
    }
}