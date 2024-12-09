namespace UsoDeLayouts;

public partial class Stacklayoutdemo : ContentPage
{
    public Stacklayoutdemo()
    {
        InitializeComponent();
    }

    private async void FlexButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayout());

    }
}