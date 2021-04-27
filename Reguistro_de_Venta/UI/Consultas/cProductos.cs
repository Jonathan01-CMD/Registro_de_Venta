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

            if (FiltroCheckBox.Checked == true)
            {
              //  listado = ProductosBLL.GetList(e => e.FechaCreacion.Date >= FechaDesdeDateTimePicker.Value.Date && e.FechaCreacion.Date <= FechaHastaDateTimePicker.Value.Date);
            }

            if (ActivoRadioButton.Checked == true)
            {
              //  listado = ProductosBLL.GetList(e => e.EsActivo == true);
            }

            if (InactivoRadioButton.Checked == true)
            {
               // listado = ProductosBLL.GetList(e => e.EsActivo == false);
            }

            DataGridView.DataSource = null;
            DataGridView.DataSource = listado;
        }
    }
}
