using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string dni = txtdni.Text;
            string nombre = txtnombre.Text;
            string apellido = txtapellido.Text;
            string direccion = txtdireccion.Text;
            string telefono = txttelefono.Text;
            string email = txtemail.Text;
            string date = dtpfn.Text;
            dgvUsuarios.Rows.Add("", dni, nombre, apellido, direccion, telefono, email,date);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
