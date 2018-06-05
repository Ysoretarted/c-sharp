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
            管理员登入.Text = a;
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
            MessageBox.Show("guanli --个人中心");
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("guanli --修改密码");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
            MessageBox.Show("guanli --退出");
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
    }
}
