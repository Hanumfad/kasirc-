namespace Terserah_banget
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnclear = new System.Windows.Forms.Button();
            this.txtkembalian = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotalbayar = new System.Windows.Forms.TextBox();
            this.txttotalharga = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtstok = new System.Windows.Forms.TextBox();
            this.cmbnama = new System.Windows.Forms.ComboBox();
            this.cmbjenis = new System.Windows.Forms.ComboBox();
            this.btnbtl = new System.Windows.Forms.Button();
            this.btnhitung = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbdiskon = new System.Windows.Forms.ComboBox();
            this.numuang = new System.Windows.Forms.NumericUpDown();
            this.numjumlah = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numuang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numjumlah)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(501, 328);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(101, 51);
            this.btnclear.TabIndex = 48;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtkembalian
            // 
            this.txtkembalian.Location = new System.Drawing.Point(520, 255);
            this.txtkembalian.Name = "txtkembalian";
            this.txtkembalian.ReadOnly = true;
            this.txtkembalian.Size = new System.Drawing.Size(121, 23);
            this.txtkembalian.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(434, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 46;
            this.label11.Text = "Kembalian :";
            // 
            // txttotalbayar
            // 
            this.txttotalbayar.Location = new System.Drawing.Point(521, 202);
            this.txttotalbayar.Name = "txttotalbayar";
            this.txttotalbayar.ReadOnly = true;
            this.txttotalbayar.Size = new System.Drawing.Size(121, 23);
            this.txttotalbayar.TabIndex = 44;
            // 
            // txttotalharga
            // 
            this.txttotalharga.Location = new System.Drawing.Point(166, 328);
            this.txttotalharga.Name = "txttotalharga";
            this.txttotalharga.ReadOnly = true;
            this.txttotalharga.Size = new System.Drawing.Size(121, 23);
            this.txttotalharga.TabIndex = 42;
            this.txttotalharga.Click += new System.EventHandler(this.txttotalharga_Click);
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(166, 227);
            this.txtharga.Name = "txtharga";
            this.txtharga.ReadOnly = true;
            this.txtharga.Size = new System.Drawing.Size(121, 23);
            this.txtharga.TabIndex = 40;
            // 
            // txtstok
            // 
            this.txtstok.Location = new System.Drawing.Point(166, 178);
            this.txtstok.Name = "txtstok";
            this.txtstok.ReadOnly = true;
            this.txtstok.Size = new System.Drawing.Size(121, 23);
            this.txtstok.TabIndex = 39;
            // 
            // cmbnama
            // 
            this.cmbnama.FormattingEnabled = true;
            this.cmbnama.Items.AddRange(new object[] {
            "Kaos polos",
            "Kaos bergambar"});
            this.cmbnama.Location = new System.Drawing.Point(166, 127);
            this.cmbnama.Name = "cmbnama";
            this.cmbnama.Size = new System.Drawing.Size(121, 23);
            this.cmbnama.TabIndex = 38;
            this.cmbnama.SelectedIndexChanged += new System.EventHandler(this.cmbnama_SelectedIndexChanged);
            // 
            // cmbjenis
            // 
            this.cmbjenis.FormattingEnabled = true;
            this.cmbjenis.Location = new System.Drawing.Point(166, 79);
            this.cmbjenis.Name = "cmbjenis";
            this.cmbjenis.Size = new System.Drawing.Size(121, 23);
            this.cmbjenis.TabIndex = 37;
            this.cmbjenis.SelectedIndexChanged += new System.EventHandler(this.cmbjenis_SelectedIndexChanged);
            // 
            // btnbtl
            // 
            this.btnbtl.Location = new System.Drawing.Point(656, 328);
            this.btnbtl.Name = "btnbtl";
            this.btnbtl.Size = new System.Drawing.Size(101, 51);
            this.btnbtl.TabIndex = 36;
            this.btnbtl.Text = "Exit";
            this.btnbtl.UseVisualStyleBackColor = true;
            this.btnbtl.Click += new System.EventHandler(this.btnbtl_Click);
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(342, 328);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(101, 51);
            this.btnhitung.TabIndex = 35;
            this.btnhitung.Text = "Bayar";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(389, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 19);
            this.label10.TabIndex = 34;
            this.label10.Text = "Uang Pembayaran:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(426, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 33;
            this.label9.Text = "Total Bayar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(454, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 32;
            this.label8.Text = "Diskon :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Harga :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(30, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Jumlah Pakaian :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Harga Per Pakaian :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Stok Pakaian :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nama Pakaian :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Jenis Pakaian :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Jual Beli Pakaian";
            // 
            // cmbdiskon
            // 
            this.cmbdiskon.FormattingEnabled = true;
            this.cmbdiskon.Location = new System.Drawing.Point(520, 100);
            this.cmbdiskon.Name = "cmbdiskon";
            this.cmbdiskon.Size = new System.Drawing.Size(121, 23);
            this.cmbdiskon.TabIndex = 49;
            this.cmbdiskon.SelectedIndexChanged += new System.EventHandler(this.cmbdiskon_SelectedIndexChanged);
            // 
            // numuang
            // 
            this.numuang.Location = new System.Drawing.Point(521, 147);
            this.numuang.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numuang.Name = "numuang";
            this.numuang.Size = new System.Drawing.Size(120, 23);
            this.numuang.TabIndex = 50;
            // 
            // numjumlah
            // 
            this.numjumlah.Location = new System.Drawing.Point(167, 281);
            this.numjumlah.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numjumlah.Name = "numjumlah";
            this.numjumlah.Size = new System.Drawing.Size(120, 23);
            this.numjumlah.TabIndex = 51;
            this.numjumlah.ValueChanged += new System.EventHandler(this.numjumlah_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numjumlah);
            this.Controls.Add(this.numuang);
            this.Controls.Add(this.cmbdiskon);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtkembalian);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txttotalbayar);
            this.Controls.Add(this.txttotalharga);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.cmbnama);
            this.Controls.Add(this.cmbjenis);
            this.Controls.Add(this.btnbtl);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numuang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numjumlah)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnclear;
        private TextBox txtkembalian;
        private Label label11;
        private TextBox txttotalbayar;
        private TextBox txttotalharga;
        private TextBox txtharga;
        private TextBox txtstok;
        private ComboBox cmbnama;
        private ComboBox cmbjenis;
        private Button btnbtl;
        private Button btnhitung;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbdiskon;
        private NumericUpDown numuang;
        private NumericUpDown numjumlah;
    }
}