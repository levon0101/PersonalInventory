using PersonalInventory.Model;
using PersonalInventory.UI.Data;
using PersonalInventory.UI.Event;
using Prism.Commands;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonalInventory.UI.ViewModel
{
    public class ItemDetailViewModel : ViewModelBase, IItemDetailViewModel
    {
        private IItemDataService _dataService;
        private IEventAggregator _eventAggregator;

        public ItemDetailViewModel(IItemDataService dataService,
            IEventAggregator eventAggregator)
        {
            _dataService = dataService;
            _eventAggregator = eventAggregator;
            _eventAggregator.GetEvent<OpenItemDetailViewEvent>()
                .Subscribe(OnOpenFriendDetailView);

            SaveCommand = new DelegateCommand(OnSaveExecute, OnSaveCanExecute);
        }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync(Item);
            _eventAggregator.GetEvent<AfterItemSavedEvent>()
                .Publish(new AfterItemSavedEventArgs
                {
                    Id = Item.Id,
                    DisplayMember = Item.ItemName
                });
        }

        private bool OnSaveCanExecute()
        {
            return true;
        }

        private async void OnOpenFriendDetailView(int itemId)
        {
            await LoadAsync(itemId);
        }

        public async Task LoadAsync(int itemId)
        {
            Item = await _dataService.GetByIdAsync(itemId);
        }

        private Item _item;

        public Item Item
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }
    }
}
