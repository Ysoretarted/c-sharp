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
    public partial class Form4__用户登录 : Form
    {
        string str1;
        Form lastform;
        public Form4__用户登录(string a,Form f)
        {
            InitializeComponent();
            this.str1 = a;
            MessageBox.Show(str1);
            登录用户.Text = str1;
            this.lastform = f;
         }

        private void Form4__用户登录_Load(object sender, EventArgs e)
        {

        }

        private void Form4__用户登录_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void 登录用户_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip1.Show(登录用户, 0, this.登录用户.Height);
        }


        private void 个人中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("个人中心");
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("修改密码");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
            MessageBox.Show("退出");
        }

        private void 登录用户_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void 登录用户_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }


    }
}
