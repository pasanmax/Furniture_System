namespace Furniture_System
{
    partial class Ins_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ins_Report));
            this.DataTable_Ins_View_AllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet5 = new Furniture_System.DataSet5();
            this.DataTable_Paid_TotBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer_Ins_Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable_Ins_View_AllTableAdapter = new Furniture_System.DataSet5TableAdapters.DataTable_Ins_View_AllTableAdapter();
            this.DataTable_Paid_TotTableAdapter = new Furniture_System.DataSet5TableAdapters.DataTable_Paid_TotTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Ins_View_AllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Paid_TotBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_Ins_View_AllBindingSource
            // 
            this.DataTable_Ins_View_AllBindingSource.DataMember = "DataTable_Ins_View_All";
            this.DataTable_Ins_View_AllBindingSource.DataSource = this.DataSet5;
            // 
            // DataSet5
            // 
            this.DataSet5.DataSetName = "DataSet5";
            this.DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_Paid_TotBindingSource
            // 
            this.DataTable_Paid_TotBindingSource.DataMember = "DataTable_Paid_Tot";
            this.DataTable_Paid_TotBindingSource.DataSource = this.DataSet5;
            // 
            // reportViewer_Ins_Report
            // 
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.DataTable_Ins_View_AllBindingSource;
            reportDataSource2.Name = "DataSet6";
            reportDataSource2.Value = this.DataTable_Paid_TotBindingSource;
            this.reportViewer_Ins_Report.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_Ins_Report.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_Ins_Report.LocalReport.ReportEmbeddedResource = "Furniture_System.Report_Installment.rdlc";
            this.reportViewer_Ins_Report.Location = new System.Drawing.Point(11, 86);
            this.reportViewer_Ins_Report.Name = "reportViewer_Ins_Report";
            this.reportViewer_Ins_Report.ServerReport.BearerToken = null;
            this.reportViewer_Ins_Report.Size = new System.Drawing.Size(1026, 607);
            this.reportViewer_Ins_Report.TabIndex = 0;
            // 
            // DataTable_Ins_View_AllTableAdapter
            // 
            this.DataTable_Ins_View_AllTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_Paid_TotTableAdapter
            // 
            this.DataTable_Paid_TotTableAdapter.ClearBeforeFill = true;
            // 
            // Ins_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.reportViewer_Ins_Report);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ins_Report";
            this.Resizable = false;
            this.Text = "Installment Report";
            this.Load += new System.EventHandler(this.Ins_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Ins_View_AllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Paid_TotBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Ins_Report;
        private System.Windows.Forms.BindingSource DataTable_Ins_View_AllBindingSource;
        private DataSet5 DataSet5;
        private DataSet5TableAdapters.DataTable_Ins_View_AllTableAdapter DataTable_Ins_View_AllTableAdapter;
        private System.Windows.Forms.BindingSource DataTable_Paid_TotBindingSource;
        private DataSet5TableAdapters.DataTable_Paid_TotTableAdapter DataTable_Paid_TotTableAdapter;
    }
}