using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
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
            string usuario = "estudiante2022";
            string contraseña = "uisrael2022";
            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                Navigation.PushAsync(new Bienvenida(usuario));
            }
            else
            {
                DisplayAlert("ALERTA", "Uusuario/Contraseña incorrecto", "Cerrar");
            }

        }

        private void btnRegistro_Clicked(object sender, EventArgs e)
        {
            //string usuario = txtUsuario.Text;
            Navigation.PushAsync(new Registro());
        }
    }
}