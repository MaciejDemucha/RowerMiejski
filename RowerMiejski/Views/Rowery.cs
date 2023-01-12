using RowerMiejski.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowerMiejski.Views
{
    public partial class Rowery : Form
    {
        private readonly ViewController _controller;
        private readonly int _id;
        public Rowery(SqlConnection connection, int id)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
            _id = id;
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var dataTable = _controller.getListaRowerow(_id);
            dataGridViewRowery.DataSource = dataTable;
        }
    }
}
