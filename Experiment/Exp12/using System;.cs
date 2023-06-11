using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ameyk\onedrive\documents\visual studio 2010\Projects\WindowsFormsApplication2\WindowsFormsApplication2\Books.mdf;Integrated Security=True;User Instance=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd=con.CreateCommand();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText="insert into Books1(Title,Author,Publisher) values('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            disp_data();
            MessageBox.Show("Record Inserted");
        }
         public void disp_data()
        {
            con.Open();
            SqlCommand cmd=con.CreateCommand();
            cmd.CommandType=CommandType.Text;
            cmd.CommandText="select *from Books1";
            cmd.ExecuteNonQuery();
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource=dt;
            con.Close();
        }

         private void button2_Click(object sender, EventArgs e)
         {
             con.Open();
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "update Books1 set Title='"+textBox2.Text+"' where Title='"+textBox1.Text+"'";
             cmd.ExecuteNonQuery();
             con.Close();
             disp_data();
             MessageBox.Show("Record Updated");
           
         }

         private void Form1_Load(object sender, EventArgs e)
         {
             disp_data();
         }

         private void button3_Click(object sender, EventArgs e)
         {
             con.Open();
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "delete from Books1 where Title='"+textBox1.Text+"'";
             cmd.ExecuteNonQuery();
             con.Close();
             disp_data();
             MessageBox.Show("Record Deleted");
             textBox1.Text = "";
             textBox2.Text = "";
             textBox3.Text = "";
         }
         private void button5_Click(object sender, EventArgs e)
         {
             con.Open();
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "select *from Books1 where Title='"+textBox1.Text+"'";
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             da.Fill(dt);
             dataGridView1.DataSource = dt;
             con.Close();
       
         }

    }
}
