using CRUD_WinForms.Models;

namespace CRUD_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarUsuarios();
        }

        userRepository connection = new();

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new();

            bool canParse = int.TryParse(TxtDNI.Text, out int _);
            if (!canParse || TxtDNI.Text.Length != 8) 
            {
                MessageBox.Show("El DNI no cumple el formato");
                return;
            };

            if (TxtNombre.Text.Length == 0 || TxtApellido.Text.Length == 0)
            {
                MessageBox.Show("No se permiten espacios en blanco");
                return;
            }

            canParse = int.TryParse(TxtTelefono.Text, out int _);
            if (!canParse || TxtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El telefono no cumple el formato");
                return;
            }


            nuevoUsuario.Dni = int.Parse(TxtDNI.Text);
            nuevoUsuario.Nombre = TxtNombre.Text;
            nuevoUsuario.Apellido = TxtApellido.Text;
            nuevoUsuario.FechaNacimiento = DateNacimiento.Value.Date;
            nuevoUsuario.NumeroTelefono = int.Parse(TxtTelefono.Text);

            connection.Create(nuevoUsuario);
            MostrarUsuarios();
            LimpiarDatos();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new();

            bool canParse = int.TryParse(TxtDNI.Text, out int _);
            if (!canParse || TxtDNI.Text.Length != 8)
            {
                MessageBox.Show("El DNI no cumple el formato");
                return;
            };

            if (TxtNombre.Text.Length == 0 || TxtApellido.Text.Length == 0)
            {
                MessageBox.Show("No se permiten espacios en blanco");
                return;
            }

            canParse = int.TryParse(TxtTelefono.Text, out int _);
            if (!canParse || TxtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El telefono no cumple el formato");
                return;
            }


            nuevoUsuario.Dni = int.Parse(TxtDNI.Text);
            nuevoUsuario.Nombre = TxtNombre.Text;
            nuevoUsuario.Apellido = TxtApellido.Text;
            nuevoUsuario.FechaNacimiento = DateNacimiento.Value.Date;
            nuevoUsuario.NumeroTelefono = int.Parse(TxtTelefono.Text);

            var canUpdate = connection.Update(nuevoUsuario);
            if(canUpdate == null)
            {
                MessageBox.Show("Ha ingresado un dni que no se encuentra en la base de datos");
                return;
            }
            MostrarUsuarios();
            LimpiarDatos();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            bool canParse = int.TryParse(TxtDNIEliminar.Text, out int _);
            if (!canParse || TxtDNIEliminar.Text.Length != 8)
            {
                MessageBox.Show("El DNI no cumple el formato");
                return;
            };

            int dniEliminar = int.Parse(TxtDNIEliminar.Text);
            Usuario usuario = connection.Read().Where(x => x.Dni == dniEliminar).First();
            connection.Delete(usuario);
            MostrarUsuarios();
            LimpiarDatos();
        }

        public void MostrarUsuarios()
        {
            List<Usuario> listaUsuarios = connection.Read();
            DGVUsuarios.DataSource = null;
            DGVUsuarios.DataSource = listaUsuarios;
        }

        public void LimpiarDatos()
        {
            TxtDNI.Text = string.Empty;
            TxtNombre.Text = string.Empty;
            TxtApellido.Text = string.Empty;
            DateNacimiento.Value = DateTime.Now;
            TxtTelefono.Text = string.Empty;
            TxtDNIEliminar.Text = string.Empty;
        }

        

    }
}