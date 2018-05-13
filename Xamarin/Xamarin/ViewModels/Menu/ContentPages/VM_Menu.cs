using Xamarin.Asistant;
using Xamarin.View.Menu.Model;
using Xamarin.View.Pages.ContentPages;
using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin;

namespace MenuAccordion.ViewModels.Menu.ContentPages
{
    public class VM_Menu : NotifyPropertyChanged
    {
        public VM_Menu()
        {
            LoadItems();
        }

        #region PROPERTY

        private EMenu _MenuPage1;
        public EMenu MenuPage1
        {
            get
            {
                return _MenuPage1;
            }
            set
            {
                _MenuPage1 = value;
                OnPropertyChanged("MenuPage1");
            }
        }

        private EMenu _MenuPage2;
        public EMenu MenuPage2
        {
            get
            {
                return _MenuPage2;
            }
            set
            {
                _MenuPage2 = value;
                OnPropertyChanged("MenuPage2");
            }
        }
        private EMenu _MenuPage3;
        public EMenu MenuPage3
        {
            get
            {
                return _MenuPage3;
            }
            set
            {
                _MenuPage3 = value;
                OnPropertyChanged("MenuPage3");
            }
        }

        private EMenu _MenuPage4;
        public EMenu MenuPage4
        {
            get
            {
                return _MenuPage4;
            }
            set
            {
                _MenuPage4 = value;
                OnPropertyChanged("MenuPage4");
            }
        }
        private EMenu _Menu_Salir;
        public EMenu Menu_Salir
        {
            get
            {
                return _Menu_Salir;
            }
            set
            {
                _Menu_Salir = value;
                OnPropertyChanged("Menu_Salir");
            }
        }
        #endregion

        #region OBJETOS SECUNDARIOS 
        private SubMenu _SelectSubMenu;
        public SubMenu SelectSubMenu
        {
            get
            {
                return _SelectSubMenu;
            }
            set
            {
                _SelectSubMenu = value;
                MethodPrepareNodeSubMenu(value);
                OnPropertyChanged("SelectSubMenu");
            }
        }
        #endregion

        #region COMMAND
        public Command CMenu_Page1
        {
            get
            {
                return new Command(() =>
                {
                    MenuPage1.IsVisible = MenuPage1.IsVisible == true ? false : true;
                });
            }
        }

        public Command CMenu_Page2
        {
            get
            {
                return new Command(() =>
                {
                    MenuPage2.IsVisible = MenuPage2.IsVisible == true ? false : true;
                });
            }
        }
        public Command CMenu_Page3
        {
            get
            {
                return new Command(() =>
                {
                    MenuPage3.IsVisible = MenuPage3.IsVisible == true ? false : true;
                });
            }
        }
        public Command CMenu_Page4
        {
            get
            {
                return new Command(() =>
                {
                    MenuPage4.IsVisible = MenuPage4.IsVisible == true ? false : true;
                });
            }
        }
        public Command CMenu_Salir
        {
            get
            {
                return new Command(() =>
                {
                    App.Current.MainPage = Menu_Salir.Page;
                });
            }
        }
        #endregion

        #region METODOS
        private void MethodPrepareNodeSubMenu(SubMenu SubMenu)
        {
            try
            {
                if (SubMenu != null && SubMenu.SubPage != null)
                {
                    App.Navigator.PushAsync(SubMenu.SubPage);
                }
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("ERROR", ex.Message, "Ok");
            }
        }

        public void LoadItems()
        {
            try
            {
                MenuPage1 = new EMenu()
                {
                    Title = "Willians Parrilla",
                    MenuDetails = "Menu 1",
                    Icono = AS_DirectionImagen.Img_Menu,
                    IsVisible = false,
                    SubMenu = new ObservableCollection<SubMenu>
                    {
                    new SubMenu { SubMenuDetails = "Home", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page1() },
                    new SubMenu { SubMenuDetails = "Perfile", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "New baby", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "Link group", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "Wish list", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "Bebitus account", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "Aportaciones realizadas", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "Payment methods", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "Logout", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    }
                };

                MenuPage2 = new EMenu()
                {
                    Title = "Sarita",
                    MenuDetails = "Menu 2",
                    Icono = AS_DirectionImagen.Img_Menu,
                    IsVisible = false,
                    SubMenu = new ObservableCollection<SubMenu>
                    {
                    new SubMenu { SubMenuDetails = "Portada de sarita", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page1() },
                    new SubMenu { SubMenuDetails = "Los nenes de cole", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page2() },
                    new SubMenu { SubMenuDetails = "Compañeras de danza", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page1() },
                    new SubMenu { SubMenuDetails = "Abuelos", SubIcono = AS_DirectionImagen.Img_SubMenu, SubPage = new Page1() },
                    }
                };

                MenuPage3 = new EMenu()
                {
                    Title = "Josete",
                    Page = new Page(),
                    MenuDetails = "Josete",
                    Icono = AS_DirectionImagen.Img_close,
                    IsVisible = false,
                    SubMenu = new ObservableCollection<SubMenu>()
                    {
                    }
                };

                MenuPage4 = new EMenu()
                {
                    Title = "Lucas crece",
                    Page = new Page(),
                    MenuDetails = "Lucas crece",
                    Icono = AS_DirectionImagen.Img_close,
                    IsVisible = false,
                    SubMenu = new ObservableCollection<SubMenu>()
                    {
                    }
                };

                Menu_Salir = new EMenu()
                {
                    Title = "Salir",
                    Page = new Page(),
                    MenuDetails = "Cerrar Sesión",
                    Icono = AS_DirectionImagen.Img_close,
                    IsVisible = false,
                    SubMenu = new ObservableCollection<SubMenu>()
                    {
                    }
                };
            }
            catch (Exception ex)
            {
                App.Current.MainPage.DisplayAlert("ERROR", ex.Message, "Ok");
            }
        }

        #endregion
    }
}