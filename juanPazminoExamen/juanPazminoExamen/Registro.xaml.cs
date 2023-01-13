using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace juanPazminoExamen
{
    public partial class Registro : ContentPage
    {
        public Registro(String usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }



        void BtnCalcularPmensual_Clicked(System.Object sender, System.EventArgs e)
        {
            double a = 4000;
            double MontoInicial = Convert.ToDouble(txtMontoInicial.Text);
            if (MontoInicial > 0)
            {
                double porcentaje = 5 % a;
                double valor = (((a - MontoInicial) / 5) + porcentaje);
                DisplayAlert("Pago mensual es : ", valor.ToString(), "Cancelar", "OK");
            }
            else
            {
                DisplayAlert("Aletra", "MONTO INICIAL NO PERMITIDO", "cerrar");
            }
                
            
        }

        void btnGuardarInformacion_Clicked(System.Object sender, System.EventArgs e)
        {

            double a = 4000;
          
            double MontoInicial = Convert.ToDouble(txtMontoInicial.Text);

            if (MontoInicial > 0)
            {
                double porcentaje = 5 % a;
                double valor = (((a - MontoInicial) / 5) + porcentaje);
                txtPagoMensual.Text = valor.ToString();


                string nombre = Convert.ToString(txtNombre);

                Navigation.PushAsync(new Resumen(lblUsuario.Text, nombre, MontoInicial, valor, a));

            }
            else
            {
                DisplayAlert("Aletra", "MONTO INICIAL NO PERMITIDO", "cerrar");
            }




           
        }
    }
}

