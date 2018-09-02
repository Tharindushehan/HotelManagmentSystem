namespace newHotel
{
    partial class GenerateQuotaions
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.hotelDAtaSet = new newHotel.hotelDAtaSet();
            this.hallbookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallbookTableAdapter = new newHotel.hotelDAtaSetTableAdapters.hallbookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDAtaSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallbookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.hallbookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "newHotel.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(888, 482);
            this.reportViewer1.TabIndex = 0;
            // 
            // hotelDAtaSet
            // 
            this.hotelDAtaSet.DataSetName = "hotelDAtaSet";
            this.hotelDAtaSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hallbookBindingSource
            // 
            this.hallbookBindingSource.DataMember = "hallbook";
            this.hallbookBindingSource.DataSource = this.hotelDAtaSet;
            // 
            // hallbookTableAdapter
            // 
            this.hallbookTableAdapter.ClearBeforeFill = true;
            // 
            // GenerateQuotaions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 482);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GenerateQuotaions";
            this.Text = "GenerateQuotaions";
            this.Load += new System.EventHandler(this.GenerateQuotaions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDAtaSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallbookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource hallbookBindingSource;
        private hotelDAtaSet hotelDAtaSet;
        private hotelDAtaSetTableAdapters.hallbookTableAdapter hallbookTableAdapter;
    }
}