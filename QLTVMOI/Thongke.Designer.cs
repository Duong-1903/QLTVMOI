using System;
using System.Drawing;
using System.Windows.Forms;

namespace QLTVMOI
{
    partial class Thongke
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_congcu = new System.Windows.Forms.Panel();
            this.cms_thongke = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.locDưLiêuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêTôngQuanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_an = new System.Windows.Forms.Button();
            this.mns_congcu = new System.Windows.Forms.MenuStrip();
            this.quanLyThưViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mươnTraSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mươnSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caiĐatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chinhSachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_locdulieu = new System.Windows.Forms.Panel();
            this.rdb_muontra = new System.Windows.Forms.RadioButton();
            this.rdb_sach = new System.Windows.Forms.RadioButton();
            this.pnl_report = new System.Windows.Forms.Panel();
            this.btn_reportmuontra = new System.Windows.Forms.Button();
            this.btn_reportsach = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_dongldl = new System.Windows.Forms.Button();
            this.pnl_sach = new System.Windows.Forms.Panel();
            this.cbb_dieukienloc = new System.Windows.Forms.ComboBox();
            this.cbb_sach = new System.Windows.Forms.ComboBox();
            this.btn_sach = new System.Windows.Forms.Button();
            this.pnl_muontra = new System.Windows.Forms.Panel();
            this.cbb_muontra = new System.Windows.Forms.ComboBox();
            this.btn_muontra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_thongketongquan = new System.Windows.Forms.Panel();
            this.dtp_thang = new System.Windows.Forms.DateTimePicker();
            this.txt_tongluotmuon = new System.Windows.Forms.TextBox();
            this.txt_muontrongthang = new System.Windows.Forms.TextBox();
            this.txt_tongsachconlai = new System.Windows.Forms.TextBox();
            this.txt_tongsachdangmuon = new System.Windows.Forms.TextBox();
            this.txt_tongcuonsach = new System.Windows.Forms.TextBox();
            this.txt_tongdausach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dongtktq = new System.Windows.Forms.Button();
            this.pnl_table = new System.Windows.Forms.Panel();
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.cln_masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_nhaxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_danhsachmuontra = new System.Windows.Forms.DataGridView();
            this.cln_mapm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_tennguoimuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_tensachmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_ngaymuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_soluongmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerSach = new System.Windows.Forms.Timer(this.components);
            this.timerMuontra = new System.Windows.Forms.Timer(this.components);
            this.timerReport = new System.Windows.Forms.Timer(this.components);
            this.qltvDataSet2 = new QLTVMOI.qltvDataSet2();
            this.sachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sachTableAdapter = new QLTVMOI.qltvDataSet2TableAdapters.SachTableAdapter();
            this.pnl_congcu.SuspendLayout();
            this.cms_thongke.SuspendLayout();
            this.mns_congcu.SuspendLayout();
            this.pnl_locdulieu.SuspendLayout();
            this.pnl_report.SuspendLayout();
            this.pnl_sach.SuspendLayout();
            this.pnl_muontra.SuspendLayout();
            this.pnl_thongketongquan.SuspendLayout();
            this.pnl_table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachmuontra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qltvDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_congcu
            // 
            this.pnl_congcu.ContextMenuStrip = this.cms_thongke;
            this.pnl_congcu.Controls.Add(this.btn_thoat);
            this.pnl_congcu.Controls.Add(this.btn_an);
            this.pnl_congcu.Controls.Add(this.mns_congcu);
            this.pnl_congcu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_congcu.Location = new System.Drawing.Point(0, 0);
            this.pnl_congcu.Name = "pnl_congcu";
            this.pnl_congcu.Size = new System.Drawing.Size(1495, 50);
            this.pnl_congcu.TabIndex = 0;
            this.pnl_congcu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_congcu_MouseDown);
            // 
            // cms_thongke
            // 
            this.cms_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.cms_thongke.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_thongke.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locDưLiêuToolStripMenuItem,
            this.thôngKêTôngQuanToolStripMenuItem});
            this.cms_thongke.Name = "cms_thongke";
            this.cms_thongke.Size = new System.Drawing.Size(243, 60);
            // 
            // locDưLiêuToolStripMenuItem
            // 
            this.locDưLiêuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locDưLiêuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.locDưLiêuToolStripMenuItem.Name = "locDưLiêuToolStripMenuItem";
            this.locDưLiêuToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.locDưLiêuToolStripMenuItem.Text = "Lọc dữ liệu";
            this.locDưLiêuToolStripMenuItem.Click += new System.EventHandler(this.locDưLiêuToolStripMenuItem_Click);
            // 
            // thôngKêTôngQuanToolStripMenuItem
            // 
            this.thôngKêTôngQuanToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngKêTôngQuanToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thôngKêTôngQuanToolStripMenuItem.Name = "thôngKêTôngQuanToolStripMenuItem";
            this.thôngKêTôngQuanToolStripMenuItem.Size = new System.Drawing.Size(242, 28);
            this.thôngKêTôngQuanToolStripMenuItem.Text = "Thống kê tổng quan";
            this.thôngKêTôngQuanToolStripMenuItem.Click += new System.EventHandler(this.thôngKêTôngQuanToolStripMenuItem_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.ForeColor = System.Drawing.Color.White;
            this.btn_thoat.Location = new System.Drawing.Point(1452, 3);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(40, 38);
            this.btn_thoat.TabIndex = 0;
            this.btn_thoat.Text = "X";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_an
            // 
            this.btn_an.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_an.FlatAppearance.BorderSize = 0;
            this.btn_an.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_an.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_an.ForeColor = System.Drawing.Color.White;
            this.btn_an.Location = new System.Drawing.Point(1406, 3);
            this.btn_an.Name = "btn_an";
            this.btn_an.Size = new System.Drawing.Size(40, 38);
            this.btn_an.TabIndex = 0;
            this.btn_an.Text = "-";
            this.btn_an.UseVisualStyleBackColor = false;
            this.btn_an.Click += new System.EventHandler(this.btn_an_Click_1);
            // 
            // mns_congcu
            // 
            this.mns_congcu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mns_congcu.Dock = System.Windows.Forms.DockStyle.None;
            this.mns_congcu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mns_congcu.ForeColor = System.Drawing.Color.White;
            this.mns_congcu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns_congcu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyThưViênToolStripMenuItem,
            this.quanLySachToolStripMenuItem,
            this.mươnTraSachToolStripMenuItem,
            this.thôngKêToolStripMenuItem,
            this.caiĐatToolStripMenuItem});
            this.mns_congcu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mns_congcu.Location = new System.Drawing.Point(0, 0);
            this.mns_congcu.Name = "mns_congcu";
            this.mns_congcu.Size = new System.Drawing.Size(712, 31);
            this.mns_congcu.TabIndex = 1;
            this.mns_congcu.Text = "menuStrip1";
            // 
            // quanLyThưViênToolStripMenuItem
            // 
            this.quanLyThưViênToolStripMenuItem.Image = global::QLTVMOI.Properties.Resources.Screenshot_2025_05_10_165840;
            this.quanLyThưViênToolStripMenuItem.Name = "quanLyThưViênToolStripMenuItem";
            this.quanLyThưViênToolStripMenuItem.Size = new System.Drawing.Size(176, 27);
            this.quanLyThưViênToolStripMenuItem.Text = "Quản lý thư viện";
            this.quanLyThưViênToolStripMenuItem.Click += new System.EventHandler(this.quanLyThưViênToolStripMenuItem_Click);
            // 
            // quanLySachToolStripMenuItem
            // 
            this.quanLySachToolStripMenuItem.Image = global::QLTVMOI.Properties.Resources.Screenshot_2025_05_10_165803;
            this.quanLySachToolStripMenuItem.Name = "quanLySachToolStripMenuItem";
            this.quanLySachToolStripMenuItem.Size = new System.Drawing.Size(144, 27);
            this.quanLySachToolStripMenuItem.Text = "Quản lý sách";
            this.quanLySachToolStripMenuItem.Click += new System.EventHandler(this.quanLySachToolStripMenuItem_Click);
            // 
            // mươnTraSachToolStripMenuItem
            // 
            this.mươnTraSachToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mươnSachToolStripMenuItem,
            this.traSachToolStripMenuItem});
            this.mươnTraSachToolStripMenuItem.Image = global::QLTVMOI.Properties.Resources.Screenshot_2025_05_10_165942;
            this.mươnTraSachToolStripMenuItem.Name = "mươnTraSachToolStripMenuItem";
            this.mươnTraSachToolStripMenuItem.Size = new System.Drawing.Size(164, 27);
            this.mươnTraSachToolStripMenuItem.Text = "Mượn Trả Sách";
            // 
            // mươnSachToolStripMenuItem
            // 
            this.mươnSachToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.mươnSachToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mươnSachToolStripMenuItem.Image = global::QLTVMOI.Properties.Resources.Screenshot_2025_05_10_195606;
            this.mươnSachToolStripMenuItem.Name = "mươnSachToolStripMenuItem";
            this.mươnSachToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.mươnSachToolStripMenuItem.Text = "Mượn Sách";
            this.mươnSachToolStripMenuItem.Click += new System.EventHandler(this.mươnSachToolStripMenuItem_Click);
            // 
            // traSachToolStripMenuItem
            // 
            this.traSachToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.traSachToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.traSachToolStripMenuItem.Image = global::QLTVMOI.Properties.Resources.Screenshot_2025_05_10_165803;
            this.traSachToolStripMenuItem.Name = "traSachToolStripMenuItem";
            this.traSachToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.traSachToolStripMenuItem.Text = "Trả sách";
            this.traSachToolStripMenuItem.Click += new System.EventHandler(this.traSachToolStripMenuItem_Click);
            // 
            // thôngKêToolStripMenuItem
            // 
            this.thôngKêToolStripMenuItem.Image = global::QLTVMOI.Properties.Resources.Screenshot_2025_05_10_170046;
            this.thôngKêToolStripMenuItem.Name = "thôngKêToolStripMenuItem";
            this.thôngKêToolStripMenuItem.Size = new System.Drawing.Size(119, 27);
            this.thôngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // caiĐatToolStripMenuItem
            // 
            this.caiĐatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chinhSachToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.caiĐatToolStripMenuItem.Image = global::QLTVMOI.Properties.Resources.Screenshot_2025_05_10_170125;
            this.caiĐatToolStripMenuItem.Name = "caiĐatToolStripMenuItem";
            this.caiĐatToolStripMenuItem.Size = new System.Drawing.Size(101, 27);
            this.caiĐatToolStripMenuItem.Text = "Cài đặt";
            this.caiĐatToolStripMenuItem.Click += new System.EventHandler(this.caiĐatToolStripMenuItem_Click);
            // 
            // chinhSachToolStripMenuItem
            // 
            this.chinhSachToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.chinhSachToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.chinhSachToolStripMenuItem.Name = "chinhSachToolStripMenuItem";
            this.chinhSachToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.chinhSachToolStripMenuItem.Text = "Chính sách";
            this.chinhSachToolStripMenuItem.Click += new System.EventHandler(this.chinhSachToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.thoatToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // pnl_locdulieu
            // 
            this.pnl_locdulieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnl_locdulieu.ContextMenuStrip = this.cms_thongke;
            this.pnl_locdulieu.Controls.Add(this.rdb_muontra);
            this.pnl_locdulieu.Controls.Add(this.rdb_sach);
            this.pnl_locdulieu.Controls.Add(this.pnl_report);
            this.pnl_locdulieu.Controls.Add(this.btn_dongldl);
            this.pnl_locdulieu.Controls.Add(this.pnl_sach);
            this.pnl_locdulieu.Controls.Add(this.pnl_muontra);
            this.pnl_locdulieu.Controls.Add(this.label1);
            this.pnl_locdulieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_locdulieu.Location = new System.Drawing.Point(0, 50);
            this.pnl_locdulieu.Name = "pnl_locdulieu";
            this.pnl_locdulieu.Size = new System.Drawing.Size(296, 601);
            this.pnl_locdulieu.TabIndex = 1;
            // 
            // rdb_muontra
            // 
            this.rdb_muontra.AutoSize = true;
            this.rdb_muontra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdb_muontra.Location = new System.Drawing.Point(123, 562);
            this.rdb_muontra.Name = "rdb_muontra";
            this.rdb_muontra.Size = new System.Drawing.Size(167, 27);
            this.rdb_muontra.TabIndex = 3;
            this.rdb_muontra.Text = "Lịch sử mượn trả";
            this.rdb_muontra.UseVisualStyleBackColor = true;
            // 
            // rdb_sach
            // 
            this.rdb_sach.AutoSize = true;
            this.rdb_sach.Checked = true;
            this.rdb_sach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.rdb_sach.Location = new System.Drawing.Point(13, 562);
            this.rdb_sach.Name = "rdb_sach";
            this.rdb_sach.Size = new System.Drawing.Size(68, 27);
            this.rdb_sach.TabIndex = 3;
            this.rdb_sach.TabStop = true;
            this.rdb_sach.Text = "Sách";
            this.rdb_sach.UseVisualStyleBackColor = true;
            this.rdb_sach.CheckedChanged += new System.EventHandler(this.rdb_sach_CheckedChanged);
            // 
            // pnl_report
            // 
            this.pnl_report.Controls.Add(this.btn_reportmuontra);
            this.pnl_report.Controls.Add(this.btn_reportsach);
            this.pnl_report.Controls.Add(this.btn_report);
            this.pnl_report.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_report.Location = new System.Drawing.Point(0, 136);
            this.pnl_report.MaximumSize = new System.Drawing.Size(296, 152);
            this.pnl_report.MinimumSize = new System.Drawing.Size(296, 54);
            this.pnl_report.Name = "pnl_report";
            this.pnl_report.Size = new System.Drawing.Size(296, 54);
            this.pnl_report.TabIndex = 2;
            // 
            // btn_reportmuontra
            // 
            this.btn_reportmuontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_reportmuontra.FlatAppearance.BorderSize = 0;
            this.btn_reportmuontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportmuontra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_reportmuontra.Location = new System.Drawing.Point(49, 109);
            this.btn_reportmuontra.Name = "btn_reportmuontra";
            this.btn_reportmuontra.Size = new System.Drawing.Size(196, 30);
            this.btn_reportmuontra.TabIndex = 0;
            this.btn_reportmuontra.Text = "Report Mượn trả";
            this.btn_reportmuontra.UseVisualStyleBackColor = false;
            this.btn_reportmuontra.Click += new System.EventHandler(this.btn_reportmuontra_Click);
            // 
            // btn_reportsach
            // 
            this.btn_reportsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_reportsach.FlatAppearance.BorderSize = 0;
            this.btn_reportsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reportsach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_reportsach.Location = new System.Drawing.Point(49, 73);
            this.btn_reportsach.Name = "btn_reportsach";
            this.btn_reportsach.Size = new System.Drawing.Size(196, 30);
            this.btn_reportsach.TabIndex = 0;
            this.btn_reportsach.Text = "Report Sách";
            this.btn_reportsach.UseVisualStyleBackColor = false;
            this.btn_reportsach.Click += new System.EventHandler(this.btn_reportsach_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_report.Location = new System.Drawing.Point(0, 12);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(296, 30);
            this.btn_report.TabIndex = 0;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_dongldl
            // 
            this.btn_dongldl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_dongldl.FlatAppearance.BorderSize = 0;
            this.btn_dongldl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dongldl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dongldl.ForeColor = System.Drawing.Color.White;
            this.btn_dongldl.Location = new System.Drawing.Point(269, 4);
            this.btn_dongldl.Name = "btn_dongldl";
            this.btn_dongldl.Size = new System.Drawing.Size(24, 24);
            this.btn_dongldl.TabIndex = 0;
            this.btn_dongldl.Text = "X";
            this.btn_dongldl.UseVisualStyleBackColor = false;
            this.btn_dongldl.Click += new System.EventHandler(this.btn_dongldl_Click);
            // 
            // pnl_sach
            // 
            this.pnl_sach.Controls.Add(this.cbb_dieukienloc);
            this.pnl_sach.Controls.Add(this.cbb_sach);
            this.pnl_sach.Controls.Add(this.btn_sach);
            this.pnl_sach.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_sach.Location = new System.Drawing.Point(0, 82);
            this.pnl_sach.MaximumSize = new System.Drawing.Size(296, 152);
            this.pnl_sach.MinimumSize = new System.Drawing.Size(296, 54);
            this.pnl_sach.Name = "pnl_sach";
            this.pnl_sach.Size = new System.Drawing.Size(296, 54);
            this.pnl_sach.TabIndex = 2;
            // 
            // cbb_dieukienloc
            // 
            this.cbb_dieukienloc.BackColor = System.Drawing.Color.White;
            this.cbb_dieukienloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_dieukienloc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_dieukienloc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbb_dieukienloc.ForeColor = System.Drawing.Color.Black;
            this.cbb_dieukienloc.FormattingEnabled = true;
            this.cbb_dieukienloc.Location = new System.Drawing.Point(0, 104);
            this.cbb_dieukienloc.Name = "cbb_dieukienloc";
            this.cbb_dieukienloc.Size = new System.Drawing.Size(296, 28);
            this.cbb_dieukienloc.TabIndex = 1;
            this.cbb_dieukienloc.Visible = false;
            this.cbb_dieukienloc.SelectionChangeCommitted += new System.EventHandler(this.cbb_dieukienloc_SelectionChangeCommitted);
            // 
            // cbb_sach
            // 
            this.cbb_sach.BackColor = System.Drawing.Color.White;
            this.cbb_sach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_sach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbb_sach.ForeColor = System.Drawing.Color.Black;
            this.cbb_sach.FormattingEnabled = true;
            this.cbb_sach.Items.AddRange(new object[] {
            "Theo thể loại",
            "Theo tác giả",
            "Theo nhà xuất bản",
            "Theo số lượng",
            "Theo năm xuất bản"});
            this.cbb_sach.Location = new System.Drawing.Point(0, 60);
            this.cbb_sach.Name = "cbb_sach";
            this.cbb_sach.Size = new System.Drawing.Size(296, 28);
            this.cbb_sach.TabIndex = 1;
            this.cbb_sach.SelectionChangeCommitted += new System.EventHandler(this.cbb_sach_SelectionChangeCommitted);
            // 
            // btn_sach
            // 
            this.btn_sach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_sach.FlatAppearance.BorderSize = 0;
            this.btn_sach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_sach.Location = new System.Drawing.Point(0, 12);
            this.btn_sach.Name = "btn_sach";
            this.btn_sach.Size = new System.Drawing.Size(296, 30);
            this.btn_sach.TabIndex = 0;
            this.btn_sach.Text = "Sách";
            this.btn_sach.UseVisualStyleBackColor = false;
            this.btn_sach.Click += new System.EventHandler(this.btn_sach_Click);
            // 
            // pnl_muontra
            // 
            this.pnl_muontra.Controls.Add(this.cbb_muontra);
            this.pnl_muontra.Controls.Add(this.btn_muontra);
            this.pnl_muontra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_muontra.Location = new System.Drawing.Point(0, 28);
            this.pnl_muontra.MaximumSize = new System.Drawing.Size(296, 100);
            this.pnl_muontra.MinimumSize = new System.Drawing.Size(296, 54);
            this.pnl_muontra.Name = "pnl_muontra";
            this.pnl_muontra.Size = new System.Drawing.Size(296, 54);
            this.pnl_muontra.TabIndex = 2;
            // 
            // cbb_muontra
            // 
            this.cbb_muontra.BackColor = System.Drawing.Color.White;
            this.cbb_muontra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_muontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_muontra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_muontra.ForeColor = System.Drawing.Color.Black;
            this.cbb_muontra.FormattingEnabled = true;
            this.cbb_muontra.Items.AddRange(new object[] {
            "Đang mượn",
            "Đã trả",
            "Người mượn nhiều nhất"});
            this.cbb_muontra.Location = new System.Drawing.Point(0, 57);
            this.cbb_muontra.Name = "cbb_muontra";
            this.cbb_muontra.Size = new System.Drawing.Size(296, 28);
            this.cbb_muontra.TabIndex = 1;
            this.cbb_muontra.SelectionChangeCommitted += new System.EventHandler(this.cbb_muontra_SelectionChangeCommitted);
            // 
            // btn_muontra
            // 
            this.btn_muontra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn_muontra.FlatAppearance.BorderSize = 0;
            this.btn_muontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_muontra.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_muontra.Location = new System.Drawing.Point(0, 12);
            this.btn_muontra.Name = "btn_muontra";
            this.btn_muontra.Size = new System.Drawing.Size(296, 30);
            this.btn_muontra.TabIndex = 0;
            this.btn_muontra.Text = "Mượn trả";
            this.btn_muontra.UseVisualStyleBackColor = false;
            this.btn_muontra.Click += new System.EventHandler(this.btn_muontra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lọc dữ liệu";
            // 
            // pnl_thongketongquan
            // 
            this.pnl_thongketongquan.ContextMenuStrip = this.cms_thongke;
            this.pnl_thongketongquan.Controls.Add(this.dtp_thang);
            this.pnl_thongketongquan.Controls.Add(this.txt_tongluotmuon);
            this.pnl_thongketongquan.Controls.Add(this.txt_muontrongthang);
            this.pnl_thongketongquan.Controls.Add(this.txt_tongsachconlai);
            this.pnl_thongketongquan.Controls.Add(this.txt_tongsachdangmuon);
            this.pnl_thongketongquan.Controls.Add(this.txt_tongcuonsach);
            this.pnl_thongketongquan.Controls.Add(this.txt_tongdausach);
            this.pnl_thongketongquan.Controls.Add(this.label2);
            this.pnl_thongketongquan.Controls.Add(this.btn_dongtktq);
            this.pnl_thongketongquan.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_thongketongquan.Location = new System.Drawing.Point(1158, 50);
            this.pnl_thongketongquan.Name = "pnl_thongketongquan";
            this.pnl_thongketongquan.Size = new System.Drawing.Size(337, 601);
            this.pnl_thongketongquan.TabIndex = 3;
            // 
            // dtp_thang
            // 
            this.dtp_thang.CalendarTitleBackColor = System.Drawing.Color.Gray;
            this.dtp_thang.CustomFormat = "MM/yyyy";
            this.dtp_thang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.dtp_thang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_thang.Location = new System.Drawing.Point(25, 271);
            this.dtp_thang.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dtp_thang.MinDate = new System.DateTime(1945, 1, 1, 0, 0, 0, 0);
            this.dtp_thang.Name = "dtp_thang";
            this.dtp_thang.ShowUpDown = true;
            this.dtp_thang.Size = new System.Drawing.Size(98, 30);
            this.dtp_thang.TabIndex = 3;
            this.dtp_thang.ValueChanged += new System.EventHandler(this.dtp_thang_ValueChanged);
            // 
            // txt_tongluotmuon
            // 
            this.txt_tongluotmuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txt_tongluotmuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongluotmuon.Enabled = false;
            this.txt_tongluotmuon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongluotmuon.ForeColor = System.Drawing.Color.White;
            this.txt_tongluotmuon.Location = new System.Drawing.Point(25, 230);
            this.txt_tongluotmuon.Multiline = true;
            this.txt_tongluotmuon.Name = "txt_tongluotmuon";
            this.txt_tongluotmuon.ReadOnly = true;
            this.txt_tongluotmuon.Size = new System.Drawing.Size(285, 26);
            this.txt_tongluotmuon.TabIndex = 2;
            this.txt_tongluotmuon.Text = "Tổng Lượt Mượn: ";
            // 
            // txt_muontrongthang
            // 
            this.txt_muontrongthang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txt_muontrongthang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_muontrongthang.Enabled = false;
            this.txt_muontrongthang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_muontrongthang.ForeColor = System.Drawing.Color.White;
            this.txt_muontrongthang.Location = new System.Drawing.Point(25, 315);
            this.txt_muontrongthang.Multiline = true;
            this.txt_muontrongthang.Name = "txt_muontrongthang";
            this.txt_muontrongthang.ReadOnly = true;
            this.txt_muontrongthang.Size = new System.Drawing.Size(285, 26);
            this.txt_muontrongthang.TabIndex = 2;
            this.txt_muontrongthang.Text = "Số người mượn trong tháng: ";
            // 
            // txt_tongsachconlai
            // 
            this.txt_tongsachconlai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txt_tongsachconlai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongsachconlai.Enabled = false;
            this.txt_tongsachconlai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongsachconlai.ForeColor = System.Drawing.Color.White;
            this.txt_tongsachconlai.Location = new System.Drawing.Point(25, 188);
            this.txt_tongsachconlai.Multiline = true;
            this.txt_tongsachconlai.Name = "txt_tongsachconlai";
            this.txt_tongsachconlai.ReadOnly = true;
            this.txt_tongsachconlai.Size = new System.Drawing.Size(285, 26);
            this.txt_tongsachconlai.TabIndex = 2;
            this.txt_tongsachconlai.Text = "Tổng Sách Còn Lại: ";
            // 
            // txt_tongsachdangmuon
            // 
            this.txt_tongsachdangmuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txt_tongsachdangmuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongsachdangmuon.Enabled = false;
            this.txt_tongsachdangmuon.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongsachdangmuon.ForeColor = System.Drawing.Color.White;
            this.txt_tongsachdangmuon.Location = new System.Drawing.Point(25, 146);
            this.txt_tongsachdangmuon.Multiline = true;
            this.txt_tongsachdangmuon.Name = "txt_tongsachdangmuon";
            this.txt_tongsachdangmuon.ReadOnly = true;
            this.txt_tongsachdangmuon.Size = new System.Drawing.Size(285, 26);
            this.txt_tongsachdangmuon.TabIndex = 2;
            this.txt_tongsachdangmuon.Text = "Tổng Sách Đang Mượn: ";
            // 
            // txt_tongcuonsach
            // 
            this.txt_tongcuonsach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txt_tongcuonsach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongcuonsach.Enabled = false;
            this.txt_tongcuonsach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongcuonsach.ForeColor = System.Drawing.Color.White;
            this.txt_tongcuonsach.Location = new System.Drawing.Point(25, 62);
            this.txt_tongcuonsach.Multiline = true;
            this.txt_tongcuonsach.Name = "txt_tongcuonsach";
            this.txt_tongcuonsach.ReadOnly = true;
            this.txt_tongcuonsach.Size = new System.Drawing.Size(285, 26);
            this.txt_tongcuonsach.TabIndex = 2;
            this.txt_tongcuonsach.Text = "Tổng Cuốn Sách: ";
            // 
            // txt_tongdausach
            // 
            this.txt_tongdausach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txt_tongdausach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tongdausach.Enabled = false;
            this.txt_tongdausach.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongdausach.ForeColor = System.Drawing.Color.White;
            this.txt_tongdausach.Location = new System.Drawing.Point(25, 104);
            this.txt_tongdausach.Multiline = true;
            this.txt_tongdausach.Name = "txt_tongdausach";
            this.txt_tongdausach.ReadOnly = true;
            this.txt_tongdausach.Size = new System.Drawing.Size(285, 26);
            this.txt_tongdausach.TabIndex = 2;
            this.txt_tongdausach.Text = "Tổng Đầu Sách: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thống kê tổng quan";
            // 
            // btn_dongtktq
            // 
            this.btn_dongtktq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btn_dongtktq.FlatAppearance.BorderSize = 0;
            this.btn_dongtktq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dongtktq.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dongtktq.ForeColor = System.Drawing.Color.White;
            this.btn_dongtktq.Location = new System.Drawing.Point(310, 3);
            this.btn_dongtktq.Name = "btn_dongtktq";
            this.btn_dongtktq.Size = new System.Drawing.Size(24, 24);
            this.btn_dongtktq.TabIndex = 0;
            this.btn_dongtktq.Text = "X";
            this.btn_dongtktq.UseVisualStyleBackColor = false;
            this.btn_dongtktq.Click += new System.EventHandler(this.btn_dongtktq_Click);
            // 
            // pnl_table
            // 
            this.pnl_table.Controls.Add(this.dgv_hienthi);
            this.pnl_table.Controls.Add(this.dgv_danhsachmuontra);
            this.pnl_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_table.Location = new System.Drawing.Point(296, 50);
            this.pnl_table.Name = "pnl_table";
            this.pnl_table.Size = new System.Drawing.Size(862, 601);
            this.pnl_table.TabIndex = 4;
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.AllowUserToAddRows = false;
            this.dgv_hienthi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hienthi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_hienthi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgv_hienthi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hienthi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_hienthi.ColumnHeadersHeight = 29;
            this.dgv_hienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_masach,
            this.cln_tensach,
            this.cln_tacgia,
            this.cln_nhaxb,
            this.cln_nxb,
            this.cln_theloai,
            this.cln_soluong});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hienthi.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_hienthi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_hienthi.EnableHeadersVisualStyles = false;
            this.dgv_hienthi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgv_hienthi.Location = new System.Drawing.Point(0, 0);
            this.dgv_hienthi.MultiSelect = false;
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hienthi.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_hienthi.RowHeadersVisible = false;
            this.dgv_hienthi.RowHeadersWidth = 51;
            this.dgv_hienthi.RowTemplate.Height = 29;
            this.dgv_hienthi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hienthi.Size = new System.Drawing.Size(862, 601);
            this.dgv_hienthi.TabIndex = 1;
            this.dgv_hienthi.Visible = false;
            // 
            // cln_masach
            // 
            this.cln_masach.DataPropertyName = "idSach";
            this.cln_masach.HeaderText = "Mã Sách";
            this.cln_masach.MinimumWidth = 6;
            this.cln_masach.Name = "cln_masach";
            this.cln_masach.ReadOnly = true;
            // 
            // cln_tensach
            // 
            this.cln_tensach.DataPropertyName = "Tensach";
            this.cln_tensach.HeaderText = "Tên sách";
            this.cln_tensach.MinimumWidth = 6;
            this.cln_tensach.Name = "cln_tensach";
            this.cln_tensach.ReadOnly = true;
            // 
            // cln_tacgia
            // 
            this.cln_tacgia.DataPropertyName = "Tentacgia";
            this.cln_tacgia.HeaderText = "Tác giả";
            this.cln_tacgia.MinimumWidth = 6;
            this.cln_tacgia.Name = "cln_tacgia";
            this.cln_tacgia.ReadOnly = true;
            // 
            // cln_nhaxb
            // 
            this.cln_nhaxb.DataPropertyName = "NhaxuatBan";
            this.cln_nhaxb.HeaderText = "Nhà xuất bản";
            this.cln_nhaxb.MinimumWidth = 6;
            this.cln_nhaxb.Name = "cln_nhaxb";
            this.cln_nhaxb.ReadOnly = true;
            // 
            // cln_nxb
            // 
            this.cln_nxb.DataPropertyName = "Namxuatban";
            this.cln_nxb.HeaderText = "NXB";
            this.cln_nxb.MinimumWidth = 6;
            this.cln_nxb.Name = "cln_nxb";
            this.cln_nxb.ReadOnly = true;
            // 
            // cln_theloai
            // 
            this.cln_theloai.DataPropertyName = "Theloai";
            this.cln_theloai.HeaderText = "Thể loại";
            this.cln_theloai.MinimumWidth = 6;
            this.cln_theloai.Name = "cln_theloai";
            this.cln_theloai.ReadOnly = true;
            // 
            // cln_soluong
            // 
            this.cln_soluong.DataPropertyName = "Soluong";
            this.cln_soluong.HeaderText = "SL";
            this.cln_soluong.MinimumWidth = 6;
            this.cln_soluong.Name = "cln_soluong";
            this.cln_soluong.ReadOnly = true;
            // 
            // dgv_danhsachmuontra
            // 
            this.dgv_danhsachmuontra.AllowUserToAddRows = false;
            this.dgv_danhsachmuontra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_danhsachmuontra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_danhsachmuontra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgv_danhsachmuontra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_danhsachmuontra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_danhsachmuontra.ColumnHeadersHeight = 29;
            this.dgv_danhsachmuontra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cln_mapm,
            this.cln_tennguoimuon,
            this.cln_sdt,
            this.cln_diachi,
            this.cln_tensachmt,
            this.cln_tinhtrang,
            this.cln_ngaymuon,
            this.cln_ngaytra,
            this.cln_soluongmt});
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_danhsachmuontra.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_danhsachmuontra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_danhsachmuontra.EnableHeadersVisualStyles = false;
            this.dgv_danhsachmuontra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.dgv_danhsachmuontra.Location = new System.Drawing.Point(0, 0);
            this.dgv_danhsachmuontra.MultiSelect = false;
            this.dgv_danhsachmuontra.Name = "dgv_danhsachmuontra";
            this.dgv_danhsachmuontra.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_danhsachmuontra.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_danhsachmuontra.RowHeadersVisible = false;
            this.dgv_danhsachmuontra.RowHeadersWidth = 51;
            this.dgv_danhsachmuontra.RowTemplate.Height = 29;
            this.dgv_danhsachmuontra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachmuontra.Size = new System.Drawing.Size(862, 601);
            this.dgv_danhsachmuontra.TabIndex = 2;
            // 
            // cln_mapm
            // 
            this.cln_mapm.DataPropertyName = "idPhieuMuon";
            this.cln_mapm.HeaderText = "Mã PM";
            this.cln_mapm.MinimumWidth = 6;
            this.cln_mapm.Name = "cln_mapm";
            this.cln_mapm.ReadOnly = true;
            // 
            // cln_tennguoimuon
            // 
            this.cln_tennguoimuon.DataPropertyName = "TenDocGia";
            this.cln_tennguoimuon.HeaderText = "Tên người mượn";
            this.cln_tennguoimuon.MinimumWidth = 6;
            this.cln_tennguoimuon.Name = "cln_tennguoimuon";
            this.cln_tennguoimuon.ReadOnly = true;
            // 
            // cln_sdt
            // 
            this.cln_sdt.DataPropertyName = "SDT";
            this.cln_sdt.HeaderText = "SDT";
            this.cln_sdt.MinimumWidth = 6;
            this.cln_sdt.Name = "cln_sdt";
            this.cln_sdt.ReadOnly = true;
            // 
            // cln_diachi
            // 
            this.cln_diachi.DataPropertyName = "DiaChi";
            this.cln_diachi.HeaderText = "Địa chỉ";
            this.cln_diachi.MinimumWidth = 6;
            this.cln_diachi.Name = "cln_diachi";
            this.cln_diachi.ReadOnly = true;
            // 
            // cln_tensachmt
            // 
            this.cln_tensachmt.DataPropertyName = "Tensach";
            this.cln_tensachmt.HeaderText = "Tên sách";
            this.cln_tensachmt.MinimumWidth = 6;
            this.cln_tensachmt.Name = "cln_tensachmt";
            this.cln_tensachmt.ReadOnly = true;
            // 
            // cln_tinhtrang
            // 
            this.cln_tinhtrang.DataPropertyName = "TinhTrangGiaoDich";
            this.cln_tinhtrang.HeaderText = "Tình trạng";
            this.cln_tinhtrang.MinimumWidth = 6;
            this.cln_tinhtrang.Name = "cln_tinhtrang";
            this.cln_tinhtrang.ReadOnly = true;
            // 
            // cln_ngaymuon
            // 
            this.cln_ngaymuon.DataPropertyName = "NgayMuon";
            this.cln_ngaymuon.HeaderText = "Ngày mượn";
            this.cln_ngaymuon.MinimumWidth = 6;
            this.cln_ngaymuon.Name = "cln_ngaymuon";
            this.cln_ngaymuon.ReadOnly = true;
            // 
            // cln_ngaytra
            // 
            this.cln_ngaytra.DataPropertyName = "NgayTra";
            this.cln_ngaytra.HeaderText = "Ngày trả";
            this.cln_ngaytra.MinimumWidth = 6;
            this.cln_ngaytra.Name = "cln_ngaytra";
            this.cln_ngaytra.ReadOnly = true;
            // 
            // cln_soluongmt
            // 
            this.cln_soluongmt.DataPropertyName = "SoLuong";
            this.cln_soluongmt.HeaderText = "SL";
            this.cln_soluongmt.MinimumWidth = 6;
            this.cln_soluongmt.Name = "cln_soluongmt";
            this.cln_soluongmt.ReadOnly = true;
            this.cln_soluongmt.Visible = false;
            // 
            // timerSach
            // 
            this.timerSach.Interval = 10;
            this.timerSach.Tick += new System.EventHandler(this.timerSach_Tick);
            // 
            // timerMuontra
            // 
            this.timerMuontra.Interval = 10;
            this.timerMuontra.Tick += new System.EventHandler(this.timerMuontra_Tick);
            // 
            // timerReport
            // 
            this.timerReport.Interval = 10;
            this.timerReport.Tick += new System.EventHandler(this.timerReport_Tick);
            // 
            // qltvDataSet2
            // 
            this.qltvDataSet2.DataSetName = "qltvDataSet2";
            this.qltvDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sachBindingSource
            // 
            this.sachBindingSource.DataMember = "Sach";
            this.sachBindingSource.DataSource = this.qltvDataSet2;
            // 
            // sachTableAdapter
            // 
            this.sachTableAdapter.ClearBeforeFill = true;
            // 
            // Thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1495, 651);
            this.Controls.Add(this.pnl_table);
            this.Controls.Add(this.pnl_thongketongquan);
            this.Controls.Add(this.pnl_locdulieu);
            this.Controls.Add(this.pnl_congcu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.mns_congcu;
            this.Name = "Thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thongke";
            this.Load += new System.EventHandler(this.Thongke_Load);
            this.Shown += new System.EventHandler(this.Thongke_Shown);
            this.pnl_congcu.ResumeLayout(false);
            this.pnl_congcu.PerformLayout();
            this.cms_thongke.ResumeLayout(false);
            this.mns_congcu.ResumeLayout(false);
            this.mns_congcu.PerformLayout();
            this.pnl_locdulieu.ResumeLayout(false);
            this.pnl_locdulieu.PerformLayout();
            this.pnl_report.ResumeLayout(false);
            this.pnl_sach.ResumeLayout(false);
            this.pnl_muontra.ResumeLayout(false);
            this.pnl_thongketongquan.ResumeLayout(false);
            this.pnl_thongketongquan.PerformLayout();
            this.pnl_table.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachmuontra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qltvDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        // Update the method signature of Thongke_Shown to match the EventHandler delegate
        private void Thongke_Shown(object sender, EventArgs e)
        {
            // Add your logic here
        }

        #endregion

        private Panel pnl_congcu;
        private Button btn_thoat;
        private Button btn_an;
        private MenuStrip mns_congcu;
        private ToolStripMenuItem quanLyThưViênToolStripMenuItem;
        private ToolStripMenuItem quanLySachToolStripMenuItem;
        private ToolStripMenuItem mươnTraSachToolStripMenuItem;
        private ToolStripMenuItem thôngKêToolStripMenuItem;
        private ToolStripMenuItem caiĐatToolStripMenuItem;
        private ToolStripMenuItem mươnSachToolStripMenuItem;
        private ToolStripMenuItem traSachToolStripMenuItem;
        private Panel pnl_locdulieu;
        private Panel pnl_sach;
        private Label label1;
        private ComboBox cbb_sach;
        private Button btn_sach;
        private Panel pnl_muontra;
        private ComboBox cbb_muontra;
        private Button btn_muontra;
        private Panel pnl_thongketongquan;
        private Panel pnl_table;
        private Button btn_dongldl;
        private Button btn_dongtktq;
        private TextBox txt_tongdausach;
        private Label label2;
        private DateTimePicker dtp_thang;
        private TextBox txt_tongluotmuon;
        private TextBox txt_muontrongthang;
        private TextBox txt_tongsachconlai;
        private TextBox txt_tongsachdangmuon;
        private TextBox txt_tongcuonsach;
        private ContextMenuStrip cms_thongke;
        private ToolStripMenuItem locDưLiêuToolStripMenuItem;
        private ToolStripMenuItem thôngKêTôngQuanToolStripMenuItem;
        private Timer timerSach;
        private Timer timerMuontra;
        private RadioButton rdb_muontra;
        private RadioButton rdb_sach;
        private DataGridView dgv_hienthi;
        private DataGridView dgv_danhsachmuontra;
        private Panel pnl_report;
        private Button btn_report;
        private Button btn_reportmuontra;
        private Button btn_reportsach;
        private Timer timerReport;
        private ComboBox cbb_dieukienloc;
        private qltvDataSet2 qltvDataSet2;
        private BindingSource sachBindingSource;
        private qltvDataSet2TableAdapters.SachTableAdapter sachTableAdapter;
        private DataGridViewTextBoxColumn cln_mapm;
        private DataGridViewTextBoxColumn cln_tennguoimuon;
        private DataGridViewTextBoxColumn cln_sdt;
        private DataGridViewTextBoxColumn cln_diachi;
        private DataGridViewTextBoxColumn cln_tensachmt;
        private DataGridViewTextBoxColumn cln_tinhtrang;
        private DataGridViewTextBoxColumn cln_ngaymuon;
        private DataGridViewTextBoxColumn cln_ngaytra;
        private DataGridViewTextBoxColumn cln_soluongmt;
        private DataGridViewTextBoxColumn cln_masach;
        private DataGridViewTextBoxColumn cln_tensach;
        private DataGridViewTextBoxColumn cln_tacgia;
        private DataGridViewTextBoxColumn cln_nhaxb;
        private DataGridViewTextBoxColumn cln_nxb;
        private DataGridViewTextBoxColumn cln_theloai;
        private DataGridViewTextBoxColumn cln_soluong;
        private ToolStripMenuItem chinhSachToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
    }
}