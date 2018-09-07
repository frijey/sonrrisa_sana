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
        tools tool = new tools();

        public menu_principal()
        {
            InitializeComponent();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            tool.achicarg(btncitas);
        }

        private void btncitas_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandarg(btncitas);
            Form f = new lista_de_citas();
            f.ShowDialog();
        }

        private void btnpacientes_MouseDown(object sender, MouseEventArgs e)
        {
            tool.achicarg(btnpacientes);
        }

        private void btnpacientes_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandarg(btnpacientes);
            Form f = new lista_de_pacientes();
            f.ShowDialog();
        }

        private void btnnuevo_MouseDown(object sender, MouseEventArgs e)
        {
            tool.achicarg(btnnuevo);
        }

        private void btnnuevo_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandarg(btnnuevo);
            Form f = new nuevo_paciente();
            f.ShowDialog();
        }

    }
}
