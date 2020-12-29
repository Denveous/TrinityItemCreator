using System;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Flags_Custom : Form
    {
        private Form_Main mainForm;
        private static bool mIsChecked;

        public Form_Flags_Custom(Form_Main form1)
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

        private void ButtonSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++) checkedListBox1.SetItemChecked(i, mIsChecked ? false : true);
            mIsChecked = mIsChecked ? false : true;
        }

        private void Window_FlagCustomMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxBagFamilyMask_TextChanged(object sender, EventArgs e)
        {
            int _textBoxMask = Convert.ToInt32(TextBoxFlagCustomMask.Text);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string s = checkedListBox1.Items[i].ToString();
                int itemMask = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));

                checkedListBox1.SetItemChecked(i, Convert.ToBoolean(_textBoxMask & itemMask));
            }

            MyData.Field_flagsCustom = _textBoxMask;
        }

        private void Window_FlagCustomMask_Load(object sender, EventArgs e)
        {
            checkedListBox1.ItemCheck += new ItemCheckEventHandler(HandleCheckBoxItemState);
            checkedListBox1.Click += new EventHandler(ResetManualTextBoxFlagCustomMask);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string s = checkedListBox1.Items[i].ToString();
                int itemMask = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));

                if ((MyData.Field_flagsCustom & itemMask) != 0)
                    checkedListBox1.SetItemChecked(i, true);
                else
                    TextBoxFlagCustomMask.Text = MyData.Field_flagsCustom.ToString(); // contains different class mask then add full class mask to text box
            }
        }

        private void HandleCheckBoxItemState(object sender, ItemCheckEventArgs e)
        {
            string s = checkedListBox1.Items[e.Index].ToString();
            int itemMask = Convert.ToInt32(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));

            if (e.NewValue == CheckState.Checked)
            {
                if ((MyData.Field_flagsCustom & itemMask) == 0)
                    MyData.Field_flagsCustom += itemMask;
            }
            else
            {
                if ((MyData.Field_flagsCustom & itemMask) != 0)
                    MyData.Field_flagsCustom -= itemMask;
            }
        }

        private void ResetManualTextBoxFlagCustomMask(object sender, EventArgs e)
        {
            TextBoxFlagCustomMask.Text = "0";
        }

        private void Form_Flags_Custom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Functions funcs = new Functions(mainForm);
            funcs.SetFlagsMasksButtonCurrentValue();
        }
    }
}
