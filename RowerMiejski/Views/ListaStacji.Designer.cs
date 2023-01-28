
namespace RowerMiejski.Views
{
    partial class ListaStacji
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
        public System.Windows.Forms.DataGridView getStacjeDataGridView()
        {
            return stacjeDataGridView;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stacjeDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonShowBikes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stacjeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stacjeDataGridView
            // 
            this.stacjeDataGridView.AllowUserToAddRows = false;
            this.stacjeDataGridView.AllowUserToDeleteRows = false;
            this.stacjeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stacjeDataGridView.Location = new System.Drawing.Point(72, 52);
            this.stacjeDataGridView.MultiSelect = false;
            this.stacjeDataGridView.Name = "stacjeDataGridView";
            this.stacjeDataGridView.ReadOnly = true;
            this.stacjeDataGridView.RowHeadersWidth = 51;
            this.stacjeDataGridView.RowTemplate.Height = 29;
            this.stacjeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stacjeDataGridView.Size = new System.Drawing.Size(672, 337);
            this.stacjeDataGridView.TabIndex = 0;
            this.stacjeDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.stacjaDataGridView_CellValueChanged);
            this.stacjeDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.listaStacji_DataError);
            // 
            // buttonShowBikes
            // 
            this.buttonShowBikes.Location = new System.Drawing.Point(310, 412);
            this.buttonShowBikes.Name = "buttonShowBikes";
            this.buttonShowBikes.Size = new System.Drawing.Size(185, 29);
            this.buttonShowBikes.TabIndex = 1;
            this.buttonShowBikes.Text = "Wyświetl rowery na stacji";
            this.buttonShowBikes.UseVisualStyleBackColor = true;
            this.buttonShowBikes.Click += new System.EventHandler(this.buttonShowBikes_Click);
            // 
            // ListaStacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.buttonShowBikes);
            this.Controls.Add(this.stacjeDataGridView);
            this.Name = "ListaStacji";
            this.Text = "ListaStacji";
            ((System.ComponentModel.ISupportInitialize)(this.stacjeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stacjeDataGridView;
        private System.Windows.Forms.Button buttonShowBikes;

    }
}