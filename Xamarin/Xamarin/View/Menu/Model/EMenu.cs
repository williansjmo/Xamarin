using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Xamarin.View.Menu.Model
{
    public class EMenu : NotifyPropertyChanged
    {
        public string Title { get; set; }
        public Page Page { get; set; }
        public string MenuDetails { get; set; }
        public ImageSource Icono { get; set; }
        private bool _IsVisible;
        public bool IsVisible
        {
            get
            {
                return _IsVisible;
            }
            set
            {
                _IsVisible = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<SubMenu> SubMenu { get; set; }

    }

    public class SubMenu
    {
        public Page SubPage { get; set; }
        public string SubMenuDetails { get; set; }
        public ImageSource SubIcono { get; set; }
    }
}
