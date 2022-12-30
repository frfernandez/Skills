using System;
using System.Windows.Forms;
using Objects.Enumerator;

namespace Objects
{
    public sealed class Look
    {
        public string User { get; set; }

        public Look()
        {
        }

        public void TextLabel(Form FormControls, RecordEnum CRUDRecord, string Text)
        {
            if (CRUDRecord == RecordEnum.Insert)
                FormControls.Text = String.Concat(Text, " - ", "Insert");
            else if (CRUDRecord == RecordEnum.Update)
                FormControls.Text = String.Concat(Text, " - ", "Update");
            else if (CRUDRecord == RecordEnum.Delete)
                FormControls.Text = String.Concat(Text, " - ", "Delete");
            else if (CRUDRecord == RecordEnum.Select)
                FormControls.Text = Text;
        }

        public void CRUDButton(Panel PanelBtn, RecordEnum CRUDRecord)
        {
            if (PanelBtn.Controls["BtnIUD"] != null)
            {
                if (CRUDRecord == RecordEnum.Insert)
                    PanelBtn.Controls["BtnIUD"].Text = "&Insert";
                else if (CRUDRecord == RecordEnum.Update)
                    PanelBtn.Controls["BtnIUD"].Text = "&Update";
                else if (CRUDRecord == RecordEnum.Delete)
                    PanelBtn.Controls["BtnIUD"].Text = "&Delete";
            }
        }

        public void ObjectFocus(object Object)
        {
            if (Object is TextBox)
            {
                if (((TextBox)Object).CanFocus == true)
                    ((TextBox)Object).Focus();
            }
            else if (Object is MaskedTextBox)
            {
                if (((MaskedTextBox)Object).CanFocus == true)
                    ((MaskedTextBox)Object).Focus();
            }
            else if (Object is RichTextBox)
            {
                if (((RichTextBox)Object).CanFocus == true)
                    ((RichTextBox)Object).Focus();
            }
            else if (Object is NumericUpDown)
            {
                if (((NumericUpDown)Object).CanFocus == true)
                    ((NumericUpDown)Object).Focus();
            }
            else if (Object is PictureBox)
            {
                if (((PictureBox)Object).CanFocus == true)
                    ((PictureBox)Object).Focus();
            }
            else if (Object is ComboBox)
            {
                if (((ComboBox)Object).CanFocus == true)
                    ((ComboBox)Object).Focus();
            }
            else if (Object is DataGridView)
            {
                if (((DataGridView)Object).CanFocus == true)
                    ((DataGridView)Object).Focus();
            }
            else if (Object is CheckBox)
            {
                if (((CheckBox)Object).CanFocus == true)
                    ((CheckBox)Object).Focus();
            }
        }
    }
}
