using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EFStorageAreaRep : IStorageAreaRep
    {
        private EFDBContext context;
        public EFStorageAreaRep(EFDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<StorageArea> GetAllStorAreas(bool includeDetails = false)
        {
            if (includeDetails)
                return context.Set<StorageArea>().Include(x => x.Details).AsNoTracking().ToList();
            else
                return context.StorageArea.ToList();
        }

        public StorageArea GetStorageAreaById(int StorageAreaId, bool includeDetails = false)
        {
            if (includeDetails)
                return context.Set<StorageArea>().Include(x => x.Details).AsNoTracking().FirstOrDefault(x => x.StorageAreaId == StorageAreaId);
            else
                return context.StorageArea.FirstOrDefault(x => x.StorageAreaId == StorageAreaId);
        }

        public void SaveStorageArea(StorageArea StorageArea)
        {
            if (StorageArea.StorageAreaId == 0)
                context.StorageArea.Add(StorageArea);
            else
                context.Entry(StorageArea).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteStorageArea(StorageArea StorageArea)
        {
            context.StorageArea.Remove(StorageArea);
            context.SaveChanges();
        }
    }
}
