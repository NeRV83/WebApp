using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public interface IStorageAreaRep
    {
        IEnumerable<StorageArea> GetAllStorAreas(bool includeDetails = false);
        StorageArea GetStorageAreaById(int StorageAreaId, bool includeDetails = false);
        void SaveStorageArea(StorageArea achieve);
        void DeleteStorageArea(StorageArea achieve);
    }
}
