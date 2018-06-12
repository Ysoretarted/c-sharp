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
    public partial class Form12__修改图书信息 : Form
    {
        private void init() {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
        }
        string bookid = null;
        Form5__管理员登入 lastform = null;
        public Form12__修改图书信息(Form5__管理员登入 f)
        {
            InitializeComponent();
            lastform = f;
            init();
        }

        private void Form12__修改图书信息_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("------  " + bookid);
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            string sql = "update Books set 书籍序列号=@add1,书名=@add2,作者=@add3,出版社=@add4,价格=@add5,库存量=@add6 where 书籍序列号=@bookid;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@bookid",bookid);
            cmd.Parameters.AddWithValue("@add1", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@add2", textBox3.Text.ToString());
            cmd.Parameters.AddWithValue("@add3", textBox4.Text.ToString());
            cmd.Parameters.AddWithValue("@add4", textBox5.Text.ToString());
            cmd.Parameters.AddWithValue("@add5", textBox6.Text.ToString());
            cmd.Parameters.AddWithValue("@add6", textBox7.Text.ToString());
            conn.Open();//数据库必须打开
            cmd.ExecuteNonQuery();

            //MessageBox.Show("+++++  " + bookid);
            string sql1 = "update Rent_books set 书籍序列号=@add1,书名=@add2,作者=@add3,出版社=@add4 where 书籍序列号=@bookid;";
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.Parameters.AddWithValue("@bookid", bookid);
            cmd1.Parameters.AddWithValue("@add1", textBox2.Text.ToString());
            cmd1.Parameters.AddWithValue("@add2", textBox3.Text.ToString());
            cmd1.Parameters.AddWithValue("@add3", textBox4.Text.ToString());
            cmd1.Parameters.AddWithValue("@add4", textBox5.Text.ToString());
           // cmd1.Parameters.AddWithValue("@add5", textBox6.Text.ToString());
           // cmd1.Parameters.AddWithValue("@add6", textBox7.Text.ToString());
            if (cmd1.ExecuteNonQuery() > 0||cmd.ExecuteNonQuery()>0) MessageBox.Show("更新成功");
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            init();
            bookid = textBox1.Text.ToString().Trim();
            if (bookid==string.Empty)
                MessageBox.Show("输入不能为空，请重新输入");
            else {
                //数据库连接字符串（引号中的字符串为之前复制的那段字符）  
                //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名，  
                //Password=数据库连接密码,integrated Security=True  
                string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(str);

                //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='"+str1+"' and 类型='"+user_flag+"'", conn); 


                //多条件查询
                SqlCommand MyCommand = new SqlCommand("SELECT * FROM Books WHERE 书籍序列号='" + bookid + "'", conn); //定义一个数据库操作指令
                SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
                SelectAdapter.SelectCommand = MyCommand;//定义数据适配器的操作指令
                DataSet MyDataSet = new DataSet();//定义一个数据集
                conn.Open();//打开数据库连接
                SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
                conn.Close();//关闭数据库
                SelectAdapter.Fill(MyDataSet);//填充数据集
                //DataGrid DataGird1 = new DataGrid();


                int flag = 0;
                DataTable table = MyDataSet.Tables[0]; //查询第一张表
              //  MessageBox.Show(table.Columns.Count + "  " + table.Columns.Count);
                for (int i = 0; i < table.Rows.Count; i++)  //遍历每一行,DataTable包含若干个行
                {
                    DataRow row = table.Rows[i];    //遍历每一行,得到每一行的内容
                    //  MessageBox.Show(table.Columns.Count.ToString());
                    for (int j = 0; j < table.Columns.Count; j++)
                    {//遍历row的列
                        flag = 1;
                        if (j == 0) textBox2.Text = row[j].ToString().Trim();
                        else if (j == 1) textBox3.Text = row[j].ToString().Trim();
                        else if (j == 2) textBox4.Text = row[j].ToString().Trim();
                        else if (j == 3) textBox5.Text = row[j].ToString().Trim();
                        else if (j == 4) textBox6.Text = row[j].ToString().Trim();
                        else if (j == 5) textBox7.Text = row[j].ToString().Trim();
                    }
                }
                if (flag == 0)
                    MessageBox.Show("无此书籍的信息，请重新输入");
            }

            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
        }

        private void Form12__修改图书信息_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false;
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.ReadOnly = false;
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.ReadOnly = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.ReadOnly = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.ReadOnly = false;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
        }


    }
}
