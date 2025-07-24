using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Objects.Enumerator;

namespace Objects
{
    public sealed class Look
    {
        public string User { get; set; }
        public DataTables Configuration { get; set; }

        public Look()
        {
        }

        public Look(string user, DataTables configuration)
        {
            User = user.ToUpper();
            Configuration = configuration;
        }

        private static List<Control> Components(Control Component)
        {
            var Result = new List<Control>();

            foreach (Control Detail in Component.Controls)
            {
                if (String.IsNullOrEmpty(Detail.Name) == false)
                {
                    Result.AddRange(Components(Detail));
                    Result.Add(Detail);
                }
            }

            return Result;
        }

        private static object ObjectType(string ObjectName)
        {
            object Result = null;

            ObjectName = ObjectName.Trim().ToUpper();
            if (ObjectName == "Panel".ToUpper())
                Result = new Panel();
            else if (ObjectName == "TabControl".ToUpper())
                Result = new TabControl();
            else if (ObjectName == "Button".ToUpper())
                Result = new Button();
            else if (ObjectName == "Label".ToUpper())
                Result = new Label();
            else if (ObjectName == "TextBox".ToUpper())
                Result = new TextBox();
            else if (ObjectName == "MaskedTextBox".ToUpper())
                Result = new MaskedTextBox();
            else if (ObjectName == "RichTextBox".ToUpper())
                Result = new RichTextBox();
            else if (ObjectName == "NumericUpDown".ToUpper())
                Result = new NumericUpDown();
            else if (ObjectName == "DataGridView".ToUpper())
                Result = new DataGridView();

            return Result;
        }

        private static BorderStyle ControlBorderStyle(BorderStyle Style, string Config)
        {
            BorderStyle Result = Style;

            if (Config.ToUpper() == "Fixed3D".ToUpper())
                Result = BorderStyle.Fixed3D;
            else if (Config.ToUpper() == "FixedSingle".ToUpper())
                Result = BorderStyle.FixedSingle;

            return Result;
        }

        private static IEnumerable<Control> FilterControlType<T>(List<Control> FormComponents) where T : Control
        {
            var Result = from Component in FormComponents
                         where (Component.GetType() == typeof(T))
                         select Component;

            return Result;
        }

        private static IEnumerable<Control> FilterControlType<T>(List<Control> FormComponents, string ObjectName) where T : Control
        {
            IEnumerable<Control> Result = null;

            ObjectName = ObjectName.Trim().ToUpper();
            if (ObjectName == "Panel".ToUpper())
                Result = FilterControlType<Panel>(FormComponents);
            else if (ObjectName == "TabControl".ToUpper())
                Result = FilterControlType<TabControl>(FormComponents);
            else if (ObjectName == "Button".ToUpper())
                Result = FilterControlType<Button>(FormComponents);
            else if (ObjectName == "Label".ToUpper())
                Result = FilterControlType<Label>(FormComponents);
            else if (ObjectName == "TextBox".ToUpper())
                Result = FilterControlType<TextBox>(FormComponents);
            else if (ObjectName == "MaskedTextBox".ToUpper())
                Result = FilterControlType<MaskedTextBox>(FormComponents);
            else if (ObjectName == "RichTextBox".ToUpper())
                Result = FilterControlType<RichTextBox>(FormComponents);
            else if (ObjectName == "NumericUpDown".ToUpper())
                Result = FilterControlType<NumericUpDown>(FormComponents);
            else if (ObjectName == "DataGridView".ToUpper())
                Result = FilterControlType<DataGridView>(FormComponents);

            return Result;
        }

        private void ImageButton(Form FormControls, ImageList ImagesList)
        {
            List<Control> FormComponents = Components(FormControls);
            ImageButton(FormControls, ImagesList);
        }

