﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventory.UI.ViewModel
{
    public class NavigationItemViewModel : ViewModelBase
    {
        private string _displayMember;
        public NavigationItemViewModel(int id, string displayMember)
        {
            _displayMember = displayMember;
            Id = id;
        }
        public int Id { get; set; }


        public string DisplayMember
        {
            get { return _displayMember; }
            set
            {
                _displayMember = value;
                OnPropertyChanged();
            }
        }

    }
}
