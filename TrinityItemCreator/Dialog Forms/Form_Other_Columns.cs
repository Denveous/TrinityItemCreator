using System;
using System.Drawing;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Other_Columns : Form
    {
        private Form_Main mainForm;

        public Form_Other_Columns(Form_Main form1)
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

        private void Watermark_MyTextBox_Leave(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text.Length == 0)
                mTextBox.Text = "0";
        }

        private void Watermark_MyTextBox_Enter(object sender, EventArgs e)
        {
            MyTextBox mTextBox = (MyTextBox)sender;
            if (mTextBox.Text == "0")
                mTextBox.Text = "";
        }

        private void Watermark_MyTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_Other_Options_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void MyTextBox25_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox25.Text, out int userVal))
                MyData.Field_minMoneyLoot = userVal;
        }

        private void MyTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox1.Text, out int userVal))
                MyData.Field_maxMoneyLoot = userVal;
        }

        private void MyTextBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox2.Text, out int userVal))
                MyData.Field_lockid = userVal;
        }

        private void MyTextBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox3.Text, out int userVal))
                MyData.Field_PageMaterial = userVal;
        }

        private void MyTextBox4_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox4.Text, out int userVal))
                MyData.Field_PageText = userVal;
        }

        private void MyTextBox5_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox5.Text, out int userVal))
                MyData.Field_LanguageID = userVal;
        }

        private void MyTextBox21_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox21.Text, out int userVal))
                MyData.Field_RequiredReputationFaction = userVal;
        }

        private void MyTextBox22_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox2.Text, out int userVal))
                MyData.Field_RequiredReputationRank = userVal;
        }

        private void MyTextBox7_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox7.Text, out int userVal))
                MyData.Field_RequiredDisenchantSkill = userVal;
        }

        private void MyTextBox8_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox8.Text, out int userVal))
                MyData.Field_DisenchantID = userVal;
        }

        private void MyTextBox19_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox19.Text, out int userVal))
                MyData.Field_requiredhonorrank = userVal;
        }

        private void MyTextBox20_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox20.Text, out int userVal))
                MyData.Field_RequiredCityRank = userVal;
        }

        private void MyTextBox16_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox16.Text, out int userVal))
                MyData.Field_RequiredSkill = userVal;
        }

        private void MyTextBox17_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox17.Text, out int userVal))
                MyData.Field_RequiredSkillRank = userVal;
        }

        private void MyTextBox18_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox18.Text, out int userVal))
                MyData.Field_requiredspell = userVal;
        }

        private void MyTextBox15_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox15.Text, out int userVal))
                MyData.Field_Map = userVal;
        }

        private void MyTextBox14_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox14.Text, out int userVal))
                MyData.Field_area = userVal;
        }

        private void MyTextBox13_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox13.Text, out int userVal))
                MyData.Field_duration = userVal;
        }

        private void MyTextBox6_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox6.Text, out int userVal))
                MyData.Field_startquest = userVal;
        }

        private void MyTextBox9_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox9.Text, out int userVal))
                MyData.Field_GemProperties = userVal;
        }

        private void MyTextBox10_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox10.Text, out int userVal))
                MyData.Field_HolidayId = userVal;
        }

        private void MyTextBox11_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox11.Text, out int userVal))
                MyData.Field_SoundOverrideSubclass = userVal;
        }

        private void MyTextBox12_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(MyTextBox12.Text, out int userVal))
                MyData.Field_ItemLimitCategory = userVal;
        }

        private void MyTextBox23_TextChanged(object sender, EventArgs e)
        {
            MyData.Field_ScriptName = MyTextBox23.Text;
        }

        private void Window_Other_Options_Load(object sender, EventArgs e)
        {
            MyTextBox1.Text = MyData.Field_maxMoneyLoot.ToString();
            MyTextBox2.Text = MyData.Field_lockid.ToString();
            MyTextBox3.Text = MyData.Field_PageMaterial.ToString();
            MyTextBox4.Text = MyData.Field_PageText.ToString();
            MyTextBox5.Text = MyData.Field_LanguageID.ToString();
            MyTextBox6.Text = MyData.Field_startquest.ToString();
            MyTextBox7.Text = MyData.Field_RequiredDisenchantSkill.ToString();
            MyTextBox8.Text = MyData.Field_DisenchantID.ToString();
            MyTextBox9.Text = MyData.Field_GemProperties.ToString();
            MyTextBox10.Text = MyData.Field_HolidayId.ToString();
            MyTextBox11.Text = MyData.Field_SoundOverrideSubclass.ToString();
            MyTextBox12.Text = MyData.Field_ItemLimitCategory.ToString();
            MyTextBox13.Text = MyData.Field_duration.ToString();
            MyTextBox14.Text = MyData.Field_area.ToString();
            MyTextBox15.Text = MyData.Field_Map.ToString();
            MyTextBox16.Text = MyData.Field_RequiredSkill.ToString();
            MyTextBox17.Text = MyData.Field_RequiredSkillRank.ToString();
            MyTextBox18.Text = MyData.Field_requiredspell.ToString();
            MyTextBox19.Text = MyData.Field_requiredhonorrank.ToString();
            MyTextBox20.Text = MyData.Field_RequiredCityRank.ToString();
            MyTextBox21.Text = MyData.Field_RequiredReputationFaction.ToString();
            MyTextBox22.Text = MyData.Field_RequiredReputationRank.ToString();
            MyTextBox23.Text = MyData.Field_ScriptName;
            MyTextBox25.Text = MyData.Field_minMoneyLoot.ToString();
        }
    }
}
