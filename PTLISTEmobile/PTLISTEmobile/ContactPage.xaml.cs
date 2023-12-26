using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTLISTEmobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPage : ContentPage
    {
        private ObservableCollection<Contact> contacts;
        public ContactPage()
        {
            InitializeComponent();

        }


        protected async override void OnAppearing()
        {
            listcontacts.ItemsSource = await App.Database.GetContactAsync();
        }
        private void BtnAfficher_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Détails", contact.name + "\n" + contact.imagesource, "OK");
        }
        private void BtnDelete_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            //contacts.Remove(contact);
            App.Database.DeleteContactAsync(contact);
            this.OnAppearing();
        }


    }
}