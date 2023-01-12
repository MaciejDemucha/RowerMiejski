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
    public partial class Uzytkownicy : Form
    {
        private readonly ViewController _controller;
        public Uzytkownicy(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
        }

        private void buttonWypozyczenia_Click(object sender, EventArgs e)
        {

        }
    }
}
