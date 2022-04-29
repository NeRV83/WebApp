using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DataManager
    {
        private IStorageAreaRep _StorageAreaRep;
        private IDetailRep _DetailRep;
        private IUserRep _UserRep;

        public DataManager(IStorageAreaRep StorageAreaRep, IDetailRep DetailRep, IUserRep UserRep)
        {
            _StorageAreaRep = StorageAreaRep;
            _DetailRep = DetailRep;
            _UserRep = UserRep;
        }

        public IStorageAreaRep StorageArea { get { return _StorageAreaRep; } }
        public IDetailRep Detail { get { return _DetailRep; } }
        public IUserRep User { get { return _UserRep; } }
    }
}
