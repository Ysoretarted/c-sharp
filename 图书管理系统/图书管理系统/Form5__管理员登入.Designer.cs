namespace 图书管理系统
{
    partial class Form5__管理员登入
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.管理员登入 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.个人中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.修改用户信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理图书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改学生密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.修改图书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // 管理员登入
            // 
            this.管理员登入.Font = new System.Drawing.Font("宋体", 12F);
            this.管理员登入.Location = new System.Drawing.Point(396, 61);
            this.管理员登入.Name = "管理员登入";
            this.管理员登入.Size = new System.Drawing.Size(100, 20);
            this.管理员登入.TabIndex = 1;
            this.管理员登入.Text = "管理员";
            this.管理员登入.Click += new System.EventHandler(this.管理员_Click);
            this.管理员登入.MouseEnter += new System.EventHandler(this.管理员登入_MouseEnter);
            this.管理员登入.MouseLeave += new System.EventHandler(this.管理员登入_MouseLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人中心ToolStripMenuItem,
            this.修改密码ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 个人中心ToolStripMenuItem
            // 
            this.个人中心ToolStripMenuItem.Name = "个人中心ToolStripMenuItem";
            this.个人中心ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.个人中心ToolStripMenuItem.Text = "个人中心";
            this.个人中心ToolStripMenuItem.Click += new System.EventHandler(this.个人中心ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改用户信息ToolStripMenuItem,
            this.管理图书信息ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 修改用户信息ToolStripMenuItem
            // 
            this.修改用户信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改学生密码ToolStripMenuItem});
            this.修改用户信息ToolStripMenuItem.Name = "修改用户信息ToolStripMenuItem";
            this.修改用户信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.修改用户信息ToolStripMenuItem.Text = "修改用户信息";
            // 
            // 管理图书信息ToolStripMenuItem
            // 
            this.管理图书信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改图书信息ToolStripMenuItem,
            this.新增图书ToolStripMenuItem,
            this.删除图书ToolStripMenuItem});
            this.管理图书信息ToolStripMenuItem.Name = "管理图书信息ToolStripMenuItem";
            this.管理图书信息ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.管理图书信息ToolStripMenuItem.Text = "管理图书信息";
            // 
            // 修改学生密码ToolStripMenuItem
            // 
            this.修改学生密码ToolStripMenuItem.Name = "修改学生密码ToolStripMenuItem";
            this.修改学生密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改学生密码ToolStripMenuItem.Text = "修改学生密码";
            this.修改学生密码ToolStripMenuItem.Click += new System.EventHandler(this.修改学生密码ToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // 修改图书信息ToolStripMenuItem
            // 
            this.修改图书信息ToolStripMenuItem.Name = "修改图书信息ToolStripMenuItem";
            this.修改图书信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.修改图书信息ToolStripMenuItem.Text = "修改图书信息";
            this.修改图书信息ToolStripMenuItem.Click += new System.EventHandler(this.修改图书信息ToolStripMenuItem_Click);
            // 
            // 新增图书ToolStripMenuItem
            // 
            this.新增图书ToolStripMenuItem.Name = "新增图书ToolStripMenuItem";
            this.新增图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增图书ToolStripMenuItem.Text = "新增图书";
            this.新增图书ToolStripMenuItem.Click += new System.EventHandler(this.新增图书ToolStripMenuItem_Click);
            // 
            // 删除图书ToolStripMenuItem
            // 
            this.删除图书ToolStripMenuItem.Name = "删除图书ToolStripMenuItem";
            this.删除图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除图书ToolStripMenuItem.Text = "删除图书";
            this.删除图书ToolStripMenuItem.Click += new System.EventHandler(this.删除图书ToolStripMenuItem_Click);
            // 
            // Form5__管理员登入
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.管理员登入);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5__管理员登入";
            this.Text = "Form5__管理员登入";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5__管理员登入_FormClosed);
            this.Load += new System.EventHandler(this.Form5__管理员登入_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label 管理员登入;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 修改用户信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改学生密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理图书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改图书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除图书ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}