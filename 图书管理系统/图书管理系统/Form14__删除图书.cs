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
    public partial class Form14__删除图书 : Form
    {
        int a = -1;
        string bookid = null;
        Form5__管理员登入 lastform;
        private void init()
        {
            this.listView1.Columns.Add("书籍序列号", 60, HorizontalAlignment.Left);
            this.listView1.Columns.Add("书名", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("作者", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("出版社", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("价格", 60, HorizontalAlignment.Left);
            this.listView1.Columns.Add("库存量", 60, HorizontalAlignment.Left);
            this.listView1.View = System.Windows.Forms.View.Details;  //这命令比较重要，否则不能显示

            //数据库连接字符串（引号中的字符串为之前复制的那段字符）  
            //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名，  
            //Password=数据库连接密码,integrated Security=True  
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);

            //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='"+str1+"' and 类型='"+user_flag+"'", conn); 


            //多条件查询
            SqlCommand MyCommand = new SqlCommand("SELECT * FROM Books", conn); //定义一个数据库操作指令
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
        public Form14__删除图书(Form5__管理员登入  f)
        {
            InitializeComponent();
            init();
            lastform = f;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = listView1.FocusedItem.Index;
            bookid = listView1.Items[a].SubItems[0].Text;
            /*add2 = listView1.Items[a].SubItems[1].Text;
            add3 = listView1.Items[a].SubItems[2].Text;
            add4 = listView1.Items[a].SubItems[3].Text;
            if (listView1.SelectedItems.Count == 1)
            {//避免以后句子被触发两次
                bookid = listView1.Items[a].SubItems[0].Text;
                MessageBox.Show(bookid);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string q1 = "delete  Books where 书籍序列号='" +bookid + "'";
            SqlCommand cmd = new SqlCommand(q1, conn);
            if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("删除成功!");
            else MessageBox.Show("删除失败，请重新选择!");




            string sql = "update Rent_books set 备注=@num where 书籍序列号=@bookid;";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            cmd1.Parameters.AddWithValue("@num","该书已被管理员删除");
            cmd1.Parameters.AddWithValue("@bookid", bookid);
            cmd1.ExecuteNonQuery();


            conn.Close();
            listView1.Clear();
            init();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }

        private void Form14__删除图书_Load(object sender, EventArgs e)
        {

        }
    }
}
