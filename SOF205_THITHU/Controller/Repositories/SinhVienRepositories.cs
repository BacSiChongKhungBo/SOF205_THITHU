using SOF205_THITHU.Model.Context;
using SOF205_THITHU.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF205_THITHU.Controller.Repositories
{
    internal class SinhVienRepositories
    {
        // làm việc với context
        // => khai báo Context
        private MyContext _context;

        //ctor + tab
        public SinhVienRepositories()
        {
            //Khởi tạo Context
            _context = new MyContext();
        }

        //4 hàm CRUD : Create Read Update Delete
        
        //Read : đọc dữ liệu
        public List<Sinhvien> GetSinhviens()
        {
            //Vào DB, Chọn bảng Sinh Vien, lấy dữ liệu
            return _context.Sinhviens.ToList();
        }

        // Vẫn thực hiện công việc add vào DB
        // Tuy nhiên trả về kết quả bool
        // để báo cho service biết có thành công hay không
        public bool AddSV(Sinhvien sv)
        {
            //nếu ko tồn tại sv
            if(sv == null)
            {
                return false;
            }
            //thêm vào DB
            _context.Add(sv); 
            //_context.Sinhviens.Add(sv);
            //Lưu hành động đã thực hiện
            _context.SaveChanges();
            return true;
        }

        public bool SuaSV(Sinhvien sv)
        {
            if (sv == null)
            {
                return false;
            }
            _context.Update(sv);
            _context.SaveChanges();
            return true;
        }

        public bool XoaSV(Sinhvien sv)
        {
            if (sv == null)
            {
                return false;
            }
            _context.Remove(sv);
            _context.SaveChanges();
            return true;
        }
    }
}
