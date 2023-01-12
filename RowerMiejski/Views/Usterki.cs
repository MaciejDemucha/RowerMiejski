using RowerMiejski.Controllers;
using RowerMiejski.Models;
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
    public partial class Usterki : Form
    {
        private readonly Usterka _usterka;
        private readonly ViewController _controller;
        public Usterki(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var dataTable = _controller.getListaUsterek();
            usterkiDataGridView.DataSource = dataTable;
        }

    }
}

