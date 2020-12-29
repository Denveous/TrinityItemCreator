using System;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Default_Templates : Form
    {
        private Form_Main mainForm;

        public Form_Default_Templates(Form_Main form1)
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

        private void ButtonSkip_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            var myCF = new Functions(mainForm);
            myCF.UnBlurMainForm();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                Close();
        }

        private void ButtonWeapon_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(0);
            Close();
        }

        private void ButtonArmor_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(1);
            Close();
        }

        private void ButtonGem_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(2);
            Close();
        }

        private void ButtonProjectile_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(3);
            Close();
        }

        private void ButtonContainer_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(4);
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(5);
            Close();
        }

        private void ButtonGlyph_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(6);
            Close();
        }

        private void ButtonRecipe_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(7);
            Close();
        }

        private void ButtonQuest_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(8);
            Close();
        }

        private void ButtonKey_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(9);
            Close();
        }

        private void ButtonReagent_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(10);
            Close();
        }

        private void ButtonTradeGoods_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(11);
            Close();
        }

        private void ButtonConsumable_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(12);
            Close();
        }

        private void ButtonMisc_Click(object sender, EventArgs e)
        {
            Functions myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(13);
            Close();
        }

        private void ButtonMyTemplates_Click(object sender, EventArgs e)
        {
            Close();
            Form_Load_Custom_Template form4 = new Form_Load_Custom_Template(mainForm);
            form4.ShowDialog();
        }
    }
}
