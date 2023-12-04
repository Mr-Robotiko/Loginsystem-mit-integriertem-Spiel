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
            login_panel1 = new Panel();
            login_panel2 = new Panel();
            login_panel3 = new Panel();
            login_panel2.SuspendLayout();
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
            login_panel3.Location = new Point(5, 5);
            login_panel3.Name = "login_panel3";
            login_panel3.Size = new Size(480, 380);
            login_panel3.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel login_panel1;
        private Panel login_panel2;
        private Panel login_panel3;
    }
}