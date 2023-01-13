using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace juanPazminoExamen
{
    public partial class Resumen : ContentPage
    {
        public Resumen(String usuario, String nombre, double valor , double MontoInicial, double PagoMensual)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtTotal.Text = valor.ToString();

        }

        void btnAcercaDe_Clicked(System.Object sender, System.EventArgs e)
        {
            
            DisplayAlert("App creada por Juan Pazmiño"," ","cancel");
            
        }
    }
}

