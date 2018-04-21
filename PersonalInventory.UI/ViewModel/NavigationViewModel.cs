using PersonalInventory.Model;
using PersonalInventory.UI.Data;
using PersonalInventory.UI.Event;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventory.UI.ViewModel
{
    public class NavigationViewModel : ViewModelBase, INavigationViewModel
    {
        private IItemLookupDataService _itemLookupDataService;
        private IEventAggregator _eventAggregator;

        public NavigationViewModel(IItemLookupDataService itemLookupDataService,
            IEventAggregator eventAggregator)
        {
            _itemLookupDataService = itemLookupDataService;
            _eventAggregator = eventAggregator;
            Items = new ObservableCollection<LookupItem>();
        }

        public async Task LoadAsync()
        {
            var lookup = await _itemLookupDataService.GetItemLookupAsync();
            Items.Clear();
            foreach (var item in lookup)
            {
                Items.Add(item);
            }
        }

        public ObservableCollection<LookupItem> Items { get; }

        private LookupItem _selectedItem;

        public LookupItem SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                OnPropertyChanged();

                if(_selectedItem != null)
                {
                    _eventAggregator.GetEvent<OpenItemDetailViewEvent>()
                        .Publish(_selectedItem.Id);
                }
            }
        }

    }
}
