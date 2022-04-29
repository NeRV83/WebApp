using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class Detail
    {
        public int DetailId { get; set; }
        [Required]
        public int DetailNumber { get; set; }
        [Required]
        public int ManufactYear { get; set; }
        [Required]
        public int ManufactCode { get; set; }
        public DateTime? InDate { get; set; }
        public DateTime? OutDate { get; set; }
        public int? RailCar { get; set; }
        public int? StorageSq { get; set; }
        public int? Quantity { get; set; }
        public int? WheelSize { get; set; }
        [Required]
        public string DetailCategory { get; set; }
        [Required]
        public string DetailType { get; set; }
        [Required] 
        public string DetailCondition { get; set; }
        public string AttachedFiles { get; set; }
        public int? StorageAreaId { get; set; } // внешний ключ
        public StorageArea StorageArea { get; set; } // навигационное свойство
    }
}
