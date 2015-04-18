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
    public partial class frmloaninterest : Form
    {
        SqlConnection con = null;
        public frmloaninterest()
        {
            InitializeComponent();
        }

        private void frmloaninterest_Load(object sender, EventArgs e)
        {
            String tname;
            cmbmember.Items.Clear();
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=E:\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            try
            {

                con.Open();


                SqlDataAdapter da = new SqlDataAdapter("select membername from loan", con);

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

        private void cmbmember_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbamount.Items.Clear();
            String name = (String)cmbmember.SelectedValue;
            con.Open();
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select amount from loan where membername='"+name+"'", con);


                da.Fill(dt);
                int count = dt.Rows.Count;
                for (int i = 0; i < count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    cmbamount.Items.Add(dr[0].ToString());
                }


            }
            catch(SqlException eq)
            {
                MessageBox.Show(eq.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
