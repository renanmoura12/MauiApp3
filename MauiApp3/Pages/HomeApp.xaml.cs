using Plugin.Firebase.CloudMessaging;

namespace MauiApp3.Pages;

public partial class HomeApp : ContentPage
{
    public HomeApp()
    {
        InitializeComponent();

        label.BindingContext = slider;
        label.SetBinding(Label.RotationProperty, "Value");

    }
}