
namespace RowerMiejski.Views
{
    partial class Wypozyczenia
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
            this.dataGridViewHistoria = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHistoria
            // 
            this.dataGridViewHistoria.AllowUserToAddRows = false;
            this.dataGridViewHistoria.AllowUserToDeleteRows = false;
            this.dataGridViewHistoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoria.Location = new System.Drawing.Point(58, 29);
            this.dataGridViewHistoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHistoria.MultiSelect = false;
            this.dataGridViewHistoria.Name = "dataGridViewHistoria";
            this.dataGridViewHistoria.ReadOnly = true;
            this.dataGridViewHistoria.RowHeadersWidth = 51;
            this.dataGridViewHistoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistoria.Size = new System.Drawing.Size(576, 226);
            this.dataGridViewHistoria.TabIndex = 0;
            // 
            // Wypozyczenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.dataGridViewHistoria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Wypozyczenia";
            this.Text = "Wypozyczenia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHistoria;
    }
}