﻿namespace QuanLyCuaHang
{
    partial class HomePageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePageForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caLàmViệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProductCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tồnKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.khuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.pnlOfProductCategory = new System.Windows.Forms.Panel();
            this.pnlOfHai = new System.Windows.Forms.Panel();
            this.xemHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2043, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.sảnPhẩmToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.doanhThuToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("danhMụcToolStripMenuItem.Image")));
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(52, 38);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(356, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caLàmViệcToolStripMenuItem,
            this.lươngToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(359, 44);
            this.toolStripMenuItem1.Text = "Nhân Viên";
            // 
            // caLàmViệcToolStripMenuItem
            // 
            this.caLàmViệcToolStripMenuItem.Name = "caLàmViệcToolStripMenuItem";
            this.caLàmViệcToolStripMenuItem.Size = new System.Drawing.Size(277, 44);
            this.caLàmViệcToolStripMenuItem.Text = "Ca Làm Việc";
            this.caLàmViệcToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenu_CaLamViec_Click);
            // 
            // lươngToolStripMenuItem
            // 
            this.lươngToolStripMenuItem.Name = "lươngToolStripMenuItem";
            this.lươngToolStripMenuItem.Size = new System.Drawing.Size(277, 44);
            this.lươngToolStripMenuItem.Text = "Bảng Lương";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProductCategory,
            this.tồnKhoToolStripMenuItem1,
            this.khuyếnMãiToolStripMenuItem});
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản Phẩm";
            // 
            // tsmProductCategory
            // 
            this.tsmProductCategory.Name = "tsmProductCategory";
            this.tsmProductCategory.Size = new System.Drawing.Size(371, 44);
            this.tsmProductCategory.Text = "Danh Mục Sản Phẩm";
            this.tsmProductCategory.Click += new System.EventHandler(this.ToolStripMenu_ProductCategory_Click);
            // 
            // tồnKhoToolStripMenuItem1
            // 
            this.tồnKhoToolStripMenuItem1.Name = "tồnKhoToolStripMenuItem1";
            this.tồnKhoToolStripMenuItem1.Size = new System.Drawing.Size(371, 44);
            this.tồnKhoToolStripMenuItem1.Text = "Kho";
            // 
            // khuyếnMãiToolStripMenuItem
            // 
            this.khuyếnMãiToolStripMenuItem.Name = "khuyếnMãiToolStripMenuItem";
            this.khuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.khuyếnMãiToolStripMenuItem.Text = "Khuyến Mãi";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtHóaĐơnToolStripMenuItem,
            this.xemHóaĐơnToolStripMenuItem});
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa Đơn";
            // 
            // xuấtHóaĐơnToolStripMenuItem
            // 
            this.xuấtHóaĐơnToolStripMenuItem.Name = "xuấtHóaĐơnToolStripMenuItem";
            this.xuấtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.xuấtHóaĐơnToolStripMenuItem.Text = "Xuất Hóa Đơn";
            this.xuấtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.OutPutBillToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.doanhThuToolStripMenuItem.Text = "Doanh Thu";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // pnlOfProductCategory
            // 
            this.pnlOfProductCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlOfProductCategory.Location = new System.Drawing.Point(1284, 231);
            this.pnlOfProductCategory.Name = "pnlOfProductCategory";
            this.pnlOfProductCategory.Size = new System.Drawing.Size(640, 292);
            this.pnlOfProductCategory.TabIndex = 1;
            // 
            // pnlOfHai
            // 
            this.pnlOfHai.Location = new System.Drawing.Point(170, 43);
            this.pnlOfHai.Name = "pnlOfHai";
            this.pnlOfHai.Size = new System.Drawing.Size(1810, 908);
            this.pnlOfHai.TabIndex = 2;
            // 
            // xemHóaĐơnToolStripMenuItem
            // 
            this.xemHóaĐơnToolStripMenuItem.Name = "xemHóaĐơnToolStripMenuItem";
            this.xemHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.xemHóaĐơnToolStripMenuItem.Text = "Xem Hóa Đơn";
            this.xemHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.BillViewToolStripMenuItem_Click);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(2043, 1041);
            this.Controls.Add(this.pnlOfHai);
            this.Controls.Add(this.pnlOfProductCategory);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomePageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cửa hàng tiện lợi";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem caLàmViệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmProductCategory;
        private System.Windows.Forms.ToolStripMenuItem tồnKhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuyếnMãiToolStripMenuItem;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Panel pnlOfProductCategory;
        private System.Windows.Forms.Panel pnlOfHai;
        private System.Windows.Forms.ToolStripMenuItem xuấtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHóaĐơnToolStripMenuItem;
    }
}