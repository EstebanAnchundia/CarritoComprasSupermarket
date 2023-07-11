using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CarritoComprasSupermarket.Vista;

namespace CarritoComprasSupermarket
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "uisrael2023";
            string contraseña = "esteban2023";
            if (txtUsuario.Text == usuario && txtContraseña.Text == contraseña)
            {
                Navigation.PushAsync(new Compras(usuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario/Contraseña incorrectos", "Cerrar");
            }
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
        }
    }
}