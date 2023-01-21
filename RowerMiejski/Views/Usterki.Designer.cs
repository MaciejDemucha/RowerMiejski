
namespace RowerMiejski.Views
{
    partial class Usterki
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
            this.usterkiDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonMojeUsterki = new System.Windows.Forms.Button();
            this.buttonVerify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usterkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usterkiDataGridView
            // 
            this.usterkiDataGridView.AllowUserToAddRows = false;
            this.usterkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usterkiDataGridView.Location = new System.Drawing.Point(42, 28);
            this.usterkiDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usterkiDataGridView.Name = "usterkiDataGridView";
            this.usterkiDataGridView.RowHeadersWidth = 51;
            this.usterkiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usterkiDataGridView.Size = new System.Drawing.Size(620, 218);
            this.usterkiDataGridView.TabIndex = 0;
            // 
            // buttonMojeUsterki
            // 
            this.buttonMojeUsterki.Location = new System.Drawing.Point(152, 274);
            this.buttonMojeUsterki.Name = "buttonMojeUsterki";
            this.buttonMojeUsterki.Size = new System.Drawing.Size(85, 26);
            this.buttonMojeUsterki.TabIndex = 3;
            this.buttonMojeUsterki.Text = "Moje usterki";
            this.buttonMojeUsterki.UseVisualStyleBackColor = true;
            this.buttonMojeUsterki.Click += new System.EventHandler(this.buttonMoje_Click);
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(462, 274);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(91, 28);
            this.buttonVerify.TabIndex = 1;
            this.buttonVerify.Text = "Zweryfikuj";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // Usterki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonMojeUsterki);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.usterkiDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Usterki";
            this.Text = "Usterki";
            ((System.ComponentModel.ISupportInitialize)(this.usterkiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usterkiDataGridView;
        private System.Windows.Forms.Button buttonMojeUsterki;
        private System.Windows.Forms.Button buttonVerify;
    }
}