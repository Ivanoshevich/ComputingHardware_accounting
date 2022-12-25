namespace EquipmentDB.View.Report
{
    partial class Report1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.equipmentDBDataSet = new EquipmentDB.EquipmentDBDataSet();
            this.equipmentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.balanceTypeTableAdapter = new EquipmentDB.EquipmentDBDataSetTableAdapters.BalanceTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.balanceTypeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentDB.View.Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(582, 372);
            this.reportViewer1.TabIndex = 0;
            // 
            // equipmentDBDataSet
            // 
            this.equipmentDBDataSet.DataSetName = "EquipmentDBDataSet";
            this.equipmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipmentDBDataSetBindingSource
            // 
            this.equipmentDBDataSetBindingSource.DataSource = this.equipmentDBDataSet;
            this.equipmentDBDataSetBindingSource.Position = 0;
            // 
            // balanceTypeBindingSource
            // 
            this.balanceTypeBindingSource.DataMember = "BalanceType";
            this.balanceTypeBindingSource.DataSource = this.equipmentDBDataSet;
            // 
            // balanceTypeTableAdapter
            // 
            this.balanceTypeTableAdapter.ClearBeforeFill = true;
            // 
            // Report1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 396);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report1";
            this.Text = "Отчет по типам баланса";
            this.Load += new System.EventHandler(this.Report1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balanceTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EquipmentDBDataSet equipmentDBDataSet;
        private System.Windows.Forms.BindingSource equipmentDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource balanceTypeBindingSource;
        private EquipmentDBDataSetTableAdapters.BalanceTypeTableAdapter balanceTypeTableAdapter;
    }
}