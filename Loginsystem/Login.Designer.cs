namespace Loginsystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            login_panel1 = new Panel();
            login_panel2 = new Panel();
            login_panel3 = new Panel();
            login_nutzer_pictureBox = new PictureBox();
            login_anmelden_button = new Button();
            login_abbrechen_button = new Button();
            login_panel5 = new Panel();
            login_passwort_textBox = new TextBox();
            login_panel4 = new Panel();
            login_benutzername_textBox = new TextBox();
            login_beenden_button = new Button();
            login_schneeflocken_pictureBox2 = new PictureBox();
            login_schneeflocken_pictureBox1 = new PictureBox();
            login_panel6 = new Panel();
            login_panel7 = new Panel();
            pictureBox1 = new PictureBox();
            login_panel2.SuspendLayout();
            login_panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)login_nutzer_pictureBox).BeginInit();
            login_panel5.SuspendLayout();
            login_panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)login_schneeflocken_pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)login_schneeflocken_pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_panel1
            // 
            login_panel1.BackColor = Color.White;
            login_panel1.Location = new Point(550, 300);
            login_panel1.Name = "login_panel1";
            login_panel1.Size = new Size(500, 400);
            login_panel1.TabIndex = 0;
            // 
            // login_panel2
            // 
            login_panel2.Controls.Add(login_panel3);
            login_panel2.Location = new Point(555, 305);
            login_panel2.Name = "login_panel2";
            login_panel2.Size = new Size(490, 390);
            login_panel2.TabIndex = 1;
            // 
            // login_panel3
            // 
            login_panel3.BackColor = Color.White;
            login_panel3.Controls.Add(login_nutzer_pictureBox);
            login_panel3.Controls.Add(login_anmelden_button);
            login_panel3.Controls.Add(login_abbrechen_button);
            login_panel3.Controls.Add(login_panel5);
            login_panel3.Controls.Add(login_panel4);
            login_panel3.Location = new Point(5, 5);
            login_panel3.Name = "login_panel3";
            login_panel3.Size = new Size(480, 380);
            login_panel3.TabIndex = 0;
            // 
            // login_nutzer_pictureBox
            // 
            login_nutzer_pictureBox.Image = (Image)resources.GetObject("login_nutzer_pictureBox.Image");
            login_nutzer_pictureBox.Location = new Point(165, 10);
            login_nutzer_pictureBox.Name = "login_nutzer_pictureBox";
            login_nutzer_pictureBox.Size = new Size(150, 150);
            login_nutzer_pictureBox.TabIndex = 4;
            login_nutzer_pictureBox.TabStop = false;
            // 
            // login_anmelden_button
            // 
            login_anmelden_button.BackColor = Color.FromArgb(31, 82, 75);
            login_anmelden_button.FlatStyle = FlatStyle.Flat;
            login_anmelden_button.Font = new Font("Tahoma", 16.2F);
            login_anmelden_button.ForeColor = Color.White;
            login_anmelden_button.Location = new Point(270, 320);
            login_anmelden_button.Name = "login_anmelden_button";
            login_anmelden_button.Size = new Size(200, 45);
            login_anmelden_button.TabIndex = 3;
            login_anmelden_button.Text = "Anmelden";
            login_anmelden_button.UseVisualStyleBackColor = false;
            // 
            // login_abbrechen_button
            // 
            login_abbrechen_button.BackColor = Color.FromArgb(31, 82, 75);
            login_abbrechen_button.FlatStyle = FlatStyle.Flat;
            login_abbrechen_button.Font = new Font("Tahoma", 16.2F);
            login_abbrechen_button.ForeColor = Color.White;
            login_abbrechen_button.Location = new Point(10, 320);
            login_abbrechen_button.Name = "login_abbrechen_button";
            login_abbrechen_button.Size = new Size(200, 45);
            login_abbrechen_button.TabIndex = 2;
            login_abbrechen_button.Text = "Abbrechen";
            login_abbrechen_button.UseVisualStyleBackColor = false;
            // 
            // login_panel5
            // 
            login_panel5.BackColor = Color.FromArgb(31, 82, 75);
            login_panel5.Controls.Add(login_passwort_textBox);
            login_panel5.Location = new Point(10, 250);
            login_panel5.Name = "login_panel5";
            login_panel5.Size = new Size(460, 48);
            login_panel5.TabIndex = 3;
            // 
            // login_passwort_textBox
            // 
            login_passwort_textBox.BackColor = Color.White;
            login_passwort_textBox.BorderStyle = BorderStyle.FixedSingle;
            login_passwort_textBox.Font = new Font("Tahoma", 16.2F);
            login_passwort_textBox.Location = new Point(4, 4);
            login_passwort_textBox.Name = "login_passwort_textBox";
            login_passwort_textBox.PlaceholderText = "passwort";
            login_passwort_textBox.Size = new Size(452, 40);
            login_passwort_textBox.TabIndex = 1;
            // 
            // login_panel4
            // 
            login_panel4.BackColor = Color.FromArgb(31, 82, 75);
            login_panel4.Controls.Add(login_benutzername_textBox);
            login_panel4.Location = new Point(10, 180);
            login_panel4.Name = "login_panel4";
            login_panel4.Size = new Size(460, 48);
            login_panel4.TabIndex = 2;
            // 
            // login_benutzername_textBox
            // 
            login_benutzername_textBox.BackColor = Color.White;
            login_benutzername_textBox.BorderStyle = BorderStyle.FixedSingle;
            login_benutzername_textBox.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_benutzername_textBox.Location = new Point(4, 4);
            login_benutzername_textBox.Name = "login_benutzername_textBox";
            login_benutzername_textBox.PlaceholderText = "benutzername";
            login_benutzername_textBox.Size = new Size(452, 40);
            login_benutzername_textBox.TabIndex = 0;
            // 
            // login_beenden_button
            // 
            login_beenden_button.BackColor = Color.White;
            login_beenden_button.FlatStyle = FlatStyle.Flat;
            login_beenden_button.Image = (Image)resources.GetObject("login_beenden_button.Image");
            login_beenden_button.Location = new Point(1550, 0);
            login_beenden_button.Name = "login_beenden_button";
            login_beenden_button.Size = new Size(50, 50);
            login_beenden_button.TabIndex = 3;
            login_beenden_button.UseVisualStyleBackColor = false;
            login_beenden_button.Click += login_beenden_button_Click;
            // 
            // login_schneeflocken_pictureBox2
            // 
            login_schneeflocken_pictureBox2.BackColor = Color.White;
            login_schneeflocken_pictureBox2.Image = (Image)resources.GetObject("login_schneeflocken_pictureBox2.Image");
            login_schneeflocken_pictureBox2.Location = new Point(1350, 0);
            login_schneeflocken_pictureBox2.Name = "login_schneeflocken_pictureBox2";
            login_schneeflocken_pictureBox2.Size = new Size(71, 900);
            login_schneeflocken_pictureBox2.TabIndex = 4;
            login_schneeflocken_pictureBox2.TabStop = false;
            // 
            // login_schneeflocken_pictureBox1
            // 
            login_schneeflocken_pictureBox1.BackColor = Color.White;
            login_schneeflocken_pictureBox1.Image = (Image)resources.GetObject("login_schneeflocken_pictureBox1.Image");
            login_schneeflocken_pictureBox1.InitialImage = null;
            login_schneeflocken_pictureBox1.Location = new Point(179, 0);
            login_schneeflocken_pictureBox1.Name = "login_schneeflocken_pictureBox1";
            login_schneeflocken_pictureBox1.Size = new Size(71, 900);
            login_schneeflocken_pictureBox1.TabIndex = 6;
            login_schneeflocken_pictureBox1.TabStop = false;
            // 
            // login_panel6
            // 
            login_panel6.BackColor = Color.White;
            login_panel6.Location = new Point(174, 0);
            login_panel6.Name = "login_panel6";
            login_panel6.Size = new Size(81, 900);
            login_panel6.TabIndex = 8;
            // 
            // login_panel7
            // 
            login_panel7.BackColor = Color.White;
            login_panel7.Location = new Point(1345, 0);
            login_panel7.Name = "login_panel7";
            login_panel7.Size = new Size(81, 900);
            login_panel7.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1600, 900);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 82, 75);
            ClientSize = new Size(1600, 900);
            ControlBox = false;
            Controls.Add(login_schneeflocken_pictureBox1);
            Controls.Add(login_schneeflocken_pictureBox2);
            Controls.Add(login_beenden_button);
            Controls.Add(login_panel2);
            Controls.Add(login_panel1);
            Controls.Add(login_panel6);
            Controls.Add(login_panel7);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            login_panel2.ResumeLayout(false);
            login_panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)login_nutzer_pictureBox).EndInit();
            login_panel5.ResumeLayout(false);
            login_panel5.PerformLayout();
            login_panel4.ResumeLayout(false);
            login_panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)login_schneeflocken_pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)login_schneeflocken_pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel login_panel1;
        private Panel login_panel2;
        private Panel login_panel3;
        private TextBox login_passwort_textBox;
        private TextBox login_benutzername_textBox;
        private Panel login_panel4;
        private Panel login_panel5;
        private Button login_anmelden_button;
        private Button login_abbrechen_button;
        private PictureBox login_nutzer_pictureBox;
        private Button login_beenden_button;
        private PictureBox login_schneeflocken_pictureBox2;
        private PictureBox login_schneeflocken_pictureBox1;
        private Panel login_panel6;
        private Panel login_panel7;
        private PictureBox pictureBox1;
    }
}