﻿namespace RashoApp
{
    partial class uiPrijava
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
            this.uiOznakaLozinka = new System.Windows.Forms.Label();
            this.uiOznakaKorisničkoIme = new System.Windows.Forms.Label();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.uiInputKorisničkoIme = new System.Windows.Forms.TextBox();
            this.uiAkcijaPrijaviSe = new System.Windows.Forms.Button();
            this.HelpPrijava = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // uiOznakaLozinka
            // 
            this.uiOznakaLozinka.AutoSize = true;
            this.uiOznakaLozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOznakaLozinka.Location = new System.Drawing.Point(62, 64);
            this.uiOznakaLozinka.Name = "uiOznakaLozinka";
            this.uiOznakaLozinka.Size = new System.Drawing.Size(68, 20);
            this.uiOznakaLozinka.TabIndex = 10;
            this.uiOznakaLozinka.Text = "Lozinka:";
            // 
            // uiOznakaKorisničkoIme
            // 
            this.uiOznakaKorisničkoIme.AutoSize = true;
            this.uiOznakaKorisničkoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOznakaKorisničkoIme.Location = new System.Drawing.Point(16, 38);
            this.uiOznakaKorisničkoIme.Name = "uiOznakaKorisničkoIme";
            this.uiOznakaKorisničkoIme.Size = new System.Drawing.Size(114, 20);
            this.uiOznakaKorisničkoIme.TabIndex = 9;
            this.uiOznakaKorisničkoIme.Text = "Korisničko ime:";
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Location = new System.Drawing.Point(136, 64);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.Size = new System.Drawing.Size(100, 20);
            this.uiInputLozinka.TabIndex = 7;
            // 
            // uiInputKorisničkoIme
            // 
            this.uiInputKorisničkoIme.Location = new System.Drawing.Point(136, 38);
            this.uiInputKorisničkoIme.Name = "uiInputKorisničkoIme";
            this.uiInputKorisničkoIme.Size = new System.Drawing.Size(100, 20);
            this.uiInputKorisničkoIme.TabIndex = 6;
            // 
            // uiAkcijaPrijaviSe
            // 
            this.uiAkcijaPrijaviSe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiAkcijaPrijaviSe.Location = new System.Drawing.Point(97, 106);
            this.uiAkcijaPrijaviSe.Name = "uiAkcijaPrijaviSe";
            this.uiAkcijaPrijaviSe.Size = new System.Drawing.Size(103, 42);
            this.uiAkcijaPrijaviSe.TabIndex = 11;
            this.uiAkcijaPrijaviSe.Text = "Prijavi se";
            this.uiAkcijaPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // HelpPrijava
            // 
            this.HelpPrijava.HelpNamespace = "C:\\Users\\filip\\Desktop\\help.html";
            // 
            // uiPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 169);
            this.Controls.Add(this.uiAkcijaPrijaviSe);
            this.Controls.Add(this.uiOznakaLozinka);
            this.Controls.Add(this.uiOznakaKorisničkoIme);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisničkoIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uiPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uiOznakaLozinka;
        private System.Windows.Forms.Label uiOznakaKorisničkoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.TextBox uiInputKorisničkoIme;
        private System.Windows.Forms.Button uiAkcijaPrijaviSe;
        private System.Windows.Forms.HelpProvider HelpPrijava;
    }
}