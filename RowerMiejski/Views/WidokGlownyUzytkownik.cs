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
    public partial class WidokGlownyUzytkownik : Form
    {
        int h, m, s;
        System.Timers.Timer timer;
        private readonly UserController _controller; 
        private readonly Uzytkownik _user;
        public int? idWybranegoRoweru;
        public WidokGlownyUzytkownik(SqlConnection connection)
        {
            InitializeComponent();         
            _controller = new UserController(connection);
            _user = new Uzytkownik(/*_controller.GetUzytkownikId(_username),*/ _controller.getUsername(), _controller.getName(), _controller.getSurname(), _controller.getPhone(), _controller.getEmail(), _controller.getBirthDate(), _controller.getBalans());
            setBalanceLabel();

        }

        public void setBalanceLabel()
        {
            labelBalance.Text = _controller.getBalans() + " zł";
            String rentedBike = _controller.getWypozyczonyRower();
            if (rentedBike == "")
                labelBike.Text = "Brak";
            else
                labelBike.Text = rentedBike;
            labelPrice.Text = _controller.getKosztWypozyczenia().ToString();
        }

        private void buttonKonto_Click(object sender, EventArgs e)
        {
            var form = new DaneOsobiste(_controller.getConnection(), _user);
            form.ShowDialog();
        }

        private void buttonStacje_Click(object sender, EventArgs e)
        {
            var form = new ListaStacji(_controller.getConnection(), this);
            form.ShowDialog();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            var form = new Wypozyczenia(_controller.getConnection());
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            Double kwota;
            bool success = double.TryParse(textBoxMoney.Text, out kwota);
            if (success)
            {
                _controller.doladuj(kwota);
            }
            else
            {
                MessageBox.Show("Nieprawidłowa wartość");
            }
            setBalanceLabel();
        }

        private void buttonZwrocRower_Click(object sender, EventArgs e)
        {
            if(_controller.czyWypozyczony() == "")
            {
                MessageBox.Show("Nie wypożyczyłeś roweru");
            }
            else
            {
                using (var form = new WyborStacji(_controller.getConnection()))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        int stacjaId = form.stacja;
                        _controller.zwrocRower(stacjaId);
                        idWybranegoRoweru = null;
                        setBalanceLabel();
                        stopTimer();
                    }
                }
            }
           
        }

        private void WidokGlownyUzytkownik_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            setBalanceLabel();
        }

        public void startTimer()
        {
             timer.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelBike_Click(object sender, EventArgs e)
        {

        }

        public void stopTimer()
        {
            timer.Stop();
            h = m = s = 0;
            timeLabel.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s == 60)
                {
                    s = 0;
                    m++;
                }
                if (m == 60)
                {
                    m = 0;
                    h++;
                }
                timeLabel.Text = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            }));
        }
    }
}
