namespace Equipment_Purchase_Support
{
    partial class FrmNoviZahtjev
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
            this.label_Urbroj = new System.Windows.Forms.Label();
            this.textBox_Urbroj = new System.Windows.Forms.TextBox();
            this.label_NazivOpreme = new System.Windows.Forms.Label();
            this.label_Ponuditelj = new System.Windows.Forms.Label();
            this.label_CijenaBezPDV = new System.Windows.Forms.Label();
            this.label_CijenaPDV = new System.Windows.Forms.Label();
            this.label_Valuta = new System.Windows.Forms.Label();
            this.label_IzvorFinanciranja = new System.Windows.Forms.Label();
            this.label_NazivProjekta = new System.Windows.Forms.Label();
            this.label_VoditeljProjekta = new System.Windows.Forms.Label();
            this.label_Podnositelj = new System.Windows.Forms.Label();
            this.textBox_Naziv = new System.Windows.Forms.TextBox();
            this.textBox_Ponuditelj = new System.Windows.Forms.TextBox();
            this.textBox_CijenaBezPDV = new System.Windows.Forms.TextBox();
            this.textBox_CijenaPDV = new System.Windows.Forms.TextBox();
            this.textBox_NazivProjekta = new System.Windows.Forms.TextBox();
            this.textBox_VoditeljProjekta = new System.Windows.Forms.TextBox();
            this.textBox_IzvorFinanciranja = new System.Windows.Forms.TextBox();
            this.textBox_PodnositeljZahtjeva = new System.Windows.Forms.TextBox();
            this.comboBox_Valuta = new System.Windows.Forms.ComboBox();
            this.button_Odustani = new System.Windows.Forms.Button();
            this.button_Podnesi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Urbroj
            // 
            this.label_Urbroj.AutoSize = true;
            this.label_Urbroj.Location = new System.Drawing.Point(60, 65);
            this.label_Urbroj.Name = "label_Urbroj";
            this.label_Urbroj.Size = new System.Drawing.Size(116, 20);
            this.label_Urbroj.TabIndex = 0;
            this.label_Urbroj.Text = "Urudžbeni broj:";
            // 
            // textBox_Urbroj
            // 
            this.textBox_Urbroj.Location = new System.Drawing.Point(220, 59);
            this.textBox_Urbroj.Name = "textBox_Urbroj";
            this.textBox_Urbroj.Size = new System.Drawing.Size(201, 26);
            this.textBox_Urbroj.TabIndex = 1;
            // 
            // label_NazivOpreme
            // 
            this.label_NazivOpreme.AutoSize = true;
            this.label_NazivOpreme.Location = new System.Drawing.Point(60, 119);
            this.label_NazivOpreme.Name = "label_NazivOpreme";
            this.label_NazivOpreme.Size = new System.Drawing.Size(109, 20);
            this.label_NazivOpreme.TabIndex = 2;
            this.label_NazivOpreme.Text = "Naziv opreme:";
            // 
            // label_Ponuditelj
            // 
            this.label_Ponuditelj.AutoSize = true;
            this.label_Ponuditelj.Location = new System.Drawing.Point(60, 172);
            this.label_Ponuditelj.Name = "label_Ponuditelj";
            this.label_Ponuditelj.Size = new System.Drawing.Size(82, 20);
            this.label_Ponuditelj.TabIndex = 3;
            this.label_Ponuditelj.Text = "Ponuditelj:";
            this.label_Ponuditelj.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_CijenaBezPDV
            // 
            this.label_CijenaBezPDV.AutoSize = true;
            this.label_CijenaBezPDV.Location = new System.Drawing.Point(60, 227);
            this.label_CijenaBezPDV.Name = "label_CijenaBezPDV";
            this.label_CijenaBezPDV.Size = new System.Drawing.Size(138, 20);
            this.label_CijenaBezPDV.TabIndex = 4;
            this.label_CijenaBezPDV.Text = "Cijena bez PDV-a:";
            this.label_CijenaBezPDV.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_CijenaPDV
            // 
            this.label_CijenaPDV.AutoSize = true;
            this.label_CijenaPDV.Location = new System.Drawing.Point(60, 283);
            this.label_CijenaPDV.Name = "label_CijenaPDV";
            this.label_CijenaPDV.Size = new System.Drawing.Size(136, 20);
            this.label_CijenaPDV.TabIndex = 5;
            this.label_CijenaPDV.Text = "Cijena S PDV-om:";
            // 
            // label_Valuta
            // 
            this.label_Valuta.AutoSize = true;
            this.label_Valuta.Location = new System.Drawing.Point(60, 337);
            this.label_Valuta.Name = "label_Valuta";
            this.label_Valuta.Size = new System.Drawing.Size(59, 20);
            this.label_Valuta.TabIndex = 6;
            this.label_Valuta.Text = "Valuta:";
            // 
            // label_IzvorFinanciranja
            // 
            this.label_IzvorFinanciranja.AutoSize = true;
            this.label_IzvorFinanciranja.Location = new System.Drawing.Point(60, 391);
            this.label_IzvorFinanciranja.Name = "label_IzvorFinanciranja";
            this.label_IzvorFinanciranja.Size = new System.Drawing.Size(132, 20);
            this.label_IzvorFinanciranja.TabIndex = 7;
            this.label_IzvorFinanciranja.Text = "Izvor financiranja:";
            // 
            // label_NazivProjekta
            // 
            this.label_NazivProjekta.AutoSize = true;
            this.label_NazivProjekta.Location = new System.Drawing.Point(60, 450);
            this.label_NazivProjekta.Name = "label_NazivProjekta";
            this.label_NazivProjekta.Size = new System.Drawing.Size(112, 20);
            this.label_NazivProjekta.TabIndex = 8;
            this.label_NazivProjekta.Text = "Naziv projekta:";
            // 
            // label_VoditeljProjekta
            // 
            this.label_VoditeljProjekta.AutoSize = true;
            this.label_VoditeljProjekta.Location = new System.Drawing.Point(60, 513);
            this.label_VoditeljProjekta.Name = "label_VoditeljProjekta";
            this.label_VoditeljProjekta.Size = new System.Drawing.Size(127, 20);
            this.label_VoditeljProjekta.TabIndex = 9;
            this.label_VoditeljProjekta.Text = "Voditelj Projekta:";
            // 
            // label_Podnositelj
            // 
            this.label_Podnositelj.AutoSize = true;
            this.label_Podnositelj.Location = new System.Drawing.Point(60, 575);
            this.label_Podnositelj.Name = "label_Podnositelj";
            this.label_Podnositelj.Size = new System.Drawing.Size(155, 20);
            this.label_Podnositelj.TabIndex = 10;
            this.label_Podnositelj.Text = "Podnositelj Zahtjeva:";
            // 
            // textBox_Naziv
            // 
            this.textBox_Naziv.Location = new System.Drawing.Point(220, 113);
            this.textBox_Naziv.Name = "textBox_Naziv";
            this.textBox_Naziv.Size = new System.Drawing.Size(441, 26);
            this.textBox_Naziv.TabIndex = 11;
            // 
            // textBox_Ponuditelj
            // 
            this.textBox_Ponuditelj.Location = new System.Drawing.Point(220, 166);
            this.textBox_Ponuditelj.Name = "textBox_Ponuditelj";
            this.textBox_Ponuditelj.Size = new System.Drawing.Size(441, 26);
            this.textBox_Ponuditelj.TabIndex = 12;
            // 
            // textBox_CijenaBezPDV
            // 
            this.textBox_CijenaBezPDV.Location = new System.Drawing.Point(220, 221);
            this.textBox_CijenaBezPDV.Name = "textBox_CijenaBezPDV";
            this.textBox_CijenaBezPDV.Size = new System.Drawing.Size(201, 26);
            this.textBox_CijenaBezPDV.TabIndex = 13;
            // 
            // textBox_CijenaPDV
            // 
            this.textBox_CijenaPDV.Location = new System.Drawing.Point(220, 277);
            this.textBox_CijenaPDV.Name = "textBox_CijenaPDV";
            this.textBox_CijenaPDV.Size = new System.Drawing.Size(201, 26);
            this.textBox_CijenaPDV.TabIndex = 14;
            // 
            // textBox_NazivProjekta
            // 
            this.textBox_NazivProjekta.Location = new System.Drawing.Point(220, 444);
            this.textBox_NazivProjekta.Name = "textBox_NazivProjekta";
            this.textBox_NazivProjekta.Size = new System.Drawing.Size(441, 26);
            this.textBox_NazivProjekta.TabIndex = 16;
            // 
            // textBox_VoditeljProjekta
            // 
            this.textBox_VoditeljProjekta.Location = new System.Drawing.Point(220, 507);
            this.textBox_VoditeljProjekta.Name = "textBox_VoditeljProjekta";
            this.textBox_VoditeljProjekta.Size = new System.Drawing.Size(441, 26);
            this.textBox_VoditeljProjekta.TabIndex = 17;
            // 
            // textBox_IzvorFinanciranja
            // 
            this.textBox_IzvorFinanciranja.Location = new System.Drawing.Point(220, 385);
            this.textBox_IzvorFinanciranja.Name = "textBox_IzvorFinanciranja";
            this.textBox_IzvorFinanciranja.Size = new System.Drawing.Size(441, 26);
            this.textBox_IzvorFinanciranja.TabIndex = 18;
            // 
            // textBox_PodnositeljZahtjeva
            // 
            this.textBox_PodnositeljZahtjeva.Location = new System.Drawing.Point(220, 569);
            this.textBox_PodnositeljZahtjeva.Name = "textBox_PodnositeljZahtjeva";
            this.textBox_PodnositeljZahtjeva.Size = new System.Drawing.Size(441, 26);
            this.textBox_PodnositeljZahtjeva.TabIndex = 19;
            // 
            // comboBox_Valuta
            // 
            this.comboBox_Valuta.FormattingEnabled = true;
            this.comboBox_Valuta.Items.AddRange(new object[] {
            "AUD",
            "BAM",
            "CAD",
            "CHF",
            "CNY",
            "CZK",
            "EUR",
            "GBP",
            "HRK",
            "JPY",
            "MKD",
            "NOK",
            "NZD",
            "PLN",
            "RSD",
            "USD"});
            this.comboBox_Valuta.Location = new System.Drawing.Point(220, 329);
            this.comboBox_Valuta.Name = "comboBox_Valuta";
            this.comboBox_Valuta.Size = new System.Drawing.Size(102, 28);
            this.comboBox_Valuta.TabIndex = 20;
            // 
            // button_Odustani
            // 
            this.button_Odustani.Location = new System.Drawing.Point(433, 650);
            this.button_Odustani.Name = "button_Odustani";
            this.button_Odustani.Size = new System.Drawing.Size(174, 51);
            this.button_Odustani.TabIndex = 21;
            this.button_Odustani.Text = "Odustani";
            this.button_Odustani.UseVisualStyleBackColor = true;
            this.button_Odustani.Click += new System.EventHandler(this.button_Odustani_Click);
            // 
            // button_Podnesi
            // 
            this.button_Podnesi.Location = new System.Drawing.Point(625, 650);
            this.button_Podnesi.Name = "button_Podnesi";
            this.button_Podnesi.Size = new System.Drawing.Size(174, 51);
            this.button_Podnesi.TabIndex = 22;
            this.button_Podnesi.Text = "Podnesi";
            this.button_Podnesi.UseVisualStyleBackColor = true;
            this.button_Podnesi.Click += new System.EventHandler(this.button_Podnesi_Click);
            // 
            // FrmNoviZahtjev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(955, 790);
            this.Controls.Add(this.button_Podnesi);
            this.Controls.Add(this.button_Odustani);
            this.Controls.Add(this.comboBox_Valuta);
            this.Controls.Add(this.textBox_PodnositeljZahtjeva);
            this.Controls.Add(this.textBox_IzvorFinanciranja);
            this.Controls.Add(this.textBox_VoditeljProjekta);
            this.Controls.Add(this.textBox_NazivProjekta);
            this.Controls.Add(this.textBox_CijenaPDV);
            this.Controls.Add(this.textBox_CijenaBezPDV);
            this.Controls.Add(this.textBox_Ponuditelj);
            this.Controls.Add(this.textBox_Naziv);
            this.Controls.Add(this.label_Podnositelj);
            this.Controls.Add(this.label_VoditeljProjekta);
            this.Controls.Add(this.label_NazivProjekta);
            this.Controls.Add(this.label_IzvorFinanciranja);
            this.Controls.Add(this.label_Valuta);
            this.Controls.Add(this.label_CijenaPDV);
            this.Controls.Add(this.label_CijenaBezPDV);
            this.Controls.Add(this.label_Ponuditelj);
            this.Controls.Add(this.label_NazivOpreme);
            this.Controls.Add(this.textBox_Urbroj);
            this.Controls.Add(this.label_Urbroj);
            this.MaximizeBox = false;
            this.Name = "FrmNoviZahtjev";
            this.ShowIcon = false;
            this.Text = "Novi Zahtjev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Urbroj;
        private System.Windows.Forms.TextBox textBox_Urbroj;
        private System.Windows.Forms.Label label_NazivOpreme;
        private System.Windows.Forms.Label label_Ponuditelj;
        private System.Windows.Forms.Label label_CijenaBezPDV;
        private System.Windows.Forms.Label label_CijenaPDV;
        private System.Windows.Forms.Label label_Valuta;
        private System.Windows.Forms.Label label_IzvorFinanciranja;
        private System.Windows.Forms.Label label_NazivProjekta;
        private System.Windows.Forms.Label label_VoditeljProjekta;
        private System.Windows.Forms.Label label_Podnositelj;
        private System.Windows.Forms.TextBox textBox_Naziv;
        private System.Windows.Forms.TextBox textBox_Ponuditelj;
        private System.Windows.Forms.TextBox textBox_CijenaBezPDV;
        private System.Windows.Forms.TextBox textBox_CijenaPDV;
        private System.Windows.Forms.TextBox textBox_NazivProjekta;
        private System.Windows.Forms.TextBox textBox_VoditeljProjekta;
        private System.Windows.Forms.TextBox textBox_IzvorFinanciranja;
        private System.Windows.Forms.TextBox textBox_PodnositeljZahtjeva;
        private System.Windows.Forms.ComboBox comboBox_Valuta;
        private System.Windows.Forms.Button button_Odustani;
        private System.Windows.Forms.Button button_Podnesi;
    }
}