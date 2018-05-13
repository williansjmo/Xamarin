using MenuAccordion.ViewModels.Menu.ContentPages;
using Xamarin.Asistant;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.View.Menu.ContentPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            App.Navigator = Navegate;
            LogoMenu.Source = AS_DirectionImagen.Img_MenuPrincipal;
            BindingContext = new VM_Menu();
        }
        private void ListSub_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var c = (ListView)sender;
            c.SelectedItem = null;
            IsPresented = false;
        }
        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    var item = e.SelectedItem as MenuMenuItem;
        //    if (item == null)
        //        return;

        //    var page = (Page)Activator.CreateInstance(item.TargetType);
        //    page.Title = item.Title;

        //    Detail = new NavigationPage(page);
        //    IsPresented = false;

        //    MasterPage.ListView.SelectedItem = null;
        //}
    }
}