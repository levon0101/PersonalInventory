using PersonalInventory.Model;
using PersonalInventory.UI.Data;
using PersonalInventory.UI.Event;
using PersonalInventory.UI.Wrapper;
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
        private ItemWrapper _item;
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

        public async Task LoadAsync(int itemId)
        {
            var item = await _dataService.GetByIdAsync(itemId);

            Item = new ItemWrapper(item);

            Item.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == nameof(Item.HasErrors))
                {
                    ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
                }
            };

            ((DelegateCommand)SaveCommand).RaiseCanExecuteChanged();
        }

        public ItemWrapper Item
        {
            get { return _item; }
            set
            {
                _item = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        private async void OnSaveExecute()
        {
            await _dataService.SaveAsync(Item.Model);
            _eventAggregator.GetEvent<AfterItemSavedEvent>()
                .Publish(new AfterItemSavedEventArgs
                {
                    Id = Item.Id,
                    DisplayMember = Item.ItemName
                });
        }

        private bool OnSaveCanExecute()
        {
            //Chack if friend has changes
            return Item != null && !Item.HasErrors;
        }

        private async void OnOpenFriendDetailView(int itemId)
        {
            await LoadAsync(itemId);
        }
    }
}
