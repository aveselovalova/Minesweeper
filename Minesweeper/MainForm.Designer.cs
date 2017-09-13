namespace Minesweeper
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
              
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reStartBtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.TextBox();
            this.counter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minerFieldControl1 = new MinerFieldControlLibrary.MinerFieldControl();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reStartBtn
            // 
            this.reStartBtn.Location = new System.Drawing.Point(112, 19);
            this.reStartBtn.Name = "reStartBtn";
            this.reStartBtn.Size = new System.Drawing.Size(75, 23);
            this.reStartBtn.TabIndex = 1;
            this.reStartBtn.TabStop = false;
            this.reStartBtn.Text = "reStart";
            this.reStartBtn.UseVisualStyleBackColor = true;
            this.reStartBtn.Click += new System.EventHandler(this.reStartBtn_Click);
            // 
            // timer
            // 
            this.timer.Location = new System.Drawing.Point(6, 19);
            this.timer.Name = "timer";
            this.timer.ReadOnly = true;
            this.timer.Size = new System.Drawing.Size(100, 20);
            this.timer.TabIndex = 2;
            // 
            // counter
            // 
            this.counter.Location = new System.Drawing.Point(194, 21);
            this.counter.Name = "counter";
            this.counter.ReadOnly = true;
            this.counter.Size = new System.Drawing.Size(100, 20);
            this.counter.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.counter);
            this.groupBox1.Controls.Add(this.reStartBtn);
            this.groupBox1.Controls.Add(this.timer);
            this.groupBox1.Controls.Add(this.minerFieldControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 300);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // minerFieldControl1
            // 
            this.minerFieldControl1.CellStep = 20;
            this.minerFieldControl1.Columns = 9;
            this.minerFieldControl1.Location = new System.Drawing.Point(62, 70);
            this.minerFieldControl1.MineCount = 10;
            this.minerFieldControl1.Name = "minerFieldControl1";
            this.minerFieldControl1.Rows = 9;
            this.minerFieldControl1.Size = new System.Drawing.Size(180, 180);
            this.minerFieldControl1.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 334);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Minesweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button reStartBtn;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.TextBox counter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private MinerFieldControlLibrary.MinerFieldControl minerFieldControl1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

