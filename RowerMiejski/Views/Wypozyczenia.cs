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
    public partial class Wypozyczenia : Form
    {
        private readonly Wypozyczenie _wypozyczenie;
        private readonly ViewController _controller;
        public Wypozyczenia(SqlConnection connection, int Id = -1)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
            RefreshDataGrid(Id);
            this.ShowDialog();
        }
        private void RefreshDataGrid(int Id = -1)
        {
            try
            {
                var dataTable = _controller.getHistoriaWypozyczen();
                dataGridViewHistoria.DataSource = dataTable;
            }
            catch (SqlException e)
            {
                var dataTable = _controller.getWypozyczeniaKlienta(Id);
                dataGridViewHistoria.DataSource = dataTable;
            }
        }
    }
}
