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
    public partial class frmAcceptmonthly : Form
    {
        SqlConnection con = null;

        String mname;
        //int amount;
        public frmAcceptmonthly()
        {
            InitializeComponent();
        }

        private void cmbmember_SelectedIndexChanged(object sender, EventArgs e)
        {
            mname = (String )(cmbmember.SelectedItem) ;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Acceptmonthly_Load(object sender, EventArgs e)
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
            catch (Exception )
            {
                MessageBox.Show ("Exception in opening connection");

            }
            try
            {
                int count=dt.Rows.Count;
                DataRow dr;
               
                for (int i = 0; i < count;i++ )
                {
                     dr = dt.Rows[i];
                    
                    tname = (String )dr[0];
                   

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




        private void btncancle_Click(object sender, EventArgs e)
        {
            txtamount.Clear();
            this.Close();
          
            

        }




        private void btnaccept_Click(object sender, EventArgs e)
        {
            String m = (String )cmbmember.SelectedItem;
            String dt = dateTimePicker1.Value.ToString();

            if (m == "")
            {
                MessageBox.Show("Select Member First");
                return;
            }
            //String mt = m.Trim();


            string mt= m.Replace(" ", string.Empty);


           

            String a = (String)txtamount.Text;
            int amt;
            bool res = int.TryParse(a, out amt);
            if (res)
            {
                con.Open();


                SqlDataAdapter da = new SqlDataAdapter("select currentmonth from currentmonth", con);
                DataTable dt1 = new DataTable();
                try
                {
                    da.Fill(dt1);
                    DataRow r = dt1.Rows[0] ;
                    String mnt = (String)r[0];
                    String cmd = "update installment set "+mnt+"="+amt+" where name='"+m+"'";
                    SqlCommand cm = new SqlCommand(cmd, con);
                    cm.ExecuteNonQuery();
                    cm = new SqlCommand("insert into "+mt +" values('"+mnt+"','"+dt+"',"+amt +")", con);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Thanks for Contrubution...Amount Credited Successfully");

                }
                catch (SqlException sqlx)
                {
                    MessageBox.Show(sqlx.ToString());
                }
                finally
                {
                    con.Close();

                }
                

            }
            else
            {
                MessageBox.Show("Enter valid amount");
                return;
            }

        }

    }
}
