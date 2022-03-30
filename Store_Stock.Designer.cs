namespace Furniture_System
{
    partial class Store_Stock
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Store_Stock));
            this.DataTable_Store_BalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet10 = new Furniture_System.DataSet10();
            this.StoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer_Store_bal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable_Store_BalTableAdapter = new Furniture_System.DataSet10TableAdapters.DataTable_Store_BalTableAdapter();
            this.StoreTableAdapter = new Furniture_System.DataSet10TableAdapters.StoreTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Store_BalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_Store_BalBindingSource
            // 
            this.DataTable_Store_BalBindingSource.DataMember = "DataTable_Store_Bal";
            this.DataTable_Store_BalBindingSource.DataSource = this.DataSet10;
            // 
            // DataSet10
            // 
            this.DataSet10.DataSetName = "DataSet10";
            this.DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StoreBindingSource
            // 
            this.StoreBindingSource.DataMember = "Store";
            this.StoreBindingSource.DataSource = this.DataSet10;
            // 
            // reportViewer_Store_bal
            // 
            reportDataSource1.Name = "DataSet10";
            reportDataSource1.Value = this.DataTable_Store_BalBindingSource;
            reportDataSource2.Name = "DataSet11";
            reportDataSource2.Value = this.StoreBindingSource;
            this.reportViewer_Store_bal.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_Store_bal.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_Store_bal.LocalReport.ReportEmbeddedResource = "Furniture_System.Report7.rdlc";
            this.reportViewer_Store_bal.Location = new System.Drawing.Point(9, 77);
            this.reportViewer_Store_bal.Name = "reportViewer_Store_bal";
            this.reportViewer_Store_bal.ServerReport.BearerToken = null;
            this.reportViewer_Store_bal.Size = new System.Drawing.Size(1029, 617);
            this.reportViewer_Store_bal.TabIndex = 1;
            // 
            // DataTable_Store_BalTableAdapter
            // 
            this.DataTable_Store_BalTableAdapter.ClearBeforeFill = true;
            // 
            // StoreTableAdapter
            // 
            this.StoreTableAdapter.ClearBeforeFill = true;
            // 
            // Store_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.reportViewer_Store_bal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Store_Stock";
            this.Resizable = false;
            this.Text = "Store Stock Report";
            this.Load += new System.EventHandler(this.Store_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Store_BalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Store_bal;
        private System.Windows.Forms.BindingSource DataTable_Store_BalBindingSource;
        private DataSet10 DataSet10;
        private DataSet10TableAdapters.DataTable_Store_BalTableAdapter DataTable_Store_BalTableAdapter;
        private System.Windows.Forms.BindingSource StoreBindingSource;
        private DataSet10TableAdapters.StoreTableAdapter StoreTableAdapter;
    }
}