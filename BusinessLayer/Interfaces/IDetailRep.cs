using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IDetailRep
    {
        IEnumerable<Detail> GetAllDetails();
        Detail GetDetailById(int DetailId);
        void SaveDetail(Detail achieve);
        void DeleteDetail(Detail achieve);
    }
}
