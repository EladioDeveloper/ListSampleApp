using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListSample.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacesPage : ContentPage
    {
        public PlacesPage()
        {
            InitializeComponent();
        }
    }
}