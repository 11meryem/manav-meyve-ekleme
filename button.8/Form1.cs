using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtmeyve_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            list.Items.Add(txtmeyve.Text);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            list.Items.Clear();
        }
    }
}
