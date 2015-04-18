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
    public partial class frmaddmember : Form
    {
        SqlConnection con = null;
        String name;
        String village;
        String mob;
        String dateofjoin;

        public frmaddmember()
        {
            InitializeComponent();
        }

        private void txtmob_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void frmaddmember_Load(object sender, EventArgs e)
        {
            btnadd.Enabled = false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                btnadd.Enabled = true;
            else
                btnadd.Enabled = false;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtvillage_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtmob_Leave(object sender, EventArgs e)
        {
                        
                
                
            
        }

        private void txtvillage_Leave(object sender, EventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           
            village = txtvillage.Text;
            mob = txtmob.Text; 
            name = txtname.Text;
            String sname = name.Replace(" ", String.Empty);
            if(village ==""||mob==""||name=="")
            {
                MessageBox.Show("Field Canot be Empty..");
                txtname.Focus();
                return;
            }
            long m;

            String t = txtmob.Text;

            bool b = long.TryParse(t, out m);
            if (!b)
            {
                MessageBox.Show("Mobile No not Valid");

                txtmob.Focus();
                return;
            }

               


            try
            {



                con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\WCE\\VSprj\\WindowsFormsApplication1\\WindowsFormsApplication1\\Database3.mdf;Integrated Security=True");
                con.Open();
                dateofjoin = dateTimePicker1.Value.Date.ToString();
                SqlCommand cmd = null;

                cmd = new SqlCommand("insert into memberinfo values('" + name + "','" + village + "','" + mob + "','" + dateofjoin + "')", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("insert into memberlist values('" + sname + "')", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO installment (name) VALUES ('" + name + "')", con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("create table "+sname+"(monthofsubmission varchar(20) not null,dateofsubmission varchar(20),amount int)", con);
                cmd.ExecuteNonQuery();
                txtname.Clear();
                txtmob.Clear();
                txtvillage.Clear();
                MessageBox.Show("Record Inserted Succesfully....\nHEARTLY WELCOME IN RUNANUBANDH GROUP "+name+"!!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Record Not Inserted properly make sure that DUPLICATION OF MEMBER NAME IS NOT THERE");


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
    }
    public class Global
    {
        public static frmwelcome w = new frmwelcome();
        public static frmlogin  l = new frmlogin();
        public static frmmain  m = new frmmain();
        public static frmforgtpass  f = new frmforgtpass();
        public static frmaddmember  addm = new frmaddmember();
        public static frmAcceptmonthly  accept = new frmAcceptmonthly ();
        //public static frmmemberdetail  mded = new frmmemberdetail();
        public static frmseecurrentsub  cur = new frmseecurrentsub ();
        public static frmmemberdetail  det = new frmmemberdetail ();
        public static frmofferloan ol = new frmofferloan();
        public static frminterestsub isub = new frminterestsub();
    }
}
