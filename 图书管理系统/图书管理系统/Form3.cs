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
    public partial class Form3 : Form
    {
        Form lastform;
        public Form3(Form f)
        {
            InitializeComponent();
            this.lastform = f;
        //    MessageBox.Show(Form1.ID);
          //  Form1.ID = "aaaa";
          //  MessageBox.Show(Form1.ID);
        }
        int flag = 1;//注册账号类型
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 确定注册_Click(object sender, EventArgs e)
        {
            int empty = 0;
            string str1 = textBox1.Text.ToString();
            string str2 = textBox2.Text.ToString();
            if (str1.Length == 0) {
                MessageBox.Show("账号不能为空");
                empty = 1;
            }
            if (str2.Length == 0) {
                MessageBox.Show("密码不能为空");
                empty = 1;
            }
            if (empty != 1) {
                string str = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=zpjsb;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Users(账号,密码,类型)VALUES('" + str1 + "','" + str2 + "','" + flag + "')", con);
                // cmd.ExecuteNonQuery();
                try
                {
                    if (!str1.Equals(string.Empty) && !str2.Equals(string.Empty))
                    {
                        // OleDbCommand cmd = new OleDbCommand(sql, conn);
                        // conn.Open();
                        if (cmd.ExecuteNonQuery() > 0) MessageBox.Show("添加成功");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "添加失败111");
                }
                finally
                {
                    con.Close();
                }
            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) flag = 1;
            else flag = 2;
           // MessageBox.Show("1111  "+flag.ToString());
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) flag = 2;
            else flag = 1;
          //  MessageBox.Show("222  "+flag.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length >16)
            {
                string str1 = textBox1.Text;
                string str2 = "";
                for (int i = 0; i < str1.Length-1; i++) {
                    str2 += str1[i];
                }
                textBox1.Text = str2;
                MessageBox.Show("账号长度不能超过16位！");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox2.Text.Length > 16)
            {
                string str1 = textBox2.Text;
                string str2 = "";
                for (int i = 0; i < str1.Length - 1; i++)
                {
                    str2 += str1[i];
                }
                textBox2.Text = str2;
                MessageBox.Show("密码长度不能超过16位！");
            }
        }

        private void 返回_Click(object sender, EventArgs e)
        {
            lastform.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
