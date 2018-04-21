using PersonalInventory.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalInventory.UI.View
{
    /// <summary>
    /// Interaction logic for NavigationView.xaml
    /// </summary>
    public partial class NavigationView : UserControl
    {
        public NavigationView()
        {
            InitializeComponent();
            //Items = new ObservableCollection<LookupItem>();
           
        }

        //public async Task LoadAsync()
        //{

        //    Items.Clear();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Items.Add(new LookupItem { Id = 1, DisplayMember = "sad asd" });
        //    }
        //}
        //public ObservableCollection<LookupItem> Items { get; }
    }
}
