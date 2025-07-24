using System;
using System.Windows.Forms;

namespace Objects
{
    public partial class Numbers : TextBox
    {
        public static void EnterKey(object sender, EventArgs e)
        {
            if (((TextBox)sender).ShortcutsEnabled == true)
                ((TextBox)sender).ShortcutsEnabled = false;

            if (((TextBox)sender).TextAlign != HorizontalAlignment.Right)
                ((TextBox)sender).TextAlign = HorizontalAlignment.Right;
        }

        public static void NumbersKeyDown(object sender, KeyEventArgs e)
        {
            Config(sender, e, null);
        }

        public static void NumbersKeyPress(object sender, KeyPressEventArgs e)
        {
            Config(sender, null, e);
        }

        public static void Config(object sender, KeyEventArgs KeyDown, KeyPressEventArgs KeyPress)
        {
            if ((KeyDown != null) &&
                ((KeyDown.KeyCode == Keys.Back) ||
                 (KeyDown.KeyCode == Keys.Home) ||
                 (KeyDown.KeyCode == Keys.Delete)))
            {
                KeyDown.Handled = true;

                if (KeyDown.KeyCode == Keys.Delete)
                    ((TextBox)sender).Text = "";

                Semicolon(sender, 1);
            }
            else
            {
                if (KeyPress != null)
                {
                    bool Number = ((KeyPress.KeyChar >= (char)Keys.D0) && (KeyPress.KeyChar <= (char)Keys.D9)),
                         Erase = (KeyPress.KeyChar == (char)Keys.Back),
                         Browse = ((KeyPress.KeyChar == (char)Keys.Home) ||
                                    (KeyPress.KeyChar == (char)Keys.End) ||
                                    (KeyPress.KeyChar == (char)Keys.PageUp) ||
                                    (KeyPress.KeyChar == (char)Keys.PageDown) ||
                                    (KeyPress.KeyChar == (char)Keys.Up) ||
                                    (KeyPress.KeyChar == (char)Keys.Down) ||
                                    (KeyPress.KeyChar == (char)Keys.Left) ||
                                    (KeyPress.KeyChar == (char)Keys.Right) ||
                                    (KeyPress.KeyChar == (char)Keys.Space)),
                         Copy = ((KeyPress.KeyChar == (char)Keys.ControlKey) && (KeyPress.KeyChar == (char)Keys.V)),
                         Exit = ((Keys)KeyPress.KeyChar == Keys.Alt && KeyPress.KeyChar == (char)Keys.F4);

                    if (Erase == true)
                    {
                        KeyPress.Handled = true;
                        Number = false;

                        if (((TextBox)sender).Text.Length > 0)
                            ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, ((TextBox)sender).Text.Length - 1);

                        Semicolon(sender, 1);
                    }

                    if (Browse == true)
                        KeyPress.Handled = true;
                    else
                    {
                        if ((Number == true) ||
                            (Copy == true))
                            Semicolon(sender, 0);
                        else
                        {
                            if (Exit == false)
                                KeyPress.Handled = true;
                        }
                    }
                }
            }

            ((TextBox)sender).Select(((TextBox)sender).Text.Length, 0);
        }

        public static void Semicolon(object sender, int PlaceDecimal)
        {
            int DecimalPlace = 0;

            string Text = "",
                   DecimalSeparator = ",",
                   ThousandSeparator = ".";

            if (((TextBox)sender).AccessibleDescription.IndexOf(",") > 0)
                DecimalPlace = Convert.ToInt32(((TextBox)sender).AccessibleDescription.Substring(((TextBox)sender).AccessibleDescription.IndexOf(",") + 1));

            if (DecimalPlace > 0)
            {
                for (int i = ((TextBox)sender).Text.Length - 1; i >= 0; i--)
                {
                    if ((((TextBox)sender).Text.Substring(i, 1) != ThousandSeparator) &&
                        (((TextBox)sender).Text.Substring(i, 1) != DecimalSeparator))
                        Text = String.Concat(((TextBox)sender).Text.Substring(i, 1), Text);
                }

                if (Text.Length > 0)
                {
                    if (Text.Substring(0, 1) == "0")
                        Text = Text.Substring(1, Text.Length - 1);
                }

                int Separator = 0,
                    Posicion = 0;

                ((TextBox)sender).Text = "";
                for (int i = Text.Length - 1; i >= 0; i--)
                {
                    if (i == Text.Length - (DecimalPlace + PlaceDecimal))
                    {
                        ((TextBox)sender).Text = String.Concat(DecimalSeparator, ((TextBox)sender).Text);

                        Separator = Separator + 1;
                    }

                    if ((((TextBox)sender).Text.Length - Separator) < Text.Length)
                    {
                        Posicion = ((TextBox)sender).Text.IndexOf(ThousandSeparator);
                        if (Posicion == -1)
                            Posicion = ((TextBox)sender).Text.IndexOf(DecimalSeparator);
                        if (Posicion == 3)
                        {
                            ((TextBox)sender).Text = String.Concat(ThousandSeparator, ((TextBox)sender).Text);

                            Separator = Separator + 1;
                        }
                    }

                    ((TextBox)sender).Text = String.Concat(Text.Substring(i, 1), ((TextBox)sender).Text);
                }

                if (((TextBox)sender).Text.Length <= DecimalPlace)
                {
                    Posicion = ((TextBox)sender).Text.IndexOf(DecimalSeparator);
                    if (Posicion == -1)
                    {
                        Text = String.Concat("0", DecimalSeparator);

                        if (((TextBox)sender).Text.Length < DecimalPlace)
                            Text = Text.PadRight((Text.Length + (DecimalPlace - 1)), '0');

                        ((TextBox)sender).Text = String.Concat(Text, ((TextBox)sender).Text);
                    }
                }
            }
        }
    }
}
