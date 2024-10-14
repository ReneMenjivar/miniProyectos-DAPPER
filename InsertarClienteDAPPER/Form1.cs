using AccesoDATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
