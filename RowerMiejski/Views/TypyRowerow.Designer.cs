
namespace RowerMiejski.Views
{
    partial class TypyRowerow
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
        public System.Windows.Forms.DataGridView getTypyRowerowDataGridView()
        {
            return typyRowerowDataGridView;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typyRowerowDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.typyRowerowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // typyRowerowDataGridView
            // 
            this.typyRowerowDataGridView.AllowUserToAddRows = false;
            this.typyRowerowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typyRowerowDataGridView.Location = new System.Drawing.Point(38, 37);
            this.typyRowerowDataGridView.Name = "typyRowerowDataGridView";
            this.typyRowerowDataGridView.RowHeadersWidth = 51;
            this.typyRowerowDataGridView.RowTemplate.Height = 29;
            this.typyRowerowDataGridView.Size = new System.Drawing.Size(723, 332);
            this.typyRowerowDataGridView.TabIndex = 0;
            this.typyRowerowDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.typyRowerowCellValueChanged);
            this.typyRowerowDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.typyRowerow_DataError);
            // 
            // TypyRowerow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.typyRowerowDataGridView);
            this.Name = "TypyRowerow";
            this.Text = "TypyRowerow";
            ((System.ComponentModel.ISupportInitialize)(this.typyRowerowDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView typyRowerowDataGridView;
    }
}