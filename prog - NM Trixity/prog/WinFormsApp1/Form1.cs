using System.ComponentModel;
using System.Diagnostics;
using WinFormsApp1.Froms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private BindingList<Grid> grids = new();
        private int rowIndex;
        public Form1()
        {
            InitializeComponent();
            using StreamReader reader = new(path: "adatok.txt");
            while (!reader.EndOfStream)
                grids.Add(new(reader.ReadLine()));

            
            dataGridView2.DataSource = grids;
        }

        private void dataGridView2_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            var r = dataGridView2.Rows[rowIndex];
            kerNev.Text = r.Cells[0].Value.ToString();
            vezNev.Text = r.Cells[1].Value.ToString();
            kor.Text = r.Cells[2].Value.ToString();
            szuletesDatum.Text = r.Cells[3].Value.ToString();
        }

        // módosítás

        private void button1_Click(object sender, EventArgs e)
        {
            Edit edit = new(dataGridView2, rowIndex);
            edit.ShowDialog();
        }

        // törlés

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.RemoveAt(rowIndex);
        }

        // új
        private void button2_Click(object sender, EventArgs e)
        {
            var sor = "";

            if (newKerNev.Text == "" || newVezNev.Text == "" || newKor.Text == "" || newDatum.Text == "")
            {
                MessageBox.Show("Nincs értéke az egyik mezõnek!");
            }
            else
            {
                sor = $"{newKerNev.Text};{newVezNev.Text};{newKor.Text};{newDatum.Text}";
                grids.Add(new Grid(sor));
            }

        }

        // mentés

        private void Save_Click(object sender, EventArgs e)
        {
            using StreamWriter writer = new(path: "adatok.txt");
            foreach (var i in grids)
                writer.WriteLine(i.ToString());
        }

        private void htmlbutt_Click(object sender, EventArgs e)
        {
            Print print = new Print(dataGridView2);
            print.print();



        }
    }
}