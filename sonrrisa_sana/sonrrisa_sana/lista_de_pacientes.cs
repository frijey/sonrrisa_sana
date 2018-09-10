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
    public partial class lista_de_pacientes : Form
    {
        //Acceso a la clase de Herramientas
        tools tool = new tools();

        //Para diferenciar entre si se está seleccionando el paciente o si se está buscando...
        public static bool Seleccionando = false;
        
        public lista_de_pacientes()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Form f = new info_paciente();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else { }
        }

        private void lista_de_pacientes_Load(object sender, EventArgs e)
        {

        }

        void MostrarPacienteSeleccionado()
        {
            try
            {
                menu_principal.PacienteSeleccionado = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
                menu_principal.Realizó = true;
                info_paciente.CargarPaciente = true;
                Form f = new info_paciente();
                f.ShowDialog();
            }
            catch
            {
                tool.MensajeNormal("Seleccione un paciente o presione [SALIR] ", "Selección de Paciente");
            }
        }

        void SeleccionarPaciente()
        {
            try
            {
                menu_principal.PacienteSeleccionado = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
                menu_principal.Realizó = true;
                this.Close();
            }
            catch
            {
                tool.MensajeNormal("Seleccione un paciente o presione [SALIR] ", "Selección de Paciente");
            }            
        }
        
    }
}
