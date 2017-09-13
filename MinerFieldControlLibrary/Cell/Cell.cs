using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MinerFieldControlLibrary
{
    public class Cell: CellBase, ICell
    {
        public Cell(Point point, Size size):base(point, size)
        {
            Digit = new Digit();
        }
        public bool HasFlag { get; set; }
        public bool IsOpened { get; set; }
        public bool IsPressed { get; set; }

        private bool _isMine;
        public bool IsMine
        {
            get { return _isMine; }
            set
            {
                _isMine = value;
                //if (value)
                //    this.Mine = new SimpleMine((Image)(new Bitmap(Image.FromFile("bomb.png"), 
                //                                                    this.Rectangle.Size)));
            }
        }
     
        public Digit Digit { get; set; }
        public SimpleMine Mine { get; set; }
    }
  
  
}
