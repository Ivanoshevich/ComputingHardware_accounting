namespace EquipmentDB.View.Report
{
    partial class Report4
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
            this.equipmentDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeEquipmentTableAdapter = new EquipmentDB.EquipmentDBDataSetTableAdapters.EmployeeEquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEquipmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.employeeEquipmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "EquipmentDB.View.Report.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(676, 476);
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
            // equipmentDBDataSetBindingSource1
            // 
            this.equipmentDBDataSetBindingSource1.DataSource = this.equipmentDBDataSet;
            this.equipmentDBDataSetBindingSource1.Position = 0;
            // 
            // employeeEquipmentBindingSource
            // 
            this.employeeEquipmentBindingSource.DataMember = "EmployeeEquipment";
            this.employeeEquipmentBindingSource.DataSource = this.equipmentDBDataSet;
            // 
            // employeeEquipmentTableAdapter
            // 
            this.employeeEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // Report4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report4";
            this.Text = "Report4";
            this.Load += new System.EventHandler(this.Report4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeEquipmentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private EquipmentDBDataSet equipmentDBDataSet;
        private System.Windows.Forms.BindingSource equipmentDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource equipmentDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource employeeEquipmentBindingSource;
        private EquipmentDBDataSetTableAdapters.EmployeeEquipmentTableAdapter employeeEquipmentTableAdapter;
    }
}