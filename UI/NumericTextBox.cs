using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace AlfredAutoClick.UI
{
    /// <summary>
    /// A TextBox that only accepts numeric integer input and formats it visually.
    /// </summary>
    public class NumericTextBox : TextBox
    {
        /// <summary>
        /// Gets or sets the minimum allowed value.
        /// </summary>
        [DefaultValue(0)]
        public int MinValue { get; set; } = 0;

        /// <summary>
        /// Gets or sets the maximum allowed value.
        /// </summary>
        [DefaultValue(int.MaxValue)]
        public int MaxValue { get; set; } = int.MaxValue;

        /// <summary>
        /// Gets or sets the integer value of the textbox.
        /// Setting the value also updates the text using the current culture format.
        /// </summary>
        [DefaultValue(0)]
        public int Value
        {
            get
            {
                var raw = CleanText(Text);
                if (long.TryParse(raw, out long parsed))
                {
                    if (parsed < MinValue) return MinValue;
                    if (parsed > MaxValue) return MaxValue;
                    return (int)parsed;
                }

                return MinValue;
            }

            set
            {
                var clamped = Math.Max(MinValue, Math.Min(MaxValue, value));
                Text = clamped.ToString("N0", CultureInfo.CurrentCulture);
            }
        }

        /// <summary>
        /// Initializes the numeric textbox with right alignment and formatting.
        /// </summary>
        public NumericTextBox()
        {
            TextAlign = HorizontalAlignment.Right;
            Value = MinValue;
        }

        /// <summary>
        /// filters out non-digit characters during typing
        /// </summary>
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);

            // allow control keys (e.g. backspace) and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        /// <summary>
        /// removes formatting when entering the control
        /// </summary>
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            Text = CleanText(Text);
        }

        /// <summary>
        /// re-applies formatting when leaving the control
        /// </summary>
        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            Text = Value.ToString("N0", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// removes group separators and spaces from a string
        /// </summary>
        private string CleanText(string input)
        {
            var sep = CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator;
            return input.Replace(sep, "").Replace(" ", "").Replace("\u00A0", "");
        }
    }
}
