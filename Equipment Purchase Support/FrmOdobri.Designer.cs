namespace Equipment_Purchase_Support
{
    partial class FrmOdobri
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
            this.dataGridView_Requests = new System.Windows.Forms.DataGridView();
            this.button_ObradiZahtjev = new System.Windows.Forms.Button();
            this.button_Odustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Requests)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Requests
            // 
            this.dataGridView_Requests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Requests.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Requests.Name = "dataGridView_Requests";
            this.dataGridView_Requests.RowHeadersWidth = 62;
            this.dataGridView_Requests.RowTemplate.Height = 28;
            this.dataGridView_Requests.Size = new System.Drawing.Size(685, 516);
            this.dataGridView_Requests.TabIndex = 0;
            this.dataGridView_Requests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Requests_CellContentClick);
            // 
            // button_ObradiZahtjev
            // 
            this.button_ObradiZahtjev.Location = new System.Drawing.Point(937, 405);
            this.button_ObradiZahtjev.Name = "button_ObradiZahtjev";
            this.button_ObradiZahtjev.Size = new System.Drawing.Size(167, 52);
            this.button_ObradiZahtjev.TabIndex = 1;
            this.button_ObradiZahtjev.Text = "Obradi zahtjev";
            this.button_ObradiZahtjev.UseVisualStyleBackColor = true;
            this.button_ObradiZahtjev.Click += new System.EventHandler(this.button_ObradiZahtjev_Click);
            // 
            // button_Odustani
            // 
            this.button_Odustani.Location = new System.Drawing.Point(937, 476);
            this.button_Odustani.Name = "button_Odustani";
            this.button_Odustani.Size = new System.Drawing.Size(167, 52);
            this.button_Odustani.TabIndex = 2;
            this.button_Odustani.Text = "Odustani";
            this.button_Odustani.UseVisualStyleBackColor = true;
            this.button_Odustani.Click += new System.EventHandler(this.button_Odustani_Click);
            // 
            // FrmOdobri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 540);
            this.Controls.Add(this.button_Odustani);
            this.Controls.Add(this.button_ObradiZahtjev);
            this.Controls.Add(this.dataGridView_Requests);
            this.Name = "FrmOdobri";
            this.ShowIcon = false;
            this.Text = "Odobri";
            this.Load += new System.EventHandler(this.Odobri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Requests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Requests;
        private System.Windows.Forms.Button button_ObradiZahtjev;
        private System.Windows.Forms.Button button_Odustani;
    }
}