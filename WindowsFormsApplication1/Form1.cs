using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class frmlogin : Form
    {
        SqlConnection con = null;


        long mob;
        String pass;
        public frmlogin()
        {
            InitializeComponent();
        }

        
       
        private void Form1_Load(object sender, EventArgs e)
        {
            txtmob.Focus();
        }
        protected void txtmob_Exit(Object sender, EventArgs e)
        {
            MessageBox.Show("TextBox1 focusing");
            if (txtmob.Focused) // get control is already focus
                MessageBox.Show("TextBox1 has been focused");
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {

            String t = txtmob.Text;

            bool b = long.TryParse(t, out mob);
            if (!b)
            {
                MessageBox.Show("Mobile No not Valid");
                //txtmob.Clear();
                txtmob.Focus();
                return;
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("Please insert password");
                txtpass.Focus();
                return;

            }
            pass = txtpass.Text;
            con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\WCE\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
            DataTable dt = new DataTable();
            try
            {

                con.Open();
                String qry = "select * from login where mobile='"+mob.ToString ()+"' AND pass='"+pass+"'" ;
                //MessageBox.Show("Successful connection");

                SqlDataAdapter da = new SqlDataAdapter(qry, con);

                da.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Exception in opening connection");

            }
            try
            {
                int count = dt.Rows.Count;
                if (count == 1)
                {
                    frmmain f = Global.m;
                    txtmob.Clear();
                    txtpass.Clear();
                    this.Close();

                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please Enter correct information..");
                    txtpass.Clear();
                }

            }
            catch (Exception)
            {
                // MessageBox.Show("data adding Exception");
            }
            finally
            {
                con.Close();
                mob = 00;
                pass = null ;



                txtmob.Clear();
                txtpass.Clear();
            }
       }

        private void txtmob_Leave(object sender, EventArgs e)
        {
            


        }

        private void txtmob_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void txtpass_Leave(object sender, EventArgs e)
        {


            

                
        }

        private void txtmob_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmob_LocationChanged(object sender, EventArgs e)
        {

        }

        private void btnforgot_Click(object sender, EventArgs e)
        {
            frmforgtpass f = Global.f;
            f.ShowDialog();
        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            frmwelcome w = Global.w;
            
            this.Close();
            w.ShowDialog();
        }

        private void frmlogin_Activated(object sender, EventArgs e)
        {

        }

        
       
    }
}
