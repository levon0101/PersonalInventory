using System.Collections.Generic;
using PersonalInventory.Model;

namespace PersonalInventory.UI.Data
{
    public interface IItemDataService
    {
        IEnumerable<Item> GetAll();
    }
}