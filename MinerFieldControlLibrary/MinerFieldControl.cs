using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinerFieldControlLibrary
{
    public partial class MinerFieldControl: UserControl
    {
        [Category("Miner")]
        public int Rows { get; set; }
       
        [Category("Miner")]
        public int Columns { get; set; }
        [Category("Miner")]
        public int MineCount { get; set; }
        [Category("Miner")]
        public int CellStep { get; set; }


        private const int _defaultRows = 9;
        private const int _defaultColumns = 9;
        private const int _defaultMines = 10;

        private Draw _draw;
        private List<Cell> _field;
        private FieldGeneration _fieldGeneration;

        private Timer _timer;
        private int _seconds;

        private bool _isGameStart;
        private bool _isGameOver;
        private bool _isLeftDown = false;
        private bool _isRightDown = false;

        public MinerFieldControl()
        {
            InitializeComponent();
            Initialize(_defaultRows, _defaultColumns, _defaultMines);
        }
        public virtual void GenerateField(int rows, int columns, int mines)
        {
            Initialize(rows,columns,mines);
            Invalidate();
        }
        private void Initialize(int rows, int columns, int mines)
        {
            DoubleBuffered = true;
            InnerDispose();

            Rows = rows;
            Columns = columns;
            MineCount = mines;
            CellStep = 20;
            _draw = new Draw();
            _field = new List<Cell>();
            _fieldGeneration = new FieldGeneration(_field, Rows, Columns, CellStep);

            CreateTimer();
            this.Size = new Size(Columns * _field[0].Rectangle.Width, Rows*_field[0].Rectangle.Height);
        }
        private void InnerDispose()
        {
            _isGameStart = false;
            _isGameOver = false;
            _seconds = 0;
            if (_field != null) _field.Clear();
            if (_timer != null)
            {
                _timer.Tick -= _timer_Tick;
                _timer.Dispose();
            }
        }
        private void CreateTimer()
        {
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += _timer_Tick;
            _timer.Start();
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            if(_isGameStart)
                OnTimer(++_seconds);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!_isGameStart)
            {
                OnTimer(0);
                OnCounter(MineCount);
            }
            _draw.DrawField(e.Graphics, _field);
            if(_isGameOver)
            _draw.DrawMines(e.Graphics, _field);
            _draw.DrawDigits(e.Graphics, _field);
        }
        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            var cell = _field.FirstOrDefault(c => c.Rectangle.Contains(e.Location));
            if (cell != null)
            {
                ProcessLeftRightMouse(cell);
                Invalidate();
            }
        }
    
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!_isGameOver)
            {
                var cell = _field.FirstOrDefault(c => c.Rectangle.Contains(e.Location));
                if (cell != null)
                {
                    if (!_isGameStart)
                    {
                        _fieldGeneration.GenerateMines(MineCount, e.Location);
                        _isGameStart = true;
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        _isRightDown = true;
                        ProcessRightMouse(cell);
                    }
                    if (e.Button == MouseButtons.Left)
                    {
                        ProcessLeftMouse(cell);
                        _isLeftDown = true;
                    }
                    if (_isLeftDown && _isRightDown)
                        ProcessLeftRightMouse(cell);
                    Invalidate();
                }
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button == MouseButtons.Right)
                _isRightDown = false;
            if (e.Button == MouseButtons.Left)
            {
                _isLeftDown = false;
                _field.ForEach(cell=>cell.IsPressed = false);
                Invalidate();
            }
        }
        protected virtual void ProcessRightMouse(Cell cell)
        {
            if (cell.IsOpened)
                return;
            if (MineCount > 0)
            {
                if (!cell.HasFlag)
                {
                    cell.HasFlag = true;
                    MineCount--;
                }
                else
                {
                    cell.HasFlag = false;
                    MineCount++;
                }
                OnCounter(MineCount);
            }
        }

        protected virtual void ProcessLeftMouse(Cell cell)
        {
            if (!cell.IsOpened && !cell.HasFlag)
            {

                if (cell.IsMine)
                    FinishGame("You loose!");

                if (cell.Digit.Value >= 0)
                {
                    cell.IsOpened = true;
                    CheckWins();

                    if (cell.Digit.Value == 0)
                        _fieldGeneration.GetNeighbours(cell)
                                        .FindAll(c => !c.HasFlag && !c.IsOpened && !c.IsMine)
                                        .ForEach(ProcessLeftMouse);
                    if(!_isGameOver)
                        cell.IsPressed = true;
                }

            }
        }
        protected virtual void CheckWins()
        {
            int counter = 0;
            foreach (var cell in _field)
            {
                if (cell.HasFlag && cell.IsMine)
                    counter++;
            }
            if (counter == _field.Count(c => c.IsMine))
                if (_field.FindAll(c => !c.HasFlag).All(c => c.IsOpened))
                    FinishGame("Win!\tYour time is " + _seconds);
        }
        private void FinishGame(string text)
        {
            _timer.Stop();
            MessageBox.Show(text);
            _isGameOver = true;
        }
        protected virtual void ProcessLeftRightMouse(Cell cell)
        {
            if (cell.IsOpened)
                if (cell.Digit.Value > 0)
                {
                    var neighbors = _fieldGeneration.GetNeighbours(cell).FindAll(c => !c.IsOpened);
                    if (neighbors.Count(c => c.HasFlag) == cell.Digit.Value)
                    {
                        if (!neighbors.FindAll(c => c.HasFlag).All(c => c.IsMine))
                            FinishGame("You loose!");
                        else
                            neighbors.FindAll(c => !c.IsMine).ForEach(ProcessLeftMouse);
                    }
                }
        }
        public event EventHandler<MinerCountEventArgs> Counter;
        public void OnCounter(int count)
        {
            Counter?.Invoke(this, new MinerCountEventArgs(count));
        }
        public event EventHandler<MinerTimerEventArgs> Timer;
        public void OnTimer(int seconds)
        {
            Timer?.Invoke(this, new MinerTimerEventArgs(seconds));
        }
      
    }
}
