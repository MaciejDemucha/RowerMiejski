
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonMojeUsterki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usterkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usterkiDataGridView
            // 
            this.usterkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usterkiDataGridView.Location = new System.Drawing.Point(42, 28);
            this.usterkiDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usterkiDataGridView.Name = "usterkiDataGridView";
            this.usterkiDataGridView.RowHeadersWidth = 51;
            this.usterkiDataGridView.Size = new System.Drawing.Size(620, 218);
            this.usterkiDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zweryfikuj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(499, 276);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Odrzuć";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonMojeUsterki
            // 
            this.buttonMojeUsterki.Location = new System.Drawing.Point(66, 276);
            this.buttonMojeUsterki.Name = "buttonMojeUsterki";
            this.buttonMojeUsterki.Size = new System.Drawing.Size(85, 26);
            this.buttonMojeUsterki.TabIndex = 3;
            this.buttonMojeUsterki.Text = "Moje usterki";
            this.buttonMojeUsterki.UseVisualStyleBackColor = true;
            // 
            // Usterki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.buttonMojeUsterki);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usterkiDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Usterki";
            this.Text = "Usterki";
            ((System.ComponentModel.ISupportInitialize)(this.usterkiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usterkiDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonMojeUsterki;
    }
}