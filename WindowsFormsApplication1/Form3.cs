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
    public partial class frmmain : Form  
    {
        SqlConnection con = null;

        public frmmain()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmaddmember a = Global.addm;
            a.ShowDialog();

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmlogin l = Global.l;
            l.ShowDialog();

        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e)
        {
            linkacceptmonthlyinst.BringToFront();



        }

        private void linkLabel9_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\WCE\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
           
            try
            {
            con.Open();
          // MessageBox.Show("Successful connection");

            SqlDataAdapter da = new SqlDataAdapter("select * from installment", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Exception in connection");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Accept monthly installment
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAcceptmonthly f = Global.accept;
            f.ShowDialog();
            
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            
            if (txtcurrent.Text == "")
            {
                MessageBox.Show("New Month field is Empty..");
               
            }
            else
            {

                if ((MessageBox.Show("You Are Adding new month in database..before that make sure that all previous month Updation is successfully completed\n Are You sure and want to Continue?? press OK to Continue else Cancel", "New Month", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) == DialogResult.OK)
                {
                    try
                    {


                        con.Open();
                        String m = txtcurrent.Text;
                        SqlCommand cmd = new SqlCommand("truncate table currentmonth", con);
                        cmd.ExecuteNonQuery();
                        cmd = new SqlCommand("insert into currentmonth values('" + m + "')", con);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("alter table installment add " + m + " varchar(20)", con);
                        cmd.ExecuteNonQuery();


                        con.Close();
                        txtcurrent.Clear();
                        MessageBox.Show("Month Information Successfully updated", "New Month", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException sqx)
                    {
                        MessageBox.Show(sqx.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                    return;

                
            }

            

        }

        private void linkseememberdeteil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmmemberdetail d = Global.det;
            d.ShowDialog();
        }

        private void linkseecurrentmonthsub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmseecurrentsub f = Global.cur;
            f.ShowDialog();
        }

        private void linkofferloan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmofferloan ol = Global.ol;
            ol.ShowDialog();
        }

        private void lnkloaninterest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frminterestsub isub = Global.isub;
            isub.ShowDialog();
        }
    }

}
