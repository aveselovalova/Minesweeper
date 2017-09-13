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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            specialRB.CheckedChanged += SpecialRB_CheckedChanged;
        }
        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            specialRB.CheckedChanged -= SpecialRB_CheckedChanged;
            okBtn.Click-= okBtn_Click;
        }
        private void SpecialRB_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
                SetNumericUpDownReadOnly(false);
            else
                SetNumericUpDownReadOnly(true);

        }
        private void SetNumericUpDownReadOnly(bool state)
        {
            minesNumericUpD.ReadOnly = state;
            rowsNumericUpD.ReadOnly = state;
            colNumericUpD.ReadOnly = state;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
