using SOF205_THITHU.Model.Context;
using SOF205_THITHU.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF205_THITHU.Controller.Repositories
{
    internal class PhuHuynhRepository
    {
        private MyContext _context;

        public PhuHuynhRepository()
        {
            _context = new MyContext();
        }

        public List<Phuhuynh> GetPhuhuynhs()
        {
            return _context.Phuhuynhs.ToList();
        }
    }
}
