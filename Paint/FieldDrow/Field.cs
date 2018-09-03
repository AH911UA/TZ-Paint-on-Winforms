using MaterialSkin.Controls;
using Paint.FieldDrow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    class Field
    {
        private static FieldForm fieldDraw = null;
        private static readonly object key = new object();

        private Field() {}

        public static FieldForm GetField(Form1 parent, Bitmap bitmap = null)
        {
            lock (key)
                if (fieldDraw == null)
                {
                    fieldDraw = new FieldForm(parent)
                    {
                        Text = "New Picture",
                        WindowState = System.Windows.Forms.FormWindowState.Maximized
                    };
                    fieldDraw.BitmapProp = bitmap;
                }
            return fieldDraw;
        }

        public static void Dispose()
        {
            fieldDraw = fieldDraw != null ? null : fieldDraw;
        }
    }
}
