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
    public partial class Bienvenida : ContentPage
    {
        public Bienvenida(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }
    }
}