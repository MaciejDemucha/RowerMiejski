
namespace RowerMiejski.Views
{
    partial class WidokGlownyUzytkownik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxMoney = new System.Windows.Forms.TextBox();
            this.buttonZwrocRower = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonStacje = new System.Windows.Forms.Button();
            this.buttonKonto = new System.Windows.Forms.Button();
            this.buttonMoney = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBike = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wypożyczony rower:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cena za minutę:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Czas wypożyczenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stan konta:";
            // 
            // textBoxMoney
            // 
            this.textBoxMoney.Location = new System.Drawing.Point(646, 141);
            this.textBoxMoney.Name = "textBoxMoney";
            this.textBoxMoney.Size = new System.Drawing.Size(125, 27);
            this.textBoxMoney.TabIndex = 5;
            // 
            // buttonZwrocRower
            // 
            this.buttonZwrocRower.Location = new System.Drawing.Point(137, 359);
            this.buttonZwrocRower.Name = "buttonZwrocRower";
            this.buttonZwrocRower.Size = new System.Drawing.Size(118, 52);
            this.buttonZwrocRower.TabIndex = 6;
            this.buttonZwrocRower.Text = "Zwróć rower";
            this.buttonZwrocRower.UseVisualStyleBackColor = true;
            this.buttonZwrocRower.Click += new System.EventHandler(this.buttonZwrocRower_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(295, 360);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(111, 51);
            this.buttonHistory.TabIndex = 7;
            this.buttonHistory.Text = "Historia wypożyczeń";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonStacje
            // 
            this.buttonStacje.Location = new System.Drawing.Point(448, 360);
            this.buttonStacje.Name = "buttonStacje";
            this.buttonStacje.Size = new System.Drawing.Size(105, 51);
            this.buttonStacje.TabIndex = 8;
            this.buttonStacje.Text = "Wyświetl stacje";
            this.buttonStacje.UseVisualStyleBackColor = true;
            this.buttonStacje.Click += new System.EventHandler(this.buttonStacje_Click);
            // 
            // buttonKonto
            // 
            this.buttonKonto.Location = new System.Drawing.Point(603, 360);
            this.buttonKonto.Name = "buttonKonto";
            this.buttonKonto.Size = new System.Drawing.Size(97, 52);
            this.buttonKonto.TabIndex = 9;
            this.buttonKonto.Text = "Konto";
            this.buttonKonto.UseVisualStyleBackColor = true;
            this.buttonKonto.Click += new System.EventHandler(this.buttonKonto_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.Location = new System.Drawing.Point(499, 135);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(117, 40);
            this.buttonMoney.TabIndex = 10;
            this.buttonMoney.Text = "Doładuj konto";
            this.buttonMoney.UseVisualStyleBackColor = true;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(261, 236);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(63, 20);
            this.timeLabel.TabIndex = 11;
            this.timeLabel.Text = "00:00:00";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(671, 59);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(67, 20);
            this.labelBalance.TabIndex = 12;
            this.labelBalance.Text = "000.00 zł";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(237, 173);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 20);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "cena";
            this.labelPrice.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelBike
            // 
            this.labelBike.AutoSize = true;
            this.labelBike.Location = new System.Drawing.Point(261, 109);
            this.labelBike.Name = "labelBike";
            this.labelBike.Size = new System.Drawing.Size(141, 20);
            this.labelBike.TabIndex = 14;
            this.labelBike.Text = "wypożyczony_rower";
            this.labelBike.Click += new System.EventHandler(this.labelBike_Click);
            // 
            // WidokGlownyUzytkownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.labelBike);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.buttonMoney);
            this.Controls.Add(this.buttonKonto);
            this.Controls.Add(this.buttonStacje);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonZwrocRower);
            this.Controls.Add(this.textBoxMoney);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WidokGlownyUzytkownik";
            this.Text = "WidokGlownyUzytkownik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.widokGlownyUzytkownik_closing);
            this.Load += new System.EventHandler(this.WidokGlownyUzytkownik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxMoney;
        private System.Windows.Forms.Button buttonZwrocRower;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonStacje;
        private System.Windows.Forms.Button buttonKonto;
        private System.Windows.Forms.Button buttonMoney;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBike;
    }
}