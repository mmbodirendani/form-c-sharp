using System;  
using System.Collections.Generic;  
using System.ComponentModel;  
using System.Data;  
using System.Drawing;  
using System.Linq;  
using System.Text;  
using System.Windows.Forms;  
using System.Data.Sql;  
using System.Data.OleDb;  
using System.Data.SqlClient;  
  
namespace login_form  
{  
    public partial class Form1 : Form  
    {  
        SqlConnection con = new SqlConnection();  
        public Form1()  
        {  
            SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";  
  
            InitializeComponent();  
        }  
  
        private void Form1_Load(object sender, EventArgs e)  
        {  
            SqlConnection con = new SqlConnection("Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True");  
            con.Open();  
  
            {  
            }  
        }  
  
        private void button1_Click(object sender, EventArgs e)  
        {  
            SqlConnection con = new SqlConnection();  
            con.ConnectionString = "Data Source=KRISHNA-PC\\SQLEXPRESS;Initial Catalog=STUDENT;Integrated Security=True";  
            con.Open();  
            string userid = textBox1.Text;  
            string password = textBox2.Text;  
            SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + textBox1.Text + "'and password='" + text Box2.Text + "'", con);  
            SqlDataAdapter da = new SqlDataAdapter(cmd);  
            DataTable dt = new DataTable();  
            da.Fill(dt);  
            if (dt.Rows.Count > 0)  
            {  
                MessageBox.Show("Login sucess Welcome to Homepage http://krishnasinghprogramming.nlogspot.com");  
                System.Diagnostics.Process.Start("http://krishnasinghprogramming.blogspot.com");  
            }  
            else  
            {  
                MessageBox.Show("Invalid Login please check username and password");  
            }  
            con.Close();  
        }  
  
        private void button2_Click(object sender, EventArgs e)  
        {  
            Application.Exit();  
  
        }  
    }  
}  
