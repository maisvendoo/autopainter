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
        private CDBaccess db;
        
        public main()
        {
            InitializeComponent();

            // DB object creation and connection
            db = new CDBaccess();

            int err = db.open("E:", "yatu.mdb", "yatu");

            if (err == -1)
            {
                MessageBox.Show("DB opening error");
            }
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

            TColorsData[] colors_data = new TColorsData[0];

            db.get_colors_data(query_data, ref colors_data);

            // Clean all rows in table
            Colors.Rows.Clear();

            // Fill table by data from query results
            for (int i = 0; i < colors_data.GetLength(0); i++)
            {
                Colors.Rows.Add(colors_data[i].RefColor,
                                colors_data[i].Manufacturer,
                                colors_data[i].ColorCode,
                                colors_data[i].ColorName,
                                colors_data[i].StockCode);
            }           
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.close();
        }
    }
}