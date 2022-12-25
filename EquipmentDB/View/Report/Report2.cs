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
    public partial class Report2 : Form
    {
        public Report2()
        {
            InitializeComponent();
        }

        private void Report2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "equipmentDBDataSet.Corps". При необходимости она может быть перемещена или удалена.
            this.corpsTableAdapter.Fill(this.equipmentDBDataSet.Corps);

            this.reportViewer1.RefreshReport();
        }
    }
}
