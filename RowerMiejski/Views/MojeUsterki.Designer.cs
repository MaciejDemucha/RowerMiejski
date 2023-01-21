namespace RowerMiejski.Views
{
    partial class MojeUsterki
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
            this.mojeUsterkiDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mojeUsterkiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mojeUsterkiDataGridView
            // 
            this.mojeUsterkiDataGridView.AllowUserToAddRows = false;
            this.mojeUsterkiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mojeUsterkiDataGridView.Location = new System.Drawing.Point(28, 23);
            this.mojeUsterkiDataGridView.Name = "mojeUsterkiDataGridView";
            this.mojeUsterkiDataGridView.RowTemplate.Height = 25;
            this.mojeUsterkiDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mojeUsterkiDataGridView.Size = new System.Drawing.Size(740, 328);
            this.mojeUsterkiDataGridView.TabIndex = 0;
            // 
            // buttonReject
            // 
            this.buttonReject.Location = new System.Drawing.Point(359, 384);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(75, 23);
            this.buttonReject.TabIndex = 1;
            this.buttonReject.Text = "Odrzuć";
            this.buttonReject.UseVisualStyleBackColor = true;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // MojeUsterki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReject);
            this.Controls.Add(this.mojeUsterkiDataGridView);
            this.Name = "MojeUsterki";
            this.Text = "MojeUsterki";
            ((System.ComponentModel.ISupportInitialize)(this.mojeUsterkiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView mojeUsterkiDataGridView;
        private System.Windows.Forms.Button buttonReject;
    }
}