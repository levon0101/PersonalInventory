using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventory.Model
{
    public class Item
    {
        public int Id { get; set; }

        public string ItemName { get; set; }

        public string ItemModel { get; set; }

        public double Cost { get; set; }

        public double SailPrice { get; set; }

        public string ItemDescription { get; set; }
    }
}
