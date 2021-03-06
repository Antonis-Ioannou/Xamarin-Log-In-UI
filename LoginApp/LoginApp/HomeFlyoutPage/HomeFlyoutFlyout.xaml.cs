using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeFlyoutFlyout : ContentPage
    {
        public ListView ListView;

        public HomeFlyoutFlyout()
        {
            InitializeComponent();

            BindingContext = new HomeFlyoutFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class HomeFlyoutFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeFlyoutFlyoutMenuItem> MenuItems { get; set; }

            public HomeFlyoutFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<HomeFlyoutFlyoutMenuItem>(new[]
                {
                    new HomeFlyoutFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new HomeFlyoutFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new HomeFlyoutFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new HomeFlyoutFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new HomeFlyoutFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}