using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentDB.View.Report
{
    public partial class Report4 : Form
    {
        public Report4()
        {
            InitializeComponent();
        }

        private void Report4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentDBDataSet.EmployeeEquipment". При необходимости она может быть перемещена или удалена.
            this.employeeEquipmentTableAdapter.Fill(this.equipmentDBDataSet.EmployeeEquipment);

            this.reportViewer1.RefreshReport();
        }
    }
}
