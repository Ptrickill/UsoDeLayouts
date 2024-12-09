namespace UsoDeLayouts;

public partial class GridlayoutPage : ContentPage
{
    public GridlayoutPage()
    {
        InitializeComponent();
    }
    private async void InfoButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Información de mí", "Mi nombre es [Isaac Trujillo]", "Cerrar");
    }

    private async void StackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Stacklayoutdemo());
    }

    private void GitHubButton_Clicked(object sender, EventArgs e)
    {
        var githubUrl = "https://github.com/Altermanns/UsoDeLayoutsTrujillo.git";
        Launcher.Default.OpenAsync(githubUrl);
    }

    private void FavoriteSongButton_Clicked(object sender, EventArgs e)
    {
        var songUrl = "https://www.youtube.com/watch?v=Jy1D6caG8nU";
        Launcher.Default.OpenAsync(songUrl);
    }

}