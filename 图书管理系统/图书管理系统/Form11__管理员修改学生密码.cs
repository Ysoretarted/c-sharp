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
    public partial class Form11__管理员修改学生密码 : Form
    {
        Form5__管理员登入 lastform;
        string str1 = null;
        public Form11__管理员修改学生密码(Form5__管理员登入 f)
        {
            InitializeComponent();
            lastform = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            str1 = textBox1.Text.ToString();
            //数据库连接字符串（引号中的字符串为之前复制的那段字符）  
            //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名，  
            //Password=数据库连接密码,integrated Security=True  
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);

            //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='"+str1+"' and 类型='"+user_flag+"'", conn); 


            //多条件查询
            SqlCommand MyCommand = new SqlCommand("SELECT * FROM Users WHERE 账号='" + str1 + "'", conn); //定义一个数据库操作指令
            SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
            SelectAdapter.SelectCommand = MyCommand;//定义数据适配器的操作指令
            DataSet MyDataSet = new DataSet();//定义一个数据集
            conn.Open();//打开数据库连接
            SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
            conn.Close();//关闭数据库
            SelectAdapter.Fill(MyDataSet);//填充数据集
            //DataGrid DataGird1 = new DataGrid();

            int flag=0;

            DataTable table = MyDataSet.Tables[0]; //查询第一张表
            //MessageBox.Show(table.Columns.Count + "  " + table.Columns.Count);
            for (int i = 0; i < table.Rows.Count; i++)  //遍历每一行,DataTable包含若干个行
            {
                DataRow row = table.Rows[i];    //遍历每一行,得到每一行的内容
                //  MessageBox.Show(table.Columns.Count.ToString());
                for (int j = 0; j < table.Columns.Count; j++)
                {//遍历row的列
                    flag=1;
                }
            }
            if(flag==0)
                MessageBox.Show("无此学生的信息,请重输入!");
            else
                MessageBox.Show("存在!");
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.ToString() != textBox2.Text.ToString())
                MessageBox.Show("密码不一致，请重新输入");
            else
                MessageBox.Show("正确");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            string sql = "update Users set 密码=@num where 账号=@bookid;";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@num", textBox2.Text.ToString());
            cmd.Parameters.AddWithValue("@bookid", textBox1.Text.ToString());
            conn.Open();//数据库必须打开
            if (cmd.ExecuteNonQuery() > 0)
                MessageBox.Show("修改成功"); ;
            conn.Close();
        }

        private void Form11__管理员修改学生密码_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
