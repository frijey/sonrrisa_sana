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
    public partial class menu_principal : Form
    {
        int desplazamientoHor = 10;
        int desplazamientoVer = 5;

        public menu_principal()
        {
            InitializeComponent();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            achicar(btncitas);
        }

        private void btncitas_MouseUp(object sender, MouseEventArgs e)
        {
            agrandar(btncitas);
            Form f = new citas();
            f.ShowDialog();
        }

        private void btnpacientes_MouseDown(object sender, MouseEventArgs e)
        {
            achicar(btnpacientes);
        }

        private void btnpacientes_MouseUp(object sender, MouseEventArgs e)
        {
            agrandar(btnpacientes);
            Form f = new pacientes();
            f.ShowDialog();
        }

        private void btnnuevo_MouseDown(object sender, MouseEventArgs e)
        {
            achicar(btnnuevo);
        }

        private void btnnuevo_MouseUp(object sender, MouseEventArgs e)
        {
            agrandar(btnnuevo);
            Form f = new nuevo();
            f.ShowDialog();
        }

        void achicar (Control boton)
        {
            boton.Size = new System.Drawing.Size(360, 104);
            boton.Location = new Point(boton.Location.X + desplazamientoHor, boton.Location.Y + desplazamientoVer);
        }

        void agrandar (Control boton)
        {
            boton.Size = new System.Drawing.Size(400, 116);
            boton.Location = new Point(boton.Location.X - desplazamientoHor, boton.Location.Y - desplazamientoVer);
        }

    }
}
