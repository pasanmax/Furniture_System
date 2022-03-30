namespace Furniture_System
{
    partial class Sales_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Report));
            this.DataTable_SM_Type_SalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet9 = new Furniture_System.DataSet9();
            this.reportViewer_SM_Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable_SM_Type_SalesTableAdapter = new Furniture_System.DataSet9TableAdapters.DataTable_SM_Type_SalesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_SM_Type_SalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_SM_Type_SalesBindingSource
            // 
            this.DataTable_SM_Type_SalesBindingSource.DataMember = "DataTable_SM_Type_Sales";
            this.DataTable_SM_Type_SalesBindingSource.DataSource = this.DataSet9;
            // 
            // DataSet9
            // 
            this.DataSet9.DataSetName = "DataSet9";
            this.DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer_SM_Report
            // 
            reportDataSource1.Name = "DataSet9";
            reportDataSource1.Value = this.DataTable_SM_Type_SalesBindingSource;
            this.reportViewer_SM_Report.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_SM_Report.LocalReport.ReportEmbeddedResource = "Furniture_System.Report_Sales.rdlc";
            this.reportViewer_SM_Report.Location = new System.Drawing.Point(9, 77);
            this.reportViewer_SM_Report.Name = "reportViewer_SM_Report";
            this.reportViewer_SM_Report.ServerReport.BearerToken = null;
            this.reportViewer_SM_Report.Size = new System.Drawing.Size(1029, 617);
            this.reportViewer_SM_Report.TabIndex = 0;
            // 
            // DataTable_SM_Type_SalesTableAdapter
            // 
            this.DataTable_SM_Type_SalesTableAdapter.ClearBeforeFill = true;
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.reportViewer_SM_Report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sales_Report";
            this.Resizable = false;
            this.Text = "Sales Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_SM_Type_SalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_SM_Report;
        private System.Windows.Forms.BindingSource DataTable_SM_Type_SalesBindingSource;
        private DataSet9 DataSet9;
        private DataSet9TableAdapters.DataTable_SM_Type_SalesTableAdapter DataTable_SM_Type_SalesTableAdapter;
    }
}