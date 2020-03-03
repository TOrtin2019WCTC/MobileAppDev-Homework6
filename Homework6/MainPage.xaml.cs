using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Homework6
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       private async void ShowClockPage(System.Object sender, System.EventArgs e)
        {

            await Navigation.PushAsync(new Page2());

        }

        private async void ShowListOfApexCharactersPage(Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
