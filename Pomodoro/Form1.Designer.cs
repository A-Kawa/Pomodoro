namespace Pomodoro
{
    partial class Pomodoro
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.StartStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerCounter = new System.Windows.Forms.Label();
            this.PomodoroGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.PomodorosCounter = new System.Windows.Forms.Label();
            this.DistractionName = new System.Windows.Forms.Label();
            this.InterruptionInside = new System.Windows.Forms.Button();
            this.InterruptionOutside = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PomodoroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StartStop
            // 
            this.StartStop.BackColor = System.Drawing.Color.Firebrick;
            this.StartStop.Location = new System.Drawing.Point(24, 75);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(75, 23);
            this.StartStop.TabIndex = 0;
            this.StartStop.Text = "Start";
            this.StartStop.UseVisualStyleBackColor = false;
            this.StartStop.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.MinimumSize = new System.Drawing.Size(100, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timer";
            // 
            // TimerCounter
            // 
            this.TimerCounter.AutoSize = true;
            this.TimerCounter.BackColor = System.Drawing.Color.Transparent;
            this.TimerCounter.Location = new System.Drawing.Point(21, 46);
            this.TimerCounter.MinimumSize = new System.Drawing.Size(100, 10);
            this.TimerCounter.Name = "TimerCounter";
            this.TimerCounter.Size = new System.Drawing.Size(100, 13);
            this.TimerCounter.TabIndex = 3;
            this.TimerCounter.Click += new System.EventHandler(this.TimerCounter_Click);
            // 
            // PomodoroGrid
            // 
            this.PomodoroGrid.BackgroundColor = System.Drawing.Color.Salmon;
            this.PomodoroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PomodoroGrid.Location = new System.Drawing.Point(222, 12);
            this.PomodoroGrid.Name = "PomodoroGrid";
            this.PomodoroGrid.Size = new System.Drawing.Size(243, 133);
            this.PomodoroGrid.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(249, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Done pomodoros:";
            // 
            // PomodorosCounter
            // 
            this.PomodorosCounter.AutoSize = true;
            this.PomodorosCounter.BackColor = System.Drawing.Color.Transparent;
            this.PomodorosCounter.Location = new System.Drawing.Point(346, 152);
            this.PomodorosCounter.Name = "PomodorosCounter";
            this.PomodorosCounter.Size = new System.Drawing.Size(13, 13);
            this.PomodorosCounter.TabIndex = 6;
            this.PomodorosCounter.Text = "0";
            // 
            // DistractionName
            // 
            this.DistractionName.AutoSize = true;
            this.DistractionName.BackColor = System.Drawing.Color.Transparent;
            this.DistractionName.Location = new System.Drawing.Point(127, 12);
            this.DistractionName.Name = "DistractionName";
            this.DistractionName.Size = new System.Drawing.Size(89, 13);
            this.DistractionName.TabIndex = 7;
            this.DistractionName.Text = "Add interruptions:";
            // 
            // InterruptionInside
            // 
            this.InterruptionInside.BackColor = System.Drawing.Color.Firebrick;
            this.InterruptionInside.Location = new System.Drawing.Point(130, 46);
            this.InterruptionInside.Name = "InterruptionInside";
            this.InterruptionInside.Size = new System.Drawing.Size(86, 23);
            this.InterruptionInside.TabIndex = 8;
            this.InterruptionInside.Text = "Self";
            this.InterruptionInside.UseVisualStyleBackColor = false;
            this.InterruptionInside.Click += new System.EventHandler(this.InterruptionInside_Click);
            // 
            // InterruptionOutside
            // 
            this.InterruptionOutside.BackColor = System.Drawing.Color.Firebrick;
            this.InterruptionOutside.Location = new System.Drawing.Point(130, 75);
            this.InterruptionOutside.Name = "InterruptionOutside";
            this.InterruptionOutside.Size = new System.Drawing.Size(86, 23);
            this.InterruptionOutside.TabIndex = 9;
            this.InterruptionOutside.Text = "external";
            this.InterruptionOutside.UseVisualStyleBackColor = false;
            this.InterruptionOutside.Click += new System.EventHandler(this.InterruptionOutside_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(523, 181);
            this.Controls.Add(this.InterruptionOutside);
            this.Controls.Add(this.InterruptionInside);
            this.Controls.Add(this.DistractionName);
            this.Controls.Add(this.PomodorosCounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PomodoroGrid);
            this.Controls.Add(this.TimerCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartStop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pomodoro";
            this.Text = "Pomodoro";
            ((System.ComponentModel.ISupportInitialize)(this.PomodoroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TimerCounter;
        private System.Windows.Forms.DataGridView PomodoroGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PomodorosCounter;
        private System.Windows.Forms.Label DistractionName;
        private System.Windows.Forms.Button InterruptionInside;
        private System.Windows.Forms.Button InterruptionOutside;
        private System.Windows.Forms.Timer timer1;
    }
}

