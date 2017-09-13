using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MinerFieldControlLibrary
{
    public abstract class FieldGenerationBase : IFieldGeneration
    {
        protected abstract void GenerateFieldCells(int rows, int columns);
        public abstract void GenerateMines(int MineCount, Point hitPoint);
        protected abstract void GenerateDigits();
    }
}
