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
    public partial class WyborStacji : Form
    {
        private readonly ViewController _controller;
        public WyborStacji(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new ViewController(connection);

            setComboBox();
        }

        private void setComboBox()
        {
            var dataTable = _controller.getListaStacji();
            int size = dataTable.Rows.Count;
            for(int i = 0; i < size; i++)
            {
                string hutt = dataTable.Rows[i]["Ulica"].ToString();
                comboBoxStacje.Items.Add(hutt);
            }
           
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
