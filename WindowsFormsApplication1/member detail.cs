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
    public partial class frmmemberdetail : Form
    {
        SqlConnection con = null;
        DataTable dt = null;
        public frmmemberdetail()
        {
            InitializeComponent();
        }

        private void frmmemberdetail_Load(object sender, EventArgs e)
        {
            String tname;
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void cmbmember_SelectedIndexChanged(object sender, EventArgs e)
        {
           
         
        }

        private void cmbmember_SelectedValueChanged(object sender, EventArgs e)
        {
            dt = null;
            try
            {


                String name = (string)cmbmember.SelectedItem;
                String tmem = name.Replace(" ", String.Empty);
                con.Open();
                dt = new DataTable();

                SqlDataAdapter d = new SqlDataAdapter("select * from memberinfo where name='" + name + "'", con);
                d.Fill(dt);
                
                DataRow dr = dt.Rows[0];
               
                lblname.Text = (String)dr[0];
                lblvillage.Text = (String)dr[1];
                lblmobile.Text = (String)dr[2];
                lbljoindate.Text = (String)dr[3];
                d = new SqlDataAdapter("select * from installment where name='"+name+"'", con);
                dt = new DataTable();
                d.Fill(dt);
                dataGridView1.DataSource = dt;
                dr = dt.Rows[0];
                int count = dt.Columns.Count;
                int total=0;
                for(int i=1;i<count;i++)
                {
                    total = total + int.Parse((String)dr[i]);
                }
                lbltotal.Text = total.ToString();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.ToString());
            }
            finally
            {
                con.Close();
            }

        }
    }
}
