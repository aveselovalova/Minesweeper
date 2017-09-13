using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MinerFieldControlLibrary
{
    public class Draw
    {
        protected Pen DefaultPen { get; set; } = Pens.Black;
        protected Color DefaultColor { get; set; } = Color.Black;
        protected Color DefaultForeColor { get; set; } = Color.Black;
        protected Color OpenedBackColor { get; set; } = SystemColors.ControlLight;
        protected Color DefaultBackColor { get; set; } = SystemColors.ControlDark;
        protected Color DefaultPressBackColor { get; set; } = SystemColors.ControlDarkDark;
        protected Color DefaulfFlagColor { get; set; } = Color.Red;
        private static float _emSize = 10;
        protected Font DefaultFont { get; set; } = new Font("Arial", _emSize);
      
        public virtual void DrawField(Graphics gr, List<Cell> fieldCells)
        {
            foreach (var cell in fieldCells) 
            {
                gr.DrawRectangle(DefaultPen, InflateFieldRect(cell.Rectangle));
                using (var brush = new SolidBrush(!cell.IsOpened ? DefaultBackColor : OpenedBackColor))
                        gr.FillRectangle(brush, InflateFieldRect(cell.Rectangle));
                if(cell.IsPressed)
                    using (var brush = new SolidBrush(DefaultPressBackColor))
                        gr.FillRectangle(brush, InflateFieldRect(cell.Rectangle));
                DrawFlag(gr, cell);
            }
        }
        protected virtual void DrawFlag(Graphics gr, Cell cell, bool wrong = false)
        {
            if (cell.HasFlag)
            {
                using (var brush = new SolidBrush(DefaulfFlagColor))
                    gr.FillEllipse(brush, InflateCellRect(cell.Rectangle));
                if (wrong)
                    using (var pen = new Pen(DefaultColor))
                        gr.DrawLine(pen, cell.Location, new Point(cell.Location.X + cell.Size.Width, cell.Location.Y + cell.Size.Height));
            }
        }
        public virtual void DrawMines(Graphics gr, List<Cell> fieldCells)
        {
            foreach (var cell in fieldCells)
            {
                if (cell.IsMine)
                {
                    if (cell.Mine == null)
                        using (var brush = new SolidBrush(DefaultColor))
                            gr.FillEllipse(brush, InflateCellRect(cell.Rectangle));
                    else
                        gr.DrawImage(cell.Mine.Image, cell.Location);
                }
                DrawFlag(gr, cell, !cell.IsMine);


            }
        }
        public virtual void DrawDigits(Graphics gr, List<Cell> fieldCells)
        {
            foreach (var cell in fieldCells)
            {
                if(cell.Digit.Value>0 && cell.IsOpened)
                    using (var brush = new SolidBrush(cell.Digit!=null? DefaultForeColor:cell.Digit.Color))
                        gr.DrawString(cell.Digit.Value.ToString(), DefaultFont, brush, 
                                      new Point(cell.Location.X+cell.Rectangle.Width/4, cell.Location.Y));
            }
        }
        private int _bombRectangleOffset = -4;
        private Rectangle InflateCellRect(Rectangle rt)
        {
            return Rectangle.Inflate(rt, _bombRectangleOffset, _bombRectangleOffset);
        }
        private int _fieldOffset = -1;
        private Rectangle InflateFieldRect(Rectangle rt)
        {
            return Rectangle.Inflate(rt, _fieldOffset, _fieldOffset);
        }
    }
}
