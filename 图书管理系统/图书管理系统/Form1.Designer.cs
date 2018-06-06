namespace 图书管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.账号 = new System.Windows.Forms.Label();
            this.密码 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.用户 = new System.Windows.Forms.RadioButton();
            this.管理员 = new System.Windows.Forms.RadioButton();
            this.登录 = new System.Windows.Forms.Button();
            this.注册 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 账号
            // 
            this.账号.AutoSize = true;
            this.账号.BackColor = System.Drawing.Color.Transparent;
            this.账号.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.账号.Location = new System.Drawing.Point(77, 65);
            this.账号.Name = "账号";
            this.账号.Size = new System.Drawing.Size(41, 12);
            this.账号.TabIndex = 0;
            this.账号.Text = "账号：";
            // 
            // 密码
            // 
            this.密码.AutoSize = true;
            this.密码.BackColor = System.Drawing.Color.Transparent;
            this.密码.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.密码.Location = new System.Drawing.Point(77, 148);
            this.密码.Name = "密码";
            this.密码.Size = new System.Drawing.Size(41, 12);
            this.密码.TabIndex = 1;
            this.密码.Text = "密码：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 3;
            // 
            // 用户
            // 
            this.用户.AutoSize = true;
            this.用户.BackColor = System.Drawing.Color.Transparent;
            this.用户.Checked = true;
            this.用户.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.用户.Location = new System.Drawing.Point(79, 201);
            this.用户.Name = "用户";
            this.用户.Size = new System.Drawing.Size(46, 16);
            this.用户.TabIndex = 5;
            this.用户.TabStop = true;
            this.用户.Text = "用户\r\n";
            this.用户.UseVisualStyleBackColor = false;
            this.用户.CheckedChanged += new System.EventHandler(this.用户_CheckedChanged);
            // 
            // 管理员
            // 
            this.管理员.AutoSize = true;
            this.管理员.BackColor = System.Drawing.Color.Transparent;
            this.管理员.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.管理员.Location = new System.Drawing.Point(203, 201);
            this.管理员.Name = "管理员";
            this.管理员.Size = new System.Drawing.Size(58, 16);
            this.管理员.TabIndex = 6;
            this.管理员.TabStop = true;
            this.管理员.Text = "管理员\r\n";
            this.管理员.UseVisualStyleBackColor = false;
            this.管理员.CheckedChanged += new System.EventHandler(this.管理员_CheckedChanged);
            // 
            // 登录
            // 
            this.登录.BackColor = System.Drawing.Color.Transparent;
            this.登录.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.登录.Location = new System.Drawing.Point(79, 242);
            this.登录.Name = "登录";
            this.登录.Size = new System.Drawing.Size(75, 23);
            this.登录.TabIndex = 7;
            this.登录.Text = "登录\r\n";
            this.登录.UseVisualStyleBackColor = false;
            this.登录.Click += new System.EventHandler(this.登录_Click);
            // 
            // 注册
            // 
            this.注册.BackColor = System.Drawing.Color.Transparent;
            this.注册.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.注册.Location = new System.Drawing.Point(204, 241);
            this.注册.Name = "注册";
            this.注册.Size = new System.Drawing.Size(75, 23);
            this.注册.TabIndex = 8;
            this.注册.Text = "注册";
            this.注册.UseVisualStyleBackColor = false;
            this.注册.Click += new System.EventHandler(this.注册_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 307);
            this.Controls.Add(this.注册);
            this.Controls.Add(this.登录);
            this.Controls.Add(this.管理员);
            this.Controls.Add(this.用户);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.密码);
            this.Controls.Add(this.账号);
            this.Name = "Form1";
            this.Text = "图书管理系统--请登录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 账号;
        private System.Windows.Forms.Label 密码;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton 用户;
        private System.Windows.Forms.RadioButton 管理员;
        private System.Windows.Forms.Button 登录;
        private System.Windows.Forms.Button 注册;
    }
}

