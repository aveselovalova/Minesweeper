using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MinerFieldControlLibrary
{
    public abstract class CellBase
    {
        public CellBase(Point point, Size size)
        {
            Location = point;
            Size = size;
            Rectangle = new Rectangle(Location, Size);
        }
        public virtual Size Size { get; set; }
        public virtual Rectangle Rectangle { get; set; }
        public virtual Point Location { get; set; }
    }
}
