namespace Furniture_System
{
    partial class Not_Paid_Ins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Not_Paid_Ins));
            this.DataTable_Not_Paid_InsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet7 = new Furniture_System.DataSet7();
            this.reportViewer_Not_Paid_Ins = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable_Not_Paid_InsTableAdapter = new Furniture_System.DataSet7TableAdapters.DataTable_Not_Paid_InsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Not_Paid_InsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_Not_Paid_InsBindingSource
            // 
            this.DataTable_Not_Paid_InsBindingSource.DataMember = "DataTable_Not_Paid_Ins";
            this.DataTable_Not_Paid_InsBindingSource.DataSource = this.DataSet7;
            // 
            // DataSet7
            // 
            this.DataSet7.DataSetName = "DataSet7";
            this.DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer_Not_Paid_Ins
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable_Not_Paid_InsBindingSource;
            this.reportViewer_Not_Paid_Ins.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_Not_Paid_Ins.LocalReport.ReportEmbeddedResource = "Furniture_System.Report5.rdlc";
            this.reportViewer_Not_Paid_Ins.Location = new System.Drawing.Point(9, 77);
            this.reportViewer_Not_Paid_Ins.Name = "reportViewer_Not_Paid_Ins";
            this.reportViewer_Not_Paid_Ins.ServerReport.BearerToken = null;
            this.reportViewer_Not_Paid_Ins.Size = new System.Drawing.Size(1029, 617);
            this.reportViewer_Not_Paid_Ins.TabIndex = 1;
            // 
            // DataTable_Not_Paid_InsTableAdapter
            // 
            this.DataTable_Not_Paid_InsTableAdapter.ClearBeforeFill = true;
            // 
            // Not_Paid_Ins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.reportViewer_Not_Paid_Ins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Not_Paid_Ins";
            this.Resizable = false;
            this.Text = "Installment Report";
            this.Load += new System.EventHandler(this.Not_Paid_Ins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Not_Paid_InsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Not_Paid_Ins;
        private System.Windows.Forms.BindingSource DataTable_Not_Paid_InsBindingSource;
        private DataSet7 DataSet7;
        private DataSet7TableAdapters.DataTable_Not_Paid_InsTableAdapter DataTable_Not_Paid_InsTableAdapter;
    }
}