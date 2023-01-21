using RowerMiejski.Controllers;
using System;
using System.Collections.Generic;
using RowerMiejski.Models;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowerMiejski.Views
{
    public partial class WidokGlownyPracownik : Form
    {
        private readonly EmployeeController _controller;
        private readonly Uzytkownik _user;
        private readonly WidokGlownyUzytkownik parent;
        public WidokGlownyPracownik(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new EmployeeController(connection);
            _user = new Uzytkownik(_controller.getUsername(), _controller.getName(), _controller.getSurnname(), 0, "", DateTime.Now, 0);
        }

        private void buttonKlienci_Click(object sender, EventArgs e)
        {
            var form = new Uzytkownicy(_controller.getConnection());
            form.ShowDialog();
        }

        private void buttonStacje_Click(object sender, EventArgs e)
        {
            var form = new ListaStacji(_controller.getConnection(), parent);
            form.getStacjeDataGridView().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            form.getStacjeDataGridView().ReadOnly = false;
            form.getStacjeDataGridView().Columns[0].ReadOnly = true;
            form.getStacjeDataGridView().Columns[4].ReadOnly = true;
            form.ShowDialog();
        }

        private void buttonUsterki_Click(object sender, EventArgs e)
        {
            var form = new Usterki(_controller.getConnection());
            form.ShowDialog();
        }

        private void buttonTypy_Click(object sender, EventArgs e)
        {
            var form = new TypyRowerow(_controller.getConnection());
            form.getTypyRowerowDataGridView().SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            form.getTypyRowerowDataGridView().ReadOnly = false;
            form.getTypyRowerowDataGridView().Columns[0].ReadOnly = true;
            form.ShowDialog();
        }

        private void buttonKonto_Click(object sender, EventArgs e)
        {
            var form = new DanePracownik(_controller.getConnection(), _user);
            form.ShowDialog();
        }
    }
}
