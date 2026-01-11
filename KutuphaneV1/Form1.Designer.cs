namespace KutuphaneV1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabYayinEvi = new System.Windows.Forms.TabControl();
            this.tbKitap = new System.Windows.Forms.TabPage();
            this.dtgKitaplar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cbSec = new System.Windows.Forms.ComboBox();
            this.rbKategori = new System.Windows.Forms.RadioButton();
            this.rbYazar = new System.Windows.Forms.RadioButton();
            this.rbKitap = new System.Windows.Forms.RadioButton();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.tbYazar = new System.Windows.Forms.TabPage();
            this.dtgYazarlar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.TabPage();
            this.dtgKategori = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnTurSil = new System.Windows.Forms.Button();
            this.btnTurGuncelle = new System.Windows.Forms.Button();
            this.btnTurEkle = new System.Windows.Forms.Button();
            this.tbKullanici = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKullaniciSil = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnKullaniciEkle = new System.Windows.Forms.Button();
            this.dtgKullanicilar = new System.Windows.Forms.DataGridView();
            this.tabYayinEvleri = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnYayinEviEkle = new System.Windows.Forms.Button();
            this.dtgYayinEvleri = new System.Windows.Forms.DataGridView();
            this.tabYayinEvi.SuspendLayout();
            this.tbKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKitaplar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgYazarlar)).BeginInit();
            this.panel2.SuspendLayout();
            this.tbKategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKategori)).BeginInit();
            this.panel3.SuspendLayout();
            this.tbKullanici.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKullanicilar)).BeginInit();
            this.tabYayinEvleri.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgYayinEvleri)).BeginInit();
            this.SuspendLayout();
            // 
            // tabYayinEvi
            // 
            this.tabYayinEvi.Controls.Add(this.tbKitap);
            this.tabYayinEvi.Controls.Add(this.tbYazar);
            this.tabYayinEvi.Controls.Add(this.tbKategori);
            this.tabYayinEvi.Controls.Add(this.tbKullanici);
            this.tabYayinEvi.Controls.Add(this.tabYayinEvleri);
            this.tabYayinEvi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabYayinEvi.ItemSize = new System.Drawing.Size(200, 50);
            this.tabYayinEvi.Location = new System.Drawing.Point(0, 0);
            this.tabYayinEvi.Name = "tabYayinEvi";
            this.tabYayinEvi.SelectedIndex = 0;
            this.tabYayinEvi.Size = new System.Drawing.Size(1575, 688);
            this.tabYayinEvi.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabYayinEvi.TabIndex = 0;
            // 
            // tbKitap
            // 
            this.tbKitap.Controls.Add(this.dtgKitaplar);
            this.tbKitap.Controls.Add(this.panel1);
            this.tbKitap.Location = new System.Drawing.Point(4, 54);
            this.tbKitap.Name = "tbKitap";
            this.tbKitap.Padding = new System.Windows.Forms.Padding(3);
            this.tbKitap.Size = new System.Drawing.Size(1567, 630);
            this.tbKitap.TabIndex = 0;
            this.tbKitap.Text = "Kitap Yönetimi";
            this.tbKitap.UseVisualStyleBackColor = true;
            // 
            // dtgKitaplar
            // 
            this.dtgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKitaplar.Location = new System.Drawing.Point(3, 85);
            this.dtgKitaplar.Name = "dtgKitaplar";
            this.dtgKitaplar.RowHeadersWidth = 51;
            this.dtgKitaplar.RowTemplate.Height = 24;
            this.dtgKitaplar.Size = new System.Drawing.Size(1561, 542);
            this.dtgKitaplar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnKitapSil);
            this.panel1.Controls.Add(this.btnKitapGuncelle);
            this.panel1.Controls.Add(this.btnKitapEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1561, 82);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Controls.Add(this.cbSec);
            this.groupBox1.Controls.Add(this.rbKategori);
            this.groupBox1.Controls.Add(this.rbYazar);
            this.groupBox1.Controls.Add(this.rbKitap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(654, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme | Arama";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(765, 44);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 32);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(609, 47);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(149, 26);
            this.txtAra.TabIndex = 4;
            // 
            // cbSec
            // 
            this.cbSec.FormattingEnabled = true;
            this.cbSec.Location = new System.Drawing.Point(444, 45);
            this.cbSec.Name = "cbSec";
            this.cbSec.Size = new System.Drawing.Size(159, 28);
            this.cbSec.TabIndex = 3;
            // 
            // rbKategori
            // 
            this.rbKategori.AutoSize = true;
            this.rbKategori.Location = new System.Drawing.Point(303, 44);
            this.rbKategori.Name = "rbKategori";
            this.rbKategori.Size = new System.Drawing.Size(135, 24);
            this.rbKategori.TabIndex = 2;
            this.rbKategori.TabStop = true;
            this.rbKategori.Text = "Türüne Göre";
            this.rbKategori.UseVisualStyleBackColor = true;
            // 
            // rbYazar
            // 
            this.rbYazar.AutoSize = true;
            this.rbYazar.Location = new System.Drawing.Point(159, 44);
            this.rbYazar.Name = "rbYazar";
            this.rbYazar.Size = new System.Drawing.Size(135, 24);
            this.rbYazar.TabIndex = 1;
            this.rbYazar.TabStop = true;
            this.rbYazar.Text = "Yazara Göre";
            this.rbYazar.UseVisualStyleBackColor = true;
            // 
            // rbKitap
            // 
            this.rbKitap.AutoSize = true;
            this.rbKitap.Location = new System.Drawing.Point(27, 44);
            this.rbKitap.Name = "rbKitap";
            this.rbKitap.Size = new System.Drawing.Size(120, 24);
            this.rbKitap.TabIndex = 0;
            this.rbKitap.TabStop = true;
            this.rbKitap.Text = "Kitap Göre";
            this.rbKitap.UseVisualStyleBackColor = true;
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKitapSil.Location = new System.Drawing.Point(440, 0);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(214, 82);
            this.btnKitapSil.TabIndex = 2;
            this.btnKitapSil.Text = "Seçili Kaydı Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKitapGuncelle.Location = new System.Drawing.Point(225, 0);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(215, 82);
            this.btnKitapGuncelle.TabIndex = 1;
            this.btnKitapGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKitapEkle.Location = new System.Drawing.Point(0, 0);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(225, 82);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Yeni Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // tbYazar
            // 
            this.tbYazar.Controls.Add(this.dtgYazarlar);
            this.tbYazar.Controls.Add(this.panel2);
            this.tbYazar.Location = new System.Drawing.Point(4, 54);
            this.tbYazar.Name = "tbYazar";
            this.tbYazar.Padding = new System.Windows.Forms.Padding(3);
            this.tbYazar.Size = new System.Drawing.Size(1567, 630);
            this.tbYazar.TabIndex = 1;
            this.tbYazar.Text = "Yazar Yönetimi";
            this.tbYazar.UseVisualStyleBackColor = true;
            // 
            // dtgYazarlar
            // 
            this.dtgYazarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgYazarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgYazarlar.Location = new System.Drawing.Point(3, 86);
            this.dtgYazarlar.Name = "dtgYazarlar";
            this.dtgYazarlar.ReadOnly = true;
            this.dtgYazarlar.RowHeadersWidth = 51;
            this.dtgYazarlar.RowTemplate.Height = 24;
            this.dtgYazarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgYazarlar.Size = new System.Drawing.Size(1561, 541);
            this.dtgYazarlar.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.btnYazarSil);
            this.panel2.Controls.Add(this.btnYazarGuncelle);
            this.panel2.Controls.Add(this.btnYazarEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1561, 83);
            this.panel2.TabIndex = 0;
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYazarSil.Location = new System.Drawing.Point(446, 0);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(231, 83);
            this.btnYazarSil.TabIndex = 2;
            this.btnYazarSil.Text = "Seçili Kaydı Sil";
            this.btnYazarSil.UseVisualStyleBackColor = true;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYazarGuncelle.Location = new System.Drawing.Point(201, 0);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(245, 83);
            this.btnYazarGuncelle.TabIndex = 1;
            this.btnYazarGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYazarEkle.Location = new System.Drawing.Point(0, 0);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(201, 83);
            this.btnYazarEkle.TabIndex = 0;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // tbKategori
            // 
            this.tbKategori.Controls.Add(this.dtgKategori);
            this.tbKategori.Controls.Add(this.panel3);
            this.tbKategori.Location = new System.Drawing.Point(4, 54);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(1567, 630);
            this.tbKategori.TabIndex = 2;
            this.tbKategori.Text = "Kategori Yönetimi";
            this.tbKategori.UseVisualStyleBackColor = true;
            // 
            // dtgKategori
            // 
            this.dtgKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKategori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKategori.Location = new System.Drawing.Point(0, 83);
            this.dtgKategori.Name = "dtgKategori";
            this.dtgKategori.ReadOnly = true;
            this.dtgKategori.RowHeadersWidth = 51;
            this.dtgKategori.RowTemplate.Height = 24;
            this.dtgKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKategori.Size = new System.Drawing.Size(1567, 547);
            this.dtgKategori.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.btnTurSil);
            this.panel3.Controls.Add(this.btnTurGuncelle);
            this.panel3.Controls.Add(this.btnTurEkle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1567, 83);
            this.panel3.TabIndex = 1;
            // 
            // btnTurSil
            // 
            this.btnTurSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTurSil.Location = new System.Drawing.Point(446, 0);
            this.btnTurSil.Name = "btnTurSil";
            this.btnTurSil.Size = new System.Drawing.Size(231, 83);
            this.btnTurSil.TabIndex = 2;
            this.btnTurSil.Text = "Seçili Kaydı Sil";
            this.btnTurSil.UseVisualStyleBackColor = true;
            // 
            // btnTurGuncelle
            // 
            this.btnTurGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTurGuncelle.Location = new System.Drawing.Point(201, 0);
            this.btnTurGuncelle.Name = "btnTurGuncelle";
            this.btnTurGuncelle.Size = new System.Drawing.Size(245, 83);
            this.btnTurGuncelle.TabIndex = 1;
            this.btnTurGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnTurGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnTurEkle
            // 
            this.btnTurEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTurEkle.Location = new System.Drawing.Point(0, 0);
            this.btnTurEkle.Name = "btnTurEkle";
            this.btnTurEkle.Size = new System.Drawing.Size(201, 83);
            this.btnTurEkle.TabIndex = 0;
            this.btnTurEkle.Text = "Tür  Ekle";
            this.btnTurEkle.UseVisualStyleBackColor = true;
            this.btnTurEkle.Click += new System.EventHandler(this.btnTurEkle_Click);
            // 
            // tbKullanici
            // 
            this.tbKullanici.Controls.Add(this.dtgKullanicilar);
            this.tbKullanici.Controls.Add(this.panel4);
            this.tbKullanici.Location = new System.Drawing.Point(4, 54);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Size = new System.Drawing.Size(1567, 630);
            this.tbKullanici.TabIndex = 3;
            this.tbKullanici.Text = "Kullanıcı Yönetimi";
            this.tbKullanici.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PowderBlue;
            this.panel4.Controls.Add(this.btnKullaniciSil);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.btnKullaniciEkle);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1567, 83);
            this.panel4.TabIndex = 2;
            // 
            // btnKullaniciSil
            // 
            this.btnKullaniciSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKullaniciSil.Location = new System.Drawing.Point(446, 0);
            this.btnKullaniciSil.Name = "btnKullaniciSil";
            this.btnKullaniciSil.Size = new System.Drawing.Size(231, 83);
            this.btnKullaniciSil.TabIndex = 2;
            this.btnKullaniciSil.Text = "Seçili Kaydı Sil";
            this.btnKullaniciSil.UseVisualStyleBackColor = true;
            this.btnKullaniciSil.Click += new System.EventHandler(this.btnKullaniciSil_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(201, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Seçili Kaydı Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnKullaniciEkle
            // 
            this.btnKullaniciEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKullaniciEkle.Location = new System.Drawing.Point(0, 0);
            this.btnKullaniciEkle.Name = "btnKullaniciEkle";
            this.btnKullaniciEkle.Size = new System.Drawing.Size(201, 83);
            this.btnKullaniciEkle.TabIndex = 0;
            this.btnKullaniciEkle.Text = "Kullanıcı  Ekle";
            this.btnKullaniciEkle.UseVisualStyleBackColor = true;
            this.btnKullaniciEkle.Click += new System.EventHandler(this.btnKullaniciEkle_Click);
            // 
            // dtgKullanicilar
            // 
            this.dtgKullanicilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKullanicilar.Location = new System.Drawing.Point(0, 83);
            this.dtgKullanicilar.Name = "dtgKullanicilar";
            this.dtgKullanicilar.ReadOnly = true;
            this.dtgKullanicilar.RowHeadersWidth = 51;
            this.dtgKullanicilar.RowTemplate.Height = 24;
            this.dtgKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKullanicilar.Size = new System.Drawing.Size(1567, 547);
            this.dtgKullanicilar.TabIndex = 3;
            // 
            // tabYayinEvleri
            // 
            this.tabYayinEvleri.Controls.Add(this.dtgYayinEvleri);
            this.tabYayinEvleri.Controls.Add(this.panel5);
            this.tabYayinEvleri.Location = new System.Drawing.Point(4, 54);
            this.tabYayinEvleri.Name = "tabYayinEvleri";
            this.tabYayinEvleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabYayinEvleri.Size = new System.Drawing.Size(1567, 630);
            this.tabYayinEvleri.TabIndex = 4;
            this.tabYayinEvleri.Text = "Yayın Evi Yönetimi";
            this.tabYayinEvleri.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PowderBlue;
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.btnYayinEviEkle);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1561, 83);
            this.panel5.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(446, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seçili Kaydı Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(201, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 83);
            this.button3.TabIndex = 1;
            this.button3.Text = "Seçili Kaydı Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnYayinEviEkle
            // 
            this.btnYayinEviEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYayinEviEkle.Location = new System.Drawing.Point(0, 0);
            this.btnYayinEviEkle.Name = "btnYayinEviEkle";
            this.btnYayinEviEkle.Size = new System.Drawing.Size(201, 83);
            this.btnYayinEviEkle.TabIndex = 0;
            this.btnYayinEviEkle.Text = "Yayın Evi  Ekle";
            this.btnYayinEviEkle.UseVisualStyleBackColor = true;
            this.btnYayinEviEkle.Click += new System.EventHandler(this.btnYayinEviEkle_Click);
            // 
            // dtgYayinEvleri
            // 
            this.dtgYayinEvleri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgYayinEvleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgYayinEvleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgYayinEvleri.Location = new System.Drawing.Point(3, 86);
            this.dtgYayinEvleri.Name = "dtgYayinEvleri";
            this.dtgYayinEvleri.ReadOnly = true;
            this.dtgYayinEvleri.RowHeadersWidth = 51;
            this.dtgYayinEvleri.RowTemplate.Height = 24;
            this.dtgYayinEvleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgYayinEvleri.Size = new System.Drawing.Size(1561, 541);
            this.dtgYayinEvleri.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 688);
            this.Controls.Add(this.tabYayinEvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabYayinEvi.ResumeLayout(false);
            this.tbKitap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKitaplar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbYazar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgYazarlar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tbKategori.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKategori)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tbKullanici.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKullanicilar)).EndInit();
            this.tabYayinEvleri.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgYayinEvleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabYayinEvi;
        private System.Windows.Forms.TabPage tbKitap;
        private System.Windows.Forms.TabPage tbYazar;
        private System.Windows.Forms.TabPage tbKategori;
        private System.Windows.Forms.TabPage tbKullanici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgKitaplar;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.RadioButton rbKategori;
        private System.Windows.Forms.RadioButton rbYazar;
        private System.Windows.Forms.RadioButton rbKitap;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cbSec;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.DataGridView dtgYazarlar;
        private System.Windows.Forms.Button btnYazarSil;
        private System.Windows.Forms.DataGridView dtgKategori;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnTurSil;
        private System.Windows.Forms.Button btnTurGuncelle;
        private System.Windows.Forms.Button btnTurEkle;
        private System.Windows.Forms.DataGridView dtgKullanicilar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKullaniciSil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnKullaniciEkle;
        private System.Windows.Forms.TabPage tabYayinEvleri;
        private System.Windows.Forms.DataGridView dtgYayinEvleri;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnYayinEviEkle;
    }
}

