using PersonalInventory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventory.UI.Data
{
    public class ItemDataService : IItemDataService
    {
        public IEnumerable<Item> GetAll()
        {
            yield return new Item { ItemName = "Arduino Uno", ItemModel = "R3", ItemDescription = "3$", Cost = 3.5, SailPrice = 2300 };
            yield return new Item { ItemName = "Arduino Nano", ItemModel = "R3", ItemDescription = "3$", Cost = 2.9, SailPrice = 2000 };
            yield return new Item { ItemName = "LCD 1602", ItemModel = "1602", ItemDescription = "3$", Cost = 2, SailPrice = 2000 };
            yield return new Item { ItemName = "Usb To TTL", ItemModel = "", ItemDescription = "", Cost = 1, SailPrice = 1000 };
        }
    }
}
