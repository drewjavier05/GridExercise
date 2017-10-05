using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridExercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayoutSample : ContentPage
    {
        public StackLayoutSample()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Xamarin", "Halooo", "OK");
        }

        private void Button_OnClickedRegister(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackLayoutSample2());
        }
    }
}