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
        private readonly ViewController _viewController;
        private readonly UserController _userController;
        private readonly int _id;
        public WidokGlownyUzytkownik parent;
        public Rowery(SqlConnection connection, int id, WidokGlownyUzytkownik Parent)
        {
            InitializeComponent();
            _viewController = new ViewController(connection);
            _userController = new UserController(connection);
            _id = id;
            parent = Parent;
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            var dataTable = _viewController.getListaRowerow(_id);
            dataGridViewRowery.DataSource = dataTable;
        }

        private void buttonWypozycz_Click(object sender, EventArgs e)
        {
            var id = dataGridViewRowery.SelectedRows[0].Cells[0].Value;
            if (id != null)
            {
                _userController.wypozyczRower((int)id);
                parent.idWybranegoRoweru = (int)id;
                parent.startTimer();
                RefreshDataGrid();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wybierz rower");
            }
        }

        private void buttonUsterka_Click(object sender, EventArgs e)
        {
            var id = dataGridViewRowery.SelectedRows[0].Cells[0].Value;
            if (id != null)
            {
                _userController.zglosUsterke((int)id);
                RefreshDataGrid();
            }
            else
            {
                MessageBox.Show("Wybierz rower");
            }
        }
    }
}
