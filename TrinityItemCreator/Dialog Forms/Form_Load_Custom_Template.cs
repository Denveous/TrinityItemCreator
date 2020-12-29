using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Load_Custom_Template : Form
    {
        private Form_Main mainForm;

        public Form_Load_Custom_Template(Form_Main form1)
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

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && listBox1.Items.Count > 0)
            {
                Functions myFunctions = new Functions(mainForm);
                myFunctions.LoadMyCustomTemplate(listBox1.SelectedItem.ToString());
                Close();
            }
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string path = "templates";
            Directory.CreateDirectory(path);

            string[] files = Directory.GetFiles(path, @"*.xml", SearchOption.TopDirectoryOnly).Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            listBox1.Items.AddRange(files);

            if (files == null || files.Length == 0)
                ButtonLoad.Enabled = false;
            else
                listBox1.SelectedIndex = 0;
        }
        
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            Functions myFunctions = new Functions(mainForm);
            myFunctions.LoadMyCustomTemplate(listBox1.SelectedItem.ToString());
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
