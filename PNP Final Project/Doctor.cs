using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace PNP
{
    public partial class Doctor : Form
    {
        
       
            SqlConnection con = new SqlConnection("data source=DESKTOP-8HS8EJU\\SQLEXPRESS;database=PNP;integrated security=True");
           
 
        
        public Doctor()
        {
            InitializeComponent();
        }

        private void Doctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {


                SqlCommand cmd = new SqlCommand("select * from D where username=@username and password=@password", con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adpt.Fill(ds);
                con.Close();

                int count = ds.Tables[0].Rows.Count;

                if (count == 1)
                {
                    MessageBox.Show("login Successful");
                    this.Hide();
                    new Doctor1().Show();
                }
                else { MessageBox.Show("Error Password"); }
            }

            else { MessageBox.Show("PLEASE ENTER ALL DATA");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
