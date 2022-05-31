namespace Equipment_Purchase_Support
{
    partial class FrmIzvjestajOBrojuZahtjeva
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
            this.dataGridView_BROJ = new System.Windows.Forms.DataGridView();
            this.button_ASC = new System.Windows.Forms.Button();
            this.button_DSC = new System.Windows.Forms.Button();
            this.button_Zatvori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BROJ)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_BROJ
            // 
            this.dataGridView_BROJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BROJ.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_BROJ.Name = "dataGridView_BROJ";
            this.dataGridView_BROJ.RowHeadersWidth = 62;
            this.dataGridView_BROJ.RowTemplate.Height = 28;
            this.dataGridView_BROJ.Size = new System.Drawing.Size(378, 506);
            this.dataGridView_BROJ.TabIndex = 0;
            // 
            // button_ASC
            // 
            this.button_ASC.Location = new System.Drawing.Point(411, 54);
            this.button_ASC.Name = "button_ASC";
            this.button_ASC.Size = new System.Drawing.Size(137, 50);
            this.button_ASC.TabIndex = 1;
            this.button_ASC.Text = "ASC";
            this.button_ASC.UseVisualStyleBackColor = true;
            this.button_ASC.Click += new System.EventHandler(this.button_ASC_Click);
            // 
            // button_DSC
            // 
            this.button_DSC.Location = new System.Drawing.Point(411, 129);
            this.button_DSC.Name = "button_DSC";
            this.button_DSC.Size = new System.Drawing.Size(137, 50);
            this.button_DSC.TabIndex = 2;
            this.button_DSC.Text = "DSC";
            this.button_DSC.UseVisualStyleBackColor = true;
            this.button_DSC.Click += new System.EventHandler(this.button_DSC_Click);
            // 
            // button_Zatvori
            // 
            this.button_Zatvori.Location = new System.Drawing.Point(654, 452);
            this.button_Zatvori.Name = "button_Zatvori";
            this.button_Zatvori.Size = new System.Drawing.Size(137, 50);
            this.button_Zatvori.TabIndex = 3;
            this.button_Zatvori.Text = "Zatvori";
            this.button_Zatvori.UseVisualStyleBackColor = true;
            this.button_Zatvori.Click += new System.EventHandler(this.button_Zatvori_Click);
            // 
            // FrmIzvjestajOBrojuZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 530);
            this.Controls.Add(this.button_Zatvori);
            this.Controls.Add(this.button_DSC);
            this.Controls.Add(this.button_ASC);
            this.Controls.Add(this.dataGridView_BROJ);
            this.Name = "FrmIzvjestajOBrojuZahtjeva";
            this.ShowIcon = false;
            this.Text = "Izvještaj o broju zahtjeva po izvoru financiranja";
            this.Load += new System.EventHandler(this.FrmIzvjestajOBrojuZahtjeva_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BROJ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_BROJ;
        private System.Windows.Forms.Button button_ASC;
        private System.Windows.Forms.Button button_DSC;
        private System.Windows.Forms.Button button_Zatvori;
    }
}