using System;
using System.Linq;

using Xamarin.Forms;
using Xaminals.Controls;
using Xaminals.Models;

namespace Xaminals.Views
{
    [QueryProperty(nameof(Name), "name")]
    public partial class GreenFamilyDetailPage : ContentPage
    {
        public GreenFamilyDetailPage()
        {
            InitializeComponent();
        }
        public string Name
        {
            set
            {
                LoadDrink(value);
            }
        }

        void LoadDrink(string name)
        {
            try
            {
                Drink drink = Data.GreenFamily.Family.FirstOrDefault(a => a.Name == name);
                BindingContext = drink;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load drink.");
            }
        }

        private void ShoppingCart_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ShoppingCartPage());
        }

        private void buy(object sender, EventArgs e)
        {
            if (quantity.Text == "0")
            {
                DisplayAlert("警告", "請輸入數量", "確認");
            }
            else
            {
                lblshow.Text = (int.Parse(lblshow.Text) * int.Parse(quantity.Text)).ToString();
            }
        }
    }
}