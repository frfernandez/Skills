using System;
using System.Windows.Forms;

namespace Objects
{
    public class Values
    {
        public static void PanelClean(Panel[] Painel)
        {
            for (int i = 0; i < Painel.Length; i++)
                PanelClean(Painel[i]);
        }

        public static void PanelClean(Panel Object)
        {
            for (int i = 0; i < Object.Controls.Count; i++)
            {
                if (Object.Controls[i] is TextBox)
                    ((TextBox)Object.Controls[i]).Text = "";
                else if (Object.Controls[i] is MaskedTextBox)
                    ((MaskedTextBox)Object.Controls[i]).Text = "";
                else if (Object.Controls[i] is RichTextBox)
                    ((RichTextBox)Object.Controls[i]).Text = "";
                else if (Object.Controls[i] is NumericUpDown)
                    ((NumericUpDown)Object.Controls[i]).Value = ((NumericUpDown)Object.Controls[i]).Minimum;
                else if (Object.Controls[i] is PictureBox)
                {
                    ((PictureBox)Object.Controls[i]).Image = null;
                    ((PictureBox)Object.Controls[i]).ImageLocation = "";
                }
                else if (Object.Controls[i] is CheckBox)
                    ((CheckBox)Object.Controls[i]).Checked = false;
                else if (Object.Controls[i] is ComboBox)
                    ((ComboBox)Object.Controls[i]).SelectedIndex = -1;
                else if (Object.Controls[i] is GroupBox)
                {
                    foreach (Control Controle in ((GroupBox)Object.Controls[i]).Controls)
                    {
                        if (Controle is RadioButton)
                        {
                            if (((RadioButton)Controle).TabIndex == 0)
                                ((RadioButton)Controle).Checked = true;
                        }
                        else if (Controle is TextBox)
                            ((TextBox)Controle).Text = "";
                    }
                }
                else if (Object.Controls[i] is DataGridView)
                {
                    if (((DataGridView)Object.Controls[i]).DataSource == null)
                        ((DataGridView)Object.Controls[i]).Rows.Clear();
                }
            }
        }
    }
}
