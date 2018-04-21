using System.Threading.Tasks;

namespace PersonalInventory.UI.ViewModel
{
    public interface IItemDetailViewModel
    {
        Task LoadAsync(int itemId);
    }
}