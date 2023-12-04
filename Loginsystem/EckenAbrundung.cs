using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class EckenAbrundung
{
    public static void RundeEcken(Control control, int radius)
    {
        // Hier werden die Ecken des jeweiligen Steuerelements abgerundet

        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
        path.AddArc(control.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
        path.AddArc(control.Width - (radius * 2), control.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
        path.AddArc(0, control.Height - (radius * 2), radius * 2, radius * 2, 90, 90);
        control.Region = new Region(path);
    }
}