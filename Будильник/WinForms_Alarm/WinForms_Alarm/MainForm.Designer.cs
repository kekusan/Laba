namespace WinForms_Alarm
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previewMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSignal;
        private System.Windows.Forms.Label labelCurrentMusic;

        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSeconds;

        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxSeconds;

        private System.Windows.Forms.Button btnIncrementHours;
        private System.Windows.Forms.Button btnDecrementHours;
        private System.Windows.Forms.Button btnIncrementMinutes;
        private System.Windows.Forms.Button btnDecrementMinutes;
        private System.Windows.Forms.Button btnIncrementSeconds;
        private System.Windows.Forms.Button btnDecrementSeconds;

        private System.Windows.Forms.Button buttonAddAlarm;
        private System.Windows.Forms.Button buttonRemoveAlarm;

        private System.Windows.Forms.ListBox listBoxAlarms;
        private System.Windows.Forms.Button buttonStart;

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

        /// <summary>
        /// Очистка ресурсов, если нужно.
        /// </summary>
        /// <param name="disposing">true, если управляемый ресурс должен быть удалён</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Метод, автоматически сгенерированный конструктором форм.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previewMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSignal = new System.Windows.Forms.Label();
            this.labelCurrentMusic = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.btnIncrementHours = new System.Windows.Forms.Button();
            this.btnDecrementHours = new System.Windows.Forms.Button();
            this.btnIncrementMinutes = new System.Windows.Forms.Button();
            this.btnDecrementMinutes = new System.Windows.Forms.Button();
            this.btnIncrementSeconds = new System.Windows.Forms.Button();
            this.btnDecrementSeconds = new System.Windows.Forms.Button();
            this.buttonAddAlarm = new System.Windows.Forms.Button();
            this.buttonRemoveAlarm = new System.Windows.Forms.Button();
            this.listBoxAlarms = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseMusicToolStripMenuItem,
            this.previewMusicToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // chooseMusicToolStripMenuItem
            // 
            this.chooseMusicToolStripMenuItem.Name = "chooseMusicToolStripMenuItem";
            this.chooseMusicToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.chooseMusicToolStripMenuItem.Text = "Выбрать музыку";
            this.chooseMusicToolStripMenuItem.Click += new System.EventHandler(this.chooseMusicToolStripMenuItem_Click);
            // 
            // previewMusicToolStripMenuItem
            // 
            this.previewMusicToolStripMenuItem.Name = "previewMusicToolStripMenuItem";
            this.previewMusicToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.previewMusicToolStripMenuItem.Text = "Прослушать музыку";
            this.previewMusicToolStripMenuItem.Click += new System.EventHandler(this.previewMusicToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.labelTitle.Location = new System.Drawing.Point(188, 37);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(207, 41);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "БУДИЛЬНИК";
            // 
            // labelSignal
            // 
            this.labelSignal.AutoSize = true;
            this.labelSignal.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelSignal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelSignal.Location = new System.Drawing.Point(166, 78);
            this.labelSignal.Name = "labelSignal";
            this.labelSignal.Size = new System.Drawing.Size(248, 25);
            this.labelSignal.TabIndex = 2;
            this.labelSignal.Text = "Сигнал сработает в (Ч:М:С)";
            // 
            // labelCurrentMusic
            // 
            this.labelCurrentMusic.AutoSize = true;
            this.labelCurrentMusic.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCurrentMusic.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelCurrentMusic.Location = new System.Drawing.Point(12, 463);
            this.labelCurrentMusic.Name = "labelCurrentMusic";
            this.labelCurrentMusic.Size = new System.Drawing.Size(137, 19);
            this.labelCurrentMusic.TabIndex = 3;
            this.labelCurrentMusic.Text = "Музыка не выбрана";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelHours.Location = new System.Drawing.Point(179, 143);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(25, 25);
            this.labelHours.TabIndex = 7;
            this.labelHours.Text = "Ч";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelMinutes.Location = new System.Drawing.Point(326, 143);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(29, 25);
            this.labelMinutes.TabIndex = 8;
            this.labelMinutes.Text = "М";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.labelSeconds.Location = new System.Drawing.Point(473, 143);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(24, 25);
            this.labelSeconds.TabIndex = 9;
            this.labelSeconds.Text = "С";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.textBoxHours.Location = new System.Drawing.Point(101, 139);
            this.textBoxHours.MaxLength = 2;
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(73, 39);
            this.textBoxHours.TabIndex = 4;
            this.textBoxHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHours_KeyPress);
            this.textBoxHours.Leave += new System.EventHandler(this.textBoxHours_Leave);
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.textBoxMinutes.Location = new System.Drawing.Point(249, 139);
            this.textBoxMinutes.MaxLength = 2;
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(73, 39);
            this.textBoxMinutes.TabIndex = 5;
            this.textBoxMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMinutes_KeyPress);
            this.textBoxMinutes.Leave += new System.EventHandler(this.textBoxMinutes_Leave);
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.textBoxSeconds.Location = new System.Drawing.Point(396, 139);
            this.textBoxSeconds.MaxLength = 2;
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(73, 39);
            this.textBoxSeconds.TabIndex = 6;
            this.textBoxSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSeconds_KeyPress);
            this.textBoxSeconds.Leave += new System.EventHandler(this.textBoxSeconds_Leave);
            // 
            // btnIncrementHours
            // 
            this.btnIncrementHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrementHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIncrementHours.Location = new System.Drawing.Point(101, 108);
            this.btnIncrementHours.Name = "btnIncrementHours";
            this.btnIncrementHours.Size = new System.Drawing.Size(73, 26);
            this.btnIncrementHours.TabIndex = 10;
            this.btnIncrementHours.Text = "▲";
            this.btnIncrementHours.UseVisualStyleBackColor = true;
            this.btnIncrementHours.Click += new System.EventHandler(this.btnIncrementHours_Click);
            // 
            // btnDecrementHours
            // 
            this.btnDecrementHours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrementHours.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDecrementHours.Location = new System.Drawing.Point(101, 178);
            this.btnDecrementHours.Name = "btnDecrementHours";
            this.btnDecrementHours.Size = new System.Drawing.Size(73, 26);
            this.btnDecrementHours.TabIndex = 11;
            this.btnDecrementHours.Text = "▼";
            this.btnDecrementHours.UseVisualStyleBackColor = true;
            this.btnDecrementHours.Click += new System.EventHandler(this.btnDecrementHours_Click);
            // 
            // btnIncrementMinutes
            // 
            this.btnIncrementMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrementMinutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIncrementMinutes.Location = new System.Drawing.Point(249, 108);
            this.btnIncrementMinutes.Name = "btnIncrementMinutes";
            this.btnIncrementMinutes.Size = new System.Drawing.Size(73, 26);
            this.btnIncrementMinutes.TabIndex = 12;
            this.btnIncrementMinutes.Text = "▲";
            this.btnIncrementMinutes.UseVisualStyleBackColor = true;
            this.btnIncrementMinutes.Click += new System.EventHandler(this.btnIncrementMinutes_Click);
            // 
            // btnDecrementMinutes
            // 
            this.btnDecrementMinutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrementMinutes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDecrementMinutes.Location = new System.Drawing.Point(249, 178);
            this.btnDecrementMinutes.Name = "btnDecrementMinutes";
            this.btnDecrementMinutes.Size = new System.Drawing.Size(73, 26);
            this.btnDecrementMinutes.TabIndex = 13;
            this.btnDecrementMinutes.Text = "▼";
            this.btnDecrementMinutes.UseVisualStyleBackColor = true;
            this.btnDecrementMinutes.Click += new System.EventHandler(this.btnDecrementMinutes_Click);
            // 
            // btnIncrementSeconds
            // 
            this.btnIncrementSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrementSeconds.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnIncrementSeconds.Location = new System.Drawing.Point(396, 108);
            this.btnIncrementSeconds.Name = "btnIncrementSeconds";
            this.btnIncrementSeconds.Size = new System.Drawing.Size(73, 26);
            this.btnIncrementSeconds.TabIndex = 14;
            this.btnIncrementSeconds.Text = "▲";
            this.btnIncrementSeconds.UseVisualStyleBackColor = true;
            this.btnIncrementSeconds.Click += new System.EventHandler(this.btnIncrementSeconds_Click);
            // 
            // btnDecrementSeconds
            // 
            this.btnDecrementSeconds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrementSeconds.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDecrementSeconds.Location = new System.Drawing.Point(396, 178);
            this.btnDecrementSeconds.Name = "btnDecrementSeconds";
            this.btnDecrementSeconds.Size = new System.Drawing.Size(73, 26);
            this.btnDecrementSeconds.TabIndex = 15;
            this.btnDecrementSeconds.Text = "▼";
            this.btnDecrementSeconds.UseVisualStyleBackColor = true;
            this.btnDecrementSeconds.Click += new System.EventHandler(this.btnDecrementSeconds_Click);
            // 
            // buttonAddAlarm
            // 
            this.buttonAddAlarm.BackColor = System.Drawing.Color.Honeydew;
            this.buttonAddAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAlarm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAddAlarm.Location = new System.Drawing.Point(171, 243);
            this.buttonAddAlarm.Name = "buttonAddAlarm";
            this.buttonAddAlarm.Size = new System.Drawing.Size(103, 39);
            this.buttonAddAlarm.TabIndex = 17;
            this.buttonAddAlarm.Text = "Добавить";
            this.buttonAddAlarm.UseVisualStyleBackColor = false;
            this.buttonAddAlarm.Click += new System.EventHandler(this.buttonAddAlarm_Click);
            // 
            // buttonRemoveAlarm
            // 
            this.buttonRemoveAlarm.BackColor = System.Drawing.Color.MistyRose;
            this.buttonRemoveAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveAlarm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonRemoveAlarm.Location = new System.Drawing.Point(300, 243);
            this.buttonRemoveAlarm.Name = "buttonRemoveAlarm";
            this.buttonRemoveAlarm.Size = new System.Drawing.Size(103, 39);
            this.buttonRemoveAlarm.TabIndex = 18;
            this.buttonRemoveAlarm.Text = "Удалить";
            this.buttonRemoveAlarm.UseVisualStyleBackColor = false;
            this.buttonRemoveAlarm.Click += new System.EventHandler(this.buttonRemoveAlarm_Click);
            // 
            // listBoxAlarms
            // 
            this.listBoxAlarms.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxAlarms.FormattingEnabled = true;
            this.listBoxAlarms.ItemHeight = 21;
            this.listBoxAlarms.Location = new System.Drawing.Point(78, 299);
            this.listBoxAlarms.Name = "listBoxAlarms";
            this.listBoxAlarms.Size = new System.Drawing.Size(419, 88);
            this.listBoxAlarms.TabIndex = 19;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.LightGray;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonStart.Location = new System.Drawing.Point(225, 406);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(141, 43);
            this.buttonStart.TabIndex = 16;
            this.buttonStart.Text = "Запустить";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP3 Files|*.mp3|All Files|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(584, 491);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelSignal);
            this.Controls.Add(this.labelCurrentMusic);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.btnIncrementHours);
            this.Controls.Add(this.btnDecrementHours);
            this.Controls.Add(this.btnIncrementMinutes);
            this.Controls.Add(this.btnDecrementMinutes);
            this.Controls.Add(this.btnIncrementSeconds);
            this.Controls.Add(this.btnDecrementSeconds);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAddAlarm);
            this.Controls.Add(this.buttonRemoveAlarm);
            this.Controls.Add(this.listBoxAlarms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будильник";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
