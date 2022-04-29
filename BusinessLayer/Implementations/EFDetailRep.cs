using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class EFDetailRep : IDetailRep
    {
        private EFDBContext context;
        public EFDetailRep(EFDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Detail> GetAllDetails()
        {
            return context.Detail.ToList();
        }

        public Detail GetDetailById(int DetailId)
        {
            return context.Detail.FirstOrDefault(x => x.DetailId == DetailId);
        }

        public void SaveDetail(Detail Detail)
        {
            if (Detail.DetailId == 0)
                context.Detail.Add(Detail);
            else
                context.Entry(Detail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteDetail(Detail Detail)
        {
            context.Detail.Remove(Detail);
            context.SaveChanges();
        }
    }
}
