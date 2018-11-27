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
            videoJuego.Titulo = TitulotextBox.Text;
            videoJuego.FechaRegistro = FechadateTimePicker.Value;
            videoJuego.Descripcion = DescripciontextBox.Text;
            videoJuego.Genero = GenerotextBox.Text;
            videoJuego.Desarrolladores = DesarrolladorestextBox.Text;
            videoJuego.Lanzamiento = LanzamientodateTimePicker.Value;
            videoJuego.Plataforma = PlataformatextBox.Text;
            return videoJuego;
        }

        private bool Validar()
        {

            bool paso = true;
            if (string.IsNullOrWhiteSpace(TitulotextBox.Text) || string.IsNullOrWhiteSpace(TitulotextBox.Text))
            {
                videoJuegoserrorProvider.SetError(TitulotextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DesarrolladorestextBox.Text) || string.IsNullOrWhiteSpace(DesarrolladorestextBox.Text))
            {
                videoJuegoserrorProvider.SetError(DesarrolladorestextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text) || string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                videoJuegoserrorProvider.SetError(DescripciontextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(PlataformatextBox.Text) || string.IsNullOrWhiteSpace(PlataformatextBox.Text))
            {
                videoJuegoserrorProvider.SetError(PlataformatextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(GenerotextBox.Text) || string.IsNullOrWhiteSpace(GenerotextBox.Text))
            {
                videoJuegoserrorProvider.SetError(GenerotextBox, "Campo Vacio");
                paso = false;
            }
            if (EjemplaresnumericUpDown.Value == 0)
            {
                videoJuegoserrorProvider.SetError(EjemplaresnumericUpDown, "Campo Vacio");
                paso = false;
            }
            if (TitulotextBox.Text.Contains("!") || TitulotextBox.Text.Contains("#") || TitulotextBox.Text.Contains("$") || TitulotextBox.Text.Contains("%") || TitulotextBox.Text.Contains("&") || TitulotextBox.Text.Contains("/") || TitulotextBox.Text.Contains("("))
            {
                videoJuegoserrorProvider.SetError(TitulotextBox, "Campo Vacio");
                paso = false;
            }


            return paso;
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            bool paso = false;
            VideoJuego videoJuego;
            if (!Validar())
                return;
            videoJuego = new VideoJuego();
            videoJuego = LlenaClase();
            if (VideoJuegoIdnumericUpDown.Value == 0)
            {

                paso = repositorio.Guardar(videoJuego);
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No Se Puede Modificar No Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(videoJuego);
            }
            if (paso)
            {
                MessageBox.Show("Guardado con Exito", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Se Puede Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            int id;
            int.TryParse(VideoJuegoIdnumericUpDown.Text, out id);
            if (!ExiteEnLaBaseDeDatos())
            {
                videoJuegoserrorProvider.SetError(VideoJuegoIdnumericUpDown, "Este Usuario No Exite");
                VideoJuegoIdnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Usuario Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se Pudo Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<VideoJuego> repositorio = new RepositorioBase<VideoJuego>();
            int id;
            VideoJuego videoJuego = new VideoJuego();

            int.TryParse(VideoJuegoIdnumericUpDown.Text, out id);
            videoJuego = repositorio.Buscar(id);

            if (videoJuego != null)
            {
                MessageBox.Show("Usuario Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampos(videoJuego);
            }
            else
            {
                MessageBox.Show("Usuario no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
    
}
