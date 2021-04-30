using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDCard_MOD11_2
{
    public partial class idCounter : Form
    {
        public idCounter()
        {
            InitializeComponent();
        }

        private void IdNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void IdNum_first17_TextChanged(object sender, EventArgs e)
        {
            if (((TextBox)sender).TextLength == 17)
            {
                int[] Q = new int[17] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
                int S = 0;
                for (int i = 0; i < 17; i++)
                {
                    S = int.Parse(((TextBox)sender).Text.Substring(i, 1)) * Q[i] + S;
                }
                int R = (12 - (S % 11)) % 11;
                string last = R == 10 ? "X" : R.ToString();
                idNum.Text = ((TextBox)sender).Text + last;
            }
        }
    }
}
