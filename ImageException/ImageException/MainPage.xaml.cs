using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageException
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var assembly = typeof(MainPage).Assembly;
            string path = "ImageException";

            var stream = assembly.GetManifestResourceStream($"{path}.Image.Image.png");
            image.Source = ImageSource.FromStream(() => stream);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MainGrid.Children.Remove(image);
            MainGrid.Children.Add(image);
        }
    }
}
