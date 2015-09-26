namespace Bowling {
    partial class ScoreForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ToolStripMenuItem dropdownFile;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreForm));
            this.menuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.frame1 = new System.Windows.Forms.GroupBox();
            this.frame1total = new System.Windows.Forms.Label();
            this.frame1r2 = new Bowling.NumericTextBox();
            this.frame1r1 = new Bowling.NumericTextBox();
            this.frame2 = new System.Windows.Forms.GroupBox();
            this.frame2total = new System.Windows.Forms.Label();
            this.frame2r2 = new Bowling.NumericTextBox();
            this.frame2r1 = new Bowling.NumericTextBox();
            this.frame3 = new System.Windows.Forms.GroupBox();
            this.frame3total = new System.Windows.Forms.Label();
            this.frame3r2 = new Bowling.NumericTextBox();
            this.frame3r1 = new Bowling.NumericTextBox();
            this.frame4 = new System.Windows.Forms.GroupBox();
            this.frame4total = new System.Windows.Forms.Label();
            this.frame4r2 = new Bowling.NumericTextBox();
            this.frame4r1 = new Bowling.NumericTextBox();
            this.frame5 = new System.Windows.Forms.GroupBox();
            this.frame5total = new System.Windows.Forms.Label();
            this.frame5r2 = new Bowling.NumericTextBox();
            this.frame5r1 = new Bowling.NumericTextBox();
            this.frame6 = new System.Windows.Forms.GroupBox();
            this.frame6total = new System.Windows.Forms.Label();
            this.frame6r2 = new Bowling.NumericTextBox();
            this.frame6r1 = new Bowling.NumericTextBox();
            this.frame7 = new System.Windows.Forms.GroupBox();
            this.frame7total = new System.Windows.Forms.Label();
            this.frame7r2 = new Bowling.NumericTextBox();
            this.frame7r1 = new Bowling.NumericTextBox();
            this.frame8 = new System.Windows.Forms.GroupBox();
            this.frame8total = new System.Windows.Forms.Label();
            this.frame8r2 = new Bowling.NumericTextBox();
            this.frame8r1 = new Bowling.NumericTextBox();
            this.frame9 = new System.Windows.Forms.GroupBox();
            this.frame9total = new System.Windows.Forms.Label();
            this.frame9r2 = new Bowling.NumericTextBox();
            this.frame9r1 = new Bowling.NumericTextBox();
            this.frame10 = new System.Windows.Forms.GroupBox();
            this.frame10r3 = new Bowling.NumericTextBox();
            this.frame10total = new System.Windows.Forms.Label();
            this.frame10r2 = new Bowling.NumericTextBox();
            this.frame10r1 = new Bowling.NumericTextBox();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.dropdownHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInstructions = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.StatusStrip();
            this.gameTotal = new System.Windows.Forms.ToolStripStatusLabel();
            dropdownFile = new System.Windows.Forms.ToolStripMenuItem();
            this.frame1.SuspendLayout();
            this.frame2.SuspendLayout();
            this.frame3.SuspendLayout();
            this.frame4.SuspendLayout();
            this.frame5.SuspendLayout();
            this.frame6.SuspendLayout();
            this.frame7.SuspendLayout();
            this.frame8.SuspendLayout();
            this.frame9.SuspendLayout();
            this.frame10.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // dropdownFile
            // 
            dropdownFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNewGame});
            dropdownFile.Name = "dropdownFile";
            dropdownFile.Size = new System.Drawing.Size(37, 20);
            dropdownFile.Text = "File";
            // 
            // menuNewGame
            // 
            this.menuNewGame.Name = "menuNewGame";
            this.menuNewGame.Size = new System.Drawing.Size(132, 22);
            this.menuNewGame.Text = "New Game";
            this.menuNewGame.Click += new System.EventHandler(this.NewGame);
            // 
            // frame1
            // 
            this.frame1.Controls.Add(this.frame1total);
            this.frame1.Controls.Add(this.frame1r2);
            this.frame1.Controls.Add(this.frame1r1);
            this.frame1.Location = new System.Drawing.Point(12, 27);
            this.frame1.Name = "frame1";
            this.frame1.Size = new System.Drawing.Size(67, 70);
            this.frame1.TabIndex = 1;
            this.frame1.TabStop = false;
            this.frame1.Text = "1";
            // 
            // frame1total
            // 
            this.frame1total.AutoSize = true;
            this.frame1total.Location = new System.Drawing.Point(6, 48);
            this.frame1total.Name = "frame1total";
            this.frame1total.Size = new System.Drawing.Size(13, 13);
            this.frame1total.TabIndex = 2;
            this.frame1total.Text = "0";
            this.frame1total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame1r2
            // 
            this.frame1r2.Location = new System.Drawing.Point(36, 19);
            this.frame1r2.MaxLength = 1;
            this.frame1r2.Name = "frame1r2";
            this.frame1r2.Size = new System.Drawing.Size(25, 20);
            this.frame1r2.TabIndex = 1;
            this.frame1r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame1r1
            // 
            this.frame1r1.Location = new System.Drawing.Point(6, 19);
            this.frame1r1.MaxLength = 1;
            this.frame1r1.Name = "frame1r1";
            this.frame1r1.Size = new System.Drawing.Size(24, 20);
            this.frame1r1.TabIndex = 0;
            this.frame1r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame2
            // 
            this.frame2.Controls.Add(this.frame2total);
            this.frame2.Controls.Add(this.frame2r2);
            this.frame2.Controls.Add(this.frame2r1);
            this.frame2.Location = new System.Drawing.Point(85, 27);
            this.frame2.Name = "frame2";
            this.frame2.Size = new System.Drawing.Size(67, 70);
            this.frame2.TabIndex = 3;
            this.frame2.TabStop = false;
            this.frame2.Text = "2";
            // 
            // frame2total
            // 
            this.frame2total.AutoSize = true;
            this.frame2total.Location = new System.Drawing.Point(6, 48);
            this.frame2total.Name = "frame2total";
            this.frame2total.Size = new System.Drawing.Size(13, 13);
            this.frame2total.TabIndex = 2;
            this.frame2total.Text = "0";
            this.frame2total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame2r2
            // 
            this.frame2r2.Location = new System.Drawing.Point(36, 19);
            this.frame2r2.MaxLength = 1;
            this.frame2r2.Name = "frame2r2";
            this.frame2r2.Size = new System.Drawing.Size(25, 20);
            this.frame2r2.TabIndex = 1;
            this.frame2r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame2r1
            // 
            this.frame2r1.Location = new System.Drawing.Point(6, 19);
            this.frame2r1.MaxLength = 1;
            this.frame2r1.Name = "frame2r1";
            this.frame2r1.Size = new System.Drawing.Size(24, 20);
            this.frame2r1.TabIndex = 0;
            this.frame2r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame3
            // 
            this.frame3.Controls.Add(this.frame3total);
            this.frame3.Controls.Add(this.frame3r2);
            this.frame3.Controls.Add(this.frame3r1);
            this.frame3.Location = new System.Drawing.Point(158, 27);
            this.frame3.Name = "frame3";
            this.frame3.Size = new System.Drawing.Size(67, 70);
            this.frame3.TabIndex = 4;
            this.frame3.TabStop = false;
            this.frame3.Text = "3";
            // 
            // frame3total
            // 
            this.frame3total.AutoSize = true;
            this.frame3total.Location = new System.Drawing.Point(6, 48);
            this.frame3total.Name = "frame3total";
            this.frame3total.Size = new System.Drawing.Size(13, 13);
            this.frame3total.TabIndex = 2;
            this.frame3total.Text = "0";
            this.frame3total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame3r2
            // 
            this.frame3r2.Location = new System.Drawing.Point(36, 19);
            this.frame3r2.MaxLength = 1;
            this.frame3r2.Name = "frame3r2";
            this.frame3r2.Size = new System.Drawing.Size(25, 20);
            this.frame3r2.TabIndex = 1;
            this.frame3r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame3r1
            // 
            this.frame3r1.Location = new System.Drawing.Point(6, 19);
            this.frame3r1.MaxLength = 1;
            this.frame3r1.Name = "frame3r1";
            this.frame3r1.Size = new System.Drawing.Size(24, 20);
            this.frame3r1.TabIndex = 0;
            this.frame3r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame4
            // 
            this.frame4.Controls.Add(this.frame4total);
            this.frame4.Controls.Add(this.frame4r2);
            this.frame4.Controls.Add(this.frame4r1);
            this.frame4.Location = new System.Drawing.Point(231, 27);
            this.frame4.Name = "frame4";
            this.frame4.Size = new System.Drawing.Size(67, 70);
            this.frame4.TabIndex = 5;
            this.frame4.TabStop = false;
            this.frame4.Text = "4";
            // 
            // frame4total
            // 
            this.frame4total.AutoSize = true;
            this.frame4total.Location = new System.Drawing.Point(6, 48);
            this.frame4total.Name = "frame4total";
            this.frame4total.Size = new System.Drawing.Size(13, 13);
            this.frame4total.TabIndex = 2;
            this.frame4total.Text = "0";
            this.frame4total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame4r2
            // 
            this.frame4r2.Location = new System.Drawing.Point(36, 19);
            this.frame4r2.MaxLength = 1;
            this.frame4r2.Name = "frame4r2";
            this.frame4r2.Size = new System.Drawing.Size(25, 20);
            this.frame4r2.TabIndex = 1;
            this.frame4r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame4r1
            // 
            this.frame4r1.Location = new System.Drawing.Point(6, 19);
            this.frame4r1.MaxLength = 1;
            this.frame4r1.Name = "frame4r1";
            this.frame4r1.Size = new System.Drawing.Size(24, 20);
            this.frame4r1.TabIndex = 0;
            this.frame4r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame5
            // 
            this.frame5.Controls.Add(this.frame5total);
            this.frame5.Controls.Add(this.frame5r2);
            this.frame5.Controls.Add(this.frame5r1);
            this.frame5.Location = new System.Drawing.Point(304, 27);
            this.frame5.Name = "frame5";
            this.frame5.Size = new System.Drawing.Size(67, 70);
            this.frame5.TabIndex = 6;
            this.frame5.TabStop = false;
            this.frame5.Text = "5";
            // 
            // frame5total
            // 
            this.frame5total.AutoSize = true;
            this.frame5total.Location = new System.Drawing.Point(6, 48);
            this.frame5total.Name = "frame5total";
            this.frame5total.Size = new System.Drawing.Size(13, 13);
            this.frame5total.TabIndex = 3;
            this.frame5total.Text = "0";
            this.frame5total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame5r2
            // 
            this.frame5r2.Location = new System.Drawing.Point(36, 19);
            this.frame5r2.MaxLength = 1;
            this.frame5r2.Name = "frame5r2";
            this.frame5r2.Size = new System.Drawing.Size(25, 20);
            this.frame5r2.TabIndex = 1;
            this.frame5r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame5r1
            // 
            this.frame5r1.Location = new System.Drawing.Point(6, 19);
            this.frame5r1.MaxLength = 1;
            this.frame5r1.Name = "frame5r1";
            this.frame5r1.Size = new System.Drawing.Size(24, 20);
            this.frame5r1.TabIndex = 0;
            this.frame5r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame6
            // 
            this.frame6.Controls.Add(this.frame6total);
            this.frame6.Controls.Add(this.frame6r2);
            this.frame6.Controls.Add(this.frame6r1);
            this.frame6.Location = new System.Drawing.Point(377, 27);
            this.frame6.Name = "frame6";
            this.frame6.Size = new System.Drawing.Size(67, 70);
            this.frame6.TabIndex = 7;
            this.frame6.TabStop = false;
            this.frame6.Text = "6";
            // 
            // frame6total
            // 
            this.frame6total.AutoSize = true;
            this.frame6total.Location = new System.Drawing.Point(6, 48);
            this.frame6total.Name = "frame6total";
            this.frame6total.Size = new System.Drawing.Size(13, 13);
            this.frame6total.TabIndex = 2;
            this.frame6total.Text = "0";
            this.frame6total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame6r2
            // 
            this.frame6r2.Location = new System.Drawing.Point(36, 19);
            this.frame6r2.MaxLength = 1;
            this.frame6r2.Name = "frame6r2";
            this.frame6r2.Size = new System.Drawing.Size(25, 20);
            this.frame6r2.TabIndex = 1;
            this.frame6r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame6r1
            // 
            this.frame6r1.Location = new System.Drawing.Point(6, 19);
            this.frame6r1.MaxLength = 1;
            this.frame6r1.Name = "frame6r1";
            this.frame6r1.Size = new System.Drawing.Size(24, 20);
            this.frame6r1.TabIndex = 0;
            this.frame6r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame7
            // 
            this.frame7.Controls.Add(this.frame7total);
            this.frame7.Controls.Add(this.frame7r2);
            this.frame7.Controls.Add(this.frame7r1);
            this.frame7.Location = new System.Drawing.Point(450, 27);
            this.frame7.Name = "frame7";
            this.frame7.Size = new System.Drawing.Size(67, 70);
            this.frame7.TabIndex = 8;
            this.frame7.TabStop = false;
            this.frame7.Text = "7";
            // 
            // frame7total
            // 
            this.frame7total.AutoSize = true;
            this.frame7total.Location = new System.Drawing.Point(6, 48);
            this.frame7total.Name = "frame7total";
            this.frame7total.Size = new System.Drawing.Size(13, 13);
            this.frame7total.TabIndex = 2;
            this.frame7total.Text = "0";
            this.frame7total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame7r2
            // 
            this.frame7r2.Location = new System.Drawing.Point(36, 19);
            this.frame7r2.MaxLength = 1;
            this.frame7r2.Name = "frame7r2";
            this.frame7r2.Size = new System.Drawing.Size(25, 20);
            this.frame7r2.TabIndex = 1;
            this.frame7r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame7r1
            // 
            this.frame7r1.Location = new System.Drawing.Point(6, 19);
            this.frame7r1.MaxLength = 1;
            this.frame7r1.Name = "frame7r1";
            this.frame7r1.Size = new System.Drawing.Size(24, 20);
            this.frame7r1.TabIndex = 0;
            this.frame7r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame8
            // 
            this.frame8.Controls.Add(this.frame8total);
            this.frame8.Controls.Add(this.frame8r2);
            this.frame8.Controls.Add(this.frame8r1);
            this.frame8.Location = new System.Drawing.Point(523, 27);
            this.frame8.Name = "frame8";
            this.frame8.Size = new System.Drawing.Size(67, 70);
            this.frame8.TabIndex = 9;
            this.frame8.TabStop = false;
            this.frame8.Text = "8";
            // 
            // frame8total
            // 
            this.frame8total.AutoSize = true;
            this.frame8total.Location = new System.Drawing.Point(6, 48);
            this.frame8total.Name = "frame8total";
            this.frame8total.Size = new System.Drawing.Size(13, 13);
            this.frame8total.TabIndex = 2;
            this.frame8total.Text = "0";
            this.frame8total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame8r2
            // 
            this.frame8r2.Location = new System.Drawing.Point(36, 19);
            this.frame8r2.MaxLength = 1;
            this.frame8r2.Name = "frame8r2";
            this.frame8r2.Size = new System.Drawing.Size(25, 20);
            this.frame8r2.TabIndex = 1;
            this.frame8r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame8r1
            // 
            this.frame8r1.Location = new System.Drawing.Point(6, 19);
            this.frame8r1.MaxLength = 1;
            this.frame8r1.Name = "frame8r1";
            this.frame8r1.Size = new System.Drawing.Size(24, 20);
            this.frame8r1.TabIndex = 0;
            this.frame8r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame9
            // 
            this.frame9.Controls.Add(this.frame9total);
            this.frame9.Controls.Add(this.frame9r2);
            this.frame9.Controls.Add(this.frame9r1);
            this.frame9.Location = new System.Drawing.Point(596, 27);
            this.frame9.Name = "frame9";
            this.frame9.Size = new System.Drawing.Size(67, 70);
            this.frame9.TabIndex = 10;
            this.frame9.TabStop = false;
            this.frame9.Text = "9";
            // 
            // frame9total
            // 
            this.frame9total.AutoSize = true;
            this.frame9total.Location = new System.Drawing.Point(6, 48);
            this.frame9total.Name = "frame9total";
            this.frame9total.Size = new System.Drawing.Size(13, 13);
            this.frame9total.TabIndex = 2;
            this.frame9total.Text = "0";
            this.frame9total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame9r2
            // 
            this.frame9r2.Location = new System.Drawing.Point(36, 19);
            this.frame9r2.MaxLength = 1;
            this.frame9r2.Name = "frame9r2";
            this.frame9r2.Size = new System.Drawing.Size(25, 20);
            this.frame9r2.TabIndex = 1;
            this.frame9r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame9r1
            // 
            this.frame9r1.Location = new System.Drawing.Point(6, 19);
            this.frame9r1.MaxLength = 1;
            this.frame9r1.Name = "frame9r1";
            this.frame9r1.Size = new System.Drawing.Size(24, 20);
            this.frame9r1.TabIndex = 0;
            this.frame9r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame10
            // 
            this.frame10.Controls.Add(this.frame10r3);
            this.frame10.Controls.Add(this.frame10total);
            this.frame10.Controls.Add(this.frame10r2);
            this.frame10.Controls.Add(this.frame10r1);
            this.frame10.Location = new System.Drawing.Point(669, 27);
            this.frame10.Name = "frame10";
            this.frame10.Size = new System.Drawing.Size(101, 70);
            this.frame10.TabIndex = 11;
            this.frame10.TabStop = false;
            this.frame10.Text = "10";
            // 
            // frame10r3
            // 
            this.frame10r3.Location = new System.Drawing.Point(67, 19);
            this.frame10r3.MaxLength = 1;
            this.frame10r3.Name = "frame10r3";
            this.frame10r3.Size = new System.Drawing.Size(25, 20);
            this.frame10r3.TabIndex = 3;
            this.frame10r3.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame10total
            // 
            this.frame10total.AutoSize = true;
            this.frame10total.Location = new System.Drawing.Point(6, 48);
            this.frame10total.Name = "frame10total";
            this.frame10total.Size = new System.Drawing.Size(13, 13);
            this.frame10total.TabIndex = 2;
            this.frame10total.Text = "0";
            this.frame10total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frame10r2
            // 
            this.frame10r2.Location = new System.Drawing.Point(36, 19);
            this.frame10r2.MaxLength = 1;
            this.frame10r2.Name = "frame10r2";
            this.frame10r2.Size = new System.Drawing.Size(25, 20);
            this.frame10r2.TabIndex = 1;
            this.frame10r2.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // frame10r1
            // 
            this.frame10r1.Location = new System.Drawing.Point(6, 19);
            this.frame10r1.MaxLength = 1;
            this.frame10r1.Name = "frame10r1";
            this.frame10r1.Size = new System.Drawing.Size(24, 20);
            this.frame10r1.TabIndex = 0;
            this.frame10r1.Leave += new System.EventHandler(this.ScoreUpdated);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            dropdownFile,
            this.dropdownHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(784, 24);
            this.menuMain.TabIndex = 12;
            this.menuMain.Text = "menuStrip1";
            // 
            // dropdownHelp
            // 
            this.dropdownHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInstructions});
            this.dropdownHelp.Name = "dropdownHelp";
            this.dropdownHelp.Size = new System.Drawing.Size(44, 20);
            this.dropdownHelp.Text = "Help";
            // 
            // menuInstructions
            // 
            this.menuInstructions.Name = "menuInstructions";
            this.menuInstructions.Size = new System.Drawing.Size(152, 22);
            this.menuInstructions.Text = "Instructions";
            this.menuInstructions.Click += new System.EventHandler(this.OpenInstructions);
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameTotal});
            this.status.Location = new System.Drawing.Point(0, 119);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(784, 22);
            this.status.TabIndex = 13;
            // 
            // gameTotal
            // 
            this.gameTotal.Name = "gameTotal";
            this.gameTotal.Size = new System.Drawing.Size(77, 17);
            this.gameTotal.Text = "Total Score: 0";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 141);
            this.Controls.Add(this.status);
            this.Controls.Add(this.frame10);
            this.Controls.Add(this.frame9);
            this.Controls.Add(this.frame8);
            this.Controls.Add(this.frame7);
            this.Controls.Add(this.frame6);
            this.Controls.Add(this.frame5);
            this.Controls.Add(this.frame4);
            this.Controls.Add(this.frame3);
            this.Controls.Add(this.frame2);
            this.Controls.Add(this.frame1);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.MaximumSize = new System.Drawing.Size(800, 180);
            this.MinimumSize = new System.Drawing.Size(800, 180);
            this.Name = "ScoreForm";
            this.Text = "Bowling";
            this.frame1.ResumeLayout(false);
            this.frame1.PerformLayout();
            this.frame2.ResumeLayout(false);
            this.frame2.PerformLayout();
            this.frame3.ResumeLayout(false);
            this.frame3.PerformLayout();
            this.frame4.ResumeLayout(false);
            this.frame4.PerformLayout();
            this.frame5.ResumeLayout(false);
            this.frame5.PerformLayout();
            this.frame6.ResumeLayout(false);
            this.frame6.PerformLayout();
            this.frame7.ResumeLayout(false);
            this.frame7.PerformLayout();
            this.frame8.ResumeLayout(false);
            this.frame8.PerformLayout();
            this.frame9.ResumeLayout(false);
            this.frame9.PerformLayout();
            this.frame10.ResumeLayout(false);
            this.frame10.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox frame1;
        private System.Windows.Forms.Label frame1total;
        private System.Windows.Forms.GroupBox frame2;
        private System.Windows.Forms.Label frame2total;
        private System.Windows.Forms.GroupBox frame3;
        private System.Windows.Forms.Label frame3total;
        private System.Windows.Forms.GroupBox frame4;
        private System.Windows.Forms.Label frame4total;
        private System.Windows.Forms.GroupBox frame5;
        private System.Windows.Forms.GroupBox frame6;
        private System.Windows.Forms.Label frame6total;
        private System.Windows.Forms.GroupBox frame7;
        private System.Windows.Forms.Label frame7total;
        private System.Windows.Forms.GroupBox frame8;
        private System.Windows.Forms.Label frame8total;
        private System.Windows.Forms.GroupBox frame9;
        private System.Windows.Forms.Label frame9total;
        private System.Windows.Forms.GroupBox frame10;
        private System.Windows.Forms.Label frame10total;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuNewGame;
        private NumericTextBox frame1r1;
        private NumericTextBox frame1r2;
        private NumericTextBox frame2r2;
        private NumericTextBox frame2r1;
        private NumericTextBox frame3r2;
        private NumericTextBox frame3r1;
        private NumericTextBox frame4r2;
        private NumericTextBox frame5r2;
        private NumericTextBox frame5r1;
        private NumericTextBox frame6r2;
        private NumericTextBox frame6r1;
        private NumericTextBox frame7r2;
        private NumericTextBox frame7r1;
        private NumericTextBox frame8r2;
        private NumericTextBox frame8r1;
        private NumericTextBox frame9r2;
        private NumericTextBox frame9r1;
        private NumericTextBox frame10r3;
        private NumericTextBox frame10r2;
        private NumericTextBox frame10r1;
        private NumericTextBox frame4r1;
        private System.Windows.Forms.Label frame5total;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel gameTotal;
        private System.Windows.Forms.ToolStripMenuItem dropdownHelp;
        private System.Windows.Forms.ToolStripMenuItem menuInstructions;
    }
}