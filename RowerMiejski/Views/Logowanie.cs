using RowerMiejski.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowerMiejski.Views
{
    public partial class Logowanie : Form
    {
        private readonly LoginController _controller;
        public Logowanie()
        {
            InitializeComponent();
            _controller = new LoginController();
            textBoxPassword.PasswordChar = '*';
            buttonRegister.Click += buttonregister_Click;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxName.Text;
            String password = textBoxPassword.Text;
            var form = new Form();

            try
            {
                _controller.login(username, password);
            }
            catch
            {
                return;
            }
           
            this.Hide();
            if (checkBoxEmployee.CheckState == CheckState.Unchecked)
                form = new WidokGlownyUzytkownik(_controller.getConnection());
            else
                form = new WidokGlownyPracownik(_controller.getConnection());
            form.ShowDialog();
        }
        private void buttonregister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameReg.Text) || string.IsNullOrEmpty(textBoxPasswordReg.Text)
                || string.IsNullOrEmpty(textBoxPasswordRegRepeat.Text) || string.IsNullOrEmpty(textBoxClientName.Text)
                || string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxPhone.Text)
                || string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxDatebirth.Text))
            {
                MessageBox.Show("Wypełnij wszystkie wymagane pola!");
            }
            else
            {
                String username = textBoxNameReg.Text;
                String password = textBoxPasswordReg.Text;
                String passwordrepeat = textBoxPasswordRegRepeat.Text;
                String name = textBoxClientName.Text;
                String surname = textBoxSurname.Text;
                int phone = 0;

                if (textBoxPhone.TextLength != 9)
                {
                    MessageBox.Show("Niepoprawny format danych!");
                    return;
                }
                try
                {
                    phone = Convert.ToInt32(textBoxPhone.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Niepoprawny format danych!");
                    return;
                }
                String email = textBoxEmail.Text;
                DateTime datebirth;
                try
                {
                    var parsedDate = DateTime.Parse(textBoxDatebirth.Text);
                    datebirth = parsedDate;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Niepoprawny format danych!");
                    return;
                }
                double balance = 0;

                if (passwordrepeat != password)
                {
                    MessageBox.Show("Pole hasło musi mieć tą samą wartość, co pole powtórzone hasło!");
                }
                else
                {
                    _controller.register(username, password, name, surname, phone, email, datebirth, balance);
                }
            }
        }

        private void logowanie_closing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Czy napewno chcesz wyjść z aplikacji?", "Wyjście z programu", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    e.Cancel = false;
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
