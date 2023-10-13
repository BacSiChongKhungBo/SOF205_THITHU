using SOF205_THITHU.Controller.Repositories;
using SOF205_THITHU.Model.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOF205_THITHU.Controller.Services
{
    internal class PhuHuynhService
    {
        private PhuHuynhRepository _repos;

        public PhuHuynhService()
        {
            _repos = new PhuHuynhRepository();
        }

        public List<Phuhuynh> GetAllPHs()
        {
            return _repos.GetPhuhuynhs();
        }
    }
}
