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
            pictureBox1 = new PictureBox();
            anmelden_button = new Button();
            abbrechen_button = new Button();
            login_panel5 = new Panel();
            login_passwort_textBox = new TextBox();
            login_panel4 = new Panel();
            login_benutzername_textBox = new TextBox();
            login_panel2.SuspendLayout();
            login_panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            login_panel5.SuspendLayout();
            login_panel4.SuspendLayout();
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
            login_panel3.Controls.Add(pictureBox1);
            login_panel3.Controls.Add(anmelden_button);
            login_panel3.Controls.Add(abbrechen_button);
            login_panel3.Controls.Add(login_panel5);
            login_panel3.Controls.Add(login_panel4);
            login_panel3.Location = new Point(5, 5);
            login_panel3.Name = "login_panel3";
            login_panel3.Size = new Size(480, 380);
            login_panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // anmelden_button
            // 
            anmelden_button.BackColor = Color.FromArgb(31, 82, 75);
            anmelden_button.FlatStyle = FlatStyle.Flat;
            anmelden_button.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            anmelden_button.ForeColor = Color.White;
            anmelden_button.Location = new Point(270, 320);
            anmelden_button.Name = "anmelden_button";
            anmelden_button.Size = new Size(200, 45);
            anmelden_button.TabIndex = 3;
            anmelden_button.Text = "Anmelden";
            anmelden_button.UseVisualStyleBackColor = false;
            // 
            // abbrechen_button
            // 
            abbrechen_button.BackColor = Color.FromArgb(31, 82, 75);
            abbrechen_button.FlatStyle = FlatStyle.Flat;
            abbrechen_button.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            abbrechen_button.ForeColor = Color.White;
            abbrechen_button.Location = new Point(10, 320);
            abbrechen_button.Name = "abbrechen_button";
            abbrechen_button.Size = new Size(200, 45);
            abbrechen_button.TabIndex = 2;
            abbrechen_button.Text = "Abbrechen";
            abbrechen_button.UseVisualStyleBackColor = false;
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
            login_passwort_textBox.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            login_passwort_textBox.Location = new Point(4, 4);
            login_passwort_textBox.Name = "login_passwort_textBox";
            login_passwort_textBox.PlaceholderText = "Passwort";
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
            login_benutzername_textBox.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            login_benutzername_textBox.Location = new Point(4, 4);
            login_benutzername_textBox.Name = "login_benutzername_textBox";
            login_benutzername_textBox.PlaceholderText = "Benutzername";
            login_benutzername_textBox.Size = new Size(452, 40);
            login_benutzername_textBox.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 82, 75);
            ClientSize = new Size(1600, 900);
            ControlBox = false;
            Controls.Add(login_panel2);
            Controls.Add(login_panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1600, 900);
            MinimumSize = new Size(1600, 900);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            login_panel2.ResumeLayout(false);
            login_panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            login_panel5.ResumeLayout(false);
            login_panel5.PerformLayout();
            login_panel4.ResumeLayout(false);
            login_panel4.PerformLayout();
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
        private Button anmelden_button;
        private Button abbrechen_button;
        private PictureBox pictureBox1;
    }
}