using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace autopainter
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Here must be functions for correct exit

            Application.Exit();
        }

        private void butFind_Click(object sender, EventArgs e)
        {
            TQueryData query_data;

            // Get data from text fields
            query_data.Manufacturer = Manufactur.Text;
            query_data.ColorCode = CCode.Text;
            query_data.ColorName = CName.Text;
        }
    }
}