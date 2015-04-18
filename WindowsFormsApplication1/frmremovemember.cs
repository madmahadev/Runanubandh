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
    
    public partial class frmremovemember : Form
    {
        SqlConnection con = null;
        public frmremovemember()
        {
            InitializeComponent();
        }

        private void frmremovemember_Load(object sender, EventArgs e)
        {
            String tname;
            cmbmember.Items.Clear();
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\WCE\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            try
            {

                con.Open();


                SqlDataAdapter da = new SqlDataAdapter("select name from installment", con);

                da.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception in opening connection");

            }
            try
            {
                int count = dt.Rows.Count;
                DataRow dr;

                for (int i = 0; i < count; i++)
                {
                    dr = dt.Rows[i];

                    tname = (String)dr[0];


                    cmbmember.Items.Add(tname);

                }



            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String mname = (String)cmbmember.SelectedItem;
            String tmname = mname.Replace(" ", String.Empty);
            con.Open();
            try
            {
                //To delete names from memberlist,installmentand loan also... 
                SqlCommand cmd = new SqlCommand("delete from memberlist where name='"+tmname+"'", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from memberinfo where name='"+mname +"'",con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("delete from installments where name='"+mname+"'", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("drop table "+tmname , con);
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                con.Close();
            }
        }
    }
}
