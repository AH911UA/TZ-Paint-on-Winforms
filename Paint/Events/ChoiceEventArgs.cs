using System;
using System.Drawing;

namespace Paint
{
    public enum Components
    {
        width,
        pencil,
        line,
        circle,
        rectangle,
        color,
        fill
    }

    public class ChoiceEventArgs : EventArgs
    {
        public Components Choice { get; set; }
        public float Thickness { get; set; }
        public Color ColorP { get; set; }
    
        public ChoiceEventArgs(Components choice, float thickness = 7, bool fill = false)
        {
            this.Choice = choice;
            this.Thickness = thickness;

            if(this.ColorP == null)
                this.ColorP = Color.Black;
        }
        public ChoiceEventArgs(Components choice, Color color)
        {
            this.ColorP = color;
            this.Choice = choice;
        }
        public ChoiceEventArgs(Components choice)
        {
            this.Choice = choice;
        }
    }
}
