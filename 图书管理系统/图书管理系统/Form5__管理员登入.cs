using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 图书管理系统
{
    public partial class Form5__管理员登入 : Form
    {

        Form lastform;
        public Form5__管理员登入(string a,Form f)
        {
            InitializeComponent();
            管理员登入.Text = Form1.ID;
            lastform = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form5__管理员登入_Load(object sender, EventArgs e)
        {

        }

        private void Form5__管理员登入_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 个人中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4__用户登录 a=null;
            Form10_修改信息 f = new Form10_修改信息(a, this);
            f.Show();
            this.Hide();
            //MessageBox.Show("guanli --个人中心");
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9__修改密码 f = new Form9__修改密码(null, this);
            f.Show();
            //MessageBox.Show("guanli --修改密码");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
            //MessageBox.Show("guanli --退出");
        }

        private void 管理员_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Show(管理员登入, 0, this.管理员登入.Height);
        }

        private void 管理员登入_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void 管理员登入_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }

        private void 修改学生密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11__管理员修改学生密码 f11 = new Form11__管理员修改学生密码(this);
            f11.Show();
            this.Hide();
        }

        private void 修改图书信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12__修改图书信息 f = new Form12__修改图书信息(this);
            f.Show();
            this.Hide();
        }

        private void 新增图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13__新增图书 f = new Form13__新增图书(this);
            f.Show();
            this.Hide();
        }

        private void 删除图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14__删除图书 f = new Form14__删除图书(this);
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }
    }
}
