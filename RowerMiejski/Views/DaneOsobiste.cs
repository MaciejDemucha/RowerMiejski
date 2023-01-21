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
        private Uzytkownik _user;
        private string oldUsername;
        public DaneOsobiste(SqlConnection connection, Uzytkownik user)
        {
            InitializeComponent();
            _user = user;
            setTextboxes();
            oldUsername = textBoxUsername.Text;
            _controller = new UserController(connection);
        }

        public void setTextboxes()
        {
            textBoxUsername.Text = _user.Nazwa;
            textBoxName.Text = _user.Imie;
            textBoxSurname.Text = _user.Nazwisko;
            textBoxPhone.Text = _user.Telefon.ToString();
            textBoxEmail.Text = _user.Email;
            textBoxDate.Text = _user.DataUrodzenia.ToString();
        }

        public void saveChanges()
        {
             _user.Nazwa = textBoxUsername.Text;
             _user.Imie = textBoxName.Text;
             _user.Nazwisko = textBoxSurname.Text;
             _user.Telefon = Int32.Parse(textBoxPhone.Text);
             _user.Email = textBoxEmail.Text;
             _user.DataUrodzenia = DateTime.Parse(textBoxDate.Text);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            saveChanges();
            _controller.UpdateUzytkownik(_user, oldUsername);
            oldUsername = textBoxUsername.Text;
            const string message = "Pomyślnie zmieniono dane!";
            const string caption = "Zmiana danych";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
