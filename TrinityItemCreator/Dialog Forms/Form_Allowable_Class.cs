using System;
using System.Linq;
using System.Windows.Forms;
using TrinityItemCreator.MyClass;

namespace TrinityItemCreator
{
    public partial class Form_Allowable_Class : Form
    {
        private Form_Main mainForm;

        public Form_Allowable_Class(Form_Main form1)
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

        private void Form_Allowable_Class_Load(object sender, EventArgs e)
        {
            int _maskToHandle = MyData.Field_AllowableClass < 0 ? 0 : MyData.Field_AllowableClass;

            foreach (var checkBox in Controls.OfType<CheckBox>()) if ((_maskToHandle & Convert.ToInt32(checkBox.Tag)) != 0) { checkBox.Checked = true; }
        }

        private void Form_Allowable_Class_FormClosed(object sender, FormClosedEventArgs e)
        {
            int _maskToHandle = 0;

            foreach (var checkBox in Controls.OfType<CheckBox>()) { if (checkBox.Checked) _maskToHandle += Convert.ToInt32(checkBox.Tag); }

            if (_maskToHandle == 0 || _maskToHandle < -1)
                MyData.Field_AllowableClass = -1;
            else
                MyData.Field_AllowableClass = _maskToHandle;

            Functions funcs = new Functions(mainForm);
            funcs.SetFlagsMasksButtonCurrentValue();
        }

        private void UnCheckAll_Click(object sender, EventArgs e) { foreach (var chkBox in Controls.OfType<CheckBox>()) chkBox.Checked = false; }

        private void ButtonFinish_Click(object sender, EventArgs e) { Close(); }

        private void Form_Allowable_Class_KeyDown(object sender, KeyEventArgs e) { if (e.KeyCode == Keys.Escape) Close(); }
    }
}
