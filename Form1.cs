using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Baitaptuan4
{
    public partial class Form1 : Form
    {
        private DataTable dtSinhVien;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtSinhVien = new DataTable();
            dtSinhVien.Columns.Add("MSSV", typeof(string));
            dtSinhVien.Columns.Add("Họ Tên", typeof(string));
            dtSinhVien.Columns.Add("Giới Tính", typeof(string));
            dtSinhVien.Columns.Add("ĐTB", typeof(double));
            dtSinhVien.Columns.Add("Khoa", typeof(string));

            dgvSinhVien.DataSource = dtSinhVien;
            cboKhoa.SelectedIndex = 0;
            rdNu.Checked = true;
            UpdateCount();
        }

        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text) || 
                string.IsNullOrWhiteSpace(txtHoTen.Text) || 
                string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDiemTB.Text, out double diemTB))
            {
                MessageBox.Show("Điểm trung bình phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssv = txtMSSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string khoa = cboKhoa.SelectedItem.ToString();

            DataRow[] existingRows = dtSinhVien.Select($"MSSV = '{mssv}'");
            
            if (existingRows.Length > 0)
            {
                existingRows[0]["Họ Tên"] = hoTen;
                existingRows[0]["Giới Tính"] = gioiTinh;
                existingRows[0]["ĐTB"] = diemTB;
                existingRows[0]["Khoa"] = khoa;
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dtSinhVien.Rows.Add(mssv, hoTen, gioiTinh, diemTB, khoa);
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearInputs();
            UpdateCount();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập MSSV cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssv = txtMSSV.Text.Trim();
            DataRow[] rowsToDelete = dtSinhVien.Select($"MSSV = '{mssv}'");

            if (rowsToDelete.Length == 0)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dtSinhVien.Rows.Remove(rowsToDelete[0]);
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                UpdateCount();
            }
        }

        private void dgvSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSinhVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSinhVien.SelectedRows[0];
                
                txtMSSV.Text = selectedRow.Cells["MSSV"].Value.ToString();
                txtHoTen.Text = selectedRow.Cells["Họ Tên"].Value.ToString();
                txtDiemTB.Text = selectedRow.Cells["ĐTB"].Value.ToString();
                
                string gioiTinh = selectedRow.Cells["Giới Tính"].Value.ToString();
                rdNam.Checked = gioiTinh == "Nam";
                rdNu.Checked = gioiTinh == "Nữ";
                
                cboKhoa.SelectedItem = selectedRow.Cells["Khoa"].Value.ToString();
            }
        }

        private void ClearInputs()
        {
            txtMSSV.Clear();
            txtHoTen.Clear();
            txtDiemTB.Clear();
            rdNu.Checked = true;
            cboKhoa.SelectedIndex = 0;
        }

        private void UpdateCount()
        {
            int soNam = dtSinhVien.AsEnumerable().Count(row => row.Field<string>("Giới Tính") == "Nam");
            int soNu = dtSinhVien.AsEnumerable().Count(row => row.Field<string>("Giới Tính") == "Nữ");
            
            lblSoNam.Text = soNam.ToString();
            lblSoNu.Text = soNu.ToString();
        }
    }
}