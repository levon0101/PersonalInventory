using PersonalInventory.Model;
using PersonalInventory.UI.Data;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace PersonalInventory.UI.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        private Item _selectedItem;
        private IItemDataService _itemDataService;

        public MainViewModel(IItemDataService itemDataService)
        {
            Items = new ObservableCollection<Item>();
            _itemDataService = itemDataService;
        }

        public void Load()
        {
            var items = _itemDataService.GetAll();

            Items.Clear();
            foreach (var item in items)
            {
                Items.Add(item);
            }
            //SelectedItem = Items.First();
            //MessageBox.Show(Items.First().ItemName);
        }


        public Item SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();
            }
        }

    }


}
