namespace Furniture_System
{
    partial class Receipt
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.Customer_DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Furniture_System.DataSet1();
            this.DataTable_FullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet2 = new Furniture_System.DataSet2();
            this.DataTable_InsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet3 = new Furniture_System.DataSet3();
            this.Receipt_report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Customer_DetailTableAdapter = new Furniture_System.DataSet1TableAdapters.Customer_DetailTableAdapter();
            this.DataTable_FullTableAdapter = new Furniture_System.DataSet2TableAdapters.DataTable_FullTableAdapter();
            this.DataTable_InsTableAdapter = new Furniture_System.DataSet3TableAdapters.DataTable_InsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_FullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).BeginInit();
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
            // Receipt_report
            // 
            this.Receipt_report.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Customer_DetailBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataTable_FullBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.DataTable_InsBindingSource;
            this.Receipt_report.LocalReport.DataSources.Add(reportDataSource1);
            this.Receipt_report.LocalReport.DataSources.Add(reportDataSource2);
            this.Receipt_report.LocalReport.DataSources.Add(reportDataSource3);
            this.Receipt_report.LocalReport.ReportEmbeddedResource = "Furniture_System.Report_Receipt.rdlc";
            this.Receipt_report.Location = new System.Drawing.Point(20, 93);
            this.Receipt_report.Name = "Receipt_report";
            this.Receipt_report.ServerReport.BearerToken = null;
            this.Receipt_report.Size = new System.Drawing.Size(1006, 587);
            this.Receipt_report.TabIndex = 0;
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
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.Receipt_report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.Resizable = false;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Customer_DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_FullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_InsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer Receipt_report;
        private System.Windows.Forms.BindingSource Customer_DetailBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.Customer_DetailTableAdapter Customer_DetailTableAdapter;
        private System.Windows.Forms.BindingSource DataTable_FullBindingSource;
        private DataSet2 DataSet2;
        private DataSet2TableAdapters.DataTable_FullTableAdapter DataTable_FullTableAdapter;
        private System.Windows.Forms.BindingSource DataTable_InsBindingSource;
        private DataSet3 DataSet3;
        private DataSet3TableAdapters.DataTable_InsTableAdapter DataTable_InsTableAdapter;
    }
}