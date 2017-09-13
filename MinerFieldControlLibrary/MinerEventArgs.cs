using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerFieldControlLibrary
{
    public class MinerCountEventArgs : EventArgs
    {
        private int _counter;
        public MinerCountEventArgs(int counter)
        {
            _counter = counter;
        }
        public int Counter
        {
            get { return _counter; }
        }
    }
    public class MinerTimerEventArgs : EventArgs
    {
        private int _seconds;
        public MinerTimerEventArgs(int seconds)
        {
            _seconds = seconds;
        }
        public int Time
        {
            get { return _seconds; }
        }
    }
}
