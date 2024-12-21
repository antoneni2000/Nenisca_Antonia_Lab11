using Nenisca_Antonia_Lab11

using Nenisca_Antonia_Lab11.Data;

namespace Nenisca_Antonia_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}
