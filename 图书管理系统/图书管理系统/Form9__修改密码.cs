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
    public partial class Form9__修改密码 : Form
    {
        string password=null;
       // string user = null;
        
        private enum Strength
        {
            Invalid = 0, //无效密码
            Weak = 1, //低强度密码
            Normal = 2, //中强度密码
            Strong = 3 //高强度密码
        };
        /// <summary>
        /// 计算密码强度
        /// </summary>
        /// <param name="password">密码字符串</param>
        /// <returns></returns>
        private static Strength PasswordStrength(string password)
        {
            //空字符串强度值为0
            if (password == "") return Strength.Invalid;
            //字符统计
            int iNum = 0, iLtt = 0, iSym = 0;
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9') iNum++;
                else if (c >= 'a' && c <= 'z') iLtt++;
                else if (c >= 'A' && c <= 'Z') iLtt++;
                else iSym++;
            }
            if (iLtt == 0 && iSym == 0) return Strength.Weak; //纯数字密码
            if (iNum == 0 && iLtt == 0) return Strength.Weak; //纯符号密码
            if (iNum == 0 && iSym == 0) return Strength.Weak; //纯字母密码
            if (password.Length <= 6) return Strength.Weak; //长度不大于6的密码
            if (iLtt == 0) return Strength.Normal; //数字和符号构成的密码
            if (iSym == 0) return Strength.Normal; //数字和字母构成的密码
            if (iNum == 0) return Strength.Normal; //字母和符号构成的密码
            if (password.Length <= 10) return Strength.Normal; //长度不大于10的密码
            return Strength.Strong; //由数字、字母、符号构成的密码
        }

        private void init_user(){
            
            //数据库连接字符串（引号中的字符串为之前复制的那段字符）  
            //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名，  
            //Password=数据库连接密码,integrated Security=True  
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);

            //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='"+str1+"' and 类型='"+user_flag+"'", conn); 


            //多条件查询
            SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='" + Form1.ID + "'", conn); //定义一个数据库操作指令
            SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
            SelectAdapter.SelectCommand = MyCommand;//定义数据适配器的操作指令
            DataSet MyDataSet = new DataSet();//定义一个数据集
            conn.Open();//打开数据库连接
            SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
            conn.Close();//关闭数据库
            SelectAdapter.Fill(MyDataSet);//填充数据集
            //DataGrid DataGird1 = new DataGrid();



            DataTable table = MyDataSet.Tables[0]; //查询第一张表
            //MessageBox.Show(table.Columns.Count + "  " + table.Columns.Count);
            for (int i = 0; i < table.Rows.Count; i++)  //遍历每一行,DataTable包含若干个行
            {
                DataRow row = table.Rows[i];    //遍历每一行,得到每一行的内容
                //  MessageBox.Show(table.Columns.Count.ToString());
                for (int j = 0; j < table.Columns.Count; j++)
                {//遍历row的列
                    password = row[j].ToString().Trim();
                }
            }
            //MessageBox.Show(password);
        }
        Form4__用户登录 lastform=null;
        Form5__管理员登入 last=null;
        public Form9__修改密码(Form4__用户登录 f4,Form5__管理员登入 f5)
        {
            InitializeComponent();
            //user=a;
            lastform = f4;
            last = f5;
            init_user();
        }

        private void Form9__修改密码_Load(object sender, EventArgs e)
        {

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
            cmd.Parameters.AddWithValue("@bookid", Form1.ID);
            conn.Open();//数据库必须打开
            if(cmd.ExecuteNonQuery()>0)
                MessageBox.Show("修改成功"); ;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lastform != null)
                lastform.Show();
            else if (last != null)
                last.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Trim() != password)
                MessageBox.Show("密码错误，请重新输入i!");
            else
                MessageBox.Show("正确");
        }
    }
}
