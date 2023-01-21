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
using System.Windows.Forms.VisualStyles;

namespace RowerMiejski.Views
{
    public partial class DanePracownik : Form
    {
        private readonly EmployeeController _controller;
        private Uzytkownik _user;
        String oldUsername;

        public DanePracownik(SqlConnection connection, Uzytkownik user)
        {
            InitializeComponent();
            _controller = new EmployeeController(connection);
            _user = user;
            setTextboxes();
            oldUsername = textBoxNazwa.Text;
        }
        public void setTextboxes()
        {
            textBoxNazwa.Text = _user.Nazwa;
            textBoxImie.Text = _user.Imie;
            textBoxNazwisko.Text = _user.Nazwisko;
        }
        public void saveChanges()
        {
            _user.Nazwa = textBoxNazwa.Text;
            _user.Imie = textBoxImie.Text;
            _user.Nazwisko = textBoxNazwisko.Text;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            saveChanges();
            _controller.UpdateEmployee(_user, oldUsername);
            oldUsername = textBoxNazwa.Text;
            const string message = "Pomyślnie zmieniono dane!";
            const string caption = "Zmiana danych";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
