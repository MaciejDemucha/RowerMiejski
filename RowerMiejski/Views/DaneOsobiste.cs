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
    public partial class DaneOsobiste : Form
    {
        private readonly UserController _controller;
        private readonly Uzytkownik _user;
        public DaneOsobiste(SqlConnection connection, Uzytkownik user)
        {
            InitializeComponent();
            _user = user;
            _controller = new UserController(connection);

            textBoxUsername.Text = user.Nazwa;
            textBoxName.Text = user.Imie;
            textBoxSurname.Text = user.Nazwisko;
            textBoxPhone.Text = user.Telefon.ToString();
            textBoxEmail.Text = user.Email;
            textBoxDate.Text = user.DataUrodzenia.ToString();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
           
        }
    }
}
