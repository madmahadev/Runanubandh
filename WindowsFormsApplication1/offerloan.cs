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
    public partial class frmofferloan : Form
    {
        SqlConnection con = null;
        public frmofferloan()
        {
            InitializeComponent();
        }

        private void btnoffer_Click(object sender, EventArgs e)
        {
           
            if(cmbmember .SelectedItem .ToString ()=="")
            {
                MessageBox.Show("Select Member Name First Please..");
                cmbmember.Focus();
               // return;

            }
            String name = (String)cmbmember.SelectedItem;
            
            int amount = 0;
            bool res = int.TryParse(txtamount.Text, out amount);
            if(!res )
            {
                MessageBox.Show("Amount value not valied");
                txtamount.Focus();
                return;
            }
            
            String date = (String)dateTimePicker1.Value.Date.ToString();
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into loan values('"+name+"',"+amount +",'"+date +"')",con );
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Loan Is Offered Successfully to"+name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }


        }

        private void frmofferloan_Load(object sender, EventArgs e)
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


        private void btncancle_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
