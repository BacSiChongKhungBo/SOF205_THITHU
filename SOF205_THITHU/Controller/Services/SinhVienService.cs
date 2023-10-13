using SOF205_THITHU.Controller.Repositories;
using SOF205_THITHU.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF205_THITHU.Controller.Services
{
    internal class SinhVienService
    {
        //service làm việc với repos
        //khai báo repos
        private SinhVienRepositories _repos;
        public SinhVienService()
        {
            //Khởi tạo repos
            _repos = new SinhVienRepositories();
        }

        //Xử lý dữ liệu từ view
        //Button Show
        //có tìm kiếm => có giá trị đầu vào
        public List<Sinhvien> ShowSinhViens(string search)
        {
            //ko search => null
            if(search == null)
            {
                return _repos.GetSinhviens();
            }
            else
            {
                return _repos.GetSinhviens().Where(x => x.Diachi.Contains(search) || x.Sdt.Contains(search)).ToList();
            }
        }

        //Thêm Sửa, Xóa SinhVien
        // nhận thông báo từ repos là true hoặc false
        // kết quả trả về sẽ là chuỗi thành công hoặc thất bại
        public string ThemSV(Sinhvien sv)
        {
            //-----------------------
            //check mã trùng
            //-----------------------
            if(_repos.AddSV(sv) == true) 
            {
                return "Thêm thành công";
            }
            else
            {
                return "Thêm thất bại";
            }
        }

        public string SuaSV(Sinhvien sv)
        {
            // tạo 1 clone của sinh viên của sửa
            var clone = _repos.GetSinhviens().FirstOrDefault(x => x.Id == sv.Id);
            // gán giá trị các trường của sinh viên vào clone
            clone.Ten = sv.Ten;
            clone.Sdt = sv.Sdt;
            clone.Email = sv.Email;
            clone.Diachi = sv.Diachi;
            clone.IdPh = sv.IdPh;
            // tiến hành gọi repos xử lý ĐỐI TƯỢNG CLONE 
            if(_repos.SuaSV(clone) == true)
            {
                return "Sửa thành công";
            }
            else
            {
                return "Sửa thất bại";
            }
        }

        public string XoaSinhVien(Sinhvien sv)
        {
            // tạo 1 clone của sinh viên của sửa
            var clone = _repos.GetSinhviens().FirstOrDefault(x => x.Id == sv.Id);
            //xóa thì chỉ cần ID nên ko cần gán
            // tiến hành gọi repos xử lý ĐỐI TƯỢNG CLONE 
            if (_repos.XoaSV(clone) == true)
            {
                return "Xóa thành công";
            }
            else
            {
                return "Xóa thất bại";
            }
        }
    }
}
