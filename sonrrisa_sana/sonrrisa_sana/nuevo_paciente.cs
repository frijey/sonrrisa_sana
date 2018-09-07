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
    public partial class nuevo_paciente : Form
    {
        tools tool = new tools();
        string RutaFoto = "C:\\sonrrisa_sana\\fotos\\pacientes\\default.jpg";

        public nuevo_paciente()
        {
            InitializeComponent();
        }

        private void nuevo_paciente_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncita_MouseDown(object sender, MouseEventArgs e)
        {
            tool.achicarp(btncita);
        }

        private void btncita_MouseUp(object sender, MouseEventArgs e)
        {
            tool.agrandarp(btncita);
            Form f = new nueva_cita();
            f.ShowDialog();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        void Guardar()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        void Eliminar()
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            NuevoPaciente();
        }

        void NuevoPaciente()
        {

        }

        private void ptbfoto_Click(object sender, EventArgs e)
        {
            tool.SeleccionarFoto(ptbfoto, RutaFoto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TomarFoto();
        }

        void TomarFoto()
        {
            tool.MensajeNormal("Esta función estará disponible próximamente", "Aviso");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TomarFoto();
        }

        private void dtfechanac_ValueChanged(object sender, EventArgs e)
        {
            txtedad.Text = tool.CalcularEdad(dtfechanac.Value);
        }

    }
}
