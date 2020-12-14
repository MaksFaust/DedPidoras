namespace AnalizatorZlozonosci_MV50629
{
    partial class AnalizatorAlgorytmowSortowania
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mvLbl_MinProba = new System.Windows.Forms.Label();
            this.mvLbl_MaxProba = new System.Windows.Forms.Label();
            this.mvLbl_DolnaGranica = new System.Windows.Forms.Label();
            this.mvLbl_GornaGranica = new System.Windows.Forms.Label();
            this.mvBtn_WybierzKolorLinii = new System.Windows.Forms.Button();
            this.mvTxt_MinProba = new System.Windows.Forms.TextBox();
            this.mvTxt_RozmiarTabeli = new System.Windows.Forms.TextBox();
            this.mvTxt_DolnaGranica = new System.Windows.Forms.TextBox();
            this.mvTxt_GornaGranica = new System.Windows.Forms.TextBox();
            this.mvLbl_WybierzAlgorytm = new System.Windows.Forms.Label();
            this.mvCb_Algorytm = new System.Windows.Forms.ComboBox();
            this.mvBtn_AkceptacjaDanych = new System.Windows.Forms.Button();
            this.mvLbl_Analizator = new System.Windows.Forms.Label();
            this.mvLbl_WziemikKoloruLinii = new System.Windows.Forms.Label();
            this.mvBtn_ChangeKolor = new System.Windows.Forms.Button();
            this.mvBtn_KolorTla = new System.Windows.Forms.Button();
            this.mvBtn_WziemnikKoloruTla = new System.Windows.Forms.Button();
            this.mvLbl_KolorTla = new System.Windows.Forms.Label();
            this.mvLbl_StylLinii = new System.Windows.Forms.Label();
            this.mvCb_StylLinii = new System.Windows.Forms.ComboBox();
            this.mvLbl_GruboscLinii = new System.Windows.Forms.Label();
            this.mvTb_GruboscLinii = new System.Windows.Forms.TrackBar();
            this.mvLbl_GruboscLiniiLiczbowo = new System.Windows.Forms.Label();
            this.mvPb_WziemnikLinii = new System.Windows.Forms.PictureBox();
            this.mvTxt_GruboscLiczbowo = new System.Windows.Forms.TextBox();
            this.mvLbl_WziemnikWzorcaLinii = new System.Windows.Forms.Label();
            this.mvBtn_Demo = new System.Windows.Forms.Button();
            this.mvBtn_TabelarycznaPrezentacja = new System.Windows.Forms.Button();
            this.mvBtn_GraficznaPrezentacja = new System.Windows.Forms.Button();
            this.mvBtn_Resetuj = new System.Windows.Forms.Button();
            this.mvBtn_TablicaPrzedSortowaniem = new System.Windows.Forms.Button();
            this.mvBtn_TablicaPoSortowaniu = new System.Windows.Forms.Button();
            this.mvDgv_Tablica = new System.Windows.Forms.DataGridView();
            this.mvRozmiarTabeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mvdgvTabelaWynikow = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mvChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mvpbAnimacja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mvTb_GruboscLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvPb_WziemnikLinii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvDgv_Tablica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvdgvTabelaWynikow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvpbAnimacja)).BeginInit();
            this.SuspendLayout();
            // 
            // mvLbl_MinProba
            // 
            this.mvLbl_MinProba.AutoSize = true;
            this.mvLbl_MinProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_MinProba.Location = new System.Drawing.Point(15, 96);
            this.mvLbl_MinProba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_MinProba.Name = "mvLbl_MinProba";
            this.mvLbl_MinProba.Size = new System.Drawing.Size(125, 40);
            this.mvLbl_MinProba.TabIndex = 1;
            this.mvLbl_MinProba.Text = "Minimalna próba\r\nbadawcza";
            this.mvLbl_MinProba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvLbl_MaxProba
            // 
            this.mvLbl_MaxProba.AutoSize = true;
            this.mvLbl_MaxProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_MaxProba.Location = new System.Drawing.Point(15, 153);
            this.mvLbl_MaxProba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_MaxProba.Name = "mvLbl_MaxProba";
            this.mvLbl_MaxProba.Size = new System.Drawing.Size(110, 20);
            this.mvLbl_MaxProba.TabIndex = 2;
            this.mvLbl_MaxProba.Text = "Rozmiar tabeli";
            this.mvLbl_MaxProba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvLbl_DolnaGranica
            // 
            this.mvLbl_DolnaGranica.AutoSize = true;
            this.mvLbl_DolnaGranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_DolnaGranica.Location = new System.Drawing.Point(15, 209);
            this.mvLbl_DolnaGranica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_DolnaGranica.Name = "mvLbl_DolnaGranica";
            this.mvLbl_DolnaGranica.Size = new System.Drawing.Size(107, 20);
            this.mvLbl_DolnaGranica.TabIndex = 3;
            this.mvLbl_DolnaGranica.Text = "Dolna granica";
            this.mvLbl_DolnaGranica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvLbl_GornaGranica
            // 
            this.mvLbl_GornaGranica.AutoSize = true;
            this.mvLbl_GornaGranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_GornaGranica.Location = new System.Drawing.Point(15, 265);
            this.mvLbl_GornaGranica.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_GornaGranica.Name = "mvLbl_GornaGranica";
            this.mvLbl_GornaGranica.Size = new System.Drawing.Size(110, 20);
            this.mvLbl_GornaGranica.TabIndex = 4;
            this.mvLbl_GornaGranica.Text = "Gorna granica";
            this.mvLbl_GornaGranica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvBtn_WybierzKolorLinii
            // 
            this.mvBtn_WybierzKolorLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_WybierzKolorLinii.Location = new System.Drawing.Point(19, 15);
            this.mvBtn_WybierzKolorLinii.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_WybierzKolorLinii.Name = "mvBtn_WybierzKolorLinii";
            this.mvBtn_WybierzKolorLinii.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_WybierzKolorLinii.TabIndex = 5;
            this.mvBtn_WybierzKolorLinii.Text = "Wybierz kolor linii";
            this.mvBtn_WybierzKolorLinii.UseVisualStyleBackColor = true;
            this.mvBtn_WybierzKolorLinii.Click += new System.EventHandler(this.mvBtn_WybierzKolorLinii_Click);
            // 
            // mvTxt_MinProba
            // 
            this.mvTxt_MinProba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvTxt_MinProba.Location = new System.Drawing.Point(19, 121);
            this.mvTxt_MinProba.Margin = new System.Windows.Forms.Padding(4);
            this.mvTxt_MinProba.Name = "mvTxt_MinProba";
            this.mvTxt_MinProba.Size = new System.Drawing.Size(124, 24);
            this.mvTxt_MinProba.TabIndex = 6;
            this.mvTxt_MinProba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mvTxt_MinProba.TextChanged += new System.EventHandler(this.mvTxt_MinProba_TextChanged);
            // 
            // mvTxt_RozmiarTabeli
            // 
            this.mvTxt_RozmiarTabeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvTxt_RozmiarTabeli.Location = new System.Drawing.Point(15, 177);
            this.mvTxt_RozmiarTabeli.Margin = new System.Windows.Forms.Padding(4);
            this.mvTxt_RozmiarTabeli.Name = "mvTxt_RozmiarTabeli";
            this.mvTxt_RozmiarTabeli.Size = new System.Drawing.Size(124, 24);
            this.mvTxt_RozmiarTabeli.TabIndex = 7;
            this.mvTxt_RozmiarTabeli.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mvTxt_RozmiarTabeli.TextChanged += new System.EventHandler(this.mvTxt_RozmiarTabeli_TextChanged);
            // 
            // mvTxt_DolnaGranica
            // 
            this.mvTxt_DolnaGranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvTxt_DolnaGranica.Location = new System.Drawing.Point(22, 243);
            this.mvTxt_DolnaGranica.Margin = new System.Windows.Forms.Padding(4);
            this.mvTxt_DolnaGranica.Name = "mvTxt_DolnaGranica";
            this.mvTxt_DolnaGranica.Size = new System.Drawing.Size(124, 24);
            this.mvTxt_DolnaGranica.TabIndex = 8;
            this.mvTxt_DolnaGranica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mvTxt_DolnaGranica.TextChanged += new System.EventHandler(this.mvTxt_DolnaGranica_TextChanged);
            // 
            // mvTxt_GornaGranica
            // 
            this.mvTxt_GornaGranica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvTxt_GornaGranica.Location = new System.Drawing.Point(19, 299);
            this.mvTxt_GornaGranica.Margin = new System.Windows.Forms.Padding(4);
            this.mvTxt_GornaGranica.Name = "mvTxt_GornaGranica";
            this.mvTxt_GornaGranica.Size = new System.Drawing.Size(124, 24);
            this.mvTxt_GornaGranica.TabIndex = 9;
            this.mvTxt_GornaGranica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mvTxt_GornaGranica.TextChanged += new System.EventHandler(this.mvTxt_GornaGranica_TextChanged);
            // 
            // mvLbl_WybierzAlgorytm
            // 
            this.mvLbl_WybierzAlgorytm.AutoSize = true;
            this.mvLbl_WybierzAlgorytm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_WybierzAlgorytm.Location = new System.Drawing.Point(17, 331);
            this.mvLbl_WybierzAlgorytm.Name = "mvLbl_WybierzAlgorytm";
            this.mvLbl_WybierzAlgorytm.Size = new System.Drawing.Size(203, 20);
            this.mvLbl_WybierzAlgorytm.TabIndex = 10;
            this.mvLbl_WybierzAlgorytm.Text = "Wybierz algorytm do analizy";
            this.mvLbl_WybierzAlgorytm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvCb_Algorytm
            // 
            this.mvCb_Algorytm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvCb_Algorytm.FormattingEnabled = true;
            this.mvCb_Algorytm.Items.AddRange(new object[] {
            "Selected Sort",
            "Insertion Sort",
            "Shell Sort",
            "Shaker Sort"});
            this.mvCb_Algorytm.Location = new System.Drawing.Point(19, 359);
            this.mvCb_Algorytm.Name = "mvCb_Algorytm";
            this.mvCb_Algorytm.Size = new System.Drawing.Size(121, 25);
            this.mvCb_Algorytm.TabIndex = 11;
            // 
            // mvBtn_AkceptacjaDanych
            // 
            this.mvBtn_AkceptacjaDanych.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_AkceptacjaDanych.Location = new System.Drawing.Point(19, 393);
            this.mvBtn_AkceptacjaDanych.Name = "mvBtn_AkceptacjaDanych";
            this.mvBtn_AkceptacjaDanych.Size = new System.Drawing.Size(75, 23);
            this.mvBtn_AkceptacjaDanych.TabIndex = 12;
            this.mvBtn_AkceptacjaDanych.Text = "Akceptacja danych\r\ndla badania\r\neksperymentalnego";
            this.mvBtn_AkceptacjaDanych.UseVisualStyleBackColor = true;
            this.mvBtn_AkceptacjaDanych.Click += new System.EventHandler(this.mvBtn_AkceptacjaDanych_Click);
            // 
            // mvLbl_Analizator
            // 
            this.mvLbl_Analizator.AutoSize = true;
            this.mvLbl_Analizator.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_Analizator.Location = new System.Drawing.Point(318, 15);
            this.mvLbl_Analizator.Name = "mvLbl_Analizator";
            this.mvLbl_Analizator.Size = new System.Drawing.Size(765, 31);
            this.mvLbl_Analizator.TabIndex = 13;
            this.mvLbl_Analizator.Text = "Analizator zloznosci obliczeniowej algorytmow sortowania";
            // 
            // mvLbl_WziemikKoloruLinii
            // 
            this.mvLbl_WziemikKoloruLinii.AutoSize = true;
            this.mvLbl_WziemikKoloruLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_WziemikKoloruLinii.Location = new System.Drawing.Point(309, 96);
            this.mvLbl_WziemikKoloruLinii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_WziemikKoloruLinii.Name = "mvLbl_WziemikKoloruLinii";
            this.mvLbl_WziemikKoloruLinii.Size = new System.Drawing.Size(140, 20);
            this.mvLbl_WziemikKoloruLinii.TabIndex = 14;
            this.mvLbl_WziemikKoloruLinii.Text = "Wziemik koloru linii";
            this.mvLbl_WziemikKoloruLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvBtn_ChangeKolor
            // 
            this.mvBtn_ChangeKolor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mvBtn_ChangeKolor.Enabled = false;
            this.mvBtn_ChangeKolor.Location = new System.Drawing.Point(314, 124);
            this.mvBtn_ChangeKolor.Name = "mvBtn_ChangeKolor";
            this.mvBtn_ChangeKolor.Size = new System.Drawing.Size(75, 23);
            this.mvBtn_ChangeKolor.TabIndex = 15;
            this.mvBtn_ChangeKolor.UseVisualStyleBackColor = false;
            // 
            // mvBtn_KolorTla
            // 
            this.mvBtn_KolorTla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_KolorTla.Location = new System.Drawing.Point(505, 95);
            this.mvBtn_KolorTla.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_KolorTla.Name = "mvBtn_KolorTla";
            this.mvBtn_KolorTla.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_KolorTla.TabIndex = 16;
            this.mvBtn_KolorTla.Text = "Wybierz kolor tla dla obszaru wykresu";
            this.mvBtn_KolorTla.UseVisualStyleBackColor = true;
            this.mvBtn_KolorTla.Click += new System.EventHandler(this.mvBtn_KolorTla_Click);
            // 
            // mvBtn_WziemnikKoloruTla
            // 
            this.mvBtn_WziemnikKoloruTla.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mvBtn_WziemnikKoloruTla.Enabled = false;
            this.mvBtn_WziemnikKoloruTla.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.mvBtn_WziemnikKoloruTla.Location = new System.Drawing.Point(676, 124);
            this.mvBtn_WziemnikKoloruTla.Name = "mvBtn_WziemnikKoloruTla";
            this.mvBtn_WziemnikKoloruTla.Size = new System.Drawing.Size(75, 23);
            this.mvBtn_WziemnikKoloruTla.TabIndex = 18;
            this.mvBtn_WziemnikKoloruTla.UseVisualStyleBackColor = false;
            // 
            // mvLbl_KolorTla
            // 
            this.mvLbl_KolorTla.AutoSize = true;
            this.mvLbl_KolorTla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_KolorTla.Location = new System.Drawing.Point(671, 96);
            this.mvLbl_KolorTla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_KolorTla.Name = "mvLbl_KolorTla";
            this.mvLbl_KolorTla.Size = new System.Drawing.Size(136, 20);
            this.mvLbl_KolorTla.TabIndex = 17;
            this.mvLbl_KolorTla.Text = "Wziemik koloru tla";
            this.mvLbl_KolorTla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvLbl_StylLinii
            // 
            this.mvLbl_StylLinii.AutoSize = true;
            this.mvLbl_StylLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_StylLinii.Location = new System.Drawing.Point(903, 96);
            this.mvLbl_StylLinii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_StylLinii.Name = "mvLbl_StylLinii";
            this.mvLbl_StylLinii.Size = new System.Drawing.Size(159, 20);
            this.mvLbl_StylLinii.TabIndex = 19;
            this.mvLbl_StylLinii.Text = "Ustal styl linii wykresu";
            this.mvLbl_StylLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvCb_StylLinii
            // 
            this.mvCb_StylLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvCb_StylLinii.FormattingEnabled = true;
            this.mvCb_StylLinii.Items.AddRange(new object[] {
            "Dash Dot",
            "Dash",
            "Dash Dot Dot",
            "Dot",
            "Solid"});
            this.mvCb_StylLinii.Location = new System.Drawing.Point(908, 124);
            this.mvCb_StylLinii.Name = "mvCb_StylLinii";
            this.mvCb_StylLinii.Size = new System.Drawing.Size(121, 25);
            this.mvCb_StylLinii.TabIndex = 20;
            this.mvCb_StylLinii.Text = "Wybierz styl linii";
            this.mvCb_StylLinii.SelectedIndexChanged += new System.EventHandler(this.mvCb_StylLinii_SelectedIndexChanged);
            // 
            // mvLbl_GruboscLinii
            // 
            this.mvLbl_GruboscLinii.AutoSize = true;
            this.mvLbl_GruboscLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_GruboscLinii.Location = new System.Drawing.Point(1175, 95);
            this.mvLbl_GruboscLinii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_GruboscLinii.Name = "mvLbl_GruboscLinii";
            this.mvLbl_GruboscLinii.Size = new System.Drawing.Size(139, 40);
            this.mvLbl_GruboscLinii.TabIndex = 21;
            this.mvLbl_GruboscLinii.Text = "Zmien grubosc linii\r\nwykresu";
            this.mvLbl_GruboscLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvTb_GruboscLinii
            // 
            this.mvTb_GruboscLinii.Location = new System.Drawing.Point(1180, 149);
            this.mvTb_GruboscLinii.Maximum = 5;
            this.mvTb_GruboscLinii.Minimum = 1;
            this.mvTb_GruboscLinii.Name = "mvTb_GruboscLinii";
            this.mvTb_GruboscLinii.Size = new System.Drawing.Size(104, 45);
            this.mvTb_GruboscLinii.TabIndex = 22;
            this.mvTb_GruboscLinii.Value = 1;
            this.mvTb_GruboscLinii.Scroll += new System.EventHandler(this.mvTb_GruboscLinii_Scroll);
            // 
            // mvLbl_GruboscLiniiLiczbowo
            // 
            this.mvLbl_GruboscLiniiLiczbowo.AutoSize = true;
            this.mvLbl_GruboscLiniiLiczbowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_GruboscLiniiLiczbowo.Location = new System.Drawing.Point(1175, 196);
            this.mvLbl_GruboscLiniiLiczbowo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_GruboscLiniiLiczbowo.Name = "mvLbl_GruboscLiniiLiczbowo";
            this.mvLbl_GruboscLiniiLiczbowo.Size = new System.Drawing.Size(159, 40);
            this.mvLbl_GruboscLiniiLiczbowo.TabIndex = 23;
            this.mvLbl_GruboscLiniiLiczbowo.Text = "Ustalona grubosc linii\r\n(liczbowo)";
            this.mvLbl_GruboscLiniiLiczbowo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvPb_WziemnikLinii
            // 
            this.mvPb_WziemnikLinii.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mvPb_WziemnikLinii.Location = new System.Drawing.Point(1232, 315);
            this.mvPb_WziemnikLinii.Name = "mvPb_WziemnikLinii";
            this.mvPb_WziemnikLinii.Size = new System.Drawing.Size(100, 50);
            this.mvPb_WziemnikLinii.TabIndex = 24;
            this.mvPb_WziemnikLinii.TabStop = false;
            // 
            // mvTxt_GruboscLiczbowo
            // 
            this.mvTxt_GruboscLiczbowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvTxt_GruboscLiczbowo.Location = new System.Drawing.Point(1208, 250);
            this.mvTxt_GruboscLiczbowo.Margin = new System.Windows.Forms.Padding(4);
            this.mvTxt_GruboscLiczbowo.Name = "mvTxt_GruboscLiczbowo";
            this.mvTxt_GruboscLiczbowo.Size = new System.Drawing.Size(124, 24);
            this.mvTxt_GruboscLiczbowo.TabIndex = 25;
            this.mvTxt_GruboscLiczbowo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mvTxt_GruboscLiczbowo.TextChanged += new System.EventHandler(this.mvTxt_GruboscLiczbowo_TextChanged);
            // 
            // mvLbl_WziemnikWzorcaLinii
            // 
            this.mvLbl_WziemnikWzorcaLinii.AutoSize = true;
            this.mvLbl_WziemnikWzorcaLinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvLbl_WziemnikWzorcaLinii.Location = new System.Drawing.Point(1175, 287);
            this.mvLbl_WziemnikWzorcaLinii.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mvLbl_WziemnikWzorcaLinii.Name = "mvLbl_WziemnikWzorcaLinii";
            this.mvLbl_WziemnikWzorcaLinii.Size = new System.Drawing.Size(156, 20);
            this.mvLbl_WziemnikWzorcaLinii.TabIndex = 26;
            this.mvLbl_WziemnikWzorcaLinii.Text = "Wziemnik wzorca linii";
            this.mvLbl_WziemnikWzorcaLinii.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mvBtn_Demo
            // 
            this.mvBtn_Demo.Enabled = false;
            this.mvBtn_Demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_Demo.Location = new System.Drawing.Point(1180, 563);
            this.mvBtn_Demo.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_Demo.Name = "mvBtn_Demo";
            this.mvBtn_Demo.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_Demo.TabIndex = 27;
            this.mvBtn_Demo.Text = "DEMO";
            this.mvBtn_Demo.UseVisualStyleBackColor = true;
            this.mvBtn_Demo.Click += new System.EventHandler(this.mvBtn_Demo_Click);
            // 
            // mvBtn_TabelarycznaPrezentacja
            // 
            this.mvBtn_TabelarycznaPrezentacja.Enabled = false;
            this.mvBtn_TabelarycznaPrezentacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_TabelarycznaPrezentacja.Location = new System.Drawing.Point(1180, 377);
            this.mvBtn_TabelarycznaPrezentacja.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_TabelarycznaPrezentacja.Name = "mvBtn_TabelarycznaPrezentacja";
            this.mvBtn_TabelarycznaPrezentacja.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_TabelarycznaPrezentacja.TabIndex = 28;
            this.mvBtn_TabelarycznaPrezentacja.Text = "Tabelaryczna\r\nprezentacja\r\nzlozonosci";
            this.mvBtn_TabelarycznaPrezentacja.UseVisualStyleBackColor = true;
            this.mvBtn_TabelarycznaPrezentacja.Click += new System.EventHandler(this.mvBtn_TabelarycznaPrezentacja_Click);
            // 
            // mvBtn_GraficznaPrezentacja
            // 
            this.mvBtn_GraficznaPrezentacja.Enabled = false;
            this.mvBtn_GraficznaPrezentacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_GraficznaPrezentacja.Location = new System.Drawing.Point(1180, 439);
            this.mvBtn_GraficznaPrezentacja.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_GraficznaPrezentacja.Name = "mvBtn_GraficznaPrezentacja";
            this.mvBtn_GraficznaPrezentacja.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_GraficznaPrezentacja.TabIndex = 29;
            this.mvBtn_GraficznaPrezentacja.Text = "Graficzna\r\nprezentacja\r\nzlozonosci";
            this.mvBtn_GraficznaPrezentacja.UseVisualStyleBackColor = true;
            this.mvBtn_GraficznaPrezentacja.Click += new System.EventHandler(this.mvBtn_GraficznaPrezentacja_Click);
            // 
            // mvBtn_Resetuj
            // 
            this.mvBtn_Resetuj.Enabled = false;
            this.mvBtn_Resetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_Resetuj.Location = new System.Drawing.Point(1180, 501);
            this.mvBtn_Resetuj.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_Resetuj.Name = "mvBtn_Resetuj";
            this.mvBtn_Resetuj.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_Resetuj.TabIndex = 30;
            this.mvBtn_Resetuj.Text = "RESETUJ";
            this.mvBtn_Resetuj.UseVisualStyleBackColor = true;
            this.mvBtn_Resetuj.Click += new System.EventHandler(this.mvBtn_Resetuj_Click);
            // 
            // mvBtn_TablicaPrzedSortowaniem
            // 
            this.mvBtn_TablicaPrzedSortowaniem.Enabled = false;
            this.mvBtn_TablicaPrzedSortowaniem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_TablicaPrzedSortowaniem.Location = new System.Drawing.Point(454, 634);
            this.mvBtn_TablicaPrzedSortowaniem.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_TablicaPrzedSortowaniem.Name = "mvBtn_TablicaPrzedSortowaniem";
            this.mvBtn_TablicaPrzedSortowaniem.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_TablicaPrzedSortowaniem.TabIndex = 31;
            this.mvBtn_TablicaPrzedSortowaniem.Text = "Wizualizacja tablicy przed\r\nsortowaniem";
            this.mvBtn_TablicaPrzedSortowaniem.UseVisualStyleBackColor = true;
            this.mvBtn_TablicaPrzedSortowaniem.Click += new System.EventHandler(this.mvBtn_TablicaPrzedSortowaniem_Click);
            // 
            // mvBtn_TablicaPoSortowaniu
            // 
            this.mvBtn_TablicaPoSortowaniu.Enabled = false;
            this.mvBtn_TablicaPoSortowaniu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mvBtn_TablicaPoSortowaniu.Location = new System.Drawing.Point(746, 634);
            this.mvBtn_TablicaPoSortowaniu.Margin = new System.Windows.Forms.Padding(4);
            this.mvBtn_TablicaPoSortowaniu.Name = "mvBtn_TablicaPoSortowaniu";
            this.mvBtn_TablicaPoSortowaniu.Size = new System.Drawing.Size(129, 54);
            this.mvBtn_TablicaPoSortowaniu.TabIndex = 32;
            this.mvBtn_TablicaPoSortowaniu.Text = "Wizualizacja tablicy po\r\nsortowaniu";
            this.mvBtn_TablicaPoSortowaniu.UseVisualStyleBackColor = true;
            this.mvBtn_TablicaPoSortowaniu.Click += new System.EventHandler(this.mvBtn_TablicaPoSortowaniu_Click);
            // 
            // mvDgv_Tablica
            // 
            this.mvDgv_Tablica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mvDgv_Tablica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mvRozmiarTabeli,
            this.Column1});
            this.mvDgv_Tablica.Location = new System.Drawing.Point(193, 331);
            this.mvDgv_Tablica.Name = "mvDgv_Tablica";
            this.mvDgv_Tablica.ReadOnly = true;
            this.mvDgv_Tablica.RowHeadersVisible = false;
            this.mvDgv_Tablica.RowHeadersWidth = 51;
            this.mvDgv_Tablica.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mvDgv_Tablica.RowTemplate.Height = 24;
            this.mvDgv_Tablica.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mvDgv_Tablica.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mvDgv_Tablica.Size = new System.Drawing.Size(538, 252);
            this.mvDgv_Tablica.TabIndex = 34;
            this.mvDgv_Tablica.Visible = false;
            // 
            // mvRozmiarTabeli
            // 
            this.mvRozmiarTabeli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mvRozmiarTabeli.HeaderText = "Numer";
            this.mvRozmiarTabeli.MinimumWidth = 6;
            this.mvRozmiarTabeli.Name = "mvRozmiarTabeli";
            this.mvRozmiarTabeli.ReadOnly = true;
            this.mvRozmiarTabeli.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Element tablicy";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mvdgvTabelaWynikow
            // 
            this.mvdgvTabelaWynikow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mvdgvTabelaWynikow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.mvdgvTabelaWynikow.Location = new System.Drawing.Point(789, 299);
            this.mvdgvTabelaWynikow.Name = "mvdgvTabelaWynikow";
            this.mvdgvTabelaWynikow.RowHeadersVisible = false;
            this.mvdgvTabelaWynikow.RowHeadersWidth = 51;
            this.mvdgvTabelaWynikow.RowTemplate.Height = 24;
            this.mvdgvTabelaWynikow.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mvdgvTabelaWynikow.Size = new System.Drawing.Size(341, 150);
            this.mvdgvTabelaWynikow.TabIndex = 35;
            this.mvdgvTabelaWynikow.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Rozmiar sortowanej tabeli";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Koszt czasowy z pomiaru";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Analtyczny koszt czasowy (na podstawie wzoru)";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Koszt pamięciowy";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // mvChart
            // 
            chartArea6.Name = "ChartArea1";
            this.mvChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.mvChart.Legends.Add(legend6);
            this.mvChart.Location = new System.Drawing.Point(237, 209);
            this.mvChart.Name = "mvChart";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Series1";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "Series2";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series3";
            this.mvChart.Series.Add(series16);
            this.mvChart.Series.Add(series17);
            this.mvChart.Series.Add(series18);
            this.mvChart.Size = new System.Drawing.Size(300, 300);
            this.mvChart.TabIndex = 36;
            this.mvChart.Text = "chart1";
            // 
            // mvpbAnimacja
            // 
            this.mvpbAnimacja.Image = global::AnalizatorZlozonosci_MV50629.Properties.Resources.Insertion;
            this.mvpbAnimacja.Location = new System.Drawing.Point(316, 110);
            this.mvpbAnimacja.Name = "mvpbAnimacja";
            this.mvpbAnimacja.Size = new System.Drawing.Size(746, 445);
            this.mvpbAnimacja.TabIndex = 37;
            this.mvpbAnimacja.TabStop = false;
            this.mvpbAnimacja.Visible = false;
            this.mvpbAnimacja.Click += new System.EventHandler(this.mvpbAnimacja_Click);
            // 
            // AnalizatorAlgorytmowSortowania
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 796);
            this.Controls.Add(this.mvpbAnimacja);
            this.Controls.Add(this.mvChart);
            this.Controls.Add(this.mvdgvTabelaWynikow);
            this.Controls.Add(this.mvDgv_Tablica);
            this.Controls.Add(this.mvBtn_TablicaPoSortowaniu);
            this.Controls.Add(this.mvBtn_TablicaPrzedSortowaniem);
            this.Controls.Add(this.mvBtn_Resetuj);
            this.Controls.Add(this.mvBtn_GraficznaPrezentacja);
            this.Controls.Add(this.mvBtn_TabelarycznaPrezentacja);
            this.Controls.Add(this.mvBtn_Demo);
            this.Controls.Add(this.mvLbl_WziemnikWzorcaLinii);
            this.Controls.Add(this.mvTxt_GruboscLiczbowo);
            this.Controls.Add(this.mvPb_WziemnikLinii);
            this.Controls.Add(this.mvLbl_GruboscLiniiLiczbowo);
            this.Controls.Add(this.mvTb_GruboscLinii);
            this.Controls.Add(this.mvLbl_GruboscLinii);
            this.Controls.Add(this.mvCb_StylLinii);
            this.Controls.Add(this.mvLbl_StylLinii);
            this.Controls.Add(this.mvBtn_WziemnikKoloruTla);
            this.Controls.Add(this.mvLbl_KolorTla);
            this.Controls.Add(this.mvBtn_KolorTla);
            this.Controls.Add(this.mvBtn_ChangeKolor);
            this.Controls.Add(this.mvLbl_WziemikKoloruLinii);
            this.Controls.Add(this.mvLbl_Analizator);
            this.Controls.Add(this.mvBtn_AkceptacjaDanych);
            this.Controls.Add(this.mvCb_Algorytm);
            this.Controls.Add(this.mvLbl_WybierzAlgorytm);
            this.Controls.Add(this.mvTxt_GornaGranica);
            this.Controls.Add(this.mvTxt_DolnaGranica);
            this.Controls.Add(this.mvTxt_RozmiarTabeli);
            this.Controls.Add(this.mvTxt_MinProba);
            this.Controls.Add(this.mvBtn_WybierzKolorLinii);
            this.Controls.Add(this.mvLbl_GornaGranica);
            this.Controls.Add(this.mvLbl_DolnaGranica);
            this.Controls.Add(this.mvLbl_MaxProba);
            this.Controls.Add(this.mvLbl_MinProba);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnalizatorAlgorytmowSortowania";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AnalizatorAlgorytmowSortowania_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mvTb_GruboscLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvPb_WziemnikLinii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvDgv_Tablica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvdgvTabelaWynikow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvpbAnimacja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mvLbl_MinProba;
        private System.Windows.Forms.Label mvLbl_MaxProba;
        private System.Windows.Forms.Label mvLbl_DolnaGranica;
        private System.Windows.Forms.Label mvLbl_GornaGranica;
        private System.Windows.Forms.Button mvBtn_WybierzKolorLinii;
        private System.Windows.Forms.TextBox mvTxt_MinProba;
        private System.Windows.Forms.TextBox mvTxt_RozmiarTabeli;
        private System.Windows.Forms.TextBox mvTxt_DolnaGranica;
        private System.Windows.Forms.TextBox mvTxt_GornaGranica;
        private System.Windows.Forms.Label mvLbl_WybierzAlgorytm;
        private System.Windows.Forms.ComboBox mvCb_Algorytm;
        private System.Windows.Forms.Button mvBtn_AkceptacjaDanych;
        private System.Windows.Forms.Label mvLbl_Analizator;
        private System.Windows.Forms.Label mvLbl_WziemikKoloruLinii;
        private System.Windows.Forms.Button mvBtn_ChangeKolor;
        private System.Windows.Forms.Button mvBtn_KolorTla;
        private System.Windows.Forms.Button mvBtn_WziemnikKoloruTla;
        private System.Windows.Forms.Label mvLbl_KolorTla;
        private System.Windows.Forms.Label mvLbl_StylLinii;
        private System.Windows.Forms.ComboBox mvCb_StylLinii;
        private System.Windows.Forms.Label mvLbl_GruboscLinii;
        private System.Windows.Forms.TrackBar mvTb_GruboscLinii;
        private System.Windows.Forms.Label mvLbl_GruboscLiniiLiczbowo;
        private System.Windows.Forms.PictureBox mvPb_WziemnikLinii;
        private System.Windows.Forms.TextBox mvTxt_GruboscLiczbowo;
        private System.Windows.Forms.Label mvLbl_WziemnikWzorcaLinii;
        private System.Windows.Forms.Button mvBtn_Demo;
        private System.Windows.Forms.Button mvBtn_TabelarycznaPrezentacja;
        private System.Windows.Forms.Button mvBtn_GraficznaPrezentacja;
        private System.Windows.Forms.Button mvBtn_Resetuj;
        private System.Windows.Forms.Button mvBtn_TablicaPrzedSortowaniem;
        private System.Windows.Forms.Button mvBtn_TablicaPoSortowaniu;
        private System.Windows.Forms.DataGridView mvDgv_Tablica;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView mvdgvTabelaWynikow;
        private System.Windows.Forms.DataVisualization.Charting.Chart mvChart;
        private System.Windows.Forms.DataGridViewTextBoxColumn mvRozmiarTabeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.PictureBox mvpbAnimacja;
    }
}

