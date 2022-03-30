namespace Furniture_System
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Customer_DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Furniture_System.DataSet1();
            this.DataTable_FullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Furniture_System.DataSet2();
            this.DataTable_InsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new Furniture_System.DataSet3();
            this.DataTable_Ins_DateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet4 = new Furniture_System.DataSet4();
            this.DataTable_PaidAmtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable_Cus_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable_SM_SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet8 = new Furniture_System.DataSet8();
            this.DataTable_SM_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl_Reports = new MetroFramework.Controls.MetroTabControl();
            this.Print_Receipt = new MetroFramework.Controls.MetroTabPage();
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
            this.lbl_Str_Ld_Name = new System.Windows.Forms.Label();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.ckbox_From_Store = new MetroFramework.Controls.MetroCheckBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.reportViewer_View_Receipts = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_View_Receipt_No = new MetroFramework.Controls.MetroTextBox();
            this.lbl_View_Rec = new System.Windows.Forms.Label();
            this.Ins_Report = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btn_View = new MetroFramework.Controls.MetroButton();
            this.lbl_To = new System.Windows.Forms.Label();
            this.lbl_From = new System.Windows.Forms.Label();
            this.metroDateTime_To = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_From = new MetroFramework.Controls.MetroDateTime();
            this.reportViewer_Ins_Rep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_search_Ins = new System.Windows.Forms.Button();
            this.txt_Rec_No = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Ins_Report = new System.Windows.Forms.Label();
            this.Ins_Receipt = new MetroFramework.Controls.MetroTabPage();
            this.txt_Status = new MetroFramework.Controls.MetroTextBox();
            this.btn_Remove = new MetroFramework.Controls.MetroButton();
            this.btn_Print_Ins_Receipt = new MetroFramework.Controls.MetroButton();
            this.btn_update = new MetroFramework.Controls.MetroButton();
            this.btn_clear_IRec = new MetroFramework.Controls.MetroButton();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Search_IRec = new System.Windows.Forms.Button();
            this.txt_Search_IRec = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid_Ins_Rec = new MetroFramework.Controls.MetroGrid();
            this.cmb_Status = new MetroFramework.Controls.MetroComboBox();
            this.txt_Ins_Amt = new MetroFramework.Controls.MetroTextBox();
            this.txt_Ins_Date = new MetroFramework.Controls.MetroTextBox();
            this.txt_IItem_No = new MetroFramework.Controls.MetroTextBox();
            this.txt_IRec_No = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Ins_Rec = new System.Windows.Forms.Label();
            this.Sales_Report = new MetroFramework.Controls.MetroTabPage();
            this.lbl_Salesman_Type = new System.Windows.Forms.Label();
            this.btn_Clear_SM = new MetroFramework.Controls.MetroButton();
            this.cmb_SM_Type = new MetroFramework.Controls.MetroComboBox();
            this.reportViewer_reportViewer_Sales_Rep = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbl_To_Date = new System.Windows.Forms.Label();
            this.lbl_From_Sales = new System.Windows.Forms.Label();
            this.metroDateTime_Sales_To = new MetroFramework.Controls.MetroDateTime();
            this.metroDateTime_Sales_From = new MetroFramework.Controls.MetroDateTime();
            this.btn_Search_SM = new System.Windows.Forms.Button();
            this.txt_SM_No = new MetroFramework.Controls.MetroTextBox();
            this.lbl_View_Sales = new System.Windows.Forms.Label();
            this.Stock_Balance = new MetroFramework.Controls.MetroTabPage();
            this.lbl_Str_Name = new System.Windows.Forms.Label();
            this.btn_Clear_Stock = new MetroFramework.Controls.MetroButton();
            this.btn_View_Stock = new MetroFramework.Controls.MetroButton();
            this.lbl_Str_Ld = new System.Windows.Forms.Label();
            this.cmb_Str_Ld = new MetroFramework.Controls.MetroComboBox();
            this.ckbox_Store = new MetroFramework.Controls.MetroCheckBox();
            this.ckbox_Load = new MetroFramework.Controls.MetroCheckBox();
            this.lbl_Stock_Bal = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.DataTable_Ins_DateTableAdapter = new Furniture_System.DataSet4TableAdapters.DataTable_Ins_DateTableAdapter();
            this.DataTable_PaidAmtTableAdapter = new Furniture_System.DataSet4TableAdapters.DataTable_PaidAmtTableAdapter();
            this.DataTable_Cus_InfoTableAdapter = new Furniture_System.DataSet4TableAdapters.DataTable_Cus_InfoTableAdapter();
            this.Customer_DetailTableAdapter = new Furniture_System.DataSet1TableAdapters.Customer_DetailTableAdapter();
            this.DataTable_InsTableAdapter = new Furniture_System.DataSet3TableAdapters.DataTable_InsTableAdapter();
            this.DataTable_FullTableAdapter = new Furniture_System.DataSet2TableAdapters.DataTable_FullTableAdapter();
            this.DataTable_SM_SalesTableAdapter = new Furniture_System.DataSet8TableAdapters.DataTable_SM_SalesTableAdapter();
            this.DataTable_SM_InfoTableAdapter = new Furniture_System.DataSet8TableAdapters.DataTable_SM_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_FullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Ins_DateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PaidAmtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Cus_InfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_SM_SalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_SM_InfoBindingSource)).BeginInit();
            this.TabControl_Reports.SuspendLayout();
            this.Print_Receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Rec_Itms)).BeginInit();
            this.View_Receipts.SuspendLayout();
            this.Ins_Report.SuspendLayout();
            this.Ins_Receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Ins_Rec)).BeginInit();
            this.Sales_Report.SuspendLayout();
            this.Stock_Balance.SuspendLayout();
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
            // DataTable_Ins_DateBindingSource
            // 
            this.DataTable_Ins_DateBindingSource.DataMember = "DataTable_Ins_Date";
            this.DataTable_Ins_DateBindingSource.DataSource = this.DataSet4;
            // 
            // DataSet4
            // 
            this.DataSet4.DataSetName = "DataSet4";
            this.DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_PaidAmtBindingSource
            // 
            this.DataTable_PaidAmtBindingSource.DataMember = "DataTable_PaidAmt";
            this.DataTable_PaidAmtBindingSource.DataSource = this.DataSet4;
            // 
            // DataTable_Cus_InfoBindingSource
            // 
            this.DataTable_Cus_InfoBindingSource.DataMember = "DataTable_Cus_Info";
            this.DataTable_Cus_InfoBindingSource.DataSource = this.DataSet4;
            // 
            // DataTable_SM_SalesBindingSource
            // 
            this.DataTable_SM_SalesBindingSource.DataMember = "DataTable_SM_Sales";
            this.DataTable_SM_SalesBindingSource.DataSource = this.DataSet8;
            // 
            // DataSet8
            // 
            this.DataSet8.DataSetName = "DataSet8";
            this.DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_SM_InfoBindingSource
            // 
            this.DataTable_SM_InfoBindingSource.DataMember = "DataTable_SM_Info";
            this.DataTable_SM_InfoBindingSource.DataSource = this.DataSet8;
            // 
            // TabControl_Reports
            // 
            this.TabControl_Reports.Controls.Add(this.Print_Receipt);
            this.TabControl_Reports.Controls.Add(this.View_Receipts);
            this.TabControl_Reports.Controls.Add(this.Ins_Report);
            this.TabControl_Reports.Controls.Add(this.Ins_Receipt);
            this.TabControl_Reports.Controls.Add(this.Sales_Report);
            this.TabControl_Reports.Controls.Add(this.Stock_Balance);
            this.TabControl_Reports.Location = new System.Drawing.Point(0, 113);
            this.TabControl_Reports.Name = "TabControl_Reports";
            this.TabControl_Reports.SelectedIndex = 0;
            this.TabControl_Reports.Size = new System.Drawing.Size(1046, 585);
            this.TabControl_Reports.TabIndex = 11;
            this.TabControl_Reports.UseSelectable = true;
            // 
            // Print_Receipt
            // 
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
            this.Print_Receipt.Controls.Add(this.lbl_Str_Ld_Name);
            this.Print_Receipt.Controls.Add(this.lbl_Item_Name);
            this.Print_Receipt.Controls.Add(this.ckbox_From_Store);
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
            this.Print_Receipt.Click += new System.EventHandler(this.Print_Receipt_Click);
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
            this.txt_Discount_Pcnt.Click += new System.EventHandler(this.txt_Discount_Pcnt_Click);
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
            // lbl_Str_Ld_Name
            // 
            this.lbl_Str_Ld_Name.AutoSize = true;
            this.lbl_Str_Ld_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Str_Ld_Name.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Str_Ld_Name.Location = new System.Drawing.Point(678, 361);
            this.lbl_Str_Ld_Name.Name = "lbl_Str_Ld_Name";
            this.lbl_Str_Ld_Name.Size = new System.Drawing.Size(0, 21);
            this.lbl_Str_Ld_Name.TabIndex = 137;
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
            // ckbox_From_Store
            // 
            this.ckbox_From_Store.AutoSize = true;
            this.ckbox_From_Store.Location = new System.Drawing.Point(564, 331);
            this.ckbox_From_Store.Name = "ckbox_From_Store";
            this.ckbox_From_Store.Size = new System.Drawing.Size(89, 17);
            this.ckbox_From_Store.TabIndex = 135;
            this.ckbox_From_Store.Text = "From Store";
            this.ckbox_From_Store.UseSelectable = true;
            this.ckbox_From_Store.CheckedChanged += new System.EventHandler(this.ckbox_From_Store_CheckedChanged);
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
            this.View_Receipts.Controls.Add(this.button1);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(994, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 26);
            this.button1.TabIndex = 148;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_search2
            // 
            this.btn_search2.BackColor = System.Drawing.Color.Transparent;
            this.btn_search2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search2.BackgroundImage")));
            this.btn_search2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search2.FlatAppearance.BorderSize = 0;
            this.btn_search2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search2.Location = new System.Drawing.Point(952, 23);
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
            this.txt_View_Receipt_No.Location = new System.Drawing.Point(725, 23);
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
            // Ins_Report
            // 
            this.Ins_Report.Controls.Add(this.metroButton1);
            this.Ins_Report.Controls.Add(this.btn_View);
            this.Ins_Report.Controls.Add(this.lbl_To);
            this.Ins_Report.Controls.Add(this.lbl_From);
            this.Ins_Report.Controls.Add(this.metroDateTime_To);
            this.Ins_Report.Controls.Add(this.metroDateTime_From);
            this.Ins_Report.Controls.Add(this.reportViewer_Ins_Rep);
            this.Ins_Report.Controls.Add(this.btn_search_Ins);
            this.Ins_Report.Controls.Add(this.txt_Rec_No);
            this.Ins_Report.Controls.Add(this.lbl_Ins_Report);
            this.Ins_Report.HorizontalScrollbarBarColor = true;
            this.Ins_Report.HorizontalScrollbarHighlightOnWheel = false;
            this.Ins_Report.HorizontalScrollbarSize = 10;
            this.Ins_Report.Location = new System.Drawing.Point(4, 38);
            this.Ins_Report.Name = "Ins_Report";
            this.Ins_Report.Size = new System.Drawing.Size(1038, 543);
            this.Ins_Report.TabIndex = 2;
            this.Ins_Report.Text = "Installment Report   ";
            this.Ins_Report.VerticalScrollbarBarColor = true;
            this.Ins_Report.VerticalScrollbarHighlightOnWheel = false;
            this.Ins_Report.VerticalScrollbarSize = 10;
            this.Ins_Report.Click += new System.EventHandler(this.Ins_Report_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(917, 44);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(100, 53);
            this.metroButton1.TabIndex = 155;
            this.metroButton1.Text = "Clear";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btn_View
            // 
            this.btn_View.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_View.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_View.Location = new System.Drawing.Point(792, 44);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(100, 53);
            this.btn_View.TabIndex = 154;
            this.btn_View.Text = "View";
            this.btn_View.UseSelectable = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // lbl_To
            // 
            this.lbl_To.AutoSize = true;
            this.lbl_To.BackColor = System.Drawing.Color.Transparent;
            this.lbl_To.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To.Location = new System.Drawing.Point(591, 32);
            this.lbl_To.Name = "lbl_To";
            this.lbl_To.Size = new System.Drawing.Size(63, 21);
            this.lbl_To.TabIndex = 153;
            this.lbl_To.Text = "To Date";
            // 
            // lbl_From
            // 
            this.lbl_From.AutoSize = true;
            this.lbl_From.BackColor = System.Drawing.Color.Transparent;
            this.lbl_From.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From.Location = new System.Drawing.Point(428, 32);
            this.lbl_From.Name = "lbl_From";
            this.lbl_From.Size = new System.Drawing.Size(84, 21);
            this.lbl_From.TabIndex = 152;
            this.lbl_From.Text = "From Date";
            // 
            // metroDateTime_To
            // 
            this.metroDateTime_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_To.Location = new System.Drawing.Point(595, 66);
            this.metroDateTime_To.MinimumSize = new System.Drawing.Size(4, 30);
            this.metroDateTime_To.Name = "metroDateTime_To";
            this.metroDateTime_To.Size = new System.Drawing.Size(147, 30);
            this.metroDateTime_To.TabIndex = 151;
            // 
            // metroDateTime_From
            // 
            this.metroDateTime_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_From.Location = new System.Drawing.Point(432, 66);
            this.metroDateTime_From.MinimumSize = new System.Drawing.Size(4, 30);
            this.metroDateTime_From.Name = "metroDateTime_From";
            this.metroDateTime_From.Size = new System.Drawing.Size(147, 30);
            this.metroDateTime_From.TabIndex = 150;
            // 
            // reportViewer_Ins_Rep
            // 
            reportDataSource4.Name = "DataSet4";
            reportDataSource4.Value = this.DataTable_Ins_DateBindingSource;
            reportDataSource5.Name = "DataSet5";
            reportDataSource5.Value = this.DataTable_PaidAmtBindingSource;
            reportDataSource6.Name = "DataSet6";
            reportDataSource6.Value = this.DataTable_Cus_InfoBindingSource;
            this.reportViewer_Ins_Rep.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer_Ins_Rep.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer_Ins_Rep.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer_Ins_Rep.LocalReport.ReportEmbeddedResource = "Furniture_System.Report2.rdlc";
            this.reportViewer_Ins_Rep.Location = new System.Drawing.Point(3, 113);
            this.reportViewer_Ins_Rep.Name = "reportViewer_Ins_Rep";
            this.reportViewer_Ins_Rep.ServerReport.BearerToken = null;
            this.reportViewer_Ins_Rep.Size = new System.Drawing.Size(1035, 430);
            this.reportViewer_Ins_Rep.TabIndex = 149;
            // 
            // btn_search_Ins
            // 
            this.btn_search_Ins.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_Ins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_Ins.BackgroundImage")));
            this.btn_search_Ins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search_Ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_Ins.FlatAppearance.BorderSize = 0;
            this.btn_search_Ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_Ins.Location = new System.Drawing.Point(238, 71);
            this.btn_search_Ins.Name = "btn_search_Ins";
            this.btn_search_Ins.Size = new System.Drawing.Size(27, 26);
            this.btn_search_Ins.TabIndex = 148;
            this.btn_search_Ins.UseVisualStyleBackColor = false;
            this.btn_search_Ins.Click += new System.EventHandler(this.btn_search_Ins_Click);
            // 
            // txt_Rec_No
            // 
            // 
            // 
            // 
            this.txt_Rec_No.CustomButton.Image = null;
            this.txt_Rec_No.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_Rec_No.CustomButton.Name = "";
            this.txt_Rec_No.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Rec_No.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Rec_No.CustomButton.TabIndex = 1;
            this.txt_Rec_No.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Rec_No.CustomButton.UseSelectable = true;
            this.txt_Rec_No.CustomButton.Visible = false;
            this.txt_Rec_No.Lines = new string[0];
            this.txt_Rec_No.Location = new System.Drawing.Point(13, 71);
            this.txt_Rec_No.MaxLength = 32767;
            this.txt_Rec_No.Name = "txt_Rec_No";
            this.txt_Rec_No.PasswordChar = '\0';
            this.txt_Rec_No.PromptText = "Receipt No";
            this.txt_Rec_No.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Rec_No.SelectedText = "";
            this.txt_Rec_No.SelectionLength = 0;
            this.txt_Rec_No.SelectionStart = 0;
            this.txt_Rec_No.ShortcutsEnabled = true;
            this.txt_Rec_No.Size = new System.Drawing.Size(208, 25);
            this.txt_Rec_No.TabIndex = 147;
            this.txt_Rec_No.UseSelectable = true;
            this.txt_Rec_No.WaterMark = "Receipt No";
            this.txt_Rec_No.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Rec_No.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Ins_Report
            // 
            this.lbl_Ins_Report.AutoSize = true;
            this.lbl_Ins_Report.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ins_Report.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ins_Report.Location = new System.Drawing.Point(9, 23);
            this.lbl_Ins_Report.Name = "lbl_Ins_Report";
            this.lbl_Ins_Report.Size = new System.Drawing.Size(133, 21);
            this.lbl_Ins_Report.TabIndex = 128;
            this.lbl_Ins_Report.Text = "View Installments";
            // 
            // Ins_Receipt
            // 
            this.Ins_Receipt.Controls.Add(this.txt_Status);
            this.Ins_Receipt.Controls.Add(this.btn_Remove);
            this.Ins_Receipt.Controls.Add(this.btn_Print_Ins_Receipt);
            this.Ins_Receipt.Controls.Add(this.btn_update);
            this.Ins_Receipt.Controls.Add(this.btn_clear_IRec);
            this.Ins_Receipt.Controls.Add(this.lbl_Status);
            this.Ins_Receipt.Controls.Add(this.btn_Search_IRec);
            this.Ins_Receipt.Controls.Add(this.txt_Search_IRec);
            this.Ins_Receipt.Controls.Add(this.metroGrid_Ins_Rec);
            this.Ins_Receipt.Controls.Add(this.cmb_Status);
            this.Ins_Receipt.Controls.Add(this.txt_Ins_Amt);
            this.Ins_Receipt.Controls.Add(this.txt_Ins_Date);
            this.Ins_Receipt.Controls.Add(this.txt_IItem_No);
            this.Ins_Receipt.Controls.Add(this.txt_IRec_No);
            this.Ins_Receipt.Controls.Add(this.lbl_Ins_Rec);
            this.Ins_Receipt.HorizontalScrollbarBarColor = true;
            this.Ins_Receipt.HorizontalScrollbarHighlightOnWheel = false;
            this.Ins_Receipt.HorizontalScrollbarSize = 10;
            this.Ins_Receipt.Location = new System.Drawing.Point(4, 38);
            this.Ins_Receipt.Name = "Ins_Receipt";
            this.Ins_Receipt.Size = new System.Drawing.Size(1038, 543);
            this.Ins_Receipt.TabIndex = 3;
            this.Ins_Receipt.Text = "Installment Receipt   ";
            this.Ins_Receipt.VerticalScrollbarBarColor = true;
            this.Ins_Receipt.VerticalScrollbarHighlightOnWheel = false;
            this.Ins_Receipt.VerticalScrollbarSize = 10;
            // 
            // txt_Status
            // 
            // 
            // 
            // 
            this.txt_Status.CustomButton.Image = null;
            this.txt_Status.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_Status.CustomButton.Name = "";
            this.txt_Status.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Status.CustomButton.TabIndex = 1;
            this.txt_Status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Status.CustomButton.UseSelectable = true;
            this.txt_Status.CustomButton.Visible = false;
            this.txt_Status.Enabled = false;
            this.txt_Status.Lines = new string[0];
            this.txt_Status.Location = new System.Drawing.Point(11, 275);
            this.txt_Status.MaxLength = 32767;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.PasswordChar = '\0';
            this.txt_Status.PromptText = "Current Status";
            this.txt_Status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Status.SelectedText = "";
            this.txt_Status.SelectionLength = 0;
            this.txt_Status.SelectionStart = 0;
            this.txt_Status.ShortcutsEnabled = true;
            this.txt_Status.Size = new System.Drawing.Size(196, 25);
            this.txt_Status.TabIndex = 144;
            this.txt_Status.UseSelectable = true;
            this.txt_Status.WaterMark = "Current Status";
            this.txt_Status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_Remove
            // 
            this.btn_Remove.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Remove.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_Remove.Location = new System.Drawing.Point(772, 445);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(100, 53);
            this.btn_Remove.TabIndex = 143;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseSelectable = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Print_Ins_Receipt
            // 
            this.btn_Print_Ins_Receipt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Print_Ins_Receipt.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_Print_Ins_Receipt.Location = new System.Drawing.Point(493, 445);
            this.btn_Print_Ins_Receipt.Name = "btn_Print_Ins_Receipt";
            this.btn_Print_Ins_Receipt.Size = new System.Drawing.Size(134, 53);
            this.btn_Print_Ins_Receipt.TabIndex = 142;
            this.btn_Print_Ins_Receipt.Text = "Print Receipt";
            this.btn_Print_Ins_Receipt.UseSelectable = true;
            this.btn_Print_Ins_Receipt.Click += new System.EventHandler(this.btn_Print_Ins_Receipt_Click);
            // 
            // btn_update
            // 
            this.btn_update.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_update.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_update.Location = new System.Drawing.Point(652, 445);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(100, 53);
            this.btn_update.TabIndex = 141;
            this.btn_update.Text = "Update";
            this.btn_update.UseSelectable = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear_IRec
            // 
            this.btn_clear_IRec.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_clear_IRec.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_clear_IRec.Location = new System.Drawing.Point(893, 445);
            this.btn_clear_IRec.Name = "btn_clear_IRec";
            this.btn_clear_IRec.Size = new System.Drawing.Size(100, 53);
            this.btn_clear_IRec.TabIndex = 139;
            this.btn_clear_IRec.Text = "Clear";
            this.btn_clear_IRec.UseSelectable = true;
            this.btn_clear_IRec.Click += new System.EventHandler(this.btn_clear_IRec_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(10, 323);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(92, 17);
            this.lbl_Status.TabIndex = 138;
            this.lbl_Status.Text = "Select Status :";
            // 
            // btn_Search_IRec
            // 
            this.btn_Search_IRec.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search_IRec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search_IRec.BackgroundImage")));
            this.btn_Search_IRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search_IRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_IRec.FlatAppearance.BorderSize = 0;
            this.btn_Search_IRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_IRec.Location = new System.Drawing.Point(999, 19);
            this.btn_Search_IRec.Name = "btn_Search_IRec";
            this.btn_Search_IRec.Size = new System.Drawing.Size(27, 26);
            this.btn_Search_IRec.TabIndex = 137;
            this.btn_Search_IRec.UseVisualStyleBackColor = false;
            this.btn_Search_IRec.Click += new System.EventHandler(this.btn_Search_IRec_Click);
            // 
            // txt_Search_IRec
            // 
            // 
            // 
            // 
            this.txt_Search_IRec.CustomButton.Image = null;
            this.txt_Search_IRec.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_Search_IRec.CustomButton.Name = "";
            this.txt_Search_IRec.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Search_IRec.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Search_IRec.CustomButton.TabIndex = 1;
            this.txt_Search_IRec.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Search_IRec.CustomButton.UseSelectable = true;
            this.txt_Search_IRec.CustomButton.Visible = false;
            this.txt_Search_IRec.Lines = new string[0];
            this.txt_Search_IRec.Location = new System.Drawing.Point(785, 19);
            this.txt_Search_IRec.MaxLength = 32767;
            this.txt_Search_IRec.Name = "txt_Search_IRec";
            this.txt_Search_IRec.PasswordChar = '\0';
            this.txt_Search_IRec.PromptText = "Receipt No";
            this.txt_Search_IRec.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Search_IRec.SelectedText = "";
            this.txt_Search_IRec.SelectionLength = 0;
            this.txt_Search_IRec.SelectionStart = 0;
            this.txt_Search_IRec.ShortcutsEnabled = true;
            this.txt_Search_IRec.Size = new System.Drawing.Size(208, 25);
            this.txt_Search_IRec.TabIndex = 136;
            this.txt_Search_IRec.UseSelectable = true;
            this.txt_Search_IRec.WaterMark = "Receipt No";
            this.txt_Search_IRec.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Search_IRec.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid_Ins_Rec
            // 
            this.metroGrid_Ins_Rec.AllowUserToResizeRows = false;
            this.metroGrid_Ins_Rec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Ins_Rec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid_Ins_Rec.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid_Ins_Rec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Ins_Rec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid_Ins_Rec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_Ins_Rec.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid_Ins_Rec.EnableHeadersVisualStyles = false;
            this.metroGrid_Ins_Rec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_Ins_Rec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Ins_Rec.Location = new System.Drawing.Point(261, 51);
            this.metroGrid_Ins_Rec.Name = "metroGrid_Ins_Rec";
            this.metroGrid_Ins_Rec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Ins_Rec.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid_Ins_Rec.RowHeadersWidth = 51;
            this.metroGrid_Ins_Rec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid_Ins_Rec.RowTemplate.Height = 24;
            this.metroGrid_Ins_Rec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid_Ins_Rec.Size = new System.Drawing.Size(765, 316);
            this.metroGrid_Ins_Rec.TabIndex = 135;
            this.metroGrid_Ins_Rec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_Ins_Rec_CellClick);
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.ItemHeight = 24;
            this.cmb_Status.Items.AddRange(new object[] {
            "Paid",
            "Not Paid"});
            this.cmb_Status.Location = new System.Drawing.Point(11, 357);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(196, 30);
            this.cmb_Status.TabIndex = 134;
            this.cmb_Status.UseSelectable = true;
            // 
            // txt_Ins_Amt
            // 
            // 
            // 
            // 
            this.txt_Ins_Amt.CustomButton.Image = null;
            this.txt_Ins_Amt.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_Ins_Amt.CustomButton.Name = "";
            this.txt_Ins_Amt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Ins_Amt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Ins_Amt.CustomButton.TabIndex = 1;
            this.txt_Ins_Amt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Ins_Amt.CustomButton.UseSelectable = true;
            this.txt_Ins_Amt.CustomButton.Visible = false;
            this.txt_Ins_Amt.Enabled = false;
            this.txt_Ins_Amt.Lines = new string[0];
            this.txt_Ins_Amt.Location = new System.Drawing.Point(11, 227);
            this.txt_Ins_Amt.MaxLength = 32767;
            this.txt_Ins_Amt.Name = "txt_Ins_Amt";
            this.txt_Ins_Amt.PasswordChar = '\0';
            this.txt_Ins_Amt.PromptText = "Installment Amount";
            this.txt_Ins_Amt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Ins_Amt.SelectedText = "";
            this.txt_Ins_Amt.SelectionLength = 0;
            this.txt_Ins_Amt.SelectionStart = 0;
            this.txt_Ins_Amt.ShortcutsEnabled = true;
            this.txt_Ins_Amt.Size = new System.Drawing.Size(196, 25);
            this.txt_Ins_Amt.TabIndex = 133;
            this.txt_Ins_Amt.UseSelectable = true;
            this.txt_Ins_Amt.WaterMark = "Installment Amount";
            this.txt_Ins_Amt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Ins_Amt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_Ins_Date
            // 
            // 
            // 
            // 
            this.txt_Ins_Date.CustomButton.Image = null;
            this.txt_Ins_Date.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_Ins_Date.CustomButton.Name = "";
            this.txt_Ins_Date.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_Ins_Date.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_Ins_Date.CustomButton.TabIndex = 1;
            this.txt_Ins_Date.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_Ins_Date.CustomButton.UseSelectable = true;
            this.txt_Ins_Date.CustomButton.Visible = false;
            this.txt_Ins_Date.Enabled = false;
            this.txt_Ins_Date.Lines = new string[0];
            this.txt_Ins_Date.Location = new System.Drawing.Point(11, 178);
            this.txt_Ins_Date.MaxLength = 32767;
            this.txt_Ins_Date.Name = "txt_Ins_Date";
            this.txt_Ins_Date.PasswordChar = '\0';
            this.txt_Ins_Date.PromptText = "Installment Date";
            this.txt_Ins_Date.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_Ins_Date.SelectedText = "";
            this.txt_Ins_Date.SelectionLength = 0;
            this.txt_Ins_Date.SelectionStart = 0;
            this.txt_Ins_Date.ShortcutsEnabled = true;
            this.txt_Ins_Date.Size = new System.Drawing.Size(196, 25);
            this.txt_Ins_Date.TabIndex = 132;
            this.txt_Ins_Date.UseSelectable = true;
            this.txt_Ins_Date.WaterMark = "Installment Date";
            this.txt_Ins_Date.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_Ins_Date.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_IItem_No
            // 
            // 
            // 
            // 
            this.txt_IItem_No.CustomButton.Image = null;
            this.txt_IItem_No.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_IItem_No.CustomButton.Name = "";
            this.txt_IItem_No.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_IItem_No.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_IItem_No.CustomButton.TabIndex = 1;
            this.txt_IItem_No.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_IItem_No.CustomButton.UseSelectable = true;
            this.txt_IItem_No.CustomButton.Visible = false;
            this.txt_IItem_No.Enabled = false;
            this.txt_IItem_No.Lines = new string[0];
            this.txt_IItem_No.Location = new System.Drawing.Point(11, 129);
            this.txt_IItem_No.MaxLength = 32767;
            this.txt_IItem_No.Name = "txt_IItem_No";
            this.txt_IItem_No.PasswordChar = '\0';
            this.txt_IItem_No.PromptText = "Item No";
            this.txt_IItem_No.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_IItem_No.SelectedText = "";
            this.txt_IItem_No.SelectionLength = 0;
            this.txt_IItem_No.SelectionStart = 0;
            this.txt_IItem_No.ShortcutsEnabled = true;
            this.txt_IItem_No.Size = new System.Drawing.Size(196, 25);
            this.txt_IItem_No.TabIndex = 131;
            this.txt_IItem_No.UseSelectable = true;
            this.txt_IItem_No.WaterMark = "Item No";
            this.txt_IItem_No.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_IItem_No.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_IRec_No
            // 
            // 
            // 
            // 
            this.txt_IRec_No.CustomButton.Image = null;
            this.txt_IRec_No.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.txt_IRec_No.CustomButton.Name = "";
            this.txt_IRec_No.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_IRec_No.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_IRec_No.CustomButton.TabIndex = 1;
            this.txt_IRec_No.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_IRec_No.CustomButton.UseSelectable = true;
            this.txt_IRec_No.CustomButton.Visible = false;
            this.txt_IRec_No.Enabled = false;
            this.txt_IRec_No.Lines = new string[0];
            this.txt_IRec_No.Location = new System.Drawing.Point(12, 80);
            this.txt_IRec_No.MaxLength = 32767;
            this.txt_IRec_No.Name = "txt_IRec_No";
            this.txt_IRec_No.PasswordChar = '\0';
            this.txt_IRec_No.PromptText = "Receipt No";
            this.txt_IRec_No.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_IRec_No.SelectedText = "";
            this.txt_IRec_No.SelectionLength = 0;
            this.txt_IRec_No.SelectionStart = 0;
            this.txt_IRec_No.ShortcutsEnabled = true;
            this.txt_IRec_No.Size = new System.Drawing.Size(196, 25);
            this.txt_IRec_No.TabIndex = 130;
            this.txt_IRec_No.UseSelectable = true;
            this.txt_IRec_No.WaterMark = "Receipt No";
            this.txt_IRec_No.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_IRec_No.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_Ins_Rec
            // 
            this.lbl_Ins_Rec.AutoSize = true;
            this.lbl_Ins_Rec.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ins_Rec.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ins_Rec.Location = new System.Drawing.Point(9, 23);
            this.lbl_Ins_Rec.Name = "lbl_Ins_Rec";
            this.lbl_Ins_Rec.Size = new System.Drawing.Size(147, 21);
            this.lbl_Ins_Rec.TabIndex = 129;
            this.lbl_Ins_Rec.Text = "Installment Receipt ";
            // 
            // Sales_Report
            // 
            this.Sales_Report.Controls.Add(this.lbl_Salesman_Type);
            this.Sales_Report.Controls.Add(this.btn_Clear_SM);
            this.Sales_Report.Controls.Add(this.cmb_SM_Type);
            this.Sales_Report.Controls.Add(this.reportViewer_reportViewer_Sales_Rep);
            this.Sales_Report.Controls.Add(this.lbl_To_Date);
            this.Sales_Report.Controls.Add(this.lbl_From_Sales);
            this.Sales_Report.Controls.Add(this.metroDateTime_Sales_To);
            this.Sales_Report.Controls.Add(this.metroDateTime_Sales_From);
            this.Sales_Report.Controls.Add(this.btn_Search_SM);
            this.Sales_Report.Controls.Add(this.txt_SM_No);
            this.Sales_Report.Controls.Add(this.lbl_View_Sales);
            this.Sales_Report.HorizontalScrollbarBarColor = true;
            this.Sales_Report.HorizontalScrollbarHighlightOnWheel = false;
            this.Sales_Report.HorizontalScrollbarSize = 10;
            this.Sales_Report.Location = new System.Drawing.Point(4, 38);
            this.Sales_Report.Name = "Sales_Report";
            this.Sales_Report.Size = new System.Drawing.Size(1038, 543);
            this.Sales_Report.TabIndex = 4;
            this.Sales_Report.Text = "Sales Report   ";
            this.Sales_Report.VerticalScrollbarBarColor = true;
            this.Sales_Report.VerticalScrollbarHighlightOnWheel = false;
            this.Sales_Report.VerticalScrollbarSize = 10;
            // 
            // lbl_Salesman_Type
            // 
            this.lbl_Salesman_Type.AutoSize = true;
            this.lbl_Salesman_Type.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Salesman_Type.Enabled = false;
            this.lbl_Salesman_Type.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salesman_Type.Location = new System.Drawing.Point(370, 63);
            this.lbl_Salesman_Type.Name = "lbl_Salesman_Type";
            this.lbl_Salesman_Type.Size = new System.Drawing.Size(112, 21);
            this.lbl_Salesman_Type.TabIndex = 166;
            this.lbl_Salesman_Type.Text = "Salesman Type";
            this.lbl_Salesman_Type.Visible = false;
            // 
            // btn_Clear_SM
            // 
            this.btn_Clear_SM.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Clear_SM.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_Clear_SM.Location = new System.Drawing.Point(919, 74);
            this.btn_Clear_SM.Name = "btn_Clear_SM";
            this.btn_Clear_SM.Size = new System.Drawing.Size(100, 53);
            this.btn_Clear_SM.TabIndex = 165;
            this.btn_Clear_SM.Text = "Clear";
            this.btn_Clear_SM.UseSelectable = true;
            this.btn_Clear_SM.Click += new System.EventHandler(this.btn_Clear_SM_Click);
            // 
            // cmb_SM_Type
            // 
            this.cmb_SM_Type.Enabled = false;
            this.cmb_SM_Type.FormattingEnabled = true;
            this.cmb_SM_Type.ItemHeight = 24;
            this.cmb_SM_Type.Items.AddRange(new object[] {
            "Salesman Officer",
            "Outlet Salesman Officer",
            "Recovery Officer"});
            this.cmb_SM_Type.Location = new System.Drawing.Point(374, 97);
            this.cmb_SM_Type.Name = "cmb_SM_Type";
            this.cmb_SM_Type.Size = new System.Drawing.Size(241, 30);
            this.cmb_SM_Type.TabIndex = 164;
            this.cmb_SM_Type.UseSelectable = true;
            this.cmb_SM_Type.Visible = false;
            // 
            // reportViewer_reportViewer_Sales_Rep
            // 
            reportDataSource7.Name = "DataSet8";
            reportDataSource7.Value = this.DataTable_SM_SalesBindingSource;
            reportDataSource8.Name = "DataSet9";
            reportDataSource8.Value = this.DataTable_SM_InfoBindingSource;
            this.reportViewer_reportViewer_Sales_Rep.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer_reportViewer_Sales_Rep.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer_reportViewer_Sales_Rep.LocalReport.ReportEmbeddedResource = "Furniture_System.Report6.rdlc";
            this.reportViewer_reportViewer_Sales_Rep.Location = new System.Drawing.Point(0, 154);
            this.reportViewer_reportViewer_Sales_Rep.Name = "reportViewer_reportViewer_Sales_Rep";
            this.reportViewer_reportViewer_Sales_Rep.ServerReport.BearerToken = null;
            this.reportViewer_reportViewer_Sales_Rep.Size = new System.Drawing.Size(1038, 389);
            this.reportViewer_reportViewer_Sales_Rep.TabIndex = 163;
            // 
            // lbl_To_Date
            // 
            this.lbl_To_Date.AutoSize = true;
            this.lbl_To_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_To_Date.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_To_Date.Location = new System.Drawing.Point(191, 63);
            this.lbl_To_Date.Name = "lbl_To_Date";
            this.lbl_To_Date.Size = new System.Drawing.Size(63, 21);
            this.lbl_To_Date.TabIndex = 162;
            this.lbl_To_Date.Text = "To Date";
            // 
            // lbl_From_Sales
            // 
            this.lbl_From_Sales.AutoSize = true;
            this.lbl_From_Sales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_From_Sales.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_From_Sales.Location = new System.Drawing.Point(28, 63);
            this.lbl_From_Sales.Name = "lbl_From_Sales";
            this.lbl_From_Sales.Size = new System.Drawing.Size(84, 21);
            this.lbl_From_Sales.TabIndex = 161;
            this.lbl_From_Sales.Text = "From Date";
            // 
            // metroDateTime_Sales_To
            // 
            this.metroDateTime_Sales_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Sales_To.Location = new System.Drawing.Point(195, 97);
            this.metroDateTime_Sales_To.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime_Sales_To.Name = "metroDateTime_Sales_To";
            this.metroDateTime_Sales_To.Size = new System.Drawing.Size(147, 30);
            this.metroDateTime_Sales_To.TabIndex = 160;
            // 
            // metroDateTime_Sales_From
            // 
            this.metroDateTime_Sales_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime_Sales_From.Location = new System.Drawing.Point(32, 97);
            this.metroDateTime_Sales_From.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime_Sales_From.Name = "metroDateTime_Sales_From";
            this.metroDateTime_Sales_From.Size = new System.Drawing.Size(147, 30);
            this.metroDateTime_Sales_From.TabIndex = 159;
            // 
            // btn_Search_SM
            // 
            this.btn_Search_SM.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search_SM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Search_SM.BackgroundImage")));
            this.btn_Search_SM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Search_SM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_SM.FlatAppearance.BorderSize = 0;
            this.btn_Search_SM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_SM.Location = new System.Drawing.Point(865, 97);
            this.btn_Search_SM.Name = "btn_Search_SM";
            this.btn_Search_SM.Size = new System.Drawing.Size(27, 26);
            this.btn_Search_SM.TabIndex = 158;
            this.btn_Search_SM.UseVisualStyleBackColor = false;
            this.btn_Search_SM.Click += new System.EventHandler(this.btn_Search_SM_Click);
            // 
            // txt_SM_No
            // 
            // 
            // 
            // 
            this.txt_SM_No.CustomButton.Image = null;
            this.txt_SM_No.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txt_SM_No.CustomButton.Name = "";
            this.txt_SM_No.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_SM_No.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_SM_No.CustomButton.TabIndex = 1;
            this.txt_SM_No.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_SM_No.CustomButton.UseSelectable = true;
            this.txt_SM_No.CustomButton.Visible = false;
            this.txt_SM_No.Lines = new string[0];
            this.txt_SM_No.Location = new System.Drawing.Point(640, 97);
            this.txt_SM_No.MaxLength = 32767;
            this.txt_SM_No.Name = "txt_SM_No";
            this.txt_SM_No.PasswordChar = '\0';
            this.txt_SM_No.PromptText = "Salesman ID";
            this.txt_SM_No.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_SM_No.SelectedText = "";
            this.txt_SM_No.SelectionLength = 0;
            this.txt_SM_No.SelectionStart = 0;
            this.txt_SM_No.ShortcutsEnabled = true;
            this.txt_SM_No.Size = new System.Drawing.Size(208, 25);
            this.txt_SM_No.TabIndex = 157;
            this.txt_SM_No.UseSelectable = true;
            this.txt_SM_No.WaterMark = "Salesman ID";
            this.txt_SM_No.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_SM_No.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbl_View_Sales
            // 
            this.lbl_View_Sales.AutoSize = true;
            this.lbl_View_Sales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_Sales.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Sales.Location = new System.Drawing.Point(9, 23);
            this.lbl_View_Sales.Name = "lbl_View_Sales";
            this.lbl_View_Sales.Size = new System.Drawing.Size(83, 21);
            this.lbl_View_Sales.TabIndex = 156;
            this.lbl_View_Sales.Text = "View Sales";
            // 
            // Stock_Balance
            // 
            this.Stock_Balance.Controls.Add(this.lbl_Str_Name);
            this.Stock_Balance.Controls.Add(this.btn_Clear_Stock);
            this.Stock_Balance.Controls.Add(this.btn_View_Stock);
            this.Stock_Balance.Controls.Add(this.lbl_Str_Ld);
            this.Stock_Balance.Controls.Add(this.cmb_Str_Ld);
            this.Stock_Balance.Controls.Add(this.ckbox_Store);
            this.Stock_Balance.Controls.Add(this.ckbox_Load);
            this.Stock_Balance.Controls.Add(this.lbl_Stock_Bal);
            this.Stock_Balance.HorizontalScrollbarBarColor = true;
            this.Stock_Balance.HorizontalScrollbarHighlightOnWheel = false;
            this.Stock_Balance.HorizontalScrollbarSize = 10;
            this.Stock_Balance.Location = new System.Drawing.Point(4, 38);
            this.Stock_Balance.Name = "Stock_Balance";
            this.Stock_Balance.Size = new System.Drawing.Size(1038, 543);
            this.Stock_Balance.TabIndex = 5;
            this.Stock_Balance.Text = "Stock Balance   ";
            this.Stock_Balance.VerticalScrollbarBarColor = true;
            this.Stock_Balance.VerticalScrollbarHighlightOnWheel = false;
            this.Stock_Balance.VerticalScrollbarSize = 10;
            // 
            // lbl_Str_Name
            // 
            this.lbl_Str_Name.AutoSize = true;
            this.lbl_Str_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Str_Name.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Str_Name.Location = new System.Drawing.Point(227, 116);
            this.lbl_Str_Name.Name = "lbl_Str_Name";
            this.lbl_Str_Name.Size = new System.Drawing.Size(0, 21);
            this.lbl_Str_Name.TabIndex = 171;
            // 
            // btn_Clear_Stock
            // 
            this.btn_Clear_Stock.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Clear_Stock.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_Clear_Stock.Location = new System.Drawing.Point(571, 50);
            this.btn_Clear_Stock.Name = "btn_Clear_Stock";
            this.btn_Clear_Stock.Size = new System.Drawing.Size(100, 53);
            this.btn_Clear_Stock.TabIndex = 170;
            this.btn_Clear_Stock.Text = "Clear";
            this.btn_Clear_Stock.UseSelectable = true;
            this.btn_Clear_Stock.Click += new System.EventHandler(this.btn_Clear_Stock_Click);
            // 
            // btn_View_Stock
            // 
            this.btn_View_Stock.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_View_Stock.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_View_Stock.Location = new System.Drawing.Point(446, 50);
            this.btn_View_Stock.Name = "btn_View_Stock";
            this.btn_View_Stock.Size = new System.Drawing.Size(100, 53);
            this.btn_View_Stock.TabIndex = 169;
            this.btn_View_Stock.Text = "View";
            this.btn_View_Stock.UseSelectable = true;
            this.btn_View_Stock.Click += new System.EventHandler(this.btn_View_Stock_Click);
            // 
            // lbl_Str_Ld
            // 
            this.lbl_Str_Ld.AutoSize = true;
            this.lbl_Str_Ld.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Str_Ld.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Str_Ld.Location = new System.Drawing.Point(223, 39);
            this.lbl_Str_Ld.Name = "lbl_Str_Ld";
            this.lbl_Str_Ld.Size = new System.Drawing.Size(140, 21);
            this.lbl_Str_Ld.TabIndex = 168;
            this.lbl_Str_Ld.Text = "Select Load/Store :";
            // 
            // cmb_Str_Ld
            // 
            this.cmb_Str_Ld.FormattingEnabled = true;
            this.cmb_Str_Ld.ItemHeight = 24;
            this.cmb_Str_Ld.Location = new System.Drawing.Point(227, 73);
            this.cmb_Str_Ld.Name = "cmb_Str_Ld";
            this.cmb_Str_Ld.Size = new System.Drawing.Size(150, 30);
            this.cmb_Str_Ld.TabIndex = 167;
            this.cmb_Str_Ld.UseSelectable = true;
            this.cmb_Str_Ld.SelectedIndexChanged += new System.EventHandler(this.cmb_Str_Ld_SelectedIndexChanged);
            // 
            // ckbox_Store
            // 
            this.ckbox_Store.AutoSize = true;
            this.ckbox_Store.Location = new System.Drawing.Point(119, 80);
            this.ckbox_Store.Name = "ckbox_Store";
            this.ckbox_Store.Size = new System.Drawing.Size(55, 17);
            this.ckbox_Store.TabIndex = 159;
            this.ckbox_Store.Text = "Store";
            this.ckbox_Store.UseSelectable = true;
            this.ckbox_Store.CheckedChanged += new System.EventHandler(this.ckbox_Store_CheckedChanged);
            // 
            // ckbox_Load
            // 
            this.ckbox_Load.AutoSize = true;
            this.ckbox_Load.Location = new System.Drawing.Point(31, 80);
            this.ckbox_Load.Name = "ckbox_Load";
            this.ckbox_Load.Size = new System.Drawing.Size(53, 17);
            this.ckbox_Load.TabIndex = 158;
            this.ckbox_Load.Text = "Load";
            this.ckbox_Load.UseSelectable = true;
            this.ckbox_Load.CheckedChanged += new System.EventHandler(this.ckbox_Load_CheckedChanged);
            // 
            // lbl_Stock_Bal
            // 
            this.lbl_Stock_Bal.AutoSize = true;
            this.lbl_Stock_Bal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Stock_Bal.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_Bal.Location = new System.Drawing.Point(9, 23);
            this.lbl_Stock_Bal.Name = "lbl_Stock_Bal";
            this.lbl_Stock_Bal.Size = new System.Drawing.Size(143, 21);
            this.lbl_Stock_Bal.TabIndex = 157;
            this.lbl_Stock_Bal.Text = "View Stock Balance";
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
            this.btn_Back.TabIndex = 12;
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
            this.lbl_Customer.TabIndex = 10;
            this.lbl_Customer.Text = "Back";
            // 
            // DataTable_Ins_DateTableAdapter
            // 
            this.DataTable_Ins_DateTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_PaidAmtTableAdapter
            // 
            this.DataTable_PaidAmtTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_Cus_InfoTableAdapter
            // 
            this.DataTable_Cus_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Customer_DetailTableAdapter
            // 
            this.Customer_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_InsTableAdapter
            // 
            this.DataTable_InsTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_FullTableAdapter
            // 
            this.DataTable_FullTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_SM_SalesTableAdapter
            // 
            this.DataTable_SM_SalesTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_SM_InfoTableAdapter
            // 
            this.DataTable_SM_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.TabControl_Reports);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reports";
            this.Resizable = false;
            this.Text = "Reports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reports_FormClosing);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_FullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Ins_DateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_PaidAmtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Cus_InfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_SM_SalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_SM_InfoBindingSource)).EndInit();
            this.TabControl_Reports.ResumeLayout(false);
            this.Print_Receipt.ResumeLayout(false);
            this.Print_Receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Rec_Itms)).EndInit();
            this.View_Receipts.ResumeLayout(false);
            this.View_Receipts.PerformLayout();
            this.Ins_Report.ResumeLayout(false);
            this.Ins_Report.PerformLayout();
            this.Ins_Receipt.ResumeLayout(false);
            this.Ins_Receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Ins_Rec)).EndInit();
            this.Sales_Report.ResumeLayout(false);
            this.Sales_Report.PerformLayout();
            this.Stock_Balance.ResumeLayout(false);
            this.Stock_Balance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl_Reports;
        private MetroFramework.Controls.MetroTabPage Print_Receipt;
        private MetroFramework.Controls.MetroTabPage View_Receipts;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Customer;
        private MetroFramework.Controls.MetroButton btn_Print;
        private MetroFramework.Controls.MetroButton btn_Add_Item;
        private MetroFramework.Controls.MetroButton btn_clear_Load;
        private MetroFramework.Controls.MetroTextBox txt_Discount_Pcnt;
        private MetroFramework.Controls.MetroTextBox txt_No_of_Ins;
        private MetroFramework.Controls.MetroTextBox txt_Downpayment;
        private System.Windows.Forms.Label lbl_Str_Ld_Name;
        private System.Windows.Forms.Label lbl_Item_Name;
        private MetroFramework.Controls.MetroCheckBox ckbox_From_Store;
        private System.Windows.Forms.Label lbl_uPrice;
        private MetroFramework.Controls.MetroComboBox cmb_Str_Ldr_Name;
        private MetroFramework.Controls.MetroComboBox cmb_Quantity;
        private System.Windows.Forms.Label lbl_Quantity;
        private MetroFramework.Controls.MetroComboBox cmb_Item_Name;
        private MetroFramework.Controls.MetroComboBox cmb_Payment_Type;
        private System.Windows.Forms.Label lbl_Payment_Type;
        private MetroFramework.Controls.MetroGrid metroGrid_Rec_Itms;
        private System.Windows.Forms.Label lbl_AddItems;
        private MetroFramework.Controls.MetroTextBox txt_NIC;
        private MetroFramework.Controls.MetroTextBox txt_Receipt_No;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn Load_or_Store;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Downpayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn No_of_Installments;
        private MetroFramework.Controls.MetroButton btn_clear_all;
        private System.Windows.Forms.Label lbl_Sub_Tot;
        private System.Windows.Forms.Label lbl_Tot_Full;
        private System.Windows.Forms.Label lbl_Tot_Down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTabPage Ins_Report;
        private MetroFramework.Controls.MetroTextBox txt_View_Receipt_No;
        private System.Windows.Forms.Label lbl_View_Rec;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_View_Receipts;
        private System.Windows.Forms.BindingSource Customer_DetailBindingSource;
        private DataSet1 DataSet1;
        private System.Windows.Forms.BindingSource DataTable_FullBindingSource;
        private DataSet2 DataSet2;
        private System.Windows.Forms.BindingSource DataTable_InsBindingSource;
        private DataSet3 DataSet3;
        private DataSet1TableAdapters.Customer_DetailTableAdapter Customer_DetailTableAdapter;
        private DataSet2TableAdapters.DataTable_FullTableAdapter DataTable_FullTableAdapter;
        private DataSet3TableAdapters.DataTable_InsTableAdapter DataTable_InsTableAdapter;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Ins_Report;
        private System.Windows.Forms.Button btn_search_Ins;
        private MetroFramework.Controls.MetroTextBox txt_Rec_No;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Ins_Rep;
        private System.Windows.Forms.BindingSource DataTable_Ins_DateBindingSource;
        private DataSet4 DataSet4;
        private DataSet4TableAdapters.DataTable_Ins_DateTableAdapter DataTable_Ins_DateTableAdapter;
        private System.Windows.Forms.BindingSource DataTable_PaidAmtBindingSource;
        private DataSet4TableAdapters.DataTable_PaidAmtTableAdapter DataTable_PaidAmtTableAdapter;
        private System.Windows.Forms.Label lbl_From;
        private MetroFramework.Controls.MetroDateTime metroDateTime_To;
        private MetroFramework.Controls.MetroDateTime metroDateTime_From;
        private System.Windows.Forms.Label lbl_To;
        private MetroFramework.Controls.MetroButton btn_View;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTabPage Ins_Receipt;
        private System.Windows.Forms.Label lbl_Ins_Rec;
        private MetroFramework.Controls.MetroTextBox txt_Ins_Amt;
        private MetroFramework.Controls.MetroTextBox txt_Ins_Date;
        private MetroFramework.Controls.MetroTextBox txt_IItem_No;
        private MetroFramework.Controls.MetroTextBox txt_IRec_No;
        private MetroFramework.Controls.MetroComboBox cmb_Status;
        private System.Windows.Forms.Button btn_Search_IRec;
        private MetroFramework.Controls.MetroTextBox txt_Search_IRec;
        private MetroFramework.Controls.MetroGrid metroGrid_Ins_Rec;
        private System.Windows.Forms.Label lbl_Status;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_clear_IRec;
        private MetroFramework.Controls.MetroButton btn_Print_Ins_Receipt;
        private MetroFramework.Controls.MetroButton btn_Remove;
        private MetroFramework.Controls.MetroTextBox txt_Status;
        private System.Windows.Forms.BindingSource DataTable_Cus_InfoBindingSource;
        private DataSet4TableAdapters.DataTable_Cus_InfoTableAdapter DataTable_Cus_InfoTableAdapter;
        private MetroFramework.Controls.MetroTabPage Sales_Report;
        private System.Windows.Forms.Label lbl_To_Date;
        private System.Windows.Forms.Label lbl_From_Sales;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Sales_To;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Sales_From;
        private System.Windows.Forms.Button btn_Search_SM;
        private MetroFramework.Controls.MetroTextBox txt_SM_No;
        private System.Windows.Forms.Label lbl_View_Sales;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_reportViewer_Sales_Rep;
        private System.Windows.Forms.BindingSource DataTable_SM_SalesBindingSource;
        private DataSet8 DataSet8;
        private DataSet8TableAdapters.DataTable_SM_SalesTableAdapter DataTable_SM_SalesTableAdapter;
        private System.Windows.Forms.BindingSource DataTable_SM_InfoBindingSource;
        private DataSet8TableAdapters.DataTable_SM_InfoTableAdapter DataTable_SM_InfoTableAdapter;
        private MetroFramework.Controls.MetroButton btn_Clear_SM;
        private MetroFramework.Controls.MetroComboBox cmb_SM_Type;
        private System.Windows.Forms.Label lbl_Salesman_Type;
        private MetroFramework.Controls.MetroTabPage Stock_Balance;
        private System.Windows.Forms.Label lbl_Str_Ld;
        private MetroFramework.Controls.MetroComboBox cmb_Str_Ld;
        private MetroFramework.Controls.MetroCheckBox ckbox_Store;
        private MetroFramework.Controls.MetroCheckBox ckbox_Load;
        private System.Windows.Forms.Label lbl_Stock_Bal;
        private System.Windows.Forms.Label lbl_Str_Name;
        private MetroFramework.Controls.MetroButton btn_Clear_Stock;
        private MetroFramework.Controls.MetroButton btn_View_Stock;
    }
}