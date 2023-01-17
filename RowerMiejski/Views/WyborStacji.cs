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
        private List<int> idList = new List<int>();
        private int idStacji;
        public int stacja
        {
            get { return idStacji; }
        }
        public WyborStacji(SqlConnection connection)
        {
            InitializeComponent();
            _controller = new ViewController(connection);

            setComboBox();
            buttonChoose.DialogResult = DialogResult.OK;
        }

        private void setComboBox()
        {
            var dataTable = _controller.getListaStacji();
            int size = dataTable.Rows.Count;
            for(int i = 0; i < size; i++)
            {
                string street = dataTable.Rows[i]["Ulica"].ToString();
                int id = Int32.Parse(dataTable.Rows[i]["Id"].ToString());
                idList.Add(id);
                comboBoxStacje.Items.Add(street);
            }
           
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            int chosenStation = comboBoxStacje.SelectedIndex;
            idStacji = idList.ElementAt(chosenStation);
            this.Close();

        }
    }
}
