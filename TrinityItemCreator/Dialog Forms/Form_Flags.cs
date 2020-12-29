using System;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Flags : Form
    {
        private Form_Main mainForm;
        private static bool mIsChecked = false;

        public Form_Flags(Form_Main form1)
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
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, mIsChecked ? false : true);

            mIsChecked = mIsChecked ? false : true;
        }

        private void Window_FlagMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ButtonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxFlagMask_TextChanged(object sender, EventArgs e)
        {
            ulong _textBoxMask = Convert.ToUInt64(TextBoxFlagMask.Text);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string s = checkedListBox1.Items[i].ToString();
                ulong itemMask = Convert.ToUInt64(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));

                checkedListBox1.SetItemChecked(i, Convert.ToBoolean(_textBoxMask & itemMask));
            }

            MyData.Field_Flags = _textBoxMask;
        }

        private void Window_FlagMask_Load(object sender, EventArgs e)
        {
            checkedListBox1.ItemCheck += new ItemCheckEventHandler(HandleCheckBoxItemState);
            checkedListBox1.Click += new EventHandler(ResetManualTextBoxFlagMask);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                string s = checkedListBox1.Items[i].ToString();
                ulong itemMask = Convert.ToUInt64(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));

                if ((MyData.Field_Flags & itemMask) != 0)
                    checkedListBox1.SetItemChecked(i, true);
                else
                    TextBoxFlagMask.Text = MyData.Field_Flags.ToString(); // contains different class mask then add full class mask to text box
            }
        }

        private void HandleCheckBoxItemState(object sender, ItemCheckEventArgs e)
        {
            string s = checkedListBox1.Items[e.Index].ToString();
            ulong itemMask = Convert.ToUInt64(s.Remove(s.IndexOf(']')).Substring(s.IndexOf('[') + 1));

            if (e.NewValue == CheckState.Checked)
            {
                if ((MyData.Field_Flags & itemMask) == 0)
                    MyData.Field_Flags += itemMask;
            }
            else
            {
                if ((MyData.Field_Flags & itemMask) != 0)
                    MyData.Field_Flags -= itemMask;
            }
        }

        private void ResetManualTextBoxFlagMask(object sender, EventArgs e)
        {
            TextBoxFlagMask.Text = "0";
        }

        private void Form_Flags_FormClosed(object sender, FormClosedEventArgs e)
        {
            Functions funcs = new Functions(mainForm);
            funcs.SetFlagsMasksButtonCurrentValue();
        }
    }
}
