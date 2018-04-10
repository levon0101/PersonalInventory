using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventory.Model
{
    public class Item
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string ItemModel { get; set; }

        
        public double Cost { get; set; }

        public double SailPrice { get; set; }

        [StringLength(250)]
        public string ItemDescription { get; set; }
    }
}