        private void ImageButton(List<Control> FormControls, ImageList ImagesList)
        {
            string ButtonImageAlign = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "BUTTON_IMAGE_ALIGN".ToUpper())),
                   ButtonTextAlign = Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "BUTTON_TEXT_ALIGN".ToUpper())),
                   Complement;

            IEnumerable<Control> FilterControl = FilterControlType<Button>(FormControls);
            foreach (Control Component in FilterControl)
            {
                if (Component.Enabled == true)
                    Complement = "+";
                else
                    Complement = "-";

                if (Component.Name.ToUpper() == "BtnIUD".ToUpper())
                {
                    if (Component.Text.Replace("&", "").Substring(0, 1) == "I")
                        ((Button)Component).Image = ImagesList.Images[String.Concat("Insert", Complement)];
                    else if (Component.Text.Replace("&", "").Substring(0, 1) == "U")
                        ((Button)Component).Image = ImagesList.Images[String.Concat("Update", Complement)];
                    else if (Component.Text.Replace("&", "").Substring(0, 1) == "D")
                        ((Button)Component).Image = ImagesList.Images[String.Concat("Delete", Complement)];
                }
                else
                    ((Button)Component).Image = ImagesList.Images[String.Concat(Component.Name.Substring(3), Complement)];

                if (String.IsNullOrEmpty(ButtonImageAlign) == false)
                {
                    ((Button)Component).ImageAlign = ObjectTypeEnum.ImageAlignType(ButtonImageAlign);
                    ((Button)Component).TextAlign = ObjectTypeEnum.TextAlignType(ButtonTextAlign);
                }
            }
        }

        public void Form(Form FormControls, ImageList ImagesList, ToolTip Tip)
        {
            List<Control> FormComponents = Components(FormControls);
            IEnumerable<Control> FilterControl = null;
            string ControlNameCurrent = "";
            DataRow Line = null;

            FormControls.FormBorderStyle = FormBorderStyle.FixedSingle;

            ImageButton(FormComponents, ImagesList);

            if (FormControls.Name.ToUpper() == "MainF".ToUpper())
            {
                PictureBox PcBImage = ((PictureBox)FormControls.Controls["PcBImage"]);

                if (PcBImage != null)
                {
                    if (Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_DOCK")).ToUpper() == "None".ToUpper())
                    {
                        PcBImage.Dock = DockStyle.None;

                        if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_TOP")) == true)
                            PcBImage.Top = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_TOP".ToUpper())));

                        if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_LEFT")) == true)
                            PcBImage.Left = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_LEFT".ToUpper())));

                        if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_HEIGHT")) == true)
                            PcBImage.Height = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_HEIGHT".ToUpper())));

                        if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_WIDTH")) == true)
                            PcBImage.Width = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "MAIN_FORM_IMAGE_WIDTH".ToUpper())));
                    }
                }
            }

            if (Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "CONTEXTMENUSTRIP".ToUpper())) != "Y")
                FormControls.ContextMenuStrip = null;

            if (Tip != null)
            {
                if (Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP".ToUpper())) == "Y")
                {
                    Tip.Active = true;

                    if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_AUTOMATICDELAY")) == true)
                        Tip.AutomaticDelay = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_AUTOMATICDELAY".ToUpper())));

                    if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_AUTOPOPDELAY")) == true)
                        Tip.AutoPopDelay = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_AUTOPOPDELAY".ToUpper())));

                    if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_INITIALDELAY")) == true)
                        Tip.InitialDelay = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_INITIALDELAY".ToUpper())));

                    if (Configuration.TableCommand.Find(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_RESHOWDELAY")) == true)
                        Tip.ReshowDelay = Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "TOOLTIP_RESHOWDELAY".ToUpper())));
                }
                else
                    Tip.Active = false;
            }

            foreach (DataRow row in Configuration.TableConfig.Rows)
            {
                if (ControlNameCurrent != row["ControlName"].ToString())
                {
                    ControlNameCurrent = row["ControlName"].ToString();
                    FilterControl = FilterControlType<Button>(FormComponents, row["ControlName"].ToString());
                }

                if (FilterControl != null)
                {
                    foreach (Control Component in FilterControl)
                    {
                        if (Configuration.TableControl != null)
                            Line = Configuration.TableCommand.Posicion(Configuration.TableControl, ((Control)Component).Name.Substring(3).ToUpper());

                        if (Component is TextBox)
                        {
                            ((TextBox)Component).BorderStyle = ControlBorderStyle(((TextBox)Component).BorderStyle, row["Value"].ToString());

                            if (Line != null)
                            {
                                if (String.IsNullOrEmpty(Line["FieldLength"].ToString()) == false)
                                {
                                    if (String.IsNullOrEmpty(Line["Precision"].ToString()) == true)
                                        ((TextBox)Component).MaxLength = Convert.ToInt32(Line["FieldLength"]);
                                    else
                                    {
                                        if (Convert.ToInt32(Line["FieldLength"]) >= Convert.ToInt32(Line["Precision"]))
                                            ((TextBox)Component).MaxLength = Convert.ToInt32(Line["FieldLength"]);
                                        else
                                            ((TextBox)Component).MaxLength = Convert.ToInt32(Line["Precision"]);
                                    }
                                }

                                if ((Line["Type"].ToString().ToUpper() == "int".ToUpper()) ||
                                    (Line["Type"].ToString().ToUpper() == "Decimal".ToUpper()))
                                {
                                    ((TextBox)Component).AccessibleDescription = String.Concat(Line["Precision"].ToString(), ",", Line["Scale"].ToString());
                                    ((TextBox)Component).Enter += new EventHandler(Numbers.EnterKey);
                                    ((TextBox)Component).KeyDown += new KeyEventHandler(Numbers.NumbersKeyDown);
                                    ((TextBox)Component).KeyPress += new KeyPressEventHandler(Numbers.NumbersKeyPress);
                                }
                            }
                        }
                        else if (Component is MaskedTextBox)
                        {
                            ((MaskedTextBox)Component).BorderStyle = ControlBorderStyle(((MaskedTextBox)Component).BorderStyle, row["Value"].ToString());

                            if (((MaskedTextBox)Component).Mask == "00/00/0000")
                                ((MaskedTextBox)Component).Text = Convert.ToString(DateTime.Now.Date.AddDays(+Convert.ToInt32(Configuration.TableCommand.UniqueValue(Configuration.TableConfig, String.Concat(User, "|", "CALENDAR_DAYS".ToUpper())))));
                        }
                        else if (Component is RichTextBox)
                            ((RichTextBox)Component).BorderStyle = ControlBorderStyle(((RichTextBox)Component).BorderStyle, row["Value"].ToString());
                        else if (Component is PictureBox)
                            ((PictureBox)Component).BorderStyle = ControlBorderStyle(((PictureBox)Component).BorderStyle, row["Value"].ToString());
                        else if (Component is NumericUpDown)
                        {
                            ((NumericUpDown)Component).BorderStyle = ControlBorderStyle(((NumericUpDown)Component).BorderStyle, row["Value"].ToString());

                            if (Component.Name.Substring(0, "NUDMny".Length).ToUpper() == "NUDMny".ToUpper())
                            {
                                if ((row["User"].ToString() == "ALL") && (row["Key"].ToString() == "NUMERICUPDOWN_DECIMALPLACES_MONEY"))
                                {
                                    ((NumericUpDown)Component).DecimalPlaces = Convert.ToInt32(row["Value"].ToString());
                                    ((NumericUpDown)Component).Increment = Convert.ToDecimal(String.Concat("0,", "".PadRight(((NumericUpDown)Component).DecimalPlaces - 1, '0'), "1"));
                                }
                            }
                            else if (Component.Name.Substring(0, "NUDAmo".Length).ToUpper() == "NUDAmo".ToUpper())
                            {
                                if ((row["User"].ToString() == "ALL") && (row["Key"].ToString() == "NUMERICUPDOWN_DECIMALPLACES_AMOUNT"))
                                {
                                    ((NumericUpDown)Component).DecimalPlaces = Convert.ToInt32(row["Value"].ToString());
                                    ((NumericUpDown)Component).Increment = Convert.ToDecimal(String.Concat("0,", "".PadRight(((NumericUpDown)Component).DecimalPlaces - 1, '0'), "1"));
                                }
                            }
                            else if (Component.Name.Substring(0, "NUDAmo".Length).ToUpper() == "NUDCry".ToUpper())
                            {
                                if ((row["User"].ToString() == "ALL") && (row["Key"].ToString() == "NUMERICUPDOWN_DECIMALPLACES_CRYPTOCURRENCY"))
                                {
                                    ((NumericUpDown)Component).DecimalPlaces = Convert.ToInt32(row["Value"].ToString());
                                    ((NumericUpDown)Component).Increment = Convert.ToDecimal(String.Concat("0,", "".PadRight(((NumericUpDown)Component).DecimalPlaces - 1, '0'), "1"));
                                }
                            }
                        }
                        else if (Component is CheckedListBox)
                            ((CheckedListBox)Component).BorderStyle = ControlBorderStyle(((CheckedListBox)Component).BorderStyle, row["Value"].ToString());
                        else if (Component is Label)
                            ((Label)Component).BorderStyle = ControlBorderStyle(((Label)Component).BorderStyle, row["Value"].ToString());
                        else if (Component is LinkLabel)
                            ((LinkLabel)Component).BorderStyle = ControlBorderStyle(((LinkLabel)Component).BorderStyle, row["Value"].ToString());
                        else if (Component is ListBox)
                            ((ListBox)Component).BorderStyle = ControlBorderStyle(((ListBox)Component).BorderStyle, row["Value"].ToString());
                    }
                }
            }
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

        public string CheckBoxValue(CheckBox Object)
        {
            string Result = "";
            string[] Values = new string[0];
            Values = Matrix.Config(";", Object.Tag.ToString());

            if (Object.Checked == true)
                Result = Values[0];
            else
                Result = Values[1];

            return Result;
        }

        public void CheckBoxCheck(CheckBox Object, string Value)
        {
            string[] Values = new string[0];
            Values = Matrix.Config(";", Object.Tag.ToString());

            if (Value == Values[0])
                Object.CheckState = CheckState.Checked;
            else if (Value == Values[1])
                Object.CheckState = CheckState.Unchecked;
            else
                Object.CheckState = CheckState.Indeterminate;
        }

        public string RadioButtonValue(GroupBox Object)
        {
            string Result = "";

            foreach (Control control in Object.Controls)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Checked == true)
                    {
                        Result = ((RadioButton)control).Tag.ToString();
                        break;
                    }
                }
            }

            return Result;
        }

        public void RadioButtonCheck(GroupBox Object, string Value)
        {
            foreach (Control control in Object.Controls)
            {
                if (control is RadioButton)
                {
                    if (((RadioButton)control).Tag.ToString() == Value)
                    {
                        ((RadioButton)control).Checked = true;
                        break;
                    }
                }
            }
        }
    }
}
