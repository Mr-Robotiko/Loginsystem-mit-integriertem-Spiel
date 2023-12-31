namespace Loginsystem
{
    partial class Nutzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nutzer));
            this.background_pictureBox = new System.Windows.Forms.PictureBox();
            this.beenden_button = new System.Windows.Forms.Button();
            this.nutzer_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // background_pictureBox
            // 
            this.background_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("background_pictureBox.Image")));
            this.background_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.background_pictureBox.MaximumSize = new System.Drawing.Size(1280, 720);
            this.background_pictureBox.MinimumSize = new System.Drawing.Size(1280, 720);
            this.background_pictureBox.Name = "background_pictureBox";
            this.background_pictureBox.Size = new System.Drawing.Size(1280, 720);
            this.background_pictureBox.TabIndex = 0;
            this.background_pictureBox.TabStop = false;
            // 
            // beenden_button
            // 
            this.beenden_button.BackColor = System.Drawing.Color.White;
            this.beenden_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beenden_button.ForeColor = System.Drawing.Color.White;
            this.beenden_button.Image = ((System.Drawing.Image)(resources.GetObject("beenden_button.Image")));
            this.beenden_button.Location = new System.Drawing.Point(1240, 0);
            this.beenden_button.MaximumSize = new System.Drawing.Size(40, 40);
            this.beenden_button.MinimumSize = new System.Drawing.Size(40, 40);
            this.beenden_button.Name = "beenden_button";
            this.beenden_button.Size = new System.Drawing.Size(40, 40);
            this.beenden_button.TabIndex = 5;
            this.beenden_button.UseVisualStyleBackColor = false;
            this.beenden_button.Click += new System.EventHandler(this.beenden_button_Click);
            // 
            // nutzer_label
            // 
            this.nutzer_label.AutoSize = true;
            this.nutzer_label.BackColor = System.Drawing.Color.White;
            this.nutzer_label.Font = new System.Drawing.Font("Tahoma", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nutzer_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.nutzer_label.Location = new System.Drawing.Point(12, 9);
            this.nutzer_label.Name = "nutzer_label";
            this.nutzer_label.Size = new System.Drawing.Size(339, 53);
            this.nutzer_label.TabIndex = 6;
            this.nutzer_label.Text = "Hallo, Nutzer !";
            // 
            // Nutzer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(82)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.ControlBox = false;
            this.Controls.Add(this.nutzer_label);
            this.Controls.Add(this.beenden_button);
            this.Controls.Add(this.background_pictureBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Nutzer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.background_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background_pictureBox;
        private System.Windows.Forms.Button beenden_button;
        private System.Windows.Forms.Label nutzer_label;
    }
}