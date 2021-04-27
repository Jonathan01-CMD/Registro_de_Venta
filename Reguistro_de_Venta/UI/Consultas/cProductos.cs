using Reguistro_de_Venta.BLL;
using Reguistro_de_Venta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reguistro_de_Venta.UI.Consultas
{
    public partial class cProductos : Form
    {
        public cProductos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Productos>();

            if (!string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = ProductosBLL.GetList(e => e.NombreProducto.Contains(DescripcionTextBox.Text));
                        break;

                    case 1:
                        listado = ProductosBLL.GetList(e => e.MarcaProducto.Contains(DescripcionTextBox.Text));
                        break;

                }
            }
            else
            {
                listado = ProductosBLL.GetList(c => true);
            }
            DataGridView.DataSource = null;
            DataGridView.DataSource = listado;
        }
    }
}
