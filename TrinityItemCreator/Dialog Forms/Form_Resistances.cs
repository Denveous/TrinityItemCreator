using System;
using System.Drawing;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Resistances : Form
    {
        private Form_Main mainForm;

        public Form_Resistances(Form_Main form1)
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

        private void Watermark_myTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
                mTextBox.Text = "0";
        }

        private void Watermark_myTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "0")
                mTextBox.Text = "";
        }

        private void Watermark_myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_Resistances_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void myTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox5.Text, out int userVal))
                MyData.Field_holy_res = userVal;
        }

        private void myTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox1.Text, out int userVal))
                MyData.Field_frost_res = userVal;
        }

        private void myTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox2.Text, out int userVal))
                MyData.Field_fire_res = userVal;
        }

        private void myTextBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox6.Text, out int userVal))
                MyData.Field_shadow_res = userVal;
        }

        private void myTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox4.Text, out int userVal))
                MyData.Field_nature_res = userVal;
        }

        private void myTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(myTextBox3.Text, out int userVal))
                MyData.Field_arcane_res = userVal;
        }

        private void Window_Resistances_Load(object sender, EventArgs e)
        {
            myTextBox1.Text = MyData.Field_frost_res.ToString();
            myTextBox2.Text = MyData.Field_fire_res.ToString();
            myTextBox3.Text = MyData.Field_arcane_res.ToString();
            myTextBox4.Text = MyData.Field_nature_res.ToString();
            myTextBox5.Text = MyData.Field_holy_res.ToString();
            myTextBox6.Text = MyData.Field_shadow_res.ToString();
        }
    }
}
