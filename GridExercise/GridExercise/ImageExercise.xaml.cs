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
    public partial class ImageExercise : ContentPage
    {
        private int counter = 1;


        public ImageExercise()
        {
            InitializeComponent();
            counter = 1;
            LoadImage();
        }

        private void LoadImage()
        {
            Image.Source = new UriImageSource()
            {
                Uri = new Uri($"http://lorempixel.com/1920/1080/city/{counter}"),
                CachingEnabled = false
            }
            ;
        }


        private void Button_OnClicked(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
                
                counter = 10;

            LoadImage();
        }

        private void Button_OnClickedForward(object sender, EventArgs e)
        {
            counter++;
            if (counter == 11)

                counter = 1;

            LoadImage();
        }
    }
}