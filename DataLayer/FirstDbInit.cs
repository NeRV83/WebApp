using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class FirstDbInit
    {
        public static void InitData(EFDBContext context)
        {
            if (!context.Detail.Any() & !context.StorageArea.Any())
            {
                context.StorageArea.Add(new StorageArea() { Name = "Площадка филиала", Adress = "Ангарск", INN = 774000, Capacity = 300, Area = 100 });
                context.StorageArea.Add(new StorageArea() { Name = "Свалка", Adress = "Ангарск", INN = 380102, Capacity = 500, Area = 300 });
                context.SaveChanges();

                context.Detail.Add(new Detail() { DetailNumber = 112233, ManufactCode = 44, ManufactYear = 2000, DetailType = "Боковая рама", DetailCondition = "Условно пригодная", StorageAreaId = context.StorageArea.First().StorageAreaId});
                context.Detail.Add(new Detail() { DetailNumber = 332211, ManufactCode = 55, ManufactYear = 2000, DetailType = "Боковая рама", DetailCondition = "Условно пригодная", StorageAreaId = context.StorageArea.First().StorageAreaId });
                context.Detail.Add(new Detail() { DetailNumber = 456, ManufactCode = 66, ManufactYear = 2000, DetailType = "Боковая рама", DetailCondition = "Условно пригодная", StorageAreaId = context.StorageArea.Last().StorageAreaId });
                context.SaveChanges();
            }
        }
    }
}
