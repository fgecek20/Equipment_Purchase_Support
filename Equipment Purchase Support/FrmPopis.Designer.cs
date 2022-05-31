namespace Equipment_Purchase_Support
{
    partial class FrmPopis
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
            this.button_MojiZahtjevi = new System.Windows.Forms.Button();
            this.button_SviZahtjevi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.dataGridView_Requests.Size = new System.Drawing.Size(537, 615);
            this.dataGridView_Requests.TabIndex = 0;
            // 
            // button_MojiZahtjevi
            // 
            this.button_MojiZahtjevi.Location = new System.Drawing.Point(568, 24);
            this.button_MojiZahtjevi.Name = "button_MojiZahtjevi";
            this.button_MojiZahtjevi.Size = new System.Drawing.Size(120, 35);
            this.button_MojiZahtjevi.TabIndex = 1;
            this.button_MojiZahtjevi.Text = "Moji Zahtjevi";
            this.button_MojiZahtjevi.UseVisualStyleBackColor = true;
            this.button_MojiZahtjevi.Click += new System.EventHandler(this.button_MojiZahtjevi_Click);
            // 
            // button_SviZahtjevi
            // 
            this.button_SviZahtjevi.Location = new System.Drawing.Point(568, 80);
            this.button_SviZahtjevi.Name = "button_SviZahtjevi";
            this.button_SviZahtjevi.Size = new System.Drawing.Size(120, 35);
            this.button_SviZahtjevi.TabIndex = 2;
            this.button_SviZahtjevi.Text = "Svi zahtjevi";
            this.button_SviZahtjevi.UseVisualStyleBackColor = true;
            this.button_SviZahtjevi.Click += new System.EventHandler(this.button_SviZahtjevi_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(568, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Detalji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(851, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Zatvori";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmPopis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 639);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_SviZahtjevi);
            this.Controls.Add(this.button_MojiZahtjevi);
            this.Controls.Add(this.dataGridView_Requests);
            this.Name = "FrmPopis";
            this.Text = "FrmPopis";
            this.Load += new System.EventHandler(this.FrmPopis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Requests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Requests;
        private System.Windows.Forms.Button button_MojiZahtjevi;
        private System.Windows.Forms.Button button_SviZahtjevi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}