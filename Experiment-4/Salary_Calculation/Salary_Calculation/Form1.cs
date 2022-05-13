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


namespace Salary_Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double sal, etfamount, epfamount, gsal, nsal, allowance;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string conString = "Data Source=LAPTOP-TTVBJPBU;Initial Catalog=Akash;Integrated Security=True";

        private void txtetf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "Update exp4 set name = '" + txtName.Text + "' , salary = '" + txtSal.Text + "' , ETF = '" + txtetf.Text + "' , EPF = '" + txtepf.Text + "' , Gross_Salary =  '" + txtGsal.Text + "' , Allowance = '" + txtAllowance.Text + "' ,Net_Salary = '" + txtNsal.Text + "' where name = '" + txtName.Text + "' ";

                SqlCommand sqlCommand = new SqlCommand(query, con);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully");

                con.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            if(con.State == System.Data.ConnectionState.Open)
            {
                string query = "Delete from exp4 where name = '" + txtName.Text + "'";

                SqlCommand sqlCommand = new SqlCommand(query,con);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record Deleted Successfully");

                con.Close();
            }
        }

        SqlConnection con;


        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            con.Open();

            if(con.State == System.Data.ConnectionState.Open)
            {
                string query = "Insert into exp4 values ( '" + txtName.Text + "' , '" + txtSal.Text + "' , '" + txtetf.Text + "' , '" + txtepf.Text + "' , '" + txtGsal.Text + "' , '" + txtAllowance.Text + "' , '" + txtNsal.Text + "' )";

                SqlCommand sqlCommand = new SqlCommand(query, con);

                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully");

                con.Close();
            }

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        //EPF - Employee Provident Fund 
        //ETF - exchange-traded fund
        private void btnOk_Click(object sender, EventArgs e)
        {
            sal = Double.Parse(txtSal.Text);

            if(chketf.Checked == true)
            {
                etfamount = sal * 5 / 100;
            }

            if (chkepf.Checked == true)
            {
                epfamount = sal * 10 / 100;
            }

            txtetf.Text = etfamount.ToString();
            txtepf.Text = epfamount.ToString();

            gsal = sal - (etfamount + epfamount);

            txtGsal.Text = gsal.ToString();

            if (sal > 50000)
            {
                allowance = 3000;
            }
            else if(sal > 30000)
            {
                allowance = 1000;
            }
            else
            {
                allowance = 0;
            }

            txtAllowance.Text = allowance.ToString();

            nsal = gsal + allowance;

            txtNsal.Text = nsal.ToString();
        }
    }
}
