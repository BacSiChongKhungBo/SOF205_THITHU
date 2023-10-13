using SOF205_THITHU.Controller.Services;
using SOF205_THITHU.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOF205_THITHU.View
{
    public partial class Home : Form
    {
        //Khai báo service
        private SinhVienService _service;
        private PhuHuynhService _phService;
        //Khai báo ID đang được chọn
        int _idWhenClick;
        public Home()
        {
            InitializeComponent();
            //Khởi tạo
            _service = new SinhVienService();
            _phService = new PhuHuynhService();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //khai báo stt
            int stt = 1;
            //gán số cột cho dtgView
            Type type = typeof(Sinhvien);
            int NumberOfRecords = type.GetProperties().Length;
            dtgView.ColumnCount = NumberOfRecords + 2;
            //Đặt tên cột
            dtgView.Columns[0].Name = "STT";
            dtgView.Columns[1].Name = "ID";
            dtgView.Columns[2].Name = "Tên";
            dtgView.Columns[3].Name = "SDT";
            dtgView.Columns[4].Name = "DiaChi";
            dtgView.Columns[5].Name = "Email";
            dtgView.Columns[6].Name = "ID Phụ Huynh";
            dtgView.Columns[7].Name = "TÊN Phụ Huynh";
            dtgView.Columns[8].Name = "NGHỀ NGHIỆP";
            //Xóa dòng mỗi lần button kích hoạt
            dtgView.Rows.Clear();
            //Thêm dữ liệu vào từng row
            foreach (var x in _service.ShowSinhViens(txtSearch.Text))
            {
                if(x.IdPh != null)
                {
                    var ph = _phService.GetAllPHs().FirstOrDefault(p => p.Id == x.IdPh);
                    dtgView.Rows.Add(stt++, x.Id, x.Ten, x.Sdt, x.Diachi, x.Email, x.IdPh, ph.Ten, ph.Nghenghiep);
                } else
                {
                    dtgView.Rows.Add(stt++, x.Id, x.Ten, x.Sdt, x.Diachi, x.Email, x.IdPh, "", "");
                }
                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //tạo 1 đối tượng mới
            Sinhvien sv = new Sinhvien();
            //Gán giá trị từ textbox vào trong đối tương
            sv.Ten = txtTen.Text;
            sv.Email = txtEmail.Text;
            sv.Diachi = txtDiaChi.Text;
            sv.Sdt = txtSDT.Text;
            sv.IdPh = int.Parse(txtIDPhuHuynh.Text);
            //Trả về kết quả
            MessageBox.Show(_service.ThemSV(sv));
        }
        //Muốn Sửa và xóa
        // => lấy được ID
        private void dtgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Lấy dòng đang chọn
            int rowSelected = e.RowIndex;
            _idWhenClick = int.Parse(dtgView.Rows[rowSelected].Cells[1].Value.ToString());
            //lấy dữ liệu fill vào text box
            var sv = _service.ShowSinhViens(null).FirstOrDefault(x => x.Id == _idWhenClick);
            txtDiaChi.Text = sv.Diachi;
            txtTen.Text = sv.Ten;
            txtSDT.Text = sv.Sdt;
            txtEmail.Text = sv.Email;
            txtIDPhuHuynh.Text = sv.IdPh.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //tạo 1 đối tượng mới
            Sinhvien sv = new Sinhvien();
            //gán ID đang chọn thành id của sv này
            sv.Id = _idWhenClick;
            //Gán giá trị từ textbox vào trong đối tương
            sv.Ten = txtTen.Text;
            sv.Email = txtEmail.Text;
            sv.Diachi = txtDiaChi.Text;
            sv.Sdt = txtSDT.Text;
            sv.IdPh = int.Parse(txtIDPhuHuynh.Text);
            //Trả về kết quả
            MessageBox.Show(_service.SuaSV(sv));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //tạo 1 đối tượng mới
            Sinhvien sv = new Sinhvien();
            //gán ID đang chọn thành id của sv này
            sv.Id = _idWhenClick;
            //Trả về kết quả
            MessageBox.Show(_service.XoaSinhVien(sv));
        }
    }
}
