using System.Globalization;

namespace GUI;

public partial class FormManageShift : Form
{
    public FormManageShift()
    {
        InitializeComponent();
    }

    private void FormManageShift_Load(object sender, EventArgs e)
    {
        cbbCaLamViec.Items.AddRange("Ca sáng", "Ca chiều", "Ca tối");
        cbbCaLamViec.SelectedIndex = 0;
        CaiDatDataGridView();
    }

    private void CaiDatDataGridView()
    {
        dgvCaLamViec.Columns.Clear();
        dgvCaLamViec.Columns.Add("MaNV", "Mã nhân viên");
        dgvCaLamViec.Columns.Add("TenNV", "Tên nhân viên");
        dgvCaLamViec.Columns.Add("Ca", "Ca làm việc");
        dgvCaLamViec.Columns.Add("NgayLam", "Ngày làm");

        dgvCaLamViec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCaLamViec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvCaLamViec.RowHeadersVisible = false;
        dgvCaLamViec.AllowUserToAddRows = false;
    }

    private void btThem_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text) || string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return;
        }

        dgvCaLamViec.Rows.Add(
            txtMaNhanVien.Text,
            txtTenNhanVien.Text,
            cbbCaLamViec.SelectedItem.ToString(),
            dtpNgayLam.Value.ToString("dd/MM/yyyy")
        );

        XoaTrang();
    }

    private void btSua_Click(object sender, EventArgs e)
    {
        if (dgvCaLamViec.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var row = dgvCaLamViec.SelectedRows[0];
        row.Cells["MaNV"].Value = txtMaNhanVien.Text;
        row.Cells["TenNV"].Value = txtTenNhanVien.Text;
        row.Cells["Ca"].Value = cbbCaLamViec.SelectedItem.ToString();
        row.Cells["NgayLam"].Value = dtpNgayLam.Value.ToString("dd/MM/yyyy");

        XoaTrang();
    }

    private void btXoa_Click(object sender, EventArgs e)
    {
        if (dgvCaLamViec.SelectedRows.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            dgvCaLamViec.Rows.Remove(dgvCaLamViec.SelectedRows[0]);
        }
    }

    private void btLamMoi_Click(object sender, EventArgs e)
    {
        XoaTrang();
    }

    private void dgvCaLamViec_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            var row = dgvCaLamViec.Rows[e.RowIndex];
            txtMaNhanVien.Text = row.Cells["MaNV"].Value?.ToString();
            txtTenNhanVien.Text = row.Cells["TenNV"].Value?.ToString();
            cbbCaLamViec.SelectedItem = row.Cells["Ca"].Value?.ToString();
            if (DateTime.TryParseExact(row.Cells["NgayLam"].Value?.ToString(), "dd/MM/yyyy", null,
                    DateTimeStyles.None, out var ngay))
            {
                dtpNgayLam.Value = ngay;
            }
        }
    }

    private void XoaTrang()
    {
        txtMaNhanVien.Clear();
        txtTenNhanVien.Clear();
        cbbCaLamViec.SelectedIndex = 0;
        dtpNgayLam.Value = DateTime.Now;
    }
}