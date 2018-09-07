using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sonrrisa_sana
{
    class tools
    {
        //Variables Necesarias Para el Agrandamiento y Achicamiento
        int desplazamientoHor = 10;
        int desplazamientoVer = 5;
        double multiplicador1 = 22.2;
        double multiplicador2 = 1.115;

        public void achicarg(Control boton)
        {
            boton.Size = new System.Drawing.Size(360, 104);
            boton.Location = new Point(boton.Location.X + desplazamientoHor, boton.Location.Y + desplazamientoVer);
        }

        public void agrandarg(Control boton)
        {
            boton.Size = new System.Drawing.Size(400, 116);
            boton.Location = new Point(boton.Location.X - desplazamientoHor, boton.Location.Y - desplazamientoVer);
        }

        public void achicarp(Control boton)
        {
            boton.Size = new System.Drawing.Size(220, 80);
            boton.Location = new Point(boton.Location.X + desplazamientoHor, boton.Location.Y + desplazamientoVer);
        }

        public void agrandarp(Control boton)
        {
            boton.Size = new System.Drawing.Size(245, 91);
            boton.Location = new Point(boton.Location.X - desplazamientoHor, boton.Location.Y - desplazamientoVer);
        }

        public string CalcularEdad(DateTime fechaNacimiento)
        {
            try
            {
                if (fechaNacimiento.Month <= DateTime.Now.Month)
                {
                    if (fechaNacimiento.Month == DateTime.Now.Month)
                    {
                        if (fechaNacimiento.Day <= DateTime.Now.Day)
                        {
                            return (DateTime.Now.Year - fechaNacimiento.Year).ToString();
                        }
                        else
                        {
                            return ((DateTime.Now.Year - fechaNacimiento.Year) - (1)).ToString();
                        }                        
                    }
                    else{
                        return (DateTime.Now.Year - fechaNacimiento.Year).ToString();
                    }                    
                }
                else
                {
                    return ((DateTime.Now.Year - fechaNacimiento.Year) - (1)).ToString();
                }
            }
            catch (Exception)
            {
                return "0";
            }
        }

        public void CargarFoto(string RutaFoto, PictureBox ptbFoto)
        {
            try
            {
                Bitmap Foto = new Bitmap(RutaFoto);
                ptbFoto.Image = (Image)Foto;
            }
            catch (Exception)
            {

            }
        }

        public string SeleccionarFoto(PictureBox ptbfoto, string rutaFotoActual)
        {
            try
            {
                OpenFileDialog CargarFoto = new OpenFileDialog();
                CargarFoto.Filter = "Archivos de Imagen|*.jpg;*.png";
                CargarFoto.InitialDirectory = "C:\\sonrrisa_sana\\fotos\\pacientes";
                if (CargarFoto.ShowDialog() == DialogResult.OK)
                {
                    String Ruta = CargarFoto.FileName;
                    ptbfoto.SizeMode = PictureBoxSizeMode.Zoom;
                    Bitmap Foto = new Bitmap(Ruta);
                    ptbfoto.Image = (Image)Foto;
                    return Ruta;
                }
                else
                {
                    return rutaFotoActual;
                }
            }
            catch (Exception)
            {
                return "Error";
            }
        }

        public void MensajeNormal(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
