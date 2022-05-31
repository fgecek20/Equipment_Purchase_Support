namespace Equipment_Purchase_Support
{
    partial class FrmGlavniIzbornik
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
            this.label_PrijavljeniSteKao = new System.Windows.Forms.Label();
            this.label_KorimePrijavljenog = new System.Windows.Forms.Label();
            this.button_NoviZahtjev = new System.Windows.Forms.Button();
            this.button_PopisZahtjeva = new System.Windows.Forms.Button();
            this.button_Odobri = new System.Windows.Forms.Button();
            this.button_Izvjestaji = new System.Windows.Forms.Button();
            this.button_Odjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_PrijavljeniSteKao
            // 
            this.label_PrijavljeniSteKao.AutoSize = true;
            this.label_PrijavljeniSteKao.Location = new System.Drawing.Point(319, 33);
            this.label_PrijavljeniSteKao.Name = "label_PrijavljeniSteKao";
            this.label_PrijavljeniSteKao.Size = new System.Drawing.Size(133, 20);
            this.label_PrijavljeniSteKao.TabIndex = 0;
            this.label_PrijavljeniSteKao.Text = "Prijavljeni ste kao:";
            // 
            // label_KorimePrijavljenog
            // 
            this.label_KorimePrijavljenog.AutoSize = true;
            this.label_KorimePrijavljenog.Location = new System.Drawing.Point(454, 33);
            this.label_KorimePrijavljenog.Name = "label_KorimePrijavljenog";
            this.label_KorimePrijavljenog.Size = new System.Drawing.Size(51, 20);
            this.label_KorimePrijavljenog.TabIndex = 1;
            this.label_KorimePrijavljenog.Text = "label1";
            // 
            // button_NoviZahtjev
            // 
            this.button_NoviZahtjev.Location = new System.Drawing.Point(52, 155);
            this.button_NoviZahtjev.Name = "button_NoviZahtjev";
            this.button_NoviZahtjev.Size = new System.Drawing.Size(211, 69);
            this.button_NoviZahtjev.TabIndex = 2;
            this.button_NoviZahtjev.Text = "Novi zahtjev";
            this.button_NoviZahtjev.UseVisualStyleBackColor = true;
            this.button_NoviZahtjev.Click += new System.EventHandler(this.button_NoviZahtjev_Click);
            // 
            // button_PopisZahtjeva
            // 
            this.button_PopisZahtjeva.Location = new System.Drawing.Point(52, 239);
            this.button_PopisZahtjeva.Name = "button_PopisZahtjeva";
            this.button_PopisZahtjeva.Size = new System.Drawing.Size(211, 69);
            this.button_PopisZahtjeva.TabIndex = 3;
            this.button_PopisZahtjeva.Text = "Popis zahtjeva";
            this.button_PopisZahtjeva.UseVisualStyleBackColor = true;
            this.button_PopisZahtjeva.Click += new System.EventHandler(this.button_PopisZahtjeva_Click);
            // 
            // button_Odobri
            // 
            this.button_Odobri.Location = new System.Drawing.Point(52, 325);
            this.button_Odobri.Name = "button_Odobri";
            this.button_Odobri.Size = new System.Drawing.Size(211, 69);
            this.button_Odobri.TabIndex = 4;
            this.button_Odobri.Text = "button3";
            this.button_Odobri.UseVisualStyleBackColor = true;
            this.button_Odobri.Click += new System.EventHandler(this.button_Odobri_Click);
            // 
            // button_Izvjestaji
            // 
            this.button_Izvjestaji.Location = new System.Drawing.Point(52, 414);
            this.button_Izvjestaji.Name = "button_Izvjestaji";
            this.button_Izvjestaji.Size = new System.Drawing.Size(211, 69);
            this.button_Izvjestaji.TabIndex = 5;
            this.button_Izvjestaji.Text = "Izvještaji";
            this.button_Izvjestaji.UseVisualStyleBackColor = true;
            // 
            // button_Odjava
            // 
            this.button_Odjava.Location = new System.Drawing.Point(52, 616);
            this.button_Odjava.Name = "button_Odjava";
            this.button_Odjava.Size = new System.Drawing.Size(211, 69);
            this.button_Odjava.TabIndex = 6;
            this.button_Odjava.Text = "Odjava";
            this.button_Odjava.UseVisualStyleBackColor = true;
            this.button_Odjava.Click += new System.EventHandler(this.button_Odjava_Click);
            // 
            // FrmGlavniIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 724);
            this.Controls.Add(this.button_Odjava);
            this.Controls.Add(this.button_Izvjestaji);
            this.Controls.Add(this.button_Odobri);
            this.Controls.Add(this.button_PopisZahtjeva);
            this.Controls.Add(this.button_NoviZahtjev);
            this.Controls.Add(this.label_KorimePrijavljenog);
            this.Controls.Add(this.label_PrijavljeniSteKao);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGlavniIzbornik";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equipment Purchase Support";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_PrijavljeniSteKao;
        private System.Windows.Forms.Label label_KorimePrijavljenog;
        private System.Windows.Forms.Button button_NoviZahtjev;
        private System.Windows.Forms.Button button_PopisZahtjeva;
        private System.Windows.Forms.Button button_Odobri;
        private System.Windows.Forms.Button button_Izvjestaji;
        private System.Windows.Forms.Button button_Odjava;
    }
}