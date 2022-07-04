using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaContacto(new Contacto
            {
                Nombre = "Héctor Pérez",
                Direccion = "Avenida X #2",
                Telefono = "(987) 3232323"
            });
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
