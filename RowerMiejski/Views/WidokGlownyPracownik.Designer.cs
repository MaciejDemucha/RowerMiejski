
namespace RowerMiejski.Views
{
    partial class WidokGlownyPracownik
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
            this.buttonKlienci = new System.Windows.Forms.Button();
            this.buttonStacje = new System.Windows.Forms.Button();
            this.buttonUsterki = new System.Windows.Forms.Button();
            this.buttonTypy = new System.Windows.Forms.Button();
            this.buttonKonto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKlienci
            // 
            this.buttonKlienci.Location = new System.Drawing.Point(58, 52);
            this.buttonKlienci.Name = "buttonKlienci";
            this.buttonKlienci.Size = new System.Drawing.Size(138, 43);
            this.buttonKlienci.TabIndex = 0;
            this.buttonKlienci.Text = "Wyświetl klientów";
            this.buttonKlienci.UseVisualStyleBackColor = true;
            this.buttonKlienci.Click += new System.EventHandler(this.buttonKlienci_Click);
            // 
            // buttonStacje
            // 
            this.buttonStacje.Location = new System.Drawing.Point(58, 125);
            this.buttonStacje.Name = "buttonStacje";
            this.buttonStacje.Size = new System.Drawing.Size(138, 45);
            this.buttonStacje.TabIndex = 1;
            this.buttonStacje.Text = "Wyświetl stacje";
            this.buttonStacje.UseVisualStyleBackColor = true;
            this.buttonStacje.Click += new System.EventHandler(this.buttonStacje_Click);
            // 
            // buttonUsterki
            // 
            this.buttonUsterki.Location = new System.Drawing.Point(58, 205);
            this.buttonUsterki.Name = "buttonUsterki";
            this.buttonUsterki.Size = new System.Drawing.Size(138, 41);
            this.buttonUsterki.TabIndex = 2;
            this.buttonUsterki.Text = "Wyświetl usterki";
            this.buttonUsterki.UseVisualStyleBackColor = true;
            this.buttonUsterki.Click += new System.EventHandler(this.buttonUsterki_Click);
            // 
            // buttonTypy
            // 
            this.buttonTypy.Location = new System.Drawing.Point(58, 283);
            this.buttonTypy.Name = "buttonTypy";
            this.buttonTypy.Size = new System.Drawing.Size(138, 53);
            this.buttonTypy.TabIndex = 3;
            this.buttonTypy.Text = "Wyświetl typy rowerów i ceny";
            this.buttonTypy.UseVisualStyleBackColor = true;
            this.buttonTypy.Click += new System.EventHandler(this.buttonTypy_Click);
            // 
            // buttonKonto
            // 
            this.buttonKonto.Location = new System.Drawing.Point(431, 52);
            this.buttonKonto.Name = "buttonKonto";
            this.buttonKonto.Size = new System.Drawing.Size(94, 36);
            this.buttonKonto.TabIndex = 4;
            this.buttonKonto.Text = "Konto";
            this.buttonKonto.UseVisualStyleBackColor = true;
            this.buttonKonto.Click += new System.EventHandler(this.buttonKonto_Click);
            // 
            // WidokGlownyPracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 396);
            this.Controls.Add(this.buttonKonto);
            this.Controls.Add(this.buttonTypy);
            this.Controls.Add(this.buttonUsterki);
            this.Controls.Add(this.buttonStacje);
            this.Controls.Add(this.buttonKlienci);
            this.Name = "WidokGlownyPracownik";
            this.Text = "WidokGlownyPracownik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.widokGlownyPracownik_closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKlienci;
        private System.Windows.Forms.Button buttonStacje;
        private System.Windows.Forms.Button buttonUsterki;
        private System.Windows.Forms.Button buttonTypy;
        private System.Windows.Forms.Button buttonKonto;
    }
}