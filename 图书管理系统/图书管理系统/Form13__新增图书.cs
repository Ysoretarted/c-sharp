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
    public partial class Form13__新增图书 : Form
    {
        string add1 = null, add2 = null, add3 = null, add4 = null;
        float add5;
        int add6;
        Form5__管理员登入 lastform;
        public Form13__新增图书(Form5__管理员登入 f)
        {
            InitializeComponent();
            lastform = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add1 = textBox1.Text.ToString();
            add2 = textBox2.Text.ToString();
            add3 = textBox3.Text.ToString();
            add4 = textBox4.Text.ToString();
            add5 = float.Parse(textBox5.Text.ToString());
            int add6 = int.Parse(textBox6.Text.ToString());

            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);

            //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 书籍序列号='"+str1+"' and 类型='"+user_flag+"'", conn); 


            //多条件查询
            SqlCommand cmd = new SqlCommand("INSERT INTO Books(书籍序列号,书名,作者,出版社,价格,库存量)VALUES('" + add1 + "','" + add2 + "','" + add3 + "','" + add4 + "','" + add5 + "','" + add6 + "')", conn);
            conn.Open();//打开数据库连接
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("成功添加");
            else MessageBox.Show("添加失败，请重新添加");
            conn.Close();//关闭数据库
        }

        private void Form13__新增图书_Load(object sender, EventArgs e)
        {

        }

        private void Form13__新增图书_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();

        }
    }
}
