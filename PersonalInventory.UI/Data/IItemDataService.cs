using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalInventory.Model;

namespace PersonalInventory.UI.Data
{
    public interface IItemDataService
    {
        Task<Item> GetByIdAsync(int itemId);
        Task SaveAsync(Item item);
    }
}