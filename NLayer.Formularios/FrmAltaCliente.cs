using NLayer.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayer.Formularios
{
    public partial class FrmAltaCliente : Form
    {
        private ClienteServicio _clienteServicio; 
        public FrmAltaCliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio(); 
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string mail = txtMail.Text;
            string telefono = txtTelefono.Text;
            string direccion = txtDireccion.Text;
            DateTime fechaNacimiento = dtpFechaNac.Value;

            try
            {
                int retorno = _clienteServicio.InsertarCliente(dni, nombre, apellido, direccion, mail, telefono, fechaNacimiento);

                MessageBox.Show("Cliente se agrego con exito. Cliente ID: " + retorno);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error ->" + ex.Message);
            }

        }
    }
}
