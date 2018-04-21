using PersonalInventory.Model;
using PersonalInventory.UI.Data;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PersonalInventory.UI.ViewModel
{

    public class MainViewModel : ViewModelBase
    {

        public MainViewModel(INavigationViewModel navigationViewModel,
            IItemDetailViewModel itemDetailViewModel)
        {
            NavigationViewModel = navigationViewModel;
            ItemDetailViewModel = itemDetailViewModel;
        }


        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();
        }


        public INavigationViewModel NavigationViewModel { get; }
        public IItemDetailViewModel ItemDetailViewModel { get; }
    }


}
