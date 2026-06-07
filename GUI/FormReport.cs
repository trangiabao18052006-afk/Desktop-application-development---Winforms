namespace GUI
{
    public partial class FormReport : Form
    {
        private const string COL_MA_DH = "MaDH";
        private const string COL_NGAY_BAN = "NgayBan";
        private const string COL_KHACH_HANG = "KhachHang";
        private const string COL_SAN_PHAM = "SanPham";
        private const string COL_SO_LUONG = "SoLuong";
        private const string COL_DON_GIA = "DonGia";
        private const string COL_THANH_TIEN = "ThanhTien";

        public FormReport()
        {
            InitializeComponent();
            Load += FormReport_Load;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // Mặc định lọc từ đầu tháng đến hôm nay
            dtpTungay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpdenngay.Value = DateTime.Today;

            CaiDatDataGridView();
            TaiDuLieu();
        }

        // ──────────────────────────────────────────────
        //  Thiết lập DataGridView
        // ──────────────────────────────────────────────
        private void CaiDatDataGridView()
        {
            dtgBaoCaoDoanhThu.Columns.Clear();
            dtgBaoCaoDoanhThu.Columns.Add(COL_MA_DH, "Mã ĐH");
            dtgBaoCaoDoanhThu.Columns.Add(COL_NGAY_BAN, "Ngày bán");
            dtgBaoCaoDoanhThu.Columns.Add(COL_KHACH_HANG, "Khách hàng");
            dtgBaoCaoDoanhThu.Columns.Add(COL_SAN_PHAM, "Sản phẩm");
            dtgBaoCaoDoanhThu.Columns.Add(COL_SO_LUONG, "Số lượng");
            dtgBaoCaoDoanhThu.Columns.Add(COL_DON_GIA, "Đơn giá");
            dtgBaoCaoDoanhThu.Columns.Add(COL_THANH_TIEN, "Thành tiền");

            dtgBaoCaoDoanhThu.Columns[COL_DON_GIA].DefaultCellStyle.Format = "N0";
            dtgBaoCaoDoanhThu.Columns[COL_THANH_TIEN].DefaultCellStyle.Format = "N0";
            dtgBaoCaoDoanhThu.Columns[COL_SO_LUONG].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dtgBaoCaoDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBaoCaoDoanhThu.ReadOnly = true;
            dtgBaoCaoDoanhThu.AllowUserToAddRows = false; // Giữ false để Rows.Count chính xác
            dtgBaoCaoDoanhThu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgBaoCaoDoanhThu.RowHeadersVisible = false;
        }

        // ──────────────────────────────────────────────
        //  Tải dữ liệu (gọi BLL/DAL ở đây)
        // ──────────────────────────────────────────────
        private void TaiDuLieu()
        {
            dtgBaoCaoDoanhThu.Rows.Clear();

            var tuNgay = dtpTungay.Value.Date;
            var denNgay = dtpdenngay.Value.Date;

            if (tuNgay > denNgay)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.",
                    "Lỗi khoảng ngày",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // TODO: Thay bằng lời gọi BLL/DAL thực tế, ví dụ:
            // var list = DoanhThuBLL.LayTheoKhoangNgay(tuNgay, denNgay);
            // foreach (var item in list)
            //     dtgBaoCaoDoanhThu.Rows.Add(item.MaDH, item.NgayBan, ...);

            TinhTong();
        }

        // ──────────────────────────────────────────────
        //  Tính tổng thống kê
        // ──────────────────────────────────────────────
        private void TinhTong()
        {
            decimal tongDT = 0, caoNhat = 0, thapNhat = 0;
            var tongDon = 0;

            foreach (DataGridViewRow row in dtgBaoCaoDoanhThu.Rows)
            {
                var val = row.Cells[COL_THANH_TIEN].Value;
                if (val == null || val == DBNull.Value) continue;

                var thanhTien = Convert.ToDecimal(val);
                tongDon++;
                tongDT += thanhTien;

                if (tongDon == 1)
                {
                    caoNhat = thapNhat = thanhTien;
                }
                else
                {
                    if (thanhTien > caoNhat) caoNhat = thanhTien;
                    if (thanhTien < thapNhat) thapNhat = thanhTien;
                }
            }

            lblTongSoDonHang.Text = $"Tổng đơn hàng: {tongDon}";
            lblTongDoanhThu.Text = $"Tổng doanh thu: {tongDT:N0} đ";
            lblCaoNhat.Text = $"Cao nhất: {caoNhat:N0} đ";
            lblThapnhat.Text = $"Thấp nhất: {thapNhat:N0} đ";
        }

        // ──────────────────────────────────────────────
        //  Event handlers
        // ──────────────────────────────────────────────
        private void btThem_Click(object sender, EventArgs e)
        {
            // TODO: Mở form thêm đơn hàng, sau đó reload
            // using (var frm = new FormThemDonHang())
            // {
            //     if (frm.ShowDialog() == DialogResult.OK)
            //         TaiDuLieu();
            // }
        }

        private void btLammoi_Click(object sender, EventArgs e)
        {
            dtpTungay.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            dtpdenngay.Value = DateTime.Today;
            TaiDuLieu();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel đang phát triển!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            if (dtgBaoCaoDoanhThu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần in.",
                    "Chưa chọn đơn hàng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Chức năng in đang phát triển!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}