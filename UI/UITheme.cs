using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlfredAutoClick.UI
{
    /// <summary>
    /// Applies a consistent blue theme to all controls in a Form.
    /// </summary>
    public static class UITheme
    {
        public static readonly Color BackgroundColor = Color.FromArgb(15, 25, 45);
        public static readonly Color ForegroundColor = Color.FromArgb(220, 230, 250);
        public static readonly Color AccentColor = Color.FromArgb(70, 130, 180);
        public static readonly Color ButtonHoverColor = Color.FromArgb(130, 90, 120);
        public static readonly Color InputBackgroundColor = Color.FromArgb(25, 40, 65);
        public static readonly Color InputBackgroundAltColor = Color.FromArgb(90, 60, 80);

        /// <summary>
        /// Applies the blue theme to root control and all child controls.
        /// </summary>
        public static void Apply(Control root)
        {
            foreach (Control control in root.Controls)
            {
                if (control is Button btn)
                {
                    btn.BackColor = AccentColor;
                    btn.ForeColor = ForegroundColor;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.MouseEnter += (s, e) => btn.BackColor = ButtonHoverColor;
                    btn.MouseLeave += (s, e) => btn.BackColor = AccentColor;
                }
                else if (control is ComboBox combo)
                {
                    combo.BackColor = InputBackgroundAltColor;
                    combo.ForeColor = ForegroundColor;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = InputBackgroundAltColor;
                    txt.ForeColor = ForegroundColor;
                }
                else if (control is Label lbl)
                {
                    lbl.ForeColor = ForegroundColor;
                    lbl.BackColor = Color.Transparent;
                }

                if (control.HasChildren)
                    Apply(control);
            }
        }
    }
}
