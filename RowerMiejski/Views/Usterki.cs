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
        private readonly ViewController _controller;
        private readonly EmployeeController _employeeController;
        public Usterki(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
            _employeeController = new EmployeeController(connection);
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var dataTable = _controller.getListaUsterek();
            usterkiDataGridView.DataSource = dataTable;
            usterkiDataGridView.ReadOnly = true;
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            var id = usterkiDataGridView.SelectedRows[0].Cells[0].Value;

            if(id != null)
            {
                _employeeController.zweryfikujUsterke((int)id);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Wybierz usterke!");
            }
        }

        private void buttonMoje_Click(object sender, EventArgs e)
        {
            var form = new MojeUsterki(_controller.getConnection());
            form.ShowDialog();
        }
    }
}

