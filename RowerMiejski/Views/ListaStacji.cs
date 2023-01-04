using RowerMiejski.Controllers;
using RowerMiejski.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowerMiejski.Views
{
    public partial class ListaStacji : Form
    {
        private readonly Stacja _stacja;
        private readonly ViewController _controller;
        public ListaStacji()
        {
            InitializeComponent();
            _controller = new ViewController();
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            var dataTable = _controller.getListaStacji();
            stacjeDataGridView.DataSource = dataTable;
        }
    }
}
