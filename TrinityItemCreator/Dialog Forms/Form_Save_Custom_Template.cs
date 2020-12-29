using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Save_Custom_Template : Form
    {
        private Form_Main mainForm;

        public Form_Save_Custom_Template(Form_Main form1)
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);

            mainForm = form1;
            myTextBox2.Text = Functions.templateName;
        }
        public void CallThisShit()
        {
            myTextBox2.Text = Functions.templateName;
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

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
            else if (e.KeyCode == Keys.Enter)
                ButtonSave_Click(sender, e);
        }

        private void Watermark_myTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
            {
                mTextBox.Text = "Required!";
                mTextBox.ForeColor = Color.Red;
            }
        }
        private void Watermark_myTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "Required!")
            {
                mTextBox.Text = "";
                mTextBox.ForeColor = Color.DimGray;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            MyData myData = new MyData();

            if (myTextBox2.Text != "Required!")
            {
                bool replaceTemplate = false;
                string path = "templates";
                string filename = myTextBox2.Text;

                Directory.CreateDirectory(path);

                if (File.Exists($"{path}\\{myTextBox2.Text}.xml"))
                {
                    DialogResult dialogResult = MessageBox.Show($"Template {filename} already exists", "Do you want to replace?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        LabelWarning.Text = $"Template {filename} replaced!";
                        replaceTemplate = true;
                        Functions.templateName = filename;
                    }
                }

                if (!myData.SaveNewTemplateAsXML(filename, replaceTemplate))
                    LabelWarning.Text = "Name already in use, should've replaced!";
                else
                    Close();
            }
            else
                LabelWarning.Text = "Please use a valid name!";
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Save_Custom_Template_Load(object sender, EventArgs e)
        {

        }

        private void myTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
