using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalInventory.Model;

namespace PersonalInventory.UI.Data
{
    public interface IItemLookupDataService
    {
        Task<IEnumerable<LookupItem>> GetItemLookupAsync();
    }
}