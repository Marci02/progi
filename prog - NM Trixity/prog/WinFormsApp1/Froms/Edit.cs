using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.Froms
{
    public partial class Edit : Form
    {
        private DataGridView gridView;
        private int rowIndex;
        public Edit(DataGridView gridView, int rowIndex)
        {
            InitializeComponent();
            this.gridView = gridView;
            this.rowIndex = rowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var r = gridView.Rows[rowIndex];
            r.Cells[0].Value = kerNev.Text;
            r.Cells[1].Value = vezNev.Text;
            r.Cells[2].Value = kor.Text;
            r.Cells[3].Value = szulDatum.Text;

            this.Close();
        }
    }
}
