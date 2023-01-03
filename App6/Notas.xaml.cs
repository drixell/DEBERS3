using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double datoSeguimientoUno = Convert.ToDouble(txtDatoSeguimientoUno.Text)*0.3;
            double datoSeguimientoDos = Convert.ToDouble(txtDatoSeguimientoDos.Text)*0.3;
            double datoExamenUno = Convert.ToDouble(txtDatoExamenUno.Text) * 0.2;
            double datoExamenDos= Convert.ToDouble(txtDatoExamenDos.Text) * 0.2;
            double notaParcialUno = datoSeguimientoUno + datoExamenUno;
            double notaParcialDos = datoSeguimientoDos+ datoExamenDos;
            double notaFinal = notaParcialDos + notaParcialDos;
            //string estado = txtEstado.Text;

            if (notaFinal >= 7)
            {
                txtEstado.Text = "Aprobado";
            }
            if (notaFinal < 7)
            {
                txtEstado.Text = "Complementario";
            }
            if (notaFinal >=0 && notaFinal<=5)
            {
                txtEstado.Text = "Perdio Semestre";
            }
            txtNota.Text = notaFinal.ToString();
        }

        private void txtDatoSeguimientoUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            double datoSeguimientoUno = Convert.ToDouble(txtDatoSeguimientoUno.Text);
            double datoSeguimientoDos = Convert.ToDouble(txtDatoSeguimientoDos.Text);
            double datoExamenUno = Convert.ToDouble(txtDatoExamenUno.Text) ;
            double datoExamenDos = Convert.ToDouble(txtDatoExamenDos.Text) ;
            try
            {
                if (datoSeguimientoUno<0 || datoSeguimientoUno > 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
                if (datoSeguimientoDos<0 || datoSeguimientoDos> 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
                if (datoExamenUno < 0 || datoExamenUno > 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
                if (datoExamenDos < 0 || datoExamenDos> 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {


        }
    }
}