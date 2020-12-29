using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class MyOpacuePanel : Panel
{
    private const int WS_EX_TRANSPARENT = 0x20;
    public MyOpacuePanel()
    {
        SetStyle(ControlStyles.Opaque, true);
    }

    private int opacity = 50;
    [DefaultValue(50)]
    public int Opacity
    {
        get
        {
            return this.opacity;
        }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentException("value must be between 0 and 100");
            opacity = value;
        }
    }
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
            return cp;
        }
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        using (var brush = new SolidBrush(Color.FromArgb(opacity * 255 / 100, BackColor)))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        base.OnPaint(e);
    }
}