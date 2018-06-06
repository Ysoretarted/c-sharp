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
            string dt = System.DateTime.Now.ToString();
            MessageBox.Show(dt);
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


            SqlCommand MyCommand = new SqlCommand("SELECT 密码,类型 FROM Users WHERE 账号='"+str1+"'", conn); //定义一个数据库操作指令
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
          //  MessageBox.Show(table.Rows.Count + "AAAAA" + table.Columns.Count);
            for (int i = 0; i < table.Rows.Count; i++)  //遍历每一行,DataTable包含若干个行
            {
                DataRow row = table.Rows[i];    //遍历每一行,得到每一行的内容
                //  MessageBox.Show(table.Columns.Count.ToString());

                flag=1;
                for (int j = 0; j < table.Columns.Count; j++) {//遍历row的列
                   // MessageBox.Show(row[j].ToString().Trim());
                    if(j==0){
                        if(!(row[j].ToString().Trim() == str2.Trim()))   flag = 2;
                    }
                    if (j == 1) {
                        if (!(row[j].ToString().Trim() ==user_flag.ToString()))   flag = 3;
                    }
                    
                }
                //if (j != 2 && flag != 3)
                //    flag = 1;
             }
           // MessageBox.Show(flag.ToString());


            flag = 1;




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
            else if (flag == 3) {
                MessageBox.Show("类型错误，请重新选择!");
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
           /* string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();//打开数据库连接
            str1 = textBox1.Text.ToString();
            str2 = textBox2.Text.ToString();
            StringBuilder sql = new StringBuilder("select * from Users");
            List<string> wheres = new List<string>();
                wheres.Add("用户名=" + str1);
                wheres.Add("密码=" +str2);
                wheres.Add("类型="+user_flag);
            //判断用户是否选择了条件
            if (wheres.Count > 0)
            {
               // string wh = string.Join(" and ", wheres.ToArray());
                //sql.Append(" where " + wh);
                MessageBox.Show("成功了"+user_flag+str1+str2);
            }*/
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
