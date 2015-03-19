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
        private int colors_found = 0;
        private int formulas_found = 0;
        private TColorsData[] colors_data;
        private TFormulasData[] formulas_data;
        
        public main()
        {
            InitializeComponent();

            foundColors.Text = "Colors - " + String.Format("{0}", colors_found) + 
                               " record(s) found.";

            foundFormulas.Text = "Formulas - " + String.Format("{0}", formulas_found) +
                               " record(s) found.";

            for (int i = Colors.Rows.Count - 1; i > -1; i--)
                Colors.Rows[i].Selected = false;

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

        //-----------------------------------------------------------
        //  Find colors in DB
        //-----------------------------------------------------------
        private void butFind_Click(object sender, EventArgs e)
        {
            TQueryData query_data;

            // Get data from text fields
            query_data.Manufacturer = Manufactur.Text;
            query_data.ColorCode = CCode.Text;
            query_data.ColorName = CName.Text;

            colors_data = null;
            colors_data = new TColorsData[0];

            db.get_colors_data(query_data, ref colors_data);

            // Found colors count output
            colors_found = colors_data.GetLength(0);

            foundColors.Text = "Colors - " + String.Format("{0}", colors_found) +
                               " record(s) found.";

            // Clean all rows in table
            Colors.Rows.Clear();

            // Fill table by data from query results

            if (colors_data.GetLength(0) > 0)
            {
                for (int i = 0; i < colors_data.GetLength(0); i++)
                {
                    Colors.Rows.Add(colors_data[i].RefColor,
                                    colors_data[i].Manufacturer,
                                    colors_data[i].ColorCode,
                                    colors_data[i].ColorName,
                                    colors_data[i].StockCode);
                }
            }

            // Clear rows selection
            Colors.ClearSelection();
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.close();
        }

        // Actions by Colors row click
        private void Colors_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Select string
                Colors.Rows[e.RowIndex].Selected = true;

                formulas_data = null;
                formulas_data = new TFormulasData[0];

                db.get_formulas_data(colors_data[e.RowIndex], ref formulas_data);

                formulas_found = formulas_data.GetLength(0);

                foundFormulas.Text = "Formulas - " + String.Format("{0}", formulas_found) +
                               " record(s) found.";

                Formulas.Rows.Clear();

                if (formulas_data.GetLength(0) > 0)
                {
                    for (int i = 0; i < formulas_data.GetLength(0); i++)
                    {
                        Formulas.Rows.Add(formulas_data[i].RefColor,
                                          formulas_data[i].ColorCode,
                                          formulas_data[i].Brand,
                                          formulas_data[i].Coat,
                                          formulas_data[i].Variant,
                                          formulas_data[i].Model,
                                          formulas_data[i].Year,
                                          formulas_data[i].Source,
                                          formulas_data[i].CreatedDate,
                                          formulas_data[i].FormulaCode,
                                          formulas_data[i].StockCode,
                                          formulas_data[i].ColorIndex);
                    }
                }

                Formulas.ClearSelection();
            }
        }       
    }
}