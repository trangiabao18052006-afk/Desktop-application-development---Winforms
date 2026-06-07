using System.ComponentModel;

namespace GUI;

partial class FormReport
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlToolbar        = new System.Windows.Forms.Panel();
        lblDenNgay        = new System.Windows.Forms.Label();
        lblTuNgay         = new System.Windows.Forms.Label();
        dtpdenngay        = new System.Windows.Forms.DateTimePicker();
        dtpTungay         = new System.Windows.Forms.DateTimePicker();
        btLammoi          = new System.Windows.Forms.Button();
        btnTimKiem        = new System.Windows.Forms.Button();
        btThem            = new System.Windows.Forms.Button();
        dtgBaoCaoDoanhThu = new System.Windows.Forms.DataGridView();
        btnXuatExcel      = new System.Windows.Forms.Button();
        btnInhoadon       = new System.Windows.Forms.Button();
        pnlRight          = new System.Windows.Forms.Panel();
        lblThapnhat       = new System.Windows.Forms.Label();
        lblCaoNhat        = new System.Windows.Forms.Label();
        lblTongDoanhThu   = new System.Windows.Forms.Label();
        lblTongSoDonHang  = new System.Windows.Forms.Label();  // Đã sửa typo: HnAg → Hang
        panel4            = new System.Windows.Forms.Panel();

        pnlToolbar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dtgBaoCaoDoanhThu).BeginInit();
        pnlRight.SuspendLayout();
        panel4.SuspendLayout();
        SuspendLayout();

        // ── pnlToolbar ──────────────────────────────────
        pnlToolbar.AutoScroll        = true;
        pnlToolbar.AutoScrollMinSize = new System.Drawing.Size(0, 45);
        pnlToolbar.Controls.Add(lblDenNgay);
        pnlToolbar.Controls.Add(lblTuNgay);
        pnlToolbar.Controls.Add(dtpdenngay);
        pnlToolbar.Controls.Add(dtpTungay);
        pnlToolbar.Controls.Add(btLammoi);
        pnlToolbar.Controls.Add(btnTimKiem);
        pnlToolbar.Controls.Add(btThem);
        pnlToolbar.Dock     = System.Windows.Forms.DockStyle.Top;
        pnlToolbar.Location = new System.Drawing.Point(0, 0);
        pnlToolbar.Name     = "pnlToolbar";
        pnlToolbar.Padding  = new System.Windows.Forms.Padding(8);
        pnlToolbar.Size     = new System.Drawing.Size(800, 75);
        pnlToolbar.TabIndex = 1;

        // ── lblTuNgay (thay txtTungay) ──────────────────
        lblTuNgay.AutoSize  = false;
        lblTuNgay.Location  = new System.Drawing.Point(14, 26);
        lblTuNgay.Name      = "lblTuNgay";
        lblTuNgay.Size      = new System.Drawing.Size(70, 27);
        lblTuNgay.TabIndex  = 6;
        lblTuNgay.Text      = "Từ ngày:";
        lblTuNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // ── dtpTungay ────────────────────────────────────
        dtpTungay.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpTungay.Location = new System.Drawing.Point(88, 24);
        dtpTungay.Name     = "dtpTungay";
        dtpTungay.Size     = new System.Drawing.Size(110, 27);
        dtpTungay.TabIndex = 0;

        // ── lblDenNgay (thay txtDenngay) ─────────────────
        lblDenNgay.AutoSize  = false;
        lblDenNgay.Location  = new System.Drawing.Point(205, 26);
        lblDenNgay.Name      = "lblDenNgay";
        lblDenNgay.Size      = new System.Drawing.Size(75, 27);
        lblDenNgay.TabIndex  = 7;
        lblDenNgay.Text      = "Đến ngày:";
        lblDenNgay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

        // ── dtpdenngay ───────────────────────────────────
        dtpdenngay.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpdenngay.Location = new System.Drawing.Point(284, 24);
        dtpdenngay.Name     = "dtpdenngay";
        dtpdenngay.Size     = new System.Drawing.Size(110, 27);
        dtpdenngay.TabIndex = 1;

        // ── btnTimKiem ───────────────────────────────────
        btnTimKiem.Location = new System.Drawing.Point(406, 19);
        btnTimKiem.Name     = "btnTimKiem";
        btnTimKiem.Size     = new System.Drawing.Size(90, 37);
        btnTimKiem.TabIndex = 2;
        btnTimKiem.Text     = "Tìm kiếm";
        btnTimKiem.UseVisualStyleBackColor = true;
        btnTimKiem.Click   += btnTimKiem_Click;

        // ── btThem ───────────────────────────────────────
        btThem.Location = new System.Drawing.Point(514, 19);
        btThem.Name     = "btThem";
        btThem.Size     = new System.Drawing.Size(100, 37);
        btThem.TabIndex = 3;
        btThem.Text     = "Thêm";
        btThem.UseVisualStyleBackColor = true;
        btThem.Click   += btThem_Click;

        // ── btLammoi ─────────────────────────────────────
        btLammoi.Location = new System.Drawing.Point(626, 19);
        btLammoi.Name     = "btLammoi";
        btLammoi.Size     = new System.Drawing.Size(100, 37);
        btLammoi.TabIndex = 4;
        btLammoi.Text     = "Làm mới";
        btLammoi.UseVisualStyleBackColor = true;
        btLammoi.Click   += btLammoi_Click;

        // ── dtgBaoCaoDoanhThu ────────────────────────────
        dtgBaoCaoDoanhThu.ColumnHeadersHeightSizeMode =
            System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dtgBaoCaoDoanhThu.Dock             = System.Windows.Forms.DockStyle.Fill;
        dtgBaoCaoDoanhThu.Location         = new System.Drawing.Point(0, 75);
        dtgBaoCaoDoanhThu.Name             = "dtgBaoCaoDoanhThu";
        dtgBaoCaoDoanhThu.RowHeadersVisible = false;
        dtgBaoCaoDoanhThu.RowHeadersWidth  = 51;
        dtgBaoCaoDoanhThu.Size             = new System.Drawing.Size(800, 405);
        dtgBaoCaoDoanhThu.TabIndex         = 2;

        // ── pnlRight ─────────────────────────────────────
        pnlRight.AutoScroll       = true;
        pnlRight.Controls.Add(lblThapnhat);
        pnlRight.Controls.Add(lblCaoNhat);
        pnlRight.Controls.Add(lblTongDoanhThu);
        pnlRight.Controls.Add(lblTongSoDonHang);
        pnlRight.Dock     = System.Windows.Forms.DockStyle.Right;
        pnlRight.Location = new System.Drawing.Point(606, 75);
        pnlRight.Name     = "pnlRight";
        pnlRight.Size     = new System.Drawing.Size(194, 405);
        pnlRight.TabIndex = 5;

        // ── lblTongSoDonHang ─────────────────────────────
        lblTongSoDonHang.Location  = new System.Drawing.Point(14, 41);
        lblTongSoDonHang.Name      = "lblTongSoDonHang"; // Đã sửa typo
        lblTongSoDonHang.Size      = new System.Drawing.Size(166, 32);
        lblTongSoDonHang.TabIndex  = 0;
        lblTongSoDonHang.Text      = "Tổng số đơn hàng";

        // ── lblTongDoanhThu ──────────────────────────────
        lblTongDoanhThu.Location  = new System.Drawing.Point(14, 123);
        lblTongDoanhThu.Name      = "lblTongDoanhThu";
        lblTongDoanhThu.Size      = new System.Drawing.Size(166, 32);
        lblTongDoanhThu.TabIndex  = 1;
        lblTongDoanhThu.Text      = "Tổng doanh thu";

        // ── lblCaoNhat ───────────────────────────────────
        lblCaoNhat.Location  = new System.Drawing.Point(14, 202);
        lblCaoNhat.Name      = "lblCaoNhat";
        lblCaoNhat.Size      = new System.Drawing.Size(166, 32);
        lblCaoNhat.TabIndex  = 2;
        lblCaoNhat.Text      = "Cao nhất";

        // ── lblThapnhat ──────────────────────────────────
        lblThapnhat.Location  = new System.Drawing.Point(14, 291);
        lblThapnhat.Name      = "lblThapnhat";
        lblThapnhat.Size      = new System.Drawing.Size(166, 32);
        lblThapnhat.TabIndex  = 3;
        lblThapnhat.Text      = "Thấp nhất";

        // ── panel4 (bottom toolbar) ───────────────────────
        panel4.AutoScroll       = true;
        panel4.AutoScrollMinSize = new System.Drawing.Size(0, 45);
        panel4.Controls.Add(btnInhoadon);
        panel4.Controls.Add(btnXuatExcel);
        panel4.Dock     = System.Windows.Forms.DockStyle.Bottom;
        panel4.Location = new System.Drawing.Point(0, 480);
        panel4.Name     = "panel4";
        panel4.Size     = new System.Drawing.Size(606, 67);
        panel4.TabIndex = 6;

        // ── btnXuatExcel ─────────────────────────────────
        btnXuatExcel.Location = new System.Drawing.Point(20, 15);
        btnXuatExcel.Name     = "btnXuatExcel";
        btnXuatExcel.Size     = new System.Drawing.Size(110, 39);
        btnXuatExcel.TabIndex = 0;
        btnXuatExcel.Text     = "Xuất Excel";
        btnXuatExcel.UseVisualStyleBackColor = true;
        btnXuatExcel.Click   += btnXuatExcel_Click;

        // ── btnInhoadon ──────────────────────────────────
        btnInhoadon.Location = new System.Drawing.Point(145, 15);
        btnInhoadon.Name     = "btnInhoadon";
        btnInhoadon.Size     = new System.Drawing.Size(110, 39);
        btnInhoadon.TabIndex = 1;
        btnInhoadon.Text     = "In hóa đơn";
        btnInhoadon.UseVisualStyleBackColor = true;
        btnInhoadon.Click   += btnInhoadon_Click;

        // ── FormReport ───────────────────────────────────
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize          = new System.Drawing.Size(800, 547);
        Controls.Add(panel4);
        Controls.Add(pnlRight);
        Controls.Add(dtgBaoCaoDoanhThu);
        Controls.Add(pnlToolbar);
        Text = "Báo cáo doanh thu";

        pnlToolbar.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)dtgBaoCaoDoanhThu).EndInit();
        pnlRight.ResumeLayout(false);
        panel4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    // ── Field declarations ────────────────────────────────────────────────────
    private System.Windows.Forms.Panel          pnlToolbar;
    private System.Windows.Forms.Label          lblTuNgay;
    private System.Windows.Forms.Label          lblDenNgay;
    private System.Windows.Forms.DateTimePicker dtpTungay;
    private System.Windows.Forms.DateTimePicker dtpdenngay;
    private System.Windows.Forms.Button         btThem;
    private System.Windows.Forms.Button         btnTimKiem;
    private System.Windows.Forms.Button         btLammoi;

    private System.Windows.Forms.DataGridView   dtgBaoCaoDoanhThu;

    private System.Windows.Forms.Panel          pnlRight;
    private System.Windows.Forms.Label          lblTongSoDonHang;   // Đã sửa typo
    private System.Windows.Forms.Label          lblTongDoanhThu;
    private System.Windows.Forms.Label          lblCaoNhat;
    private System.Windows.Forms.Label          lblThapnhat;

    private System.Windows.Forms.Panel          panel4;
    private System.Windows.Forms.Button         btnXuatExcel;
    private System.Windows.Forms.Button         btnInhoadon;
}