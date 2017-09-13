using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MinerFieldControlLibrary
{
    public class FieldGeneration: FieldGenerationBase
    {
        private List<Cell> field;
        protected int cellStep;
        public FieldGeneration(List<Cell> cells, int rows, int columns, int step)
        {
            field = cells;
            cellStep = step;
            GenerateFieldCells(rows, columns);
        }
        protected override void GenerateFieldCells(int rows, int columns)
        {
            int y = 0;
            int x = 0;
            for (var row = 0; row < rows; row++)
            {
                for (var col = 0; col < columns; col++)
                {
                    field.Add(new Cell(new Point(x, y), new Size(cellStep,cellStep)));
                    x += cellStep;
                }
                y += cellStep;
                x = 0;
            }
        }
        public override void GenerateMines(int MineCount, Point hitPoint)
        {
            Random random = new Random();
            var minX = field.Min(c => c.Rectangle.X);
            var maxX = field.Max(c => c.Rectangle.X);
            var minY = field.Min(c => c.Rectangle.Y);
            var maxY = field.Max(c => c.Rectangle.Y);
            Point point;
            Cell cell;
            for (int m = 0; m < MineCount; m++)
            {
                point = new Point(random.Next(minX, maxX), random.Next(minY, maxY));
                cell = field.FirstOrDefault(c => c.Rectangle.Contains(point) 
                                            && !c.Rectangle.Contains(hitPoint));
                if (cell != null)
                    if (!cell.IsMine)
                        cell.IsMine = true;
                    else m--;
            }
            GenerateDigits();
        }
        protected override void GenerateDigits()
        {
            foreach (var cell in field)
            {
                if (!cell.IsMine)
                    cell.Digit.Value = GetNeighbourMineCount(cell);
            }
        }
        public virtual List<Cell> GetNeighbours(Cell cell)
        {
            List<Cell> neighbours = new List<Cell>();
            neighbours = field.FindAll(c => 
                        (c.Location.X == cell.Location.X - cellStep && c.Location.Y == cell.Location.Y - cellStep)
                    || (c.Location.X == cell.Location.X && c.Location.Y == cell.Location.Y - cellStep)
                    || (c.Location.X == cell.Location.X+cellStep && c.Location.Y == cell.Location.Y - cellStep)
                    || (c.Location.X == cell.Location.X-cellStep && c.Location.Y == cell.Location.Y)
                    || (c.Location.X == cell.Location.X+cellStep && c.Location.Y == cell.Location.Y)
                    || (c.Location.X == cell.Location.X && c.Location.Y == cell.Location.Y + cellStep)
                    || (c.Location.X == cell.Location.X- cellStep && c.Location.Y == cell.Location.Y + cellStep)
                    || (c.Location.X == cell.Location.X+cellStep && c.Location.Y == cell.Location.Y + cellStep)
                    );
            return neighbours;
        }

        private int GetNeighbourMineCount(Cell cell)
        {
            return GetNeighbours(cell).Count(c => c.IsMine);
        }
      
    }
 
   
}
