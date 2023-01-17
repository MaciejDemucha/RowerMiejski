
namespace RowerMiejski.Views
{
    partial class WyborStacji
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
            this.comboBoxStacje = new System.Windows.Forms.ComboBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxStacje
            // 
            this.comboBoxStacje.FormattingEnabled = true;
            this.comboBoxStacje.Location = new System.Drawing.Point(53, 67);
            this.comboBoxStacje.Name = "comboBoxStacje";
            this.comboBoxStacje.Size = new System.Drawing.Size(222, 28);
            this.comboBoxStacje.TabIndex = 0;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(107, 365);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(94, 29);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "Wybierz";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // WyborStacji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.comboBoxStacje);
            this.Name = "WyborStacji";
            this.Text = "WyborStacji";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStacje;
        private System.Windows.Forms.Button buttonChoose;
    }
}