using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerFieldControlLibrary
{
    public interface ICell
    {
        bool HasFlag { get; set; }
        bool IsOpened { get; set; }
        bool IsMine { get; set; }
        bool IsPressed { get; set; }

    }
}
