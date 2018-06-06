namespace 图书管理系统
{
    partial class Form4__用户登录
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
            this.登录用户 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.个人中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书 = new System.Windows.Forms.Button();
            this.还书 = new System.Windows.Forms.Button();
            this.借阅 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 登录用户
            // 
            this.登录用户.AutoEllipsis = true;
            this.登录用户.Font = new System.Drawing.Font("宋体", 12F);
            this.登录用户.Location = new System.Drawing.Point(379, 9);
            this.登录用户.Name = "登录用户";
            this.登录用户.Size = new System.Drawing.Size(100, 20);
            this.登录用户.TabIndex = 3;
            this.登录用户.Text = "用户";
            this.登录用户.Click += new System.EventHandler(this.登录用户_Click);
            this.登录用户.MouseEnter += new System.EventHandler(this.登录用户_MouseEnter);
            this.登录用户.MouseLeave += new System.EventHandler(this.登录用户_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F);
            this.label2.Location = new System.Drawing.Point(332, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户：";
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
            // 借书
            // 
            this.借书.Location = new System.Drawing.Point(56, 75);
            this.借书.Name = "借书";
            this.借书.Size = new System.Drawing.Size(130, 50);
            this.借书.TabIndex = 5;
            this.借书.Text = "借书中心";
            this.借书.UseVisualStyleBackColor = true;
            this.借书.Click += new System.EventHandler(this.借书_Click);
            // 
            // 还书
            // 
            this.还书.Location = new System.Drawing.Point(56, 159);
            this.还书.Name = "还书";
            this.还书.Size = new System.Drawing.Size(130, 50);
            this.还书.TabIndex = 6;
            this.还书.Text = "还书中心";
            this.还书.UseVisualStyleBackColor = true;
            this.还书.Click += new System.EventHandler(this.还书_Click);
            // 
            // 借阅
            // 
            this.借阅.Location = new System.Drawing.Point(56, 246);
            this.借阅.Name = "借阅";
            this.借阅.Size = new System.Drawing.Size(130, 50);
            this.借阅.TabIndex = 7;
            this.借阅.Text = "借阅记录";
            this.借阅.UseVisualStyleBackColor = true;
            this.借阅.Click += new System.EventHandler(this.借阅_Click);
            // 
            // Form4__用户登录
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.借阅);
            this.Controls.Add(this.还书);
            this.Controls.Add(this.借书);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.登录用户);
            this.Name = "Form4__用户登录";
            this.Text = "Form4__用户登录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4__用户登录_FormClosed);
            this.Load += new System.EventHandler(this.Form4__用户登录_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label 登录用户;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Button 借书;
        private System.Windows.Forms.Button 还书;
        private System.Windows.Forms.Button 借阅;

    }
}