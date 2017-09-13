using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MinerFieldControlLibrary
{
    public class Digit
    {
        public Color Color { get; set; }
        public int Value { get; set; }
        public Digit()
        {
            Color = Color.Black;
            Value = 0;
        }
        public Digit(Color color, int value)
        {
            Color = color;
            Value = value;
        }
    }
}
