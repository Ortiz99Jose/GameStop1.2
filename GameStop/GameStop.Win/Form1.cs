using GameStop.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStop.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            listadeProductosBindingSource.DataSource = listadeProductos;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void productosBLBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
