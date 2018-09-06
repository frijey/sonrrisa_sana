using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sonrrisa_sana
{
    class tools
    {
        //Variables Necesarias Para el Agrandamiento y Achicamiento
        int desplazamientoHor = 10;
        int desplazamientoVer = 5;

        public void achicar(Control boton)
        {
            boton.Size = new System.Drawing.Size(360, 104);
            boton.Location = new Point(boton.Location.X + desplazamientoHor, boton.Location.Y + desplazamientoVer);
        }

        public void agrandar(Control boton)
        {
            boton.Size = new System.Drawing.Size(400, 116);
            boton.Location = new Point(boton.Location.X - desplazamientoHor, boton.Location.Y - desplazamientoVer);
        }

    }
}
