using RowerMiejski.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowerMiejski.Views
{
    public partial class Uzytkownicy : Form
    {
        private readonly ViewController _viewController;
        public Uzytkownicy(SqlConnection connection)
        {
            InitializeComponent();
            _viewController = new ViewController(connection);
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var dataTable = _viewController.getKlienci();
            dataGridViewUsers.DataSource = dataTable;
        }

        private void buttonWypozyczenia_Click(object sender, EventArgs e)
        {

        }
    }
}
