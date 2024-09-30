namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnTestPageClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Starting 5 second delay");
            await Task.Delay(5000);
            Console.WriteLine("Before PushAsync for TestPage");
            await Navigation.PushAsync(new TestPage());
            Console.WriteLine("After PushAsync for TestPage");
        }
    }

}
