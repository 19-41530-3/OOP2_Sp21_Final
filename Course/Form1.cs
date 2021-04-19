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
using System.Collections;

namespace Course
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cname = tbcoursename.Text;
            String ccode = tbcoursecode.Text;

            String connSteing = @"Server=LAPTOP-0A0FEGEC\SQLEXPRESS; Database=Prova1; User Id=prova; Password=prova;";
            SqlConnection conn = new SqlConnection(connSteing);
            conn.Open();
            String query = String.Format("insert into courses values('{0}','{1}')",cname,ccode);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();

            if (r > 0)
            {
                MessageBox.Show("Course inserted");
            }
            else
            {
                MessageBox.Show("Course not inserted");
            }


        }

        private void tbcoursename_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String cname = tbcoursename.Text;
            String ccode = tbcoursecode.Text;

            String connSteing = @"Server=LAPTOP-0A0FEGEC\SQLEXPRESS; Database=Prova1; User Id=prova; Password=1122;";
            SqlConnection conn = new SqlConnection(connSteing);
            List<Coures> courses = new List<Coures>();
            conn.Open();
            String query =" select * from courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Coures c = new Coures();
                c.ID = reader.GetInt32(reader.GetOrdinal("ID"));
                c.CourseName = reader.GetString(reader.GetOrdinal("CourseName"));
                c.CourseCode = reader.GetString(reader.GetOrdinal("CourseCode"));
                courses.Add(c);
                conn.Close();
                dtcourses.DataSource = courses;



            }



        }

        private void tbcoursecode_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

