using System.Diagnostics;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void DeleteAll(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "All text deleted", "OK");
        }
    }

}
