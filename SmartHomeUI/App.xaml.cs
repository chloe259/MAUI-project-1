namespace SmartHomeUI;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new MainPage(); // Gọi thẳng trang Dashboard
    }
}