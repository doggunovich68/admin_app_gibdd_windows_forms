using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admin_app_gibdd_windows_forms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        public int I;
        private int count = 1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Наталья Ивановна\source\repos\admin_app_gibdd_windows_forms\admin_app_gibdd_windows_forms\Drivers_app.mdf; Integrated Security = True");
            I = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM [Authorization] WHERE Login ='" + textBoxLogin.Text + "' AND Password ='" + textBoxPassword.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            I = Convert.ToInt32(dt.Rows.Count.ToString());
            if (I == 0)
            {
                MessageBox.Show("Authentication error!");
                if (count++ == 10)
                {
                    this.Close();
                }
            }
            else
            {
                this.Hide();
                Drivers f = new Drivers();
                f.Show();
            }

            con.Close();
        }
    }
}
