using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MinerFieldControlLibrary
{
    public class SimpleMine : IMineType
    {
        public SimpleMine(Image image)
        {
            Image = image;
        }
        public Image Image { get; private set; }
        public string Caption { get; set; }

    }
}
