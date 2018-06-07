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
       // string str1;
        Form lastform;
        public Form4__用户登录(string a,Form f)
        {
            InitializeComponent();
          //  this.str1 = a;
           // MessageBox.Show(str1);
           // 登录用户.Text = Form1.ID;
            this.lastform = f;
            timer1.Interval = 1000;
            timer1.Enabled = true;
            
         }

        private void Form4__用户登录_Load(object sender, EventArgs e)
        {
            登录用户.Text = Form1.ID;
            MessageBox.Show(Form1.ID);
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
            Form10_修改信息 f = new Form10_修改信息(登录用户.Text.ToString(), this);
            f.Show();
            this.Hide();
           // MessageBox.Show("个人中心");
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9__修改密码 f9 = new Form9__修改密码(登录用户.Text.ToString(), this);
            f9.Show();
            this.Hide();
          //  MessageBox.Show("修改密码");
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

        private void 借书_Click(object sender, EventArgs e)
        {
            Form6__借书中心 f6 = new Form6__借书中心(登录用户.Text.ToString().Trim(),this);
            f6.Show();
            this.Hide();
        }

        private void 还书_Click(object sender, EventArgs e)
        {
           Form7__还书中心 f7 = new Form7__还书中心(登录用户.Text.ToString().Trim(),this);
           f7.Show();
            this.Hide();
        }


        private void 借阅_Click(object sender, EventArgs e)
        {
            Form8__借阅记录 f8 = new Form8__借阅记录(登录用户.Text.ToString().Trim(),this);
            f8.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
         //   timer1.Enabled = false;
           // MessageBox.Show("----");
            登录用户.Text = Form1.ID;
           
        }


    }
}
