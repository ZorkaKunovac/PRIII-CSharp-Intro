﻿namespace P4___LoginForm
{
    partial class DbStudenti
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
            this.dgvStudenti = new System.Windows.Forms.DataGridView();
            this.txtImePrezime = new System.Windows.Forms.TextBox();
            this.btnDodajStudenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudenti
            // 
            this.dgvStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudenti.Location = new System.Drawing.Point(12, 44);
            this.dgvStudenti.Name = "dgvStudenti";
            this.dgvStudenti.RowHeadersWidth = 51;
            this.dgvStudenti.RowTemplate.Height = 24;
            this.dgvStudenti.Size = new System.Drawing.Size(357, 150);
            this.dgvStudenti.TabIndex = 0;
            // 
            // txtImePrezime
            // 
            this.txtImePrezime.Location = new System.Drawing.Point(12, 12);
            this.txtImePrezime.Name = "txtImePrezime";
            this.txtImePrezime.Size = new System.Drawing.Size(262, 22);
            this.txtImePrezime.TabIndex = 1;
            // 
            // btnDodajStudenta
            // 
            this.btnDodajStudenta.Location = new System.Drawing.Point(280, 7);
            this.btnDodajStudenta.Name = "btnDodajStudenta";
            this.btnDodajStudenta.Size = new System.Drawing.Size(89, 27);
            this.btnDodajStudenta.TabIndex = 2;
            this.btnDodajStudenta.Text = "Dodaj";
            this.btnDodajStudenta.UseVisualStyleBackColor = true;
            this.btnDodajStudenta.Click += new System.EventHandler(this.btnDodajStudenta_Click);
            // 
            // DbStudenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 216);
            this.Controls.Add(this.btnDodajStudenta);
            this.Controls.Add(this.txtImePrezime);
            this.Controls.Add(this.dgvStudenti);
            this.Name = "DbStudenti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DbStudenti";
            this.Load += new System.EventHandler(this.DbStudenti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudenti;
        private System.Windows.Forms.TextBox txtImePrezime;
        private System.Windows.Forms.Button btnDodajStudenta;
    }
}