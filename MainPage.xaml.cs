namespace CameraSave
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
            
        }
    }

}
