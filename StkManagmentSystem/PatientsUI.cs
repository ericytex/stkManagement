using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StkManagmentSystem
{
    public partial class PatientsUI : Form
    {
        SqlConnection con = new SqlConnection (@"Data Source=DESKTOP-JBPJ74V\SQLSERVERJAN2018;Initial Catalog=StkManagementSystem;Integrated Security=True");
        public PatientsUI()
        {
            InitializeComponent();
        }

        private void PatientsUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stkManagementSystemDataSet.patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.stkManagementSystemDataSet.patients);

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

           

            if(searchdb.Text == "")
            {
                //load all data into grid
                con.Open();
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "SELECT * FROM [dbo].[patients]";
                cmd2.ExecuteNonQuery();
                DataTable dt2 = new DataTable();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                da2.Fill(dt2);

                dataGridView1.DataSource = dt2;

                con.Close();
            }

            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM [dbo].[patients] WHERE uniqueid = '" + searchdb.Text + "' OR firstname = '" + searchdb.Text + "' OR middlename = '" + searchdb.Text + "' OR lastname = '" + searchdb.Text + "' OR gender = '" + searchdb.Text + "' OR dob = '" + searchdb.Text + "' OR address = '" + searchdb.Text + "' OR phonenr = '" + searchdb.Text + "' OR nok = '" + searchdb.Text + "' OR idnr = '" + searchdb.Text + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }



        }

       
    }
}
