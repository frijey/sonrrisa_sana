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
            tool.achicar(btncitas);
        }

        private void btncitas_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandar(btncitas);
            Form f = new citas();
            f.ShowDialog();
        }

        private void btnpacientes_MouseDown(object sender, MouseEventArgs e)
        {
            tool.achicar(btnpacientes);
        }

        private void btnpacientes_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandar(btnpacientes);
            Form f = new pacientes();
            f.ShowDialog();
        }

        private void btnnuevo_MouseDown(object sender, MouseEventArgs e)
        {
            tool.achicar(btnnuevo);
        }

        private void btnnuevo_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandar(btnnuevo);
            Form f = new nuevo();
            f.ShowDialog();
        }

    }
}
