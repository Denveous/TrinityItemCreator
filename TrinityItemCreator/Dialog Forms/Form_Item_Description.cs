using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Item_Description : Form
    {
        private Form_Main mainForm;

        public Form_Item_Description(Form_Main form1)
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

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_EditDescription_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = MyData.Field_description;
        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void Window_EditDescription_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyData.Field_description = richTextBox1.Text; //.Replace("\r\n","\\n");
            mainForm.tb_item_description.Text = MyData.Field_description;
        }
    }
}
