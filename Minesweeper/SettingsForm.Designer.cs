namespace Minesweeper
{
    partial class SettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.minesNumericUpD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.colNumericUpD = new System.Windows.Forms.NumericUpDown();
            this.rowsNumericUpD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.specialRB = new Minesweeper.MyRadioButton();
            this.expertRB = new Minesweeper.MyRadioButton();
            this.intermediateRB = new Minesweeper.MyRadioButton();
            this.beginnerRB = new Minesweeper.MyRadioButton();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minesNumericUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNumericUpD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okBtn);
            this.groupBox1.Controls.Add(this.specialRB);
            this.groupBox1.Controls.Add(this.expertRB);
            this.groupBox1.Controls.Add(this.intermediateRB);
            this.groupBox1.Controls.Add(this.beginnerRB);
            this.groupBox1.Controls.Add(this.minesNumericUpD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.colNumericUpD);
            this.groupBox1.Controls.Add(this.rowsNumericUpD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // minesNumericUpD
            // 
            this.minesNumericUpD.Location = new System.Drawing.Point(87, 168);
            this.minesNumericUpD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.minesNumericUpD.Name = "minesNumericUpD";
            this.minesNumericUpD.ReadOnly = true;
            this.minesNumericUpD.Size = new System.Drawing.Size(89, 20);
            this.minesNumericUpD.TabIndex = 10;
            this.minesNumericUpD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mines:";
            // 
            // colNumericUpD
            // 
            this.colNumericUpD.Location = new System.Drawing.Point(87, 139);
            this.colNumericUpD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.colNumericUpD.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.colNumericUpD.Name = "colNumericUpD";
            this.colNumericUpD.ReadOnly = true;
            this.colNumericUpD.Size = new System.Drawing.Size(89, 20);
            this.colNumericUpD.TabIndex = 8;
            this.colNumericUpD.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // rowsNumericUpD
            // 
            this.rowsNumericUpD.Location = new System.Drawing.Point(87, 113);
            this.rowsNumericUpD.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.rowsNumericUpD.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.rowsNumericUpD.Name = "rowsNumericUpD";
            this.rowsNumericUpD.ReadOnly = true;
            this.rowsNumericUpD.Size = new System.Drawing.Size(89, 20);
            this.rowsNumericUpD.TabIndex = 7;
            this.rowsNumericUpD.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columns:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rows:";
            // 
            // specialRB
            // 
            this.specialRB.AutoSize = true;
            this.specialRB.LevelState = Minesweeper.Levels.Special;
            this.specialRB.Location = new System.Drawing.Point(6, 88);
            this.specialRB.Name = "specialRB";
            this.specialRB.Size = new System.Drawing.Size(60, 17);
            this.specialRB.TabIndex = 14;
            this.specialRB.Text = "Special";
            this.specialRB.UseVisualStyleBackColor = true;
            // 
            // expertRB
            // 
            this.expertRB.AutoSize = true;
            this.expertRB.LevelState = Minesweeper.Levels.Expert;
            this.expertRB.Location = new System.Drawing.Point(6, 65);
            this.expertRB.Name = "expertRB";
            this.expertRB.Size = new System.Drawing.Size(93, 17);
            this.expertRB.TabIndex = 13;
            this.expertRB.Text = "Expert (16x30)";
            this.expertRB.UseVisualStyleBackColor = true;
            // 
            // intermediateRB
            // 
            this.intermediateRB.AutoSize = true;
            this.intermediateRB.LevelState = Minesweeper.Levels.Intermediate;
            this.intermediateRB.Location = new System.Drawing.Point(6, 42);
            this.intermediateRB.Name = "intermediateRB";
            this.intermediateRB.Size = new System.Drawing.Size(121, 17);
            this.intermediateRB.TabIndex = 12;
            this.intermediateRB.Text = "Intermediate (16x16)";
            this.intermediateRB.UseVisualStyleBackColor = true;
            // 
            // beginnerRB
            // 
            this.beginnerRB.AutoSize = true;
            this.beginnerRB.Checked = true;
            this.beginnerRB.LevelState = Minesweeper.Levels.Beginner;
            this.beginnerRB.Location = new System.Drawing.Point(6, 19);
            this.beginnerRB.Name = "beginnerRB";
            this.beginnerRB.Size = new System.Drawing.Size(93, 17);
            this.beginnerRB.TabIndex = 11;
            this.beginnerRB.TabStop = true;
            this.beginnerRB.Text = "Beginner (9x9)";
            this.beginnerRB.UseVisualStyleBackColor = true;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(26, 219);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(150, 23);
            this.okBtn.TabIndex = 15;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 283);
            this.Controls.Add(this.groupBox1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minesNumericUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNumericUpD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumericUpD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown minesNumericUpD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown colNumericUpD;
        private System.Windows.Forms.NumericUpDown rowsNumericUpD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MyRadioButton expertRB;
        private MyRadioButton intermediateRB;
        private MyRadioButton beginnerRB;
        private MyRadioButton specialRB;
        private System.Windows.Forms.Button okBtn;
    }
}