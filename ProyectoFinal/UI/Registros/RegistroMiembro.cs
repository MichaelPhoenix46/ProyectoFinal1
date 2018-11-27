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
using ProyectoFinal.DAL;
using ProyectoFinal.BLL;

namespace ProyectoFinal.UI.Registros
{
    public partial class RegistroMiembro : Form
    {
        public RegistroMiembro()
        {
            InitializeComponent();
            LlenarSexocomboBox();
        }

        private void Limpiar()
        {
            MiembroidnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            CedulatextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            SexocomboBox.Text = string.Empty;
            TelefonotextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
        }

        private bool ExiteEnLaBaseDeDatos()
        {
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            Miembro miembro = repositorio.Buscar((int)MiembroidnumericUpDown.Value);
            return (miembro != null);
        }



        private void LlenarSexocomboBox()
        {
            SexocomboBox.Items.Clear();

            SexocomboBox.Items.Add("Masculino");
            SexocomboBox.Items.Add("Femenino");
            
        }

        public void LlenarCampos(Miembro miembro)
        {
            NombretextBox.Text = miembro.Nombre;
            FechadateTimePicker.Value = miembro.FechaRegistro;
            SexocomboBox.Text = miembro.Sexo;
            TelefonotextBox.Text = miembro.Telefono;
            DirecciontextBox.Text = miembro.Direccion;
            FechadateTimePicker.Value = miembro.FechaRegistro;
            CedulatextBox.Text = miembro.Cedula;

        }

        private Miembro LlenaClase()
        {
            Miembro miembro = new Miembro();
            miembro.MiembroId = Convert.ToInt32(MiembroidnumericUpDown.Value);
            miembro.Nombre = NombretextBox.Text;
            miembro.FechaRegistro = FechadateTimePicker.Value;
            miembro.Sexo = SexocomboBox.Text;
            miembro.Telefono = TelefonotextBox.Text;
            miembro.Direccion = DirecciontextBox.Text;
            miembro.FechaRegistro = FechadateTimePicker.Value;
            miembro.Cedula = CedulatextBox.Text;
            return miembro;
        }

        private bool Validar()
        {

            bool paso = true;
            if (string.IsNullOrWhiteSpace(NombretextBox.Text) || string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                MiembroerrorProvider.SetError(NombretextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CedulatextBox.Text) || string.IsNullOrWhiteSpace(CedulatextBox.Text))
            {
                MiembroerrorProvider.SetError(CedulatextBox, "Campo Vacio ");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text) || string.IsNullOrWhiteSpace(CedulatextBox.Text))
            {
                MiembroerrorProvider.SetError(DirecciontextBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(SexocomboBox.Text) || string.IsNullOrWhiteSpace(SexocomboBox.Text))
            {
                MiembroerrorProvider.SetError(SexocomboBox, "Campo Vacio");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(TelefonotextBox.Text) || string.IsNullOrWhiteSpace(TelefonotextBox.Text))
            {
                MiembroerrorProvider.SetError(TelefonotextBox, "Campo Vacio");
                paso = false;
            }
            if (NombretextBox.Text.Contains("!") || NombretextBox.Text.Contains("#") || NombretextBox.Text.Contains("$") || NombretextBox.Text.Contains("%") || NombretextBox.Text.Contains("&") || NombretextBox.Text.Contains("/") || NombretextBox.Text.Contains("("))
            {
                MiembroerrorProvider.SetError(TelefonotextBox, "Campo Vacio");
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
            
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            bool paso = false;
            Miembro miembro;
            if (!Validar())
                return;
            miembro = new Miembro();
            miembro = LlenaClase();
            if (MiembroidnumericUpDown.Value == 0)
            {

                paso = repositorio.Guardar(miembro);
            }
            else
            {
                if (!ExiteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No Se Puede Modificar No Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = repositorio.Modificar(miembro);
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
            LlenarSexocomboBox();
            
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            int id;
            int.TryParse(MiembroidnumericUpDown.Text, out id);
            if (!ExiteEnLaBaseDeDatos())
            {
                MiembroerrorProvider.SetError(MiembroidnumericUpDown, "Este Usuario No Exite");
                MiembroidnumericUpDown.Focus();
                return;
            }
            if (repositorio.Eliminar(id))
            {
                MessageBox.Show("Usuario Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
                MessageBox.Show("No se Pudo Eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LlenarSexocomboBox();
            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           
            RepositorioBase<Miembro> repositorio = new RepositorioBase<Miembro>();
            int id;
            Miembro miembro = new Miembro();

            int.TryParse(MiembroidnumericUpDown.Text, out id);
            miembro = repositorio.Buscar(id);

            if (miembro != null)
            {
                MessageBox.Show("Usuario Encontrado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LlenarCampos(miembro);
            }
            else
            {
                MessageBox.Show("Usuario no Exite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LlenarSexocomboBox();
            
        }
    }


}
