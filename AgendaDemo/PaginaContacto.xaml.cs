﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AgendaDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaContacto : ContentPage
    {
        public PaginaContacto(Contacto contacto)
        {
            InitializeComponent();
            BackgroundColor = Color.FromRgb(48, 63, 159);
            BindingContext = contacto;
        }
    }
}
