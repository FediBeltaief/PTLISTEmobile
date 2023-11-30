using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PTLISTEmobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjoutContact : ContentPage
    {
        public AjoutContact()
        {
            InitializeComponent();
        }
        private async void Btnadd_Clicked(Object sender, EventArgs e)
        {
            Contact contact = new Contact
            {
                name = txtNom.Text,
                status = txtStatut.Text,
                imagesource = txtImage.Text,
            };
            await App.Database.SaveContactAsync(contact);
        }
    }
}