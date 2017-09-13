using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MainForm : Form
    {
        private const int _defaultSize = 300;
        private int _step = 20;
        private int _fieldOffset = 20;
        private const int _beginnerLength = 9;
        private const int _middleLength = 16;
        private const int _expertWidth = 30;
        private const int _beginnerMines = 10;
        private const int _intermMines = 40;
        private const int _expertMines = 99;
        Dictionary<string, List<int>> levelsDictionary;
        List<int> chosenLevel;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            minerFieldControl1.Counter += MinerFieldControl1_Counter;
            minerFieldControl1.Timer += MinerFieldControl1_Timer;
            levelsDictionary = new Dictionary<string, List<int>>();
            chosenLevel = new List<int>() { _beginnerLength, _beginnerLength, _beginnerMines };
            FillDicrionary();
        }
        private void FillDicrionary()
        {
            levelsDictionary.Add("Beginner", chosenLevel);
            levelsDictionary.Add("Intermediate", new List<int>() { _middleLength, _middleLength, _intermMines});
            levelsDictionary.Add("Expert", new List<int>() { _middleLength, _expertWidth, _expertMines});
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            minerFieldControl1.Counter -= MinerFieldControl1_Counter;
            minerFieldControl1.Timer -= MinerFieldControl1_Timer;
        }
        private void MinerFieldControl1_Timer(object sender, MinerFieldControlLibrary.MinerTimerEventArgs e)
        {
            timer.Text = e.Time.ToString();
        }

        private void MinerFieldControl1_Counter(object sender, MinerFieldControlLibrary.MinerCountEventArgs e)
        {
            counter.Text = e.Counter.ToString();
        }

        private void reStartBtn_Click(object sender, EventArgs e)
        {
            minerFieldControl1.GenerateField(chosenLevel[0], chosenLevel[1], chosenLevel[2]);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSettingForm();
        }
        private void ShowSettingForm()
        {
            var subForm = new SettingsForm();
            subForm.ShowDialog();

            GroupBox groupBox = subForm.Controls.Cast<GroupBox>().FirstOrDefault();
            if (groupBox != null)
                FindLevel(groupBox.Controls);
        }
        private void FindLevel(Control.ControlCollection controls)
        {
            foreach (var control in controls)
            {
                var rb = control as MyRadioButton;
                if (rb != null)
                    if (rb.Checked)
                    {
                        Point location = new Point(timer.Bounds.X, timer.Bounds.Y + timer.Height * 2);

                        if (rb.LevelState == Levels.Special)
                        {
                            SetSpetialFieldSettings(controls, location);
                        }
                        else SetFieldSettings(rb.LevelState, location);
                        break;
                    }
            }
        }
       private void SetSpetialFieldSettings(Control.ControlCollection controls, Point point)
        {
            int rows = _beginnerLength;
            int columns = _beginnerLength;
            int mines = _beginnerMines;

            foreach (var control in controls)
            {
                var numericUpDown = control as NumericUpDown;
                if (numericUpDown != null)
                {
                    rows = GetNumericUpDownValue(numericUpDown, "row");
                    columns = GetNumericUpDownValue(numericUpDown, "col");
                    mines = GetNumericUpDownValue(numericUpDown, "mine");
                }
            }
            if(IsValidValues(rows, columns, mines))
                chosenLevel = new List<int>() { rows, columns, mines };
            RepaintField(chosenLevel[0], chosenLevel[1], chosenLevel[2], point);
        }
        private bool IsValidValues(int rows, int columns, int mines)
        {
            return rows >= _beginnerLength && columns >= _beginnerLength && mines >= _beginnerMines;
        }
        private int GetNumericUpDownValue(NumericUpDown numericUpDown, string namePart)
        {
            if(numericUpDown.Name.Contains(namePart))
                return (int)numericUpDown.Value;
            return 0;

        }
        private void SetFieldSettings(Levels level, Point point)
        {
            switch (level)
            {
                case Levels.Beginner:
                    RepaintField("Beginner", point);
                    break;
                case Levels.Intermediate:
                    RepaintField("Intermediate", point);
                    break;
                case Levels.Expert:
                    RepaintField("Expert", point);
                    break;
            }
        }
     
        private void RepaintField(int rows, int columns, int mines, Point location)
        {
            minerFieldControl1.Location = location;
            minerFieldControl1.GenerateField(rows, columns, mines);
        }
        private void RepaintField(string levelName, Point location)
        {
            minerFieldControl1.Location = location;
            chosenLevel = levelsDictionary[levelName];
            minerFieldControl1.GenerateField(chosenLevel[0], chosenLevel[1], chosenLevel[2]);
            FieldResize();
        }
        private void FieldResize()
        {
            groupBox1.Size = new Size((chosenLevel[1] * _step) < _defaultSize ? _defaultSize : (chosenLevel[1] * _step + _fieldOffset),
              (chosenLevel[0] * _step) < _defaultSize ? _defaultSize : (chosenLevel[0] * _step + (_fieldOffset * 4)));
            this.Size = new Size(groupBox1.Width + (_fieldOffset * 2), groupBox1.Height + (_fieldOffset * 4));

        }

    }
}
