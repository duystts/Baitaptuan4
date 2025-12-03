namespace Baitaptuan4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblDiemTB = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.btnThemSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.lblTongNam = new System.Windows.Forms.Label();
            this.lblTongNu = new System.Windows.Forms.Label();
            this.lblSoNam = new System.Windows.Forms.Label();
            this.lblSoNu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(250, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 26);
            this.lblTitle.Text = "Quản Lý Thông Tin Sinh Viên";
            
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(30, 80);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(67, 13);
            this.lblMSSV.Text = "Mã Sinh Viên";
            
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(30, 110);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.Text = "Họ Tên";
            
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 140);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(51, 13);
            this.lblGioiTinh.Text = "Giới Tính";
            
            this.lblDiemTB.AutoSize = true;
            this.lblDiemTB.Location = new System.Drawing.Point(30, 170);
            this.lblDiemTB.Name = "lblDiemTB";
            this.lblDiemTB.Size = new System.Drawing.Size(50, 13);
            this.lblDiemTB.Text = "Điểm TB";
            
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(30, 200);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(32, 13);
            this.lblKhoa.Text = "Khoa";
            
            this.txtMSSV.Location = new System.Drawing.Point(120, 77);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(150, 20);
            
            this.txtHoTen.Location = new System.Drawing.Point(120, 107);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(150, 20);
            
            this.txtDiemTB.Location = new System.Drawing.Point(120, 167);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(150, 20);
            
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(120, 138);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            
            this.rdNu.AutoSize = true;
            this.rdNu.Checked = true;
            this.rdNu.Location = new System.Drawing.Point(180, 138);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            
            this.cboKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Items.AddRange(new object[] { "QTKD", "CNTT", "NNA" });
            this.cboKhoa.Location = new System.Drawing.Point(120, 197);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(150, 21);
            
            this.btnThemSua.Location = new System.Drawing.Point(120, 240);
            this.btnThemSua.Name = "btnThemSua";
            this.btnThemSua.Size = new System.Drawing.Size(70, 23);
            this.btnThemSua.Text = "Thêm/Sửa";
            this.btnThemSua.UseVisualStyleBackColor = true;
            this.btnThemSua.Click += new System.EventHandler(this.btnThemSua_Click);
            
            this.btnXoa.Location = new System.Drawing.Point(200, 240);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 23);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(300, 80);
            this.dgvSinhVien.MultiSelect = false;
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.Size = new System.Drawing.Size(450, 250);
            this.dgvSinhVien.SelectionChanged += new System.EventHandler(this.dgvSinhVien_SelectionChanged);
            
            this.lblTongNam.AutoSize = true;
            this.lblTongNam.Location = new System.Drawing.Point(500, 350);
            this.lblTongNam.Name = "lblTongNam";
            this.lblTongNam.Size = new System.Drawing.Size(58, 13);
            this.lblTongNam.Text = "Tổng SV Nam";
            
            this.lblTongNu.AutoSize = true;
            this.lblTongNu.Location = new System.Drawing.Point(600, 350);
            this.lblTongNu.Name = "lblTongNu";
            this.lblTongNu.Size = new System.Drawing.Size(50, 13);
            this.lblTongNu.Text = "Nữ";
            
            this.lblSoNam.AutoSize = true;
            this.lblSoNam.Location = new System.Drawing.Point(570, 350);
            this.lblSoNam.Name = "lblSoNam";
            this.lblSoNam.Size = new System.Drawing.Size(13, 13);
            this.lblSoNam.Text = "0";
            
            this.lblSoNu.AutoSize = true;
            this.lblSoNu.Location = new System.Drawing.Point(650, 350);
            this.lblSoNu.Name = "lblSoNu";
            this.lblSoNu.Size = new System.Drawing.Size(13, 13);
            this.lblSoNu.Text = "0";
            
            this.groupBox1.Controls.Add(this.lblMSSV);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lblGioiTinh);
            this.groupBox1.Controls.Add(this.lblDiemTB);
            this.groupBox1.Controls.Add(this.lblKhoa);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtDiemTB);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.cboKhoa);
            this.groupBox1.Controls.Add(this.btnThemSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(20, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 280);
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSoNu);
            this.Controls.Add(this.lblSoNam);
            this.Controls.Add(this.lblTongNu);
            this.Controls.Add(this.lblTongNam);
            this.Controls.Add(this.dgvSinhVien);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Quản Lý Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiemTB;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.Button btnThemSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label lblTongNam;
        private System.Windows.Forms.Label lblTongNu;
        private System.Windows.Forms.Label lblSoNam;
        private System.Windows.Forms.Label lblSoNu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}