using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Stats_Generator : Form
    {
        private Form_Main mainForm;
        private static bool[] CheckStatBoxes = new bool[10];
        private static string[] rangeBoxes = { "1000", "10000" };

        public Form_Stats_Generator(Form_Main form1)
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

        private void Watermark_myTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyTextBox myTextBox = (MyTextBox)sender;
            if (myTextBox.Text.Length <= 1 && e.KeyChar == (char)Keys.Back)
                e.Handled = true;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void Window_GenerateStats_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Window_GenerateStats_Load(object sender, EventArgs e)
        {
            TextBoxRangeMin.Text = rangeBoxes[0];
            TextBoxRangeMax.Text = rangeBoxes[1];

            CheckStat1.Checked = CheckStatBoxes[0];
            CheckStat2.Checked = CheckStatBoxes[1];
            CheckStat3.Checked = CheckStatBoxes[2];
            CheckStat4.Checked = CheckStatBoxes[3];
            CheckStat5.Checked = CheckStatBoxes[4];
            CheckStat6.Checked = CheckStatBoxes[5];
            CheckStat7.Checked = CheckStatBoxes[6];
            CheckStat8.Checked = CheckStatBoxes[7];
            CheckStat9.Checked = CheckStatBoxes[8];
            CheckStat10.Checked = CheckStatBoxes[9];

            ComboBoxStat1.SelectedIndex = ComboBoxStat1.FindString(string.Format("[{0}]", MyData.Field_stat_type1));
            ComboBoxStat2.SelectedIndex = ComboBoxStat2.FindString(string.Format("[{0}]", MyData.Field_stat_type2));
            ComboBoxStat3.SelectedIndex = ComboBoxStat3.FindString(string.Format("[{0}]", MyData.Field_stat_type3));
            ComboBoxStat4.SelectedIndex = ComboBoxStat4.FindString(string.Format("[{0}]", MyData.Field_stat_type4));
            ComboBoxStat5.SelectedIndex = ComboBoxStat5.FindString(string.Format("[{0}]", MyData.Field_stat_type5));
            ComboBoxStat6.SelectedIndex = ComboBoxStat6.FindString(string.Format("[{0}]", MyData.Field_stat_type6));
            ComboBoxStat7.SelectedIndex = ComboBoxStat7.FindString(string.Format("[{0}]", MyData.Field_stat_type7));
            ComboBoxStat8.SelectedIndex = ComboBoxStat8.FindString(string.Format("[{0}]", MyData.Field_stat_type8));
            ComboBoxStat9.SelectedIndex = ComboBoxStat9.FindString(string.Format("[{0}]", MyData.Field_stat_type9));
            ComboBoxStat10.SelectedIndex = ComboBoxStat10.FindString(string.Format("[{0}]", MyData.Field_stat_type10));

            LabelStatValue1.Text = MyData.Field_stat_value1.ToString();
            LabelStatValue2.Text = MyData.Field_stat_value2.ToString();
            LabelStatValue3.Text = MyData.Field_stat_value3.ToString();
            LabelStatValue4.Text = MyData.Field_stat_value4.ToString();
            LabelStatValue5.Text = MyData.Field_stat_value5.ToString();
            LabelStatValue6.Text = MyData.Field_stat_value6.ToString();
            LabelStatValue7.Text = MyData.Field_stat_value7.ToString();
            LabelStatValue8.Text = MyData.Field_stat_value8.ToString();
            LabelStatValue9.Text = MyData.Field_stat_value9.ToString();
            LabelStatValue10.Text = MyData.Field_stat_value10.ToString();
        }

        private void Window_GenerateStats_FormClosed(object sender, FormClosedEventArgs e)
        {
            rangeBoxes[0] = String.IsNullOrEmpty(TextBoxRangeMin.Text) ? "1000" : TextBoxRangeMin.Text;
            rangeBoxes[1] = String.IsNullOrEmpty(TextBoxRangeMax.Text) ? "10000" : TextBoxRangeMax.Text;

            CheckStatBoxes[0] = CheckStat1.Checked;
            CheckStatBoxes[1] = CheckStat2.Checked;
            CheckStatBoxes[2] = CheckStat3.Checked;
            CheckStatBoxes[3] = CheckStat4.Checked;
            CheckStatBoxes[4] = CheckStat5.Checked;
            CheckStatBoxes[5] = CheckStat6.Checked;
            CheckStatBoxes[6] = CheckStat7.Checked;
            CheckStatBoxes[7] = CheckStat8.Checked;
            CheckStatBoxes[8] = CheckStat9.Checked;
            CheckStatBoxes[9] = CheckStat10.Checked;
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            /* When you create a Random instance it's seeded with the current time. 
             * So if you create several of them at the same time they'll generate the same random number sequence. 
             * You need to create a single instance of Random and use that. */
            Random random = new Random();

            Functions myF = new Functions();

            if (CheckStat1.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue1.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue1.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue1.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat2.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue2.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue2.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue2.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat3.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue3.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue3.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue3.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat4.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue4.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue4.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue4.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat5.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue5.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue5.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue5.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat6.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue6.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue6.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue6.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat7.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue7.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue7.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue7.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat8.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue8.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue8.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue8.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat9.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue9.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue9.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue9.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }

            if (CheckStat10.Checked)
            {
                // if both are checked or unchecked at the same time
                if (CheckBoxOdd.Checked == CheckBoxEven.Checked)
                    LabelStatValue10.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 0).ToString();
                // if checkbox odd is checked
                else if (CheckBoxOdd.Checked)
                    LabelStatValue10.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 1).ToString();
                // if checkbox even is checked
                else
                    LabelStatValue10.Text = myF.GenerateOddEvenNumber(random, Convert.ToInt32(TextBoxRangeMin.Text), Convert.ToInt32(TextBoxRangeMax.Text), 2).ToString();
            }
        }

        private void CheckStat1_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat1.Enabled = CheckStat1.Checked;
        }

        private void CheckStat2_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat2.Enabled = CheckStat2.Checked;
        }

        private void CheckStat3_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat3.Enabled = CheckStat3.Checked;
        }

        private void CheckStat4_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat4.Enabled = CheckStat4.Checked;
        }

        private void CheckStat5_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat5.Enabled = CheckStat5.Checked;
        }

        private void CheckStat6_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat6.Enabled = CheckStat6.Checked;
        }

        private void CheckStat7_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat7.Enabled = CheckStat7.Checked;
        }

        private void CheckStat8_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat8.Enabled = CheckStat8.Checked;
        }

        private void CheckStat9_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat9.Enabled = CheckStat9.Checked;
        }

        private void CheckStat10_CheckedChanged(object sender, EventArgs e)
        {
            ComboBoxStat10.Enabled = CheckStat10.Checked;
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (CheckStat1.Checked)
            {
                string s = ComboBoxStat1.SelectedItem.ToString();
                MyData.Field_stat_type1 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value1 = Convert.ToInt32(LabelStatValue1.Text);
            }

            if (CheckStat2.Checked)
            {
                string s = ComboBoxStat2.SelectedItem.ToString();
                MyData.Field_stat_type2 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value2 = Convert.ToInt32(LabelStatValue2.Text);
            }

            if (CheckStat3.Checked)
            {
                string s = ComboBoxStat3.SelectedItem.ToString();
                MyData.Field_stat_type3 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value3 = Convert.ToInt32(LabelStatValue3.Text);
            }

            if (CheckStat4.Checked)
            {
                string s = ComboBoxStat4.SelectedItem.ToString();
                MyData.Field_stat_type4 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value4 = Convert.ToInt32(LabelStatValue4.Text);
            }

            if (CheckStat5.Checked)
            {
                string s = ComboBoxStat5.SelectedItem.ToString();
                MyData.Field_stat_type5 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value5 = Convert.ToInt32(LabelStatValue5.Text);
            }

            if (CheckStat6.Checked)
            {
                string s = ComboBoxStat6.SelectedItem.ToString();
                MyData.Field_stat_type6 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value6 = Convert.ToInt32(LabelStatValue6.Text);
            }

            if (CheckStat7.Checked)
            {
                string s = ComboBoxStat7.SelectedItem.ToString();
                MyData.Field_stat_type7 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value7 = Convert.ToInt32(LabelStatValue7.Text);
            }

            if (CheckStat8.Checked)
            {
                string s = ComboBoxStat8.SelectedItem.ToString();
                MyData.Field_stat_type8 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value8 = Convert.ToInt32(LabelStatValue8.Text);
            }

            if (CheckStat9.Checked)
            {
                string s = ComboBoxStat9.SelectedItem.ToString();
                MyData.Field_stat_type9 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value9 = Convert.ToInt32(LabelStatValue9.Text);
            }

            if (CheckStat10.Checked)
            {
                string s = ComboBoxStat10.SelectedItem.ToString();
                MyData.Field_stat_type10 = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));
                MyData.Field_stat_value10 = Convert.ToInt32(LabelStatValue10.Text);
            }

            var myF = new Functions(mainForm);
            myF.LoadDefaultTemplate(1000);
            Close();
        }
    }
}
