﻿using DirectorioTecNMCelaya.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DirectorioTecNMCelaya
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            try
            {
                InitializeComponent();

            }
            catch(Exception ex)
            {

            }
            //EnviarCorreo("luis.beltran@itcelaya.edu.mx", "saludo", "holis");
        }

    }
}
