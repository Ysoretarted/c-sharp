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
    public partial class Form1 : Form
    {
        string str1 = "";
        string str2 = "";
        int user_flag = 1;
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImage=Image.FromFile("C:\\Users\\ZCZ\\Desktop\\杂七杂八\\1.jpg");
        }

        private void 登录_Click(object sender, EventArgs e)
        {
            str1=textBox1.Text.ToString();
            str2=textBox2.Text.ToString();
            //数据库连接字符串（引号中的字符串为之前复制的那段字符）  
            //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名，  
            //Password=数据库连接密码,integrated Security=True  
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);


            SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='"+str1+"'", conn); //定义一个数据库操作指令
            SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
            SelectAdapter.SelectCommand = MyCommand;//定义数据适配器的操作指令
            DataSet MyDataSet = new DataSet();//定义一个数据集
            conn.Open();//打开数据库连接
            SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
            conn.Close();//关闭数据库
            SelectAdapter.Fill(MyDataSet);//填充数据集
            //DataGrid DataGird1 = new DataGrid();



            DataTable table = MyDataSet.Tables[0]; //查询第一张表
            int flag = 0;
            MessageBox.Show(table.Columns.Count + "  " + table.Columns.Count);
            for (int i = 0; i < table.Rows.Count; i++)  //遍历每一行,DataTable包含若干个行
            {
                DataRow row = table.Rows[i];    //遍历每一行,得到每一行的内容
                //  MessageBox.Show(table.Columns.Count.ToString());
                for (int j = 0; j < table.Columns.Count; j++) {//遍历row的列
                    if (row[j].ToString().Trim() == str2) flag = 1;
                    else flag = 2;
                }    
             }
            MessageBox.Show(flag.ToString());
            if (flag == 1)
            {
                str1 = textBox1.Text.ToString();
                if (user_flag == 1) {
                Form4__用户登录 f4 = new Form4__用户登录(str1,this);
                f4.Show();
                }
                else if (user_flag == 2) {
                    Form5__管理员登入 f5 = new Form5__管理员登入(str1,this);
                    f5.Show();
                }
                this.Hide();
            }
            else if(flag==2){
                MessageBox.Show("密码错误,请重新输入!");
            }
            else if (flag == 0) {
                MessageBox.Show("账号不存在，请重新输入!");
            }
             
        }

        private void 注册_Click(object sender, EventArgs e)
        {

            /*str1 = textBox1.Text.ToString();

            Form4__用户登录 f4 = new Form4__用户登录(str1);
            f4.Show();*/
            Form3 f3 = new Form3(this);
            f3.Show();
            this.Hide();
        }

        private void 用户_CheckedChanged(object sender, EventArgs e)
        {
            if (用户.Checked) user_flag = 1;
            else user_flag = 2;
        }

        private void 管理员_CheckedChanged(object sender, EventArgs e)
        {
            if (管理员.Checked) user_flag = 2;
            else user_flag = 1;
        }
    }
}
