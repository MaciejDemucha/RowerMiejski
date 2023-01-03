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
        private readonly StacjaController _controller;
        public ListaStacji()
        {
            InitializeComponent();
            _controller = new StacjaController();
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            var dataTable = _controller.GetStacje();
            stacjeDataGridView.DataSource = dataTable;
        }
    }
}
