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
    public partial class WidokGlownyPracownik : Form
    {
        private readonly EmployeeController _controller;
        public WidokGlownyPracownik(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new EmployeeController(connection);
        }

        private void buttonKlienci_Click(object sender, EventArgs e)
        {
            var form = new Uzytkownicy(_controller.getConnection());
            form.ShowDialog();
        }

        private void buttonStacje_Click(object sender, EventArgs e)
        {
            var form = new ListaStacji(_controller.getConnection());
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
            form.ShowDialog();
        }
    }
}
