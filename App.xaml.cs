namespace UsoDeLayouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = NavigationPage(new FlexLayout());

        }

    }
}