namespace EquipmentDB.View.Report
{
    partial class Report2
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
            this.equipmentDBDataSet = new EquipmentDB.EquipmentDBDataSet();
            this.corpsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpsTableAdapter = new EquipmentDB.EquipmentDBDataSetTableAdapters.CorpsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.corpsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentDB.View.Report.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(669, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // equipmentDBDataSet
            // 
            this.equipmentDBDataSet.DataSetName = "EquipmentDBDataSet";
            this.equipmentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corpsBindingSource
            // 
            this.corpsBindingSource.DataMember = "Corps";
            this.corpsBindingSource.DataSource = this.equipmentDBDataSet;
            // 
            // corpsTableAdapter
            // 
            this.corpsTableAdapter.ClearBeforeFill = true;
            // 
            // Report2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report2";
            this.Text = "Report2";
            this.Load += new System.EventHandler(this.Report2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EquipmentDBDataSet equipmentDBDataSet;
        private System.Windows.Forms.BindingSource corpsBindingSource;
        private EquipmentDBDataSetTableAdapters.CorpsTableAdapter corpsTableAdapter;
    }
}