
namespace RowerMiejski.Views
{
    partial class Uzytkownicy
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
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.buttonWypozyczenia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(49, 29);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 51;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(706, 301);
            this.dataGridViewUsers.TabIndex = 0;
            // 
            // buttonWypozyczenia
            // 
            this.buttonWypozyczenia.Location = new System.Drawing.Point(302, 364);
            this.buttonWypozyczenia.Name = "buttonWypozyczenia";
            this.buttonWypozyczenia.Size = new System.Drawing.Size(170, 51);
            this.buttonWypozyczenia.TabIndex = 1;
            this.buttonWypozyczenia.Text = "Wypożyczenia klienta";
            this.buttonWypozyczenia.UseVisualStyleBackColor = true;
            this.buttonWypozyczenia.Click += new System.EventHandler(this.buttonWypozyczenia_Click);
            // 
            // Uzytkownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.buttonWypozyczenia);
            this.Controls.Add(this.dataGridViewUsers);
            this.Name = "Uzytkownicy";
            this.Text = "Uzytkownicy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonWypozyczenia;
    }
}