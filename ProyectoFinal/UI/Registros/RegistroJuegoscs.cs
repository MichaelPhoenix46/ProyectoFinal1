using ProyectoFinal.BLL;
using ProyectoFinal.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroJuegoscs : Form
    {
        public RegistroJuegoscs()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            VideoJuegoIdnumericUpDown.Value = 0;
            TitulotextBox.Text = string.Empty;
            DescripciontextBox.Text = string.Empty;
            LanzamientodateTimePicker.Value = DateTime.Now;
            PlataformatextBox.Text = string.Empty;
            GenerotextBox.Text = string.Empty;
            DesarrolladorestextBox.Text = string.Empty;
            EjemplaresnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;

        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            VideoJuego videoJuego = repositorio.Buscar((int)VideoJuegoIdnumericUpDown.Value);
            return (videoJuego != null);
        }


        public void LlenarCampos(VideoJuego videoJuego)
        {
            TitulotextBox.Text = videoJuego.Titulo;
            FechadateTimePicker.Value = videoJuego.FechaRegistro;
            PlataformatextBox.Text = videoJuego.Plataforma;
            LanzamientodateTimePicker.Value = videoJuego.Lanzamiento;
            DescripciontextBox.Text = videoJuego.Descripcion;
            PlataformatextBox.Text = videoJuego.Plataforma;
            GenerotextBox.Text = videoJuego.Genero;
            DesarrolladorestextBox.Text = videoJuego.Desarrolladores;
            EjemplaresnumericUpDown.Value = videoJuego.CantidadEjemplares;

        }

        private VideoJuego LlenaClase()
        {
            VideoJuego videoJuego = new VideoJuego();
            videoJuego.VideoJuegoId = Convert.ToInt32(VideoJuegoIdnumericUpDown.Value);
            videoJuego.Nombre = NombretextBox.Text;
            videoJuego.FechaRegistro = FechadateTimePicker.Value;
            videoJuego.Sexo = SexocomboBox.Text;
            videoJuego.Telefono = TelefonotextBox.Text;
            videoJuego.Direccion = DirecciontextBox.Text;
            return ;
        }

        private bool Validar()
        {

            bool paso = true;
            if (string.IsNullOrWhiteSpace(NombretextBox.Text) || string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                videoJuegoserrorProvider.SetError(NombretextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CedulatextBox.Text) || string.IsNullOrWhiteSpace(CedulatextBox.Text))
            {
                videoJuegoserrorProvider.SetError(CedulatextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text) || string.IsNullOrWhiteSpace(CedulatextBox.Text))
            {
                videoJuegoserrorProvider.SetError(DirecciontextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(SexocomboBox.Text) || string.IsNullOrWhiteSpace(SexocomboBox.Text))
            {
                videoJuegoserrorProvider.SetError(SexocomboBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonotextBox.Text) || string.IsNullOrWhiteSpace(TelefonotextBox.Text))
            {
                videoJuegoserrorProvider.SetError(TelefonotextBox, "Campo Vacio");
                paso = false;
            }
            if (NombretextBox.Text.Contains("!") || NombretextBox.Text.Contains("#") || NombretextBox.Text.Contains("$") || NombretextBox.Text.Contains("%") || NombretextBox.Text.Contains("&") || NombretextBox.Text.Contains("/") || NombretextBox.Text.Contains("("))
            {
                videoJuegoserrorProvider.SetError(TelefonotextBox, "Campo Vacio");
                paso = false;
            }


            return paso;
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
