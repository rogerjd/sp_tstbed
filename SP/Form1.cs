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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProductVerificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductVerification frm = new frmProductVerification();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDGV frm = new frmDGV();
            frm.ShowDialog();
        }
    }
}
