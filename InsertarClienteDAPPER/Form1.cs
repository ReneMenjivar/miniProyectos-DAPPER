using AccesoDATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertarClienteDAPPER
{
    public partial class Form1 : Form
    {
        RepositorioCliente clienteR = new RepositorioCliente();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = clienteR.ObtenerTodo();
            dgvClientes.DataSource = cliente;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Clientes CrearCliente()
        {
            var nuevo = new Clientes
            {
                CustomerID = txbClienteID.Text,
                CompanyName = txbCompanyName.Text,
                ContactName = txbContactName.Text,
                ContactTitle = txbContactTitle.Text,
                Address = txbAddress.Text,
            };
            return nuevo;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = CrearCliente();
            var insertado = clienteR.insertarCliente(nuevoCliente);
            MessageBox.Show($"{insertado} registros insertados");

        }
    }
}
