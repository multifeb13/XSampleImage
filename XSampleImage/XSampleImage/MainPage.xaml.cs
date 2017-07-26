using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XSampleImage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent( );

            Image2.Source = ImageSource.FromResource( "XSampleImage.Resources.Images.りんちゃん.jpg" );
            Image3.Source = ImageSource.FromResource( "XSampleImage.Resources.Images.りんちゃん.jpg" );
        }
    }
}
