using MaterialSkin;
using MaterialSkin.Controls;
using Paint.FieldDrow;
using Paint.WorkFiles;
using System;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : MaterialForm
    {
        #region Local variables
        /// <summary>
        /// Field for drawing
        /// </summary>
        private FieldForm fieldDraw;
        private float thickness;
        private bool isFill;
        #endregion

        #region Customer events
        /// <summary>
        /// Choice of action 
        /// </summary>
        /// <param name="cea"> Data transfer </param>
        public delegate void ChoiceDelegate(ChoiceEventArgs cea);
        public event ChoiceDelegate ChoiceEvent;

        public delegate void ClearFieldDelegate();
        public event ClearFieldDelegate ClearEvent;

        public delegate void InvertPictureDelegate();
        public event InvertPictureDelegate InvertEvent;
        #endregion

        #region Standart form event
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var skinMaterial = MaterialSkinManager.Instance;
            skinMaterial.AddFormToManage(this);
            skinMaterial.Theme = MaterialSkinManager.Themes.DARK;
            skinMaterial.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.LightBlue300, Accent.LightBlue200, TextShade.WHITE);

            this.IsMdiContainer = true;
            this.thickness = float.Parse(tsbThickness.Text);
            isFill = false;

            LockLeftMenu();
        }
        #endregion

        #region Menus
        /// <summary>
        /// Top menu
        /// </summary>
        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem topMenuItem)) return;

            switch (topMenuItem.Name)
            {
                case "newFile":
                    if (fieldDraw != null)
                        Field.Dispose();

                    FileOperations.NewFile(this, out fieldDraw);

                    LockLeftMenu();
                    fieldDraw.FormClosed += Ff_FormClosed;
                    break;

                case "openFile":
                    fieldDraw = FileOperations.OpenFile(this);
                    if (fieldDraw == null) return;

                    LockLeftMenu();
                    fieldDraw.FormClosed += Ff_FormClosed;
                    break;

                case "saveFile":
                    FileOperations.SaveFile(ref fieldDraw);
                    break;

                case "clearField":
                    ClearEvent?.Invoke();
                    break;

                case "invertPic":
                    InvertEvent?.Invoke();

                    break;

                case "aboutAs":
                    MessageBox.Show("The young programmer.\nWho wants to work for you.\nThank you for verified TZ.\n" +
                            "Aleksandr Hryhorenko 03.09.2018", "About Me )");
                    break;
            }
        }
        /// <summary>
        /// Left Menu
        /// </summary>
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripButton tsb)) return;

            switch (tsb.Name)
            {
                case "tsbPen":
                    ChoiceEvent?.Invoke(new ChoiceEventArgs(Components.pencil));
                    break;

                case "tsbLine":
                    ChoiceEvent?.Invoke(new ChoiceEventArgs(Components.line));
                    break;

                case "tsbCircle":
                    ChoiceEvent?.Invoke(new ChoiceEventArgs(Components.circle));
                    break;

                case "tsbRectangle":
                    ChoiceEvent?.Invoke(new ChoiceEventArgs(Components.rectangle));
                    break;

                case "tsbThickness":
                    if (fontDialog.ShowDialog() != DialogResult.OK ||
                        this.tsbThickness.Text == fontDialog.Font.Size.ToString()) return;

                    this.tsbThickness.Text = fontDialog.Font.Size.ToString();
                    ChoiceEvent?.Invoke(new ChoiceEventArgs(Components.width, fontDialog.Font.Size));
                    break;

                case "tsbColor":
                    if (colorDialog.ShowDialog() != DialogResult.OK ||
                        tsbColor.ForeColor == colorDialog.Color) return;

                    tsbColor.ForeColor = colorDialog.Color;
                    ChoiceEvent?.Invoke(new ChoiceEventArgs(Components.color, colorDialog.Color));
                    break;

                case "tsbFill":
                    isFill = !isFill;
                    ChoiceEvent?.Invoke(new ChoiceEventArgs(Components.fill));
                    break;
            }
        }
        private void LockLeftMenu()
        {
            leftMenu.Enabled = fieldDraw != null;
        }
        #endregion

        /// <summary>
        /// To close the drawing field
        /// </summary>
        private void Ff_FormClosed(object sender, FormClosedEventArgs e)
        {
            Field.Dispose();
            LockLeftMenu();
        }

        private void notifyIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = WindowState == FormWindowState.Minimized ?
                FormWindowState.Normal : FormWindowState.Minimized;
        }
    }
}
