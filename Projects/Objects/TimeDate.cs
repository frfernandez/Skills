using System;
using System.Windows.Forms;

namespace Objects
{
    public sealed class TimeDate
    {
        public sealed class Date
        {
            public static bool Check(MaskedTextBox ControlDate)
            {
                bool Result = true;

                if (ControlDate.Text.Trim() != "/  /")
                {
                    try
                    {
                        DateTime.Parse(ControlDate.Text);
                    }
                    catch
                    {
                        ControlDate.Text = "";

                        Result = false;
                    }
                }

                return Result;
            }

            public static void Equal(MaskedTextBox ControlDateInitial, MaskedTextBox ControlDateFinal)
            {
                if (ControlDateInitial.Focused == true)
                {
                    if (ControlDateInitial.Text.Trim() != "/  /")
                    {
                        if (ControlDateFinal.Text.Trim() == "/  /")
                            ControlDateFinal.Text = ControlDateInitial.Text;

                        if (ControlDateFinal.Text.Trim() != "/  /")
                        {
                            if (Convert.ToDateTime(ControlDateInitial.Text) > Convert.ToDateTime(ControlDateFinal.Text))
                                ControlDateFinal.Text = ControlDateInitial.Text;
                        }
                    }
                }
                else if (ControlDateFinal.Focused == true)
                {
                    if (ControlDateFinal.Text.Trim() != "/  /")
                    {
                        if (ControlDateInitial.Text.Trim() == "/  /")
                            ControlDateInitial.Text = ControlDateFinal.Text;

                        if (ControlDateInitial.Text.Trim() != "/  /")
                        {
                            if (Convert.ToDateTime(ControlDateInitial.Text) > Convert.ToDateTime(ControlDateFinal.Text))
                                ControlDateInitial.Text = ControlDateFinal.Text;
                        }
                    }
                }
            }
        }

        public sealed class Time
        {
            public static bool Check(MaskedTextBox ControlTime)
            {
                bool Result = true;

                if ((ControlTime.Text.Trim() != ":") &&
                    (ControlTime.Text.Trim() != ":  :"))
                {
                    try
                    {
                        DateTime.Parse(ControlTime.Text);
                    }
                    catch
                    {
                        ControlTime.Text = "";

                        Result = false;
                    }
                }

                return Result;
            }

            public static void Equal(MaskedTextBox ControlTimeInitial, MaskedTextBox ControlTimeFinal)
            {
                if (ControlTimeInitial.Focused == true)
                {
                    if ((ControlTimeInitial.Text.Trim() != ":") &&
                        (ControlTimeInitial.Text.Trim() != ":  :"))
                    {
                        if ((ControlTimeFinal.Text.Trim() == ":") ||
                            (ControlTimeFinal.Text.Trim() == ":  :"))
                            ControlTimeFinal.Text = ControlTimeInitial.Text;

                        if ((ControlTimeFinal.Text.Trim() != ":") &&
                            (ControlTimeFinal.Text.Trim() != ":  :"))
                        {
                            if (Convert.ToDateTime(ControlTimeInitial.Text) > Convert.ToDateTime(ControlTimeFinal.Text))
                                ControlTimeFinal.Text = ControlTimeInitial.Text;
                        }
                    }
                }
                else if (ControlTimeFinal.Focused == true)
                {
                    if ((ControlTimeFinal.Text.Trim() != ":") &&
                        (ControlTimeFinal.Text.Trim() != ":  :"))
                    {
                        if ((ControlTimeInitial.Text.Trim() == ":") ||
                            (ControlTimeInitial.Text.Trim() == ":  :"))
                            ControlTimeInitial.Text = ControlTimeFinal.Text;

                        if ((ControlTimeInitial.Text.Trim() != ":") &&
                            (ControlTimeInitial.Text.Trim() != ":  :"))
                        {
                            if (Convert.ToDateTime(ControlTimeInitial.Text) > Convert.ToDateTime(ControlTimeFinal.Text))
                                ControlTimeInitial.Text = ControlTimeFinal.Text;
                        }
                    }
                }
            }
        }
    }
}
