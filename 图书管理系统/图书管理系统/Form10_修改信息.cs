using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 图书管理系统
{
    public partial class Form10_修改信息 : Form
    {
       // string user = null;
        Form4__用户登录 lastform;
        public Form10_修改信息(string a,Form4__用户登录 f4)
        {
            InitializeComponent();
            //user = a;
            lastform = f4;
        }

        private void Form10_修改信息_Load(object sender, EventArgs e)
        {

        }

        private void Form10_修改信息_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
            if (textBox1.Text.ToString() == string.Empty)
                MessageBox.Show("账号不能为空");
            else {
                string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(str);
                string sql = "update  Users set 账号=@num where 账号=@bookid;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@num",textBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@bookid", Form1.ID);
                conn.Open();//数据库必须打开
                if(cmd.ExecuteNonQuery()>0)
                    MessageBox.Show("修改成功");


                sql = "update  Rent_books set 账号=@num where 账号=@bookid;";
                SqlCommand cmd1 = new SqlCommand(sql, conn);
                cmd1.Parameters.AddWithValue("@num", textBox1.Text.ToString());
                cmd1.Parameters.AddWithValue("@bookid", Form1.ID);
                cmd1.ExecuteNonQuery();
                Form1.ID = textBox1.Text.ToString();
                MessageBox.Show(Form1.ID);
                conn.Close();
            }
        }
    }
}
