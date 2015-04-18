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
    public partial class frmforgtpass : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\WCE\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
        public frmforgtpass()
        {
            InitializeComponent();
        }

        private void btngetpass_Click(object sender, EventArgs e)
        {
            String mname = txtmname.Text;
            String nname = txtnname.Text;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select pass from login where mothername='"+mname +"' AND nickname='"+nname +"'", con);
            DataTable dt1 = new DataTable();
            da.Fill(dt1);
            int count = dt1.Rows.Count;
            if (count == 1)
            {
                DataRow dr=dt1 .Rows [0];

                String pass = (String)dr[0];
                MessageBox.Show("Your Password is :" + pass);
                con.Close();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Information  Doesn't Match");
                con.Close();
                return;
               
            }

        }
    }
}
