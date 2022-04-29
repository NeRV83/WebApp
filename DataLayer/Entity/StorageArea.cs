using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DataLayer
{
    public class StorageArea
    {
        public int StorageAreaId { get; set; }  
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        [Required]
        public int INN { get; set; }
        public int? KPP { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public int Area { get; set; }
        public List<Detail> Details { get; set; }
    }
}
