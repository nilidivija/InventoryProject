using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InventoryProject.Data
{
    public class Device_Add
    {
      
        [Required(ErrorMessage ="*required")]
        public string DevType { get; set; }

        [Required(ErrorMessage="*required")]
        public string DevTypeOther { get; set; }

        [Required(ErrorMessage="*required")]
        public string Make { get; set; }

        [Required(ErrorMessage="*required")]
        public string Model { get; set; }

        [Required(ErrorMessage="*required")]
        public string Owner { get; set; }

        [Required(ErrorMessage="*required")]
        public string Location { get; set; }

        [Required(ErrorMessage="*required")]
        public string Serial { get; set; }

        [Required(ErrorMessage = "*required")]
        public DateTime PurchaseDate { get; set; } 

        [Required(ErrorMessage = "*required")]
        public DateTime WarrantyExpDate { get; set; } 

        [Required(ErrorMessage = "*required")]
        public DateTime ServiceExpDate { get; set; } 

        [Required(ErrorMessage="*required")]
        public int Value { get; set; }

        [Required(ErrorMessage="*required")]
        public int Size { get; set; }

        [Required(ErrorMessage="*required")]
        public int Toner { get; set; }

        [Required(ErrorMessage="*required")]
        public int MacAddress { get; set; }

        [Required(ErrorMessage="*required")]
        public int IPAddress { get; set; }

        [Required(ErrorMessage="*required")]
        public int CellNumber { get; set; }

    }
}
