
namespace RowerMiejski.Views
{
    partial class Rowery
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
            this.dataGridViewRowery = new System.Windows.Forms.DataGridView();
            this.buttonWypozycz = new System.Windows.Forms.Button();
            this.buttonUsterka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRowery)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRowery
            // 
            this.dataGridViewRowery.AllowUserToAddRows = false;
            this.dataGridViewRowery.AllowUserToDeleteRows = false;
            this.dataGridViewRowery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRowery.Location = new System.Drawing.Point(60, 24);
            this.dataGridViewRowery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRowery.MultiSelect = false;
            this.dataGridViewRowery.Name = "dataGridViewRowery";
            this.dataGridViewRowery.ReadOnly = true;
            this.dataGridViewRowery.RowHeadersWidth = 51;
            this.dataGridViewRowery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRowery.Size = new System.Drawing.Size(579, 218);
            this.dataGridViewRowery.TabIndex = 0;
            // 
            // buttonWypozycz
            // 
            this.buttonWypozycz.Location = new System.Drawing.Point(172, 286);
            this.buttonWypozycz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWypozycz.Name = "buttonWypozycz";
            this.buttonWypozycz.Size = new System.Drawing.Size(91, 22);
            this.buttonWypozycz.TabIndex = 1;
            this.buttonWypozycz.Text = "Wypożycz";
            this.buttonWypozycz.UseVisualStyleBackColor = true;
            this.buttonWypozycz.Click += new System.EventHandler(this.buttonWypozycz_Click);
            // 
            // buttonUsterka
            // 
            this.buttonUsterka.Location = new System.Drawing.Point(403, 286);
            this.buttonUsterka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsterka.Name = "buttonUsterka";
            this.buttonUsterka.Size = new System.Drawing.Size(105, 22);
            this.buttonUsterka.TabIndex = 2;
            this.buttonUsterka.Text = "Zgłoś usterkę";
            this.buttonUsterka.UseVisualStyleBackColor = true;
            this.buttonUsterka.Click += new System.EventHandler(this.buttonUsterka_Click);
            // 
            // Rowery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonUsterka);
            this.Controls.Add(this.buttonWypozycz);
            this.Controls.Add(this.dataGridViewRowery);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rowery";
            this.Text = "Rowery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRowery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRowery;
        private System.Windows.Forms.Button buttonWypozycz;
        private System.Windows.Forms.Button buttonUsterka;
    }
}