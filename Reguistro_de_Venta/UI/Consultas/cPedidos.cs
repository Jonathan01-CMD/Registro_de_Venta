using Reguistro_de_Venta.BLL;
using Reguistro_de_Venta.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reguistro_de_Venta.UI.Consultas
{
    public partial class cPedidos : Form
    {
        public cPedidos()
        {
            InitializeComponent();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Pedidos>();

            if (!string.IsNullOrEmpty(DescripcionTextBox.Text))
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = PedidosBLL.GetList(e => e.NombreCliente.Contains(DescripcionTextBox.Text));
                        break;

                    case 1:
                        listado = PedidosBLL.GetList(e => e.DireccionCliente.Contains(DescripcionTextBox.Text));
                        break;

                }
            }
            else
            {
                listado = PedidosBLL.GetList(c => true);
            }

            if (FiltroCheckBox.Checked == true)
            {
                listado = PedidosBLL.GetList(e => e.FechaEntrega.Date >= DesdeDateTimePicker.Value.Date && e.FechaEntrega.Date <= HastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
                listado = PedidosBLL.GetList(e => e.Pedido == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
                listado = PedidosBLL.GetList(e => e.Pedido == false);
            }

            DataGridView.DataSource = null;
            DataGridView.DataSource = listado;
        }
    }
}
