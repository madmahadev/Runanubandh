using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class frmseecurrentsub : Form
    {
        SqlConnection con;
        public frmseecurrentsub()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void seecurrentsub_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=E:\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
                con.Open();
                SqlDataAdapter d = new SqlDataAdapter("select currentmonth from currentmonth", con);
                DataTable dt = new DataTable();
                d.Fill(dt);
                DataRow dr = dt.Rows[0];
                String m = (String)dr[0];
                d = new SqlDataAdapter("select name," + m + " from installment", con);
                lblcurmonth.Text = m;
                dt = new DataTable ();
                d.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (SqlException x)
            {
                MessageBox.Show(x.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
