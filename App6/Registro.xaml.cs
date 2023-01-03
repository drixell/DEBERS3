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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
            //lblUsuario.Text = usuario;

        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            Navigation.PushAsync(new Bienvenida(usuario));

        }
    }
}