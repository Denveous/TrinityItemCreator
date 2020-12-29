using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{

    public partial class Form_DisplayID_Finder : Form
    {
        private Form_Main mainForm;

        public Form_DisplayID_Finder(Form_Main form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        private void Window_DisplayIdFinder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void BindGridview(string searchField)
        {
            string displayFile = "displayidlist.csv";
            if (!File.Exists($"data\\{displayFile}"))
            {
                MessageBox.Show($"Missing {displayFile} from data folder!");
                return;
            }

            object[] buffer = new object[100];
            List<DataGridViewRow> rows = new List<DataGridViewRow>();

            dataGridView1.Rows.Clear();
            foreach (string line in File.ReadLines($"data\\{displayFile}"))
            {
                var values = line.Split('|');

                if (line.CaseInsensitiveContains(searchField))
                {
                    buffer[0] = values[0]; // entry
                    buffer[1] = values[1]; // name
                    buffer[2] = values[2]; // displayid
                    buffer[3] = $"https://wotlk.evowow.com/item={values[0]}/#modelviewer:10+1"; // values[1]; // name; // quality

                    rows.Add(new DataGridViewRow());
                    rows[rows.Count - 1].CreateCells(dataGridView1, buffer);
                }
            }
            dataGridView1.Rows.AddRange(rows.ToArray());
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxSearch.Text.Length >= 3)
                BindGridview(TextBoxSearch.Text);
            else
                dataGridView1.Rows.Clear();
        }

        private void DataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
                dataGridView1.Cursor = Cursors.Hand;
            else if (e.ColumnIndex == 3 && e.RowIndex != -1)
                dataGridView1.Cursor = Cursors.Hand;
        }

        private void DataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
                dataGridView1.Cursor = Cursors.Default;
            else if (e.ColumnIndex == 3 && e.RowIndex != -1)
                dataGridView1.Cursor = Cursors.Default;
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    MyData.Field_displayid = Convert.ToInt32(dataGridView1.CurrentCell.Value.ToString());
                    mainForm.TextBoxDisplayID.Text = MyData.Field_displayid.ToString();
                    Close();
                }
            }
            else if(e.ColumnIndex == 3 && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                    System.Diagnostics.Process.Start(dataGridView1.CurrentCell.Value.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
