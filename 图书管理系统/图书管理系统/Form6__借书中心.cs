using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;




using System.Threading.Tasks;


namespace 图书管理系统
{
    public partial class Form6__借书中心 : Form
    {
        //Form4__用户登录 lastform;
        private void init(){
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
                    if(j==0)
                        item.Text =row[j].ToString().Trim();
                    else
                        item.SubItems.Add(row[j].ToString().Trim());
                }
                listView1.Items.Add(item);
            }
            this.listView1.EndUpdate();

        }
        public Form6__借书中心(string a)
        {
            InitializeComponent();
            label2.Text = a;
            //lastform = f;
           /* Graphics g = this.CreateGraphics();

            //出来一个画笔,这只笔画出来的颜色是红的  
            Pen p = new Pen(Brushes.Red);

            //创建两个点  
            Point p1 = new Point(50, 50);
            Point p2 = new Point(100, 100);

            //将两个点连起来  
            g.DrawLine(p, p1, p2);*/
            init();

        }

        private void Form6__借书中心_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.UpArrow;
        }

        private void Form6__借书中心_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Point p = this.listView1.PointToClient(Control.MousePosition);
         //   ListViewHitTestInfo testInfo = this.listView1.HitTest(p);
           // Console.WriteLine(testInfo.Item.Index);
         //  MessageBox.Show(testInfo.Item.Index.ToString());
            int a = listView1.FocusedItem.Index;
            if (listView1.SelectedItems.Count == 1)//避免以后句子被触发两次
                //MessageBox.Show(a.ToString());
                MessageBox.Show(listView1.Items[a].SubItems[1].Text);
        }
    }
}
