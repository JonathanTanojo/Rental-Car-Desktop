
namespace SAA_Rental_Car
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.dtptanggalakhir = new System.Windows.Forms.DateTimePicker();
            this.dtptanggalawal = new System.Windows.Forms.DateTimePicker();
            this.cboxpilihan = new System.Windows.Forms.ComboBox();
            this.cboxkota = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtptanggalakhir
            // 
            this.dtptanggalakhir.Location = new System.Drawing.Point(172, 253);
            this.dtptanggalakhir.Name = "dtptanggalakhir";
            this.dtptanggalakhir.Size = new System.Drawing.Size(200, 20);
            this.dtptanggalakhir.TabIndex = 0;
            this.dtptanggalakhir.ValueChanged += new System.EventHandler(this.dtptanggalakhir_ValueChanged);
            // 
            // dtptanggalawal
            // 
            this.dtptanggalawal.Location = new System.Drawing.Point(172, 125);
            this.dtptanggalawal.Name = "dtptanggalawal";
            this.dtptanggalawal.Size = new System.Drawing.Size(200, 20);
            this.dtptanggalawal.TabIndex = 1;
            this.dtptanggalawal.ValueChanged += new System.EventHandler(this.dtptanggalawal_ValueChanged);
            // 
            // cboxpilihan
            // 
            this.cboxpilihan.FormattingEnabled = true;
            this.cboxpilihan.Location = new System.Drawing.Point(172, 386);
            this.cboxpilihan.Name = "cboxpilihan";
            this.cboxpilihan.Size = new System.Drawing.Size(121, 21);
            this.cboxpilihan.TabIndex = 2;
            // 
            // cboxkota
            // 
            this.cboxkota.FormattingEnabled = true;
            this.cboxkota.Location = new System.Drawing.Point(480, 124);
            this.cboxkota.Name = "cboxkota";
            this.cboxkota.Size = new System.Drawing.Size(121, 21);
            this.cboxkota.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tanggal awal rental";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tanggal akhir rental";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Supir / non supir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kota Pemesanan";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1164, 575);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nama Lengkap";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(12, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Nama Lengkap";
            this.label7.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 643);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxkota);
            this.Controls.Add(this.cboxpilihan);
            this.Controls.Add(this.dtptanggalawal);
            this.Controls.Add(this.dtptanggalakhir);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtptanggalakhir;
        private System.Windows.Forms.DateTimePicker dtptanggalawal;
        private System.Windows.Forms.ComboBox cboxpilihan;
        private System.Windows.Forms.ComboBox cboxkota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNext;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
    }
}