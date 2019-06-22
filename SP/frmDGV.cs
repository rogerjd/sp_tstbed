using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SP
{
    public partial class frmDGV : Form
    {
        public frmDGV()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        DataTable dt = new DataTable();
        private void SortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Sort";

            dt.Columns.Add("Name");
            dt.Rows.Add("A");
            dt.Rows.Add("B");
            dt.Rows.Add("C");

            dataGridView1.DataSource = dt;

            button1.Click += SortShowValues;
        }

        private void SortShowValues(object sender, EventArgs e)
        {
            int indx = dataGridView1.CurrentCell.RowIndex;
            string val = (string)dataGridView1.Rows[indx].Cells[0].Value;
            string dtVal = dt.Rows[0][0].ToString();
            MessageBox.Show(indx.ToString() + " " + val + dtVal);
        }
    }
}
