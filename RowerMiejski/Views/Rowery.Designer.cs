
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "Wypożycz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(403, 286);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 22);
            this.button2.TabIndex = 2;
            this.button2.Text = "Zgłoś usterkę";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Rowery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewRowery);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rowery";
            this.Text = "Rowery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRowery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRowery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}