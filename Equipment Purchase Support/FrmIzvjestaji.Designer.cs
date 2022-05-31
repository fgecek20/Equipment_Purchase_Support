namespace Equipment_Purchase_Support
{
    partial class FrmIzvjestaji
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
            this.button_BrojZahtjeva = new System.Windows.Forms.Button();
            this.button_Trajanje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_BrojZahtjeva
            // 
            this.button_BrojZahtjeva.Location = new System.Drawing.Point(127, 133);
            this.button_BrojZahtjeva.Name = "button_BrojZahtjeva";
            this.button_BrojZahtjeva.Size = new System.Drawing.Size(251, 79);
            this.button_BrojZahtjeva.TabIndex = 0;
            this.button_BrojZahtjeva.Text = "O broju zahtjeva po izvoru financiranja";
            this.button_BrojZahtjeva.UseVisualStyleBackColor = true;
            this.button_BrojZahtjeva.Click += new System.EventHandler(this.button_BrojZahtjeva_Click);
            // 
            // button_Trajanje
            // 
            this.button_Trajanje.Location = new System.Drawing.Point(127, 227);
            this.button_Trajanje.Name = "button_Trajanje";
            this.button_Trajanje.Size = new System.Drawing.Size(251, 79);
            this.button_Trajanje.TabIndex = 1;
            this.button_Trajanje.Text = "O vremenima trajanja ispunjenja zahtjeva";
            this.button_Trajanje.UseVisualStyleBackColor = true;
            // 
            // FrmIzvjestaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 454);
            this.Controls.Add(this.button_Trajanje);
            this.Controls.Add(this.button_BrojZahtjeva);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmIzvjestaji";
            this.ShowIcon = false;
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.FrmIzvjestaji_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_BrojZahtjeva;
        private System.Windows.Forms.Button button_Trajanje;
    }
}