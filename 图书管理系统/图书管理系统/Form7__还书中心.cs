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
    public partial class Form7__还书中心 : Form
    {
      //  string user=null;
        Form4__用户登录 lastform;
        int a;
        string bookid=null;
        private void init()
        {
            this.listView1.Columns.Add("书籍序列号", 60, HorizontalAlignment.Left);
            this.listView1.Columns.Add("书名", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("作者", 100, HorizontalAlignment.Left);
            this.listView1.Columns.Add("出版社", 80, HorizontalAlignment.Left);
            this.listView1.Columns.Add("借阅日期", 150, HorizontalAlignment.Left);
            this.listView1.Columns.Add("到期时间", 150, HorizontalAlignment.Left);
            this.listView1.Columns.Add("状态", 50, HorizontalAlignment.Left);
            this.listView1.Columns.Add("备注", 150, HorizontalAlignment.Left);
            this.listView1.View = System.Windows.Forms.View.Details;


            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);

            //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 账号='"+str1+"' and 类型='"+user_flag+"'", conn); 


            //多条件查询
            string state = "未还";
            SqlCommand MyCommand = new SqlCommand("SELECT 书籍序列号,书名,作者,出版社,借书日期,到期日期,状态,备注 FROM Rent_books where 账号='" + Form1.ID + "'and 状态='" + state + "'", conn); //定义一个数据库操作指令
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
        public Form7__还书中心(string a,Form4__用户登录 f)
        {
            InitializeComponent();
           // user=a;
            label2.Text = Form1.ID;
            lastform = f;
            init();
        }

        private void Form7__还书中心_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

 

        private void button2_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = listView1.FocusedItem.Index;
            /*add1 = listView1.Items[a].SubItems[0].Text;
            add2 = listView1.Items[a].SubItems[1].Text;
            add3 = listView1.Items[a].SubItems[2].Text;
            add4 = listView1.Items[a].SubItems[3].Text;*/
            if (listView1.SelectedItems.Count == 1)
            {//避免以后句子被触发两次
                bookid = listView1.Items[a].SubItems[0].Text;
                //MessageBox.Show(bookid);
                string aa = listView1.Items[a].SubItems[7].Text;
                if (aa != string.Empty)
                    MessageBox.Show("该书已被管理员删除，请到前台手动还书!");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);

            //SqlCommand MyCommand = new SqlCommand("SELECT 密码 FROM Users WHERE 书籍序列号='"+str1+"' and 类型='"+user_flag+"'", conn); 


            //多条件查询
            SqlCommand MyCommand = new SqlCommand("SELECT 库存量 FROM Books WHERE 书籍序列号='" + bookid + "'", conn); //定义一个数据库操作指令
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
            if (table.Rows.Count == 0)
                MessageBox.Show("无此书籍，请重新输入");
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)  //遍历每一行,DataTable包含若干个行
                {
                    DataRow row = table.Rows[i];    //遍历每一行,得到每一行的内容
                    for (int j = 0; j < table.Columns.Count; j++)
                    {//遍历row的列

                            conn.Open();



                           string  add5 = System.DateTime.Now.ToString();
                           string  add6="已还";
                           // add6 = System.DateTime.Now.AddDays(60).ToString();
                          //  MessageBox.Show(add5 + "   " + add6);
                           string sql = "update Rent_books set 还书日期=@add5,状态=@add6 where 书籍序列号=@bookid and 账号=@name;";
                           SqlCommand cmd = new SqlCommand(sql, conn);
                           cmd.Parameters.AddWithValue("@add5",add5);
                           cmd.Parameters.AddWithValue("@add6", add6);
                           cmd.Parameters.AddWithValue("@bookid",bookid );
                           cmd.Parameters.AddWithValue("@name", Form1.ID);
                           cmd.ExecuteNonQuery();



                            int num = int.Parse(row[j].ToString().Trim()) + 1;
                            //MessageBox.Show("num   "+num);
                            
                            sql = "update Books set 库存量=@num  where 书籍序列号=@id;";
                            cmd = new SqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@num", num);
                            cmd.Parameters.AddWithValue("@id", bookid);
                            cmd.ExecuteNonQuery();
                        MessageBox.Show("成功还书");
                           

                        }
                    
            
                }
            }
            listView1.Items.Clear();
            init();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }
    }
}
