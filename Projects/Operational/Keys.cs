using System;
using System.Windows.Forms;

namespace Operational
{
    public class Key
    {
        public static Keys Pressed(object sender, KeyEventArgs e)
        {
            Keys Key = e.KeyCode;
            int Code = e.KeyValue;

            e.Handled = true;

            if (Key == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                if (!(((Form)sender).ActiveControl is DataGridView) &&
                    !(((Form)sender).ActiveControl is RichTextBox))
                    SendKeys.Send("{TAB}");
            }
            else if (Key == Keys.Down)
            {
                if (!(((Form)sender).ActiveControl is DataGridView) &&
                    !(((Form)sender).ActiveControl is RichTextBox) &&
                    !(((Form)sender).ActiveControl is NumericUpDown) &&
                    !(((Form)sender).ActiveControl is ComboBox))
                    SendKeys.Send("{TAB}");
            }
            else if (Key == Keys.Up)
            {
                if (!(((Form)sender).ActiveControl is DataGridView) &&
                    !(((Form)sender).ActiveControl is RichTextBox) &&
                    !(((Form)sender).ActiveControl is NumericUpDown) &&
                    !(((Form)sender).ActiveControl is ComboBox))
                    SendKeys.Send("+{TAB}");
            }
            else if (Key == Keys.Tab)
            {
                if (((Form)sender).ActiveControl is DataGridView)
                    SendKeys.Send("{TAB}");
            }
            else if (Key == Keys.F9)
            {
                if (((Form)sender).ContextMenuStrip != null)
                {
                    int Item = -1;

                    for (int i = 0; i < ((Form)sender).ContextMenuStrip.Items.Count; i++)
                    {
                        if (((Form)sender).ContextMenuStrip.Items[i].Tag.ToString().ToUpper().IndexOf(((Form)sender).ActiveControl.Name.ToUpper()) > -1)
                        {
                            Item = i;
                            break;
                        }
                    }

                    if (Item > -1)
                    {
                        bool Visible = ((Form)sender).ContextMenuStrip.Items[Item].Visible;

                        if (((Form)sender).ContextMenuStrip.Items[Item].Enabled == true)
                        {
                            ((Form)sender).ContextMenuStrip.Items[Item].Visible = true;
                            ((Form)sender).ContextMenuStrip.Items[Item].PerformClick();
                            ((Form)sender).ContextMenuStrip.Items[Item].Visible = Visible;
                        }
                        else
                            Key = Keys.Cancel;
                    }
                }
            }
            else if (Key == Keys.T)
            {
                if (((Form)sender).ActiveControl is MaskedTextBox)
                {
                    string Date_Time = "";

                    if (((MaskedTextBox)((Form)sender).ActiveControl).Text.Trim() == "/  /")
                    {
                        int Dia = DateTime.Now.Day,
                            Mes = DateTime.Now.Month;

                        if (Dia < 10)
                            Date_Time = String.Concat("0", Convert.ToString(Dia));
                        else
                            Date_Time = Convert.ToString(Dia);

                        if (Mes < 10)
                            Date_Time = String.Concat(Date_Time, "/0", Convert.ToString(Mes), "/", DateTime.Now.Year.ToString());
                        else
                            Date_Time = String.Concat(Date_Time, "/", Convert.ToString(Mes), "/", DateTime.Now.Year.ToString());
                    }
                    else if ((((MaskedTextBox)((Form)sender).ActiveControl).Text.Trim() == ":  :") ||
                             (((MaskedTextBox)((Form)sender).ActiveControl).Text.Trim() == ":"))
                    {
                        int Hora = DateTime.Now.Hour,
                            Minuto = DateTime.Now.Minute,
                            Segundo = DateTime.Now.Second;

                        if (Hora < 10)
                            Date_Time = String.Concat("0", Convert.ToString(Hora));
                        else
                            Date_Time = Convert.ToString(Hora);

                        if (Minuto < 10)
                            Date_Time = String.Concat(Date_Time, ":0", Convert.ToString(Minuto));
                        else
                            Date_Time = String.Concat(Date_Time, ":", Convert.ToString(Minuto));

                        if (((MaskedTextBox)((Form)sender).ActiveControl).Text.Trim() == ":  :")
                        {
                            if (Segundo < 10)
                                Date_Time = String.Concat(Date_Time, ":0", Convert.ToString(Segundo));
                            else
                                Date_Time = String.Concat(Date_Time, ':', Convert.ToString(Segundo));
                        }
                    }
                    else
                        Date_Time = ((MaskedTextBox)((Form)sender).ActiveControl).Text;

                    ((MaskedTextBox)((Form)sender).ActiveControl).Text = Date_Time;
                }
            }

            e.Handled = false;

            return Key;
        }
    }
}
