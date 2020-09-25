namespace Events
{
    partial class Dogadjaj
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
            this.btnSMS = new System.Windows.Forms.Button();
            this.chTelecom = new System.Windows.Forms.CheckBox();
            this.chEronet = new System.Windows.Forms.CheckBox();
            this.txtPoruka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSMS
            // 
            this.btnSMS.Location = new System.Drawing.Point(277, 57);
            this.btnSMS.Name = "btnSMS";
            this.btnSMS.Size = new System.Drawing.Size(99, 52);
            this.btnSMS.TabIndex = 0;
            this.btnSMS.Text = "Posalji SMS";
            this.btnSMS.UseVisualStyleBackColor = true;
            this.btnSMS.Click += new System.EventHandler(this.btnSMS_Click);
            // 
            // chTelecom
            // 
            this.chTelecom.AutoSize = true;
            this.chTelecom.Location = new System.Drawing.Point(70, 85);
            this.chTelecom.Name = "chTelecom";
            this.chTelecom.Size = new System.Drawing.Size(103, 21);
            this.chTelecom.TabIndex = 1;
            this.chTelecom.Text = "BHTelecom";
            this.chTelecom.UseVisualStyleBackColor = true;
            this.chTelecom.CheckedChanged += new System.EventHandler(this.chTelecom_CheckedChanged);
            // 
            // chEronet
            // 
            this.chEronet.AutoSize = true;
            this.chEronet.Location = new System.Drawing.Point(182, 85);
            this.chEronet.Name = "chEronet";
            this.chEronet.Size = new System.Drawing.Size(72, 21);
            this.chEronet.TabIndex = 2;
            this.chEronet.Text = "Eronet";
            this.chEronet.UseVisualStyleBackColor = true;
            this.chEronet.CheckedChanged += new System.EventHandler(this.chEronet_CheckedChanged);
            // 
            // txtPoruka
            // 
            this.txtPoruka.Location = new System.Drawing.Point(70, 57);
            this.txtPoruka.Name = "txtPoruka";
            this.txtPoruka.Size = new System.Drawing.Size(184, 22);
            this.txtPoruka.TabIndex = 3;
            this.txtPoruka.TextChanged += new System.EventHandler(this.txtPoruka_TextChanged);
            // 
            // Dogadjaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 339);
            this.Controls.Add(this.txtPoruka);
            this.Controls.Add(this.chEronet);
            this.Controls.Add(this.chTelecom);
            this.Controls.Add(this.btnSMS);
            this.Name = "Dogadjaj";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSMS;
        private System.Windows.Forms.CheckBox chTelecom;
        private System.Windows.Forms.CheckBox chEronet;
        private System.Windows.Forms.TextBox txtPoruka;
    }
}

