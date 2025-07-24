using System;
using System.Windows.Forms;
using Operational;

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
                {
                    if (((NumericUpDown)Object.Controls[i]).Minimum <= 0)
                        ((NumericUpDown)Object.Controls[i]).Value = 0;
                    else
                        ((NumericUpDown)Object.Controls[i]).Value = ((NumericUpDown)Object.Controls[i]).Minimum;
                }
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
                else if (Object.Controls[i] is TreeView)
                    ((TreeView)Object.Controls[i]).Nodes.Clear();
            }
        }

        private static string Message(CheckBox Control, int MatrixTagLength)
        {
            string Result = String.Concat("Check box Tag property array ", Control.Name, " has");

            if (MatrixTagLength < 2)
                Result = String.Concat(Result, " less ");
            else if (MatrixTagLength > 2)
                Result = String.Concat(Result, " more ");

            Result = String.Concat(Result, "than 2 (two) elements !");

            return Result;
        }

        public static void CheckBoxPosition(CheckBox Control, string Value)
        {
            string[] MatrixTag = Matrix.Config(";", Control.Tag.ToString());

            if (MatrixTag.Length == 2)
            {
                int Index = Array.IndexOf(MatrixTag, Value);

                if (Index == 0)
                    Control.Checked = true;
                else
                    Control.Checked = false;
            }
            else
                MessageBox.Show(Message(Control, MatrixTag.Length), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string CheckBoxValue(CheckBox Control)
        {
            string Result = "";
            string[] MatrixTag = Matrix.Config(";", Control.Tag.ToString());

            if (MatrixTag.Length == 2)
            {
                if (Control.Checked == true)
                    Result = MatrixTag[0];
                else
                    Result = MatrixTag[1];
            }
            else
                MessageBox.Show(Message(Control, MatrixTag.Length), Diagnostic.Method(1), MessageBoxButtons.OK, MessageBoxIcon.Error);

            return Result;
        }
    }
}
