using RowerMiejski.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RowerMiejski.Views
{
    public partial class TypyRowerow : Form
    {
        private readonly ViewController _viewController;
        private readonly EmployeeController _employeeController;

        public TypyRowerow(SqlConnection connection)
        {
            InitializeComponent();
            _viewController = new ViewController(connection);
            _employeeController = new EmployeeController(connection);
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            var dataTable = _viewController.getTypy();
            typyRowerowDataGridView.DataSource = dataTable;
        }

        private void typyRowerowCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = typyRowerowDataGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = typyRowerowDataGridView.Rows[selectedrowindex];
            int typRoweruId = Convert.ToInt32(selectedRow.Cells[0].Value);

            DataGridViewCell selectedCell = typyRowerowDataGridView.CurrentCell;
            _employeeController.modyfikujTypRoweru(selectedCell, typRoweruId);
            RefreshDataGrid();
        }
    }
}
