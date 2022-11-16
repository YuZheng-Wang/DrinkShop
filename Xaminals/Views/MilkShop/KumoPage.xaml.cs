using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KumoPage : ContentPage
    {
        public KumoPage()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string drinkName = (e.CurrentSelection.FirstOrDefault() as Drink).Name;
            await Shell.Current.GoToAsync($"//milkshop/kumo/kumodetails?name={drinkName}");
        }
    }
}