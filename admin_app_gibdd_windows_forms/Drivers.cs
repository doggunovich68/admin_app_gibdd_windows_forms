using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_app_gibdd_windows_forms
{
    public partial class Drivers : Form
    {
        public Drivers()
        {
            InitializeComponent();
        }

        private void driverBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.driverBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.drivers_appDataSet);

        }

        private void Drivers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "drivers_appDataSet.Driver". При необходимости она может быть перемещена или удалена.
            this.driverTableAdapter.Fill(this.drivers_appDataSet.Driver);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Authorization f = new Authorization();
            f.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            License f = new License();
            f.Show();
        }
    }
}
