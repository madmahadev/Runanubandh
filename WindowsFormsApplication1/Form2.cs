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
    public partial class frminterestsub : Form
    {
        SqlConnection con = null;

        public frminterestsub()
        {
            InitializeComponent();
        }

        private void frminterestsub_Load(object sender, EventArgs e)
        {
            cmbmonth.Items.Clear();
            //lblst.Text = "";
            //String[] m={"JAN","FEB","MARCH","APR","MAY","JUN","JULY","AUG","SEP","OCT","NOV","DEC"};
            //for(int i=0;i<12;i++)
            //{
            //    cmbmonth.Items.Add(m[i]);
            //}


            String tname;
            cmbmember.Items.Clear();
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=E:\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            try
            {

                con.Open();


                SqlDataAdapter da = new SqlDataAdapter("select distinct membername from loan", con);

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
                //dr = dt.Rows[0];

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

            cmbdate.SelectedItem = null;
            cmbdate.Items.Clear();
            
            String nm = (String)cmbmember.SelectedItem;
            String tdate=null ;
            DataTable dt = new DataTable ();
            try
            {

                con.Open();


                SqlDataAdapter da = new SqlDataAdapter("select distinct dateofloan from loan where membername='"+nm+"'", con);

                da.Fill(dt);
            }
            catch (Exception eq)
            {
                MessageBox.Show(eq.ToString());
                MessageBox.Show("Exception in opening connection");

            }
            try
            {
                int count = dt.Rows.Count;
                DataRow dr;
                //dr = dt.Rows[0];

                for (int i = 0; i < count; i++)
                {
                    dr = dt.Rows[i];

                    tdate = (String)dr[0];

                    cmbdate.Items.Add(tdate);
                    

                }
                con.Close();
                cmbdate.SelectedItem = (String)tdate;




            }
            catch (Exception)
            {

            }
            finally
            {
                //con.Close();
            }
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbdate_SelectedValueChanged(object sender, EventArgs e)
        {
            
            String nm = (String)cmbmember.SelectedItem;
            String dte = (String)cmbdate.SelectedItem;
            //String nma = nm.Replace(" ", String.Empty);
            //nma = nma + "loan";

            DataTable dt = new DataTable();
            try
            {

                con.Open();
                

                SqlDataAdapter da = new SqlDataAdapter("select status,remaining from loan where membername='" + nm + "' AND dateofloan='"+dte+"'" , con);

                da.Fill(dt);
            }
            catch (Exception eq)
            {
                MessageBox.Show(eq.ToString());
                MessageBox.Show("Exception in opening connection");

            }
            try
            {
                int count = dt.Rows.Count;
                DataRow dr;
                //dr = dt.Rows[0];

                for (int i = 0; i < count; i++)
                {
                    dr = dt.Rows[i];

                    lblstatus .Text  = (String)dr[0];
                   
                    lblrem.Text = (String)dr[1].ToString();
                    


                }

                //SqlDataAdapter da = new SqlDataAdapter("select * from nma", con);
                //dt = new DataTable();
                //da.Fill(dt);
                //for(int i=0;i<dt.Rows .Count ;i++)
                //{
                //    DataRow dr1=dt.Rows [i];
                //    cmbmonth.Items.Add(dr1[0].ToString());

                //}
                
                


            }
            catch (Exception)
            {
                
            }
            finally
            {
                con.Close();
            }
         }

        private void cmbmonth_SelectedValueChanged(object sender, EventArgs e)
        {
            int pr = int.Parse (lblrem.Text);
            float i = (pr * 2) / 100;
            txtamount.Text = (i.ToString());
            
            try
            {
                con.Open();

            }
            catch (Exception eq)
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
