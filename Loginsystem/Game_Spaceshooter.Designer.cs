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
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
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
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(362, 555);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(75, 75);
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
            this.label.Location = new System.Drawing.Point(194, 54);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(429, 176);
            this.label.TabIndex = 1;
            this.label.Text = "label1";
            this.label.Visible = false;
            // 
            // repButton
            // 
            this.repButton.BackColor = System.Drawing.Color.DarkGreen;
            this.repButton.Font = new System.Drawing.Font("Impact", 40F);
            this.repButton.ForeColor = System.Drawing.Color.White;
            this.repButton.Location = new System.Drawing.Point(224, 222);
            this.repButton.Name = "repButton";
            this.repButton.Size = new System.Drawing.Size(356, 108);
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
            this.extButton.Location = new System.Drawing.Point(224, 349);
            this.extButton.Name = "extButton";
            this.extButton.Size = new System.Drawing.Size(356, 108);
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
            this.lvlLabel.Location = new System.Drawing.Point(650, 9);
            this.lvlLabel.Name = "lvlLabel";
            this.lvlLabel.Size = new System.Drawing.Size(116, 35);
            this.lvlLabel.TabIndex = 4;
            this.lvlLabel.Text = "LEVEL: 00";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Impact", 14F);
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(113, 35);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "SCORE: 0";
            // 
            // Game_Spaceshooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(776, 635);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.lvlLabel);
            this.Controls.Add(this.extButton);
            this.Controls.Add(this.repButton);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(798, 691);
            this.MinimumSize = new System.Drawing.Size(798, 691);
            this.Name = "Game_Spaceshooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceshooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
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
    }
}

