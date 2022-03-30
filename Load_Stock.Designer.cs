namespace Furniture_System
{
    partial class Load_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load_Stock));
            this.DataTable_Load_BalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet11 = new Furniture_System.DataSet11();
            this.LoadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer_Load_bal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable_Load_BalTableAdapter = new Furniture_System.DataSet11TableAdapters.DataTable_Load_BalTableAdapter();
            this.LoadTableAdapter = new Furniture_System.DataSet11TableAdapters.LoadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Load_BalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable_Load_BalBindingSource
            // 
            this.DataTable_Load_BalBindingSource.DataMember = "DataTable_Load_Bal";
            this.DataTable_Load_BalBindingSource.DataSource = this.DataSet11;
            // 
            // DataSet11
            // 
            this.DataSet11.DataSetName = "DataSet11";
            this.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LoadBindingSource
            // 
            this.LoadBindingSource.DataMember = "Load";
            this.LoadBindingSource.DataSource = this.DataSet11;
            // 
            // reportViewer_Load_bal
            // 
            reportDataSource1.Name = "DataSet11";
            reportDataSource1.Value = this.DataTable_Load_BalBindingSource;
            reportDataSource2.Name = "DataSet12";
            reportDataSource2.Value = this.LoadBindingSource;
            this.reportViewer_Load_bal.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_Load_bal.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_Load_bal.LocalReport.ReportEmbeddedResource = "Furniture_System.Report8.rdlc";
            this.reportViewer_Load_bal.Location = new System.Drawing.Point(9, 77);
            this.reportViewer_Load_bal.Name = "reportViewer_Load_bal";
            this.reportViewer_Load_bal.ServerReport.BearerToken = null;
            this.reportViewer_Load_bal.Size = new System.Drawing.Size(1029, 617);
            this.reportViewer_Load_bal.TabIndex = 0;
            // 
            // DataTable_Load_BalTableAdapter
            // 
            this.DataTable_Load_BalTableAdapter.ClearBeforeFill = true;
            // 
            // LoadTableAdapter
            // 
            this.LoadTableAdapter.ClearBeforeFill = true;
            // 
            // Load_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 700);
            this.Controls.Add(this.reportViewer_Load_bal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load_Stock";
            this.Resizable = false;
            this.Text = "Load Stock Report";
            this.Load += new System.EventHandler(this.Load_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable_Load_BalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Load_bal;
        private System.Windows.Forms.BindingSource DataTable_Load_BalBindingSource;
        private DataSet11 DataSet11;
        private DataSet11TableAdapters.DataTable_Load_BalTableAdapter DataTable_Load_BalTableAdapter;
        private System.Windows.Forms.BindingSource LoadBindingSource;
        private DataSet11TableAdapters.LoadTableAdapter LoadTableAdapter;
    }
}