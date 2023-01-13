using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace juanPazminoExamen
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";
            if (usuario == Usuario.Text && contrasena == Password.Text)
            {

                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Aletra", "USUARIO/CONTRASEÑA INCORRECTA", "cerrar");
            }
        }

        
    }
}

