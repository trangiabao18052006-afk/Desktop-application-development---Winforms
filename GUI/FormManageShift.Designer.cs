using System.ComponentModel;

namespace GUI;

partial class FormManageShift
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnlFilter = new System.Windows.Forms.Panel();
        lblMaNhanVien = new System.Windows.Forms.Label();
        txtMaNhanVien = new System.Windows.Forms.TextBox();
        lblTenNhanVien = new System.Windows.Forms.Label();
        txtTenNhanVien = new System.Windows.Forms.TextBox();
        lblCaLamViec = new System.Windows.Forms.Label();
        cbbCaLamViec = new System.Windows.Forms.ComboBox();
        lblNgayLam = new System.Windows.Forms.Label();
        dtpNgayLam = new System.Windows.Forms.DateTimePicker();
        dgvCaLamViec = new System.Windows.Forms.DataGridView();
        pnlFooter = new System.Windows.Forms.Panel();
        btThem = new System.Windows.Forms.Button();
        btSua = new System.Windows.Forms.Button();
        btXoa = new System.Windows.Forms.Button();
        btLamMoi = new System.Windows.Forms.Button();

        pnlFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCaLamViec).BeginInit();
        pnlFooter.SuspendLayout();
        SuspendLayout();

        // pnlFilter
        pnlFilter.Controls.Add(lblMaNhanVien);
        pnlFilter.Controls.Add(txtMaNhanVien);
        pnlFilter.Controls.Add(lblTenNhanVien);
        pnlFilter.Controls.Add(txtTenNhanVien);
        pnlFilter.Controls.Add(lblCaLamViec);
        pnlFilter.Controls.Add(cbbCaLamViec);
        pnlFilter.Controls.Add(lblNgayLam);
        pnlFilter.Controls.Add(dtpNgayLam);
        pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
        pnlFilter.BackColor = System.Drawing.SystemColors.Control;
        pnlFilter.Padding = new System.Windows.Forms.Padding(12);
        pnlFilter.Size = new System.Drawing.Size(906, 70);
        pnlFilter.Name = "pnlFilter";
        pnlFilter.TabIndex = 0;

        // lblMaNhanVien
        lblMaNhanVien.AutoSize = true;
        lblMaNhanVien.Location = new System.Drawing.Point(18, 12);
        lblMaNhanVien.Name = "lblMaNhanVien";
        lblMaNhanVien.Text = "Mã nhân viên";
        lblMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);

        // txtMaNhanVien
        txtMaNhanVien.Location = new System.Drawing.Point(18, 38);
        txtMaNhanVien.Name = "txtMaNhanVien";
        txtMaNhanVien.Size = new System.Drawing.Size(160, 27);
        txtMaNhanVien.TabIndex = 0;

        // lblTenNhanVien
        lblTenNhanVien.AutoSize = true;
        lblTenNhanVien.Location = new System.Drawing.Point(200, 12);
        lblTenNhanVien.Name = "lblTenNhanVien";
        lblTenNhanVien.Text = "Tên nhân viên";
        lblTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);

        // txtTenNhanVien
        txtTenNhanVien.Location = new System.Drawing.Point(200, 38);
        txtTenNhanVien.Name = "txtTenNhanVien";
        txtTenNhanVien.Size = new System.Drawing.Size(200, 27);
        txtTenNhanVien.TabIndex = 1;

        // lblCaLamViec
        lblCaLamViec.AutoSize = true;
        lblCaLamViec.Location = new System.Drawing.Point(420, 12);
        lblCaLamViec.Name = "lblCaLamViec";
        lblCaLamViec.Text = "Ca làm việc";
        lblCaLamViec.Font = new System.Drawing.Font("Segoe UI", 9F);

        // cbbCaLamViec
        cbbCaLamViec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cbbCaLamViec.FormattingEnabled = true;
        cbbCaLamViec.Location = new System.Drawing.Point(420, 38);
        cbbCaLamViec.Name = "cbbCaLamViec";
        cbbCaLamViec.Size = new System.Drawing.Size(160, 28);
        cbbCaLamViec.TabIndex = 2;

        // lblNgayLam
        lblNgayLam.AutoSize = true;
        lblNgayLam.Location = new System.Drawing.Point(600, 12);
        lblNgayLam.Name = "lblNgayLam";
        lblNgayLam.Text = "Ngày làm";
        lblNgayLam.Font = new System.Drawing.Font("Segoe UI", 9F);

        // dtpNgayLam
        dtpNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
        dtpNgayLam.Location = new System.Drawing.Point(600, 38);
        dtpNgayLam.Name = "dtpNgayLam";
        dtpNgayLam.Size = new System.Drawing.Size(180, 27);
        dtpNgayLam.TabIndex = 3;

        // dgvCaLamViec
        dgvCaLamViec.Dock = System.Windows.Forms.DockStyle.Fill;
        dgvCaLamViec.Name = "dgvCaLamViec";
        dgvCaLamViec.RowHeadersVisible = false;
        dgvCaLamViec.RowHeadersWidth = 51;
        dgvCaLamViec.AllowUserToAddRows = false;
        dgvCaLamViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dgvCaLamViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        dgvCaLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCaLamViec.TabIndex = 1;
        dgvCaLamViec.CellClick += dgvCaLamViec_CellClick;

        // pnlFooter
        pnlFooter.Controls.Add(btThem);
        pnlFooter.Controls.Add(btSua);
        pnlFooter.Controls.Add(btXoa);
        pnlFooter.Controls.Add(btLamMoi);
        pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnlFooter.BackColor = System.Drawing.SystemColors.Control;
        pnlFooter.Size = new System.Drawing.Size(906, 55);
        pnlFooter.Name = "pnlFooter";
        pnlFooter.TabIndex = 2;

        // btThem
        btThem.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btThem.Location = new System.Drawing.Point(14, 10);
        btThem.Name = "btThem";
        btThem.Size = new System.Drawing.Size(110, 34);
        btThem.TabIndex = 0;
        btThem.Text = "Thêm";
        btThem.UseVisualStyleBackColor = true;
        btThem.Click += btThem_Click;

        // btSua
        btSua.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btSua.Location = new System.Drawing.Point(140, 10);
        btSua.Name = "btSua";
        btSua.Size = new System.Drawing.Size(110, 34);
        btSua.TabIndex = 1;
        btSua.Text = "Sửa";
        btSua.UseVisualStyleBackColor = true;
        btSua.Click += btSua_Click;

        // btXoa
        btXoa.Anchor = System.Windows.Forms.AnchorStyles.Left;
        btXoa.Location = new System.Drawing.Point(266, 10);
        btXoa.Name = "btXoa";
        btXoa.Size = new System.Drawing.Size(110, 34);
        btXoa.TabIndex = 2;
        btXoa.Text = "Xóa";
        btXoa.UseVisualStyleBackColor = true;
        btXoa.Click += btXoa_Click;

        // btLamMoi
        btLamMoi.Anchor = System.Windows.Forms.AnchorStyles.Right;
        btLamMoi.Location = new System.Drawing.Point(782, 10);
        btLamMoi.Name = "btLamMoi";
        btLamMoi.Size = new System.Drawing.Size(110, 34);
        btLamMoi.TabIndex = 3;
        btLamMoi.Text = "Làm mới";
        btLamMoi.UseVisualStyleBackColor = true;
        btLamMoi.Click += btLamMoi_Click;

        // FormManageShift
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(906, 606);
        Controls.Add(dgvCaLamViec);
        Controls.Add(pnlFooter);
        Controls.Add(pnlFilter);
        Name = "FormManageShift";
        Text = "Quản lí ca làm việc";
        this.Load += FormManageShift_Load;

        pnlFilter.ResumeLayout(false);
        pnlFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dgvCaLamViec).EndInit();
        pnlFooter.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnlFilter;
    private System.Windows.Forms.Panel pnlFooter;
    private System.Windows.Forms.Label lblMaNhanVien;
    private System.Windows.Forms.Label lblTenNhanVien;
    private System.Windows.Forms.Label lblCaLamViec;
    private System.Windows.Forms.Label lblNgayLam;
    private System.Windows.Forms.TextBox txtMaNhanVien;
    private System.Windows.Forms.TextBox txtTenNhanVien;
    private System.Windows.Forms.ComboBox cbbCaLamViec;
    private System.Windows.Forms.DateTimePicker dtpNgayLam;
    private System.Windows.Forms.DataGridView dgvCaLamViec;
    private System.Windows.Forms.Button btThem;
    private System.Windows.Forms.Button btSua;
    private System.Windows.Forms.Button btXoa;
    private System.Windows.Forms.Button btLamMoi;

    #endregion
}