using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.WorkColor;

namespace Paint.FieldDrow
{
    public partial class FieldForm : Form
    {
        #region Local variables
        Form1 parent;

        private Graphics graphics;

        private Bitmap bitmap;
        public  Bitmap BitmapProp
        {
            get { return bitmap; }
            set { bitmap = value; }
        }

        private Pen pen;
        private Components action;

        private float thickness;
        private Color color;

        private Point pointStart;
        private Point pointEnd;

        private bool IsPressing;
        #endregion

        #region Standart form event
        public FieldForm()
        {
            InitializeComponent();

            this.Load        += FieldForm_Load;
            this.FormClosing += FieldForm_FormClosing;

            progressBar.Visible = false;
            IsPressing          = false;
            color               = Color.Black;
            thickness           = 7;
        }
        public FieldForm(Form1 parent) : this()
        {
            this.parent         = parent;
            this.Width          = parent.Width;
            this.Height         = parent.Height;
            this.Paint          += FieldForm_Paint;
            parent.ChoiceEvent  += Parent_ChoiceEvent;
            parent.ClearEvent   += Parent_ClearEvent;
            parent.InvertEvent  += Parent_InvertEvent;
        }

        private void FieldForm_Load(object sender, EventArgs e)
        {
            picture.MouseMove += Field_MouseMove;
            picture.MouseDown += Field_MouseDown;
            picture.MouseUp   += Field_MouseUp;
            InvertColor.ProgressEvent += InvertColor_ProgressEvent;

            this.pointStart = new Point();
            this.pointEnd   = new Point();

            pen = new Pen(color, thickness);

            if (bitmap == null)
                bitmap = new Bitmap(picture.Width, picture.Height);

            Task loadPicture  = Task.Run(() => 
            {
                picture.Image = bitmap;
            });
        }

        private void FieldForm_Paint(object sender, PaintEventArgs e)
        {
            if (graphics != null) return;

            try
            {
                graphics = Graphics.FromImage(bitmap);
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            }
            catch { MessageBox.Show("Problems with this file"); }
        }
        private void FieldForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.ChoiceEvent -= Parent_ChoiceEvent;
            this.Dispose();
            Field.Dispose();
        }
        #endregion

        #region Mouse Event

        #region Draw figure
        private void Field_MouseUp(object sender, MouseEventArgs e)
        {
            IsPressing = false;

            switch (action)
            {
                case Components.line:
                    new Figure.Line(ref bitmap, ref pen, ref pointEnd);
                    picture.Image = bitmap;
                    break;
                case Components.circle:
                    new Figure.Circle(ref bitmap, ref pen, ref pointEnd);
                    picture.Image = bitmap;
                    break;
                case Components.rectangle:
                    new Figure.Rectangle(ref bitmap, ref pen, ref pointEnd);
                    picture.Image = bitmap; // именно повторяется 3 раза, для избегания ощибки при работе в втором потоке
                    break;
            }
        }

        private void DrawPencil()
        {
            if (IsPressing)
            {
                graphics.DrawLine(pen, pointStart.X, pointStart.Y, pointEnd.X, pointEnd.Y);
                picture.Image = bitmap;
            }
        }
        #endregion


        private void Field_MouseDown(object sender, MouseEventArgs e)
        {
            pointStart = e.Location;
            if (!IsPressing)
                Shape.PointStart = pointStart;

            IsPressing = true;
        }

        private void Field_MouseMove(object sender, MouseEventArgs e)
        {
            pointEnd = pointStart;
            pointStart = e.Location;

            if (action == Components.pencil)
                DrawPencil();
        }
        #endregion

        #region Parents Event    
        private void Parent_ChoiceEvent(ChoiceEventArgs cea)
        {
            this.action = cea.Choice;

            switch (cea.Choice)
            {
                case Components.width:
                    thickness = thickness == cea.Thickness ? thickness : cea.Thickness;

                    if (pen == null)
                        pen = new Pen(color, thickness);
                    else pen.Width = cea.Thickness;
                    break;

                case Components.color:
                    color = color == cea.ColorP ? color : cea.ColorP;

                    if (pen == null)
                        pen = new Pen(color, thickness);
                    else pen.Color = cea.ColorP;
                    break;

                case Components.fill:
                    Shape.IsFill = !Shape.IsFill;
                    break;
            }
        }

        private void Parent_ClearEvent()
        {
            graphics.Clear(Color.WhiteSmoke);
            
            this.picture.Image = bitmap;
        }

        private void Parent_InvertEvent()
        {
            Task taskInvert = Task.Run(() => 
            {
                bitmap = InvertColor.Invert(bitmap);
                graphics = Graphics.FromImage(bitmap);
                picture.Image = bitmap;
            });
        }
        #endregion

        /// <summary>
        /// Invert picture
        /// </summary>
        /// <param name="percent"> Percentage of completion </param>
        private void InvertColor_ProgressEvent(int percent)
        {
            if (InvokeRequired)
                this.BeginInvoke(new Action(() =>
                {
                    if (progressBar.Visible == false)
                    {
                        progressBar.Visible = true;
                        progressBar.Show();
                    }
                    else
                    {
                        progressBar.Value = percent;
                    }

                    if (progressBar.Value == 100)
                    {
                        progressBar.Visible = false;
                        progressBar.Value = 0;
                    }
                }));
        }

        #region Short Methods
        private void InitImage() { picture.Image = bitmap; }
        #endregion
    }
}
