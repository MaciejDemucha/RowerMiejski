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
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxName.Text;
            String password = textBoxPassword.Text;

            _controller.login(username, password);
           

            this.Hide();
            var form = new WidokGlownyUzytkownik(_controller.getConnection());
            form.ShowDialog();
        }
    }
}
