namespace Loginsystem
{
    partial class Game_Spaceshooter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_Spaceshooter));
            this.moveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.moveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.moveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.moveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.moveUpTimer = new System.Windows.Forms.Timer(this.components);
            this.moveBulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.moveEnemiesTimer = new System.Windows.Forms.Timer(this.components);
            this.moveEnemiesBulletsTimer = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.repButton = new System.Windows.Forms.Button();
            this.extButton = new System.Windows.Forms.Button();
            this.lvlLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // moveBgTimer
            // 
            this.moveBgTimer.Enabled = true;
            this.moveBgTimer.Interval = 10;
            this.moveBgTimer.Tick += new System.EventHandler(this.moveBgTimer_Tick);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Location = new System.Drawing.Point(241, 365);
            this.Player.Margin = new System.Windows.Forms.Padding(2);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 49);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // moveLeftTimer
            // 
            this.moveLeftTimer.Interval = 5;
            this.moveLeftTimer.Tick += new System.EventHandler(this.moveLeftTimer_Tick);
            // 
            // moveRightTimer
            // 
            this.moveRightTimer.Interval = 5;
            this.moveRightTimer.Tick += new System.EventHandler(this.moveRightTimer_Tick);
            // 
            // moveDownTimer
            // 
            this.moveDownTimer.Interval = 5;
            this.moveDownTimer.Tick += new System.EventHandler(this.moveDownTimer_Tick);
            // 
            // moveUpTimer
            // 
            this.moveUpTimer.Interval = 5;
            this.moveUpTimer.Tick += new System.EventHandler(this.moveUpTimer_Tick);
            // 
            // moveBulletsTimer
            // 
            this.moveBulletsTimer.Enabled = true;
            this.moveBulletsTimer.Interval = 20;
            this.moveBulletsTimer.Tick += new System.EventHandler(this.moveBulletsTimer_Tick);
            // 
            // moveEnemiesTimer
            // 
            this.moveEnemiesTimer.Enabled = true;
            this.moveEnemiesTimer.Tick += new System.EventHandler(this.moveEnemiesTimer_Tick);
            // 
            // moveEnemiesBulletsTimer
            // 
            this.moveEnemiesBulletsTimer.Enabled = true;
            this.moveEnemiesBulletsTimer.Interval = 20;
            this.moveEnemiesBulletsTimer.Tick += new System.EventHandler(this.moveEnemiesBulletsTimer_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label.Location = new System.Drawing.Point(129, 35);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(286, 117);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            this.label.Visible = false;
            // 
            // repButton
            // 
            this.repButton.BackColor = System.Drawing.Color.DarkGreen;
            this.repButton.Font = new System.Drawing.Font("Impact", 40F);
            this.repButton.ForeColor = System.Drawing.Color.White;
            this.repButton.Location = new System.Drawing.Point(149, 144);
            this.repButton.Margin = new System.Windows.Forms.Padding(2);
            this.repButton.Name = "repButton";
            this.repButton.Size = new System.Drawing.Size(237, 70);
            this.repButton.TabIndex = 2;
            this.repButton.Text = "REPLAY";
            this.repButton.UseVisualStyleBackColor = false;
            this.repButton.Visible = false;
            this.repButton.Click += new System.EventHandler(this.repButton_Click);
            // 
            // extButton
            // 
            this.extButton.BackColor = System.Drawing.Color.DarkRed;
            this.extButton.Font = new System.Drawing.Font("Impact", 40F);
            this.extButton.ForeColor = System.Drawing.Color.Black;
            this.extButton.Location = new System.Drawing.Point(149, 227);
            this.extButton.Margin = new System.Windows.Forms.Padding(2);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(237, 70);
            this.extButton.TabIndex = 3;
            this.extButton.Text = "EXIT";
            this.extButton.UseVisualStyleBackColor = false;
            this.extButton.Visible = false;
            this.extButton.Click += new System.EventHandler(this.extButton_Click);
            // 
            // lvlLabel
            // 
            this.lvlLabel.AutoSize = true;
            this.lvlLabel.BackColor = System.Drawing.Color.Transparent;
            this.lvlLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.lvlLabel.ForeColor = System.Drawing.Color.Yellow;
            this.lvlLabel.Location = new System.Drawing.Point(433, 6);
            this.lvlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(76, 23);
            this.lvlLabel.TabIndex = 4;
            this.lvlLabel.Text = "LEVEL: 00";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(8, 6);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(76, 23);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "SCORE: 0";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(160, 313);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 6;
            // 
            // Game_Spaceshooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(523, 430);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.extButton);
            this.Controls.Add(this.repButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Player);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(539, 469);
            this.MinimumSize = new System.Drawing.Size(539, 469);
            this.Name = "Game_Spaceshooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceshooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer moveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer moveLeftTimer;
        private System.Windows.Forms.Timer moveRightTimer;
        private System.Windows.Forms.Timer moveDownTimer;
        private System.Windows.Forms.Timer moveUpTimer;
        private System.Windows.Forms.Timer moveBulletsTimer;
        private System.Windows.Forms.Timer moveEnemiesTimer;
        private System.Windows.Forms.Timer moveEnemiesBulletsTimer;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button repButton;
        private System.Windows.Forms.Button extButton;
        private System.Windows.Forms.Label lvlLabel;
        private System.Windows.Forms.Label scoreLabel;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

