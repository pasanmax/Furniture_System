namespace Furniture_System
{
    partial class Installment_Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Installment_Receipt));
            this.DataTable_Ins_RecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet6 = new Furniture_System.DataSet6();
            this.DataTable_Cus_InfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer_Ins_Receipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable_Ins_RecTableAdapter = new Furniture_System.DataSet6TableAdapters.DataTable_Ins_RecTableAdapter();
            this.DataTable_Cus_InfoTableAdapter = new Furniture_System.DataSet6TableAdapters.DataTable_Cus_InfoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Ins_RecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Cus_InfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_Ins_RecBindingSource
            // 
            this.DataTable_Ins_RecBindingSource.DataMember = "DataTable_Ins_Rec";
            this.DataTable_Ins_RecBindingSource.DataSource = this.DataSet6;
            // 
            // DataSet6
            // 
            this.DataSet6.DataSetName = "DataSet6";
            this.DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable_Cus_InfoBindingSource
            // 
            this.DataTable_Cus_InfoBindingSource.DataMember = "DataTable_Cus_Info";
            this.DataTable_Cus_InfoBindingSource.DataSource = this.DataSet6;
            // 
            // reportViewer_Ins_Receipt
            // 
            reportDataSource1.Name = "DataSet6";
            reportDataSource1.Value = this.DataTable_Ins_RecBindingSource;
            reportDataSource2.Name = "DataSet7";
            reportDataSource2.Value = this.DataTable_Cus_InfoBindingSource;
            this.reportViewer_Ins_Receipt.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_Ins_Receipt.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_Ins_Receipt.LocalReport.ReportEmbeddedResource = "Furniture_System.Report4.rdlc";
            this.reportViewer_Ins_Receipt.Location = new System.Drawing.Point(9, 77);
            this.reportViewer_Ins_Receipt.Name = "reportViewer_Ins_Receipt";
            this.reportViewer_Ins_Receipt.ServerReport.BearerToken = null;
            this.reportViewer_Ins_Receipt.Size = new System.Drawing.Size(1029, 617);
            this.reportViewer_Ins_Receipt.TabIndex = 0;
            // 
            // DataTable_Ins_RecTableAdapter
            // 
            this.DataTable_Ins_RecTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable_Cus_InfoTableAdapter
            // 
            this.DataTable_Cus_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Installment_Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.reportViewer_Ins_Receipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Installment_Receipt";
            this.Resizable = false;
            this.Text = "Installment Receipt";
            this.Load += new System.EventHandler(this.Installment_Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Ins_RecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Cus_InfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Ins_Receipt;
        private System.Windows.Forms.BindingSource DataTable_Ins_RecBindingSource;
        private DataSet6 DataSet6;
        private System.Windows.Forms.BindingSource DataTable_Cus_InfoBindingSource;
        private DataSet6TableAdapters.DataTable_Ins_RecTableAdapter DataTable_Ins_RecTableAdapter;
        private DataSet6TableAdapters.DataTable_Cus_InfoTableAdapter DataTable_Cus_InfoTableAdapter;
    }
}