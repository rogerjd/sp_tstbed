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
    public partial class frmProductVerification : Form
    {
        public frmProductVerification()
        {
            InitializeComponent();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {

        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {

        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Enter)
            {
                //textBox2.Focus();
                //OK   SelectNextControl(textBox1, true, true, false, false);
                //ok: SendKeys.Send("{TAB}");
            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = (textBox1.Text != "") && (textBox2.Text != "");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "095640";
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
