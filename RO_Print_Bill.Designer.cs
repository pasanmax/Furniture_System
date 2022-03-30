namespace Furniture_System
{
    partial class RO_Print_Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RO_Print_Bill));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControl_Reports = new MetroFramework.Controls.MetroTabControl();
            this.Ins_Report = new MetroFramework.Controls.MetroTabPage();
            this.lbl_View_Today = new System.Windows.Forms.Label();
            this.btn_search_Ins = new System.Windows.Forms.Button();
            this.lbl_Ins_Report = new System.Windows.Forms.Label();
            this.Ins_Receipt = new MetroFramework.Controls.MetroTabPage();
            this.txt_Status = new MetroFramework.Controls.MetroTextBox();
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.TabControl_Reports.SuspendLayout();
            this.Ins_Report.SuspendLayout();
            this.Ins_Receipt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Ins_Rec)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Reports
            // 
            this.TabControl_Reports.Controls.Add(this.Ins_Report);
            this.TabControl_Reports.Controls.Add(this.Ins_Receipt);
            this.TabControl_Reports.Location = new System.Drawing.Point(0, 113);
            this.TabControl_Reports.Name = "TabControl_Reports";
            this.TabControl_Reports.SelectedIndex = 0;
            this.TabControl_Reports.Size = new System.Drawing.Size(1046, 585);
            this.TabControl_Reports.TabIndex = 14;
            this.TabControl_Reports.UseSelectable = true;
            // 
            // Ins_Report
            // 
            this.Ins_Report.Controls.Add(this.lbl_View_Today);
            this.Ins_Report.Controls.Add(this.btn_search_Ins);
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
            // 
            // lbl_View_Today
            // 
            this.lbl_View_Today.AutoSize = true;
            this.lbl_View_Today.BackColor = System.Drawing.Color.Transparent;
            this.lbl_View_Today.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Today.Location = new System.Drawing.Point(48, 76);
            this.lbl_View_Today.Name = "lbl_View_Today";
            this.lbl_View_Today.Size = new System.Drawing.Size(190, 21);
            this.lbl_View_Today.TabIndex = 149;
            this.lbl_View_Today.Text = "Search Today Installments";
            // 
            // btn_search_Ins
            // 
            this.btn_search_Ins.BackColor = System.Drawing.Color.Transparent;
            this.btn_search_Ins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_Ins.BackgroundImage")));
            this.btn_search_Ins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search_Ins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_Ins.FlatAppearance.BorderSize = 0;
            this.btn_search_Ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_Ins.Location = new System.Drawing.Point(261, 74);
            this.btn_search_Ins.Name = "btn_search_Ins";
            this.btn_search_Ins.Size = new System.Drawing.Size(27, 26);
            this.btn_search_Ins.TabIndex = 148;
            this.btn_search_Ins.UseVisualStyleBackColor = false;
            this.btn_search_Ins.Click += new System.EventHandler(this.btn_search_Ins_Click);
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
            // btn_Print_Ins_Receipt
            // 
            this.btn_Print_Ins_Receipt.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btn_Print_Ins_Receipt.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btn_Print_Ins_Receipt.Location = new System.Drawing.Point(609, 445);
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
            this.btn_update.Location = new System.Drawing.Point(768, 445);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Ins_Rec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid_Ins_Rec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid_Ins_Rec.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid_Ins_Rec.EnableHeadersVisualStyles = false;
            this.metroGrid_Ins_Rec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid_Ins_Rec.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid_Ins_Rec.Location = new System.Drawing.Point(261, 51);
            this.metroGrid_Ins_Rec.Name = "metroGrid_Ins_Rec";
            this.metroGrid_Ins_Rec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid_Ins_Rec.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.btn_Back.TabIndex = 15;
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
            this.lbl_Customer.TabIndex = 13;
            this.lbl_Customer.Text = "Back";
            // 
            // RO_Print_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.TabControl_Reports);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_Customer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RO_Print_Bill";
            this.Resizable = false;
            this.Text = "Print Receipt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RO_Print_Bill_FormClosing);
            this.TabControl_Reports.ResumeLayout(false);
            this.Ins_Report.ResumeLayout(false);
            this.Ins_Report.PerformLayout();
            this.Ins_Receipt.ResumeLayout(false);
            this.Ins_Receipt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid_Ins_Rec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TabControl_Reports;
        private MetroFramework.Controls.MetroTabPage Ins_Report;
        private System.Windows.Forms.Button btn_search_Ins;
        private System.Windows.Forms.Label lbl_Ins_Report;
        private MetroFramework.Controls.MetroTabPage Ins_Receipt;
        private MetroFramework.Controls.MetroTextBox txt_Status;
        private MetroFramework.Controls.MetroButton btn_Print_Ins_Receipt;
        private MetroFramework.Controls.MetroButton btn_update;
        private MetroFramework.Controls.MetroButton btn_clear_IRec;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Search_IRec;
        private MetroFramework.Controls.MetroTextBox txt_Search_IRec;
        private MetroFramework.Controls.MetroGrid metroGrid_Ins_Rec;
        private MetroFramework.Controls.MetroComboBox cmb_Status;
        private MetroFramework.Controls.MetroTextBox txt_Ins_Amt;
        private MetroFramework.Controls.MetroTextBox txt_Ins_Date;
        private MetroFramework.Controls.MetroTextBox txt_IItem_No;
        private MetroFramework.Controls.MetroTextBox txt_IRec_No;
        private System.Windows.Forms.Label lbl_Ins_Rec;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label lbl_Customer;
        private System.Windows.Forms.Label lbl_View_Today;
    }
}