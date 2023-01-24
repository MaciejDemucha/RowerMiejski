using RowerMiejski.Controllers;
using RowerMiejski.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RowerMiejski.Views
{
    public partial class MojeUsterki : Form
    {
        private readonly ViewController _controller;
        private readonly EmployeeController _employeeController;

        public MojeUsterki(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
            _employeeController = new EmployeeController(connection);
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            var dataTable = _controller.getListaMoichUsterek();
            mojeUsterkiDataGridView.DataSource = dataTable;
            mojeUsterkiDataGridView.ReadOnly = true;
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            var id = mojeUsterkiDataGridView.SelectedRows[0].Cells[0].Value;

            if (id != null)
            {
                _employeeController.usunUsterke((int)id);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Wybierz usterke!");
            }
        }
    }
}
