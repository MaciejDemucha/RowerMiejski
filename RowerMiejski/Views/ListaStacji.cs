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
    public partial class ListaStacji : Form
    {
        private readonly Stacja _stacja;
        private readonly ViewController _controller;
        private readonly EmployeeController _employeeController;
        private WidokGlownyUzytkownik parent;
        public ListaStacji(SqlConnection connection, WidokGlownyUzytkownik Parent)
        {
            InitializeComponent();
            _controller = new ViewController(connection);
            _employeeController = new EmployeeController(connection);
            parent = Parent;
            RefreshDataGrid();
            stacjeDataGridView.CellValueChanged += new DataGridViewCellEventHandler(stacjaDataGridView_CellValueChanged);
        }
        private void stacjaDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = stacjeDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = stacjeDataGridView.Rows[selectedrowindex];
            int stacjaId = Convert.ToInt32(selectedRow.Cells[0].Value);

            DataGridViewCell selectedCell = stacjeDataGridView.CurrentCell;
            _employeeController.modyfikujDaneStacji(selectedCell, stacjaId);
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            var dataTable = _controller.getListaStacji();
            stacjeDataGridView.DataSource = dataTable;
        }

        private void buttonShowBikes_Click(object sender, EventArgs e)
        {
            var id = stacjeDataGridView.SelectedRows[0].Cells[0].Value;
            
            if (id != null)
            {
                var form = new Rowery(_controller.getConnection(), (int)id, this.parent);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz stację");
            }
            RefreshDataGrid();
        }
    }
}
