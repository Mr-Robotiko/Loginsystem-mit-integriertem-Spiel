namespace Game_Spaceshooter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moveBgTimer = new System.Windows.Forms.Timer(this.components);
            this.Player = new System.Windows.Forms.PictureBox();
            this.moveLeftTimer = new System.Windows.Forms.Timer(this.components);
            this.moveRightTimer = new System.Windows.Forms.Timer(this.components);
            this.moveDownTimer = new System.Windows.Forms.Timer(this.components);
            this.moveUpTimer = new System.Windows.Forms.Timer(this.components);
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
            this.Player.Location = new System.Drawing.Point(325, 530);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(778, 644);
            this.Controls.Add(this.Player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 700);
            this.Name = "Form1";
            this.Text = "Spaceshooter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer moveBgTimer;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer moveLeftTimer;
        private System.Windows.Forms.Timer moveRightTimer;
        private System.Windows.Forms.Timer moveDownTimer;
        private System.Windows.Forms.Timer moveUpTimer;
    }
}

