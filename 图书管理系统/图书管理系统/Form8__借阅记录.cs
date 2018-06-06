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
    public partial class Form8__借阅记录 : Form
    {
        string id = null;
        Form4__用户登录 lastform;
        private void init() {
            this.listView1.Columns.Add("书籍序列号", 60, HorizontalAlignment.Left);
            this.listView1.Columns.Add("书名", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("作者", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("出版社", 80, HorizontalAlignment.Left);
            this.listView1.Columns.Add("借阅日期", 150, HorizontalAlignment.Left);
            this.listView1.Columns.Add("到期时间", 150, HorizontalAlignment.Left);
            this.listView1.Columns.Add("状态", 50, HorizontalAlignment.Left);
            this.listView1.View = System.Windows.Forms.View.Details;


            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);

            //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='"+str1+"' and 类型='"+user_flag+"'", conn); 


            //多条件查询
            SqlCommand MyCommand = new SqlCommand("SELECT 书籍序列号,书名,作者,出版社,借书日期,到期日期,状态 FROM Rent_books where 账号='"+id+"'", conn); //定义一个数据库操作指令
            SqlDataAdapter SelectAdapter = new SqlDataAdapter();//定义一个数据适配器
            SelectAdapter.SelectCommand = MyCommand;//定义数据适配器的操作指令
            DataSet MyDataSet = new DataSet();//定义一个数据集
            conn.Open();//打开数据库连接
            SelectAdapter.SelectCommand.ExecuteNonQuery();//执行数据库查询指令
            conn.Close();//关闭数据库
            SelectAdapter.Fill(MyDataSet);//填充数据集
            //DataGrid DataGird1 = new DataGrid();



            DataTable table = MyDataSet.Tables[0]; //查询第一张表
            // MessageBox.Show(table.Columns.Count + "  " + table.Columns.Count);
            for (int i = 0; i < table.Rows.Count; i++)  //遍历每一行,DataTable包含若干个行
            {
                ListViewItem item = new ListViewItem();
                DataRow row = table.Rows[i];    //遍历每一行,得到每一行的内容

                for (int j = 0; j < table.Columns.Count; j++)
                {//遍历row的列
                    if (j == 0)
                        item.Text = row[j].ToString().Trim();
                    else
                        item.SubItems.Add(row[j].ToString().Trim());
                }
                listView1.Items.Add(item);
            }
            this.listView1.EndUpdate();
        }
        
        public Form8__借阅记录(string a,Form4__用户登录 f)
        {
            InitializeComponent();
            id = a;
            init();
            label2.Text = a;
            this.lastform = f;
        }

        private void Form8__借阅记录_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
