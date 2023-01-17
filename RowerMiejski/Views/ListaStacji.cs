﻿using RowerMiejski.Controllers;
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
    public partial class ListaStacji : Form
    {
        private readonly Stacja _stacja;
        private readonly ViewController _controller;
        public WidokGlownyUzytkownik parent;
        public ListaStacji(SqlConnection connection, WidokGlownyUzytkownik Parent)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
            parent = Parent;
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            var dataTable = _controller.getListaStacji();
            stacjeDataGridView.DataSource = dataTable;
        }

        private void buttonShowBikes_Click(object sender, EventArgs e)
        {
            var id = stacjeDataGridView.SelectedRows[0].Cells[0].Value;
            
            if (id != null)
            {
                var form = new Rowery(_controller.getConnection(), (int)id, this.parent);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz stację");
            }
        }
    }
}
