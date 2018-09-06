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
    public partial class nuevo : Form
    {
        tools tool = new tools();

        public nuevo()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncita_MouseDown(object sender, MouseEventArgs e)
        {
            tool.achicar(btncita);
        }

        private void btncita_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandar(btncita);
            Form f = new nueva_cita();
            f.ShowDialog();
        }
    }
}
