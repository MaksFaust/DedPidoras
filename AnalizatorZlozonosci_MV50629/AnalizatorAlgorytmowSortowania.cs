using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizatorZlozonosci_MV50629
{
    public partial class AnalizatorAlgorytmowSortowania : Form
    {
        const int mvMargines = 20;
        int PróbaBadawcza = 100;
        int MaxRozmiarTabl = 50;
        double DolnaGranicaWartości = 20.0;
        double GórnaGranicaWartości = 30000.0;
        double[] Tabl;
        float[] WynikiZpomiaru;
        float[] WynikiAnalityczne;
        int[] TablicaLOD;
        public AnalizatorAlgorytmowSortowania()
        {
            InitializeComponent();
            Width = mvLbl_GruboscLinii.Right + mvMargines * 2;
            Height = mvBtn_TablicaPrzedSortowaniem.Bottom + mvMargines;
            CenterToScreen();

            



        }

        private void AnalizatorAlgorytmowSortowania_Load(object sender, EventArgs e)
        {
            /* Left */

            mvBtn_WybierzKolorLinii.AutoSize = true;
            mvBtn_WybierzKolorLinii.Location = new Point(mvMargines * 2, mvMargines * 4);

            mvLbl_MinProba.Location = new Point(mvBtn_WybierzKolorLinii.Left, mvBtn_WybierzKolorLinii.Bottom + mvMargines * 2);
            mvTxt_MinProba.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_MinProba.Location = new Point(mvLbl_MinProba.Left, mvLbl_MinProba.Bottom + mvMargines / 4);

            mvLbl_MaxProba.Location = new Point(mvTxt_MinProba.Left, mvTxt_MinProba.Bottom + mvMargines / 2);
            mvTxt_RozmiarTabeli.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_RozmiarTabeli.Location = new Point(mvLbl_MaxProba.Left, mvLbl_MaxProba.Bottom + mvMargines / 4);

            mvLbl_DolnaGranica.Location = new Point(mvTxt_RozmiarTabeli.Left, mvTxt_RozmiarTabeli.Bottom + mvMargines / 2);
            mvTxt_DolnaGranica.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_DolnaGranica.Location = new Point(mvLbl_DolnaGranica.Left, mvLbl_DolnaGranica.Bottom + mvMargines / 4);

            mvLbl_GornaGranica.Location = new Point(mvTxt_DolnaGranica.Left, mvTxt_DolnaGranica.Bottom + mvMargines / 2);
            mvTxt_GornaGranica.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_GornaGranica.Location = new Point(mvLbl_GornaGranica.Left, mvLbl_GornaGranica.Bottom + mvMargines / 4);

            mvLbl_WybierzAlgorytm.Location = new Point(mvTxt_GornaGranica.Left, mvTxt_GornaGranica.Bottom + mvMargines);
            mvCb_Algorytm.Width = mvLbl_WybierzAlgorytm.Width;
            mvCb_Algorytm.Location = new Point(mvLbl_WybierzAlgorytm.Left, mvLbl_WybierzAlgorytm.Bottom + mvMargines / 4);
            mvBtn_AkceptacjaDanych.AutoSize = true;
            mvBtn_AkceptacjaDanych.Width = mvLbl_WybierzAlgorytm.Width;
            mvBtn_AkceptacjaDanych.Location = new Point(mvCb_Algorytm.Left, mvCb_Algorytm.Bottom + mvMargines / 4);

            mvLbl_Analizator.Location = new Point(Width / 2 - mvLbl_Analizator.Width / 2, mvMargines);

            /* Center */

            mvLbl_WziemikKoloruLinii.Location = new Point(mvBtn_WybierzKolorLinii.Right + mvMargines * 2, mvBtn_WybierzKolorLinii.Top);
            mvBtn_ChangeKolor.Width = mvLbl_WziemikKoloruLinii.Width;
            mvBtn_ChangeKolor.Location = new Point(mvLbl_WziemikKoloruLinii.Left, mvLbl_WziemikKoloruLinii.Bottom + mvMargines / 4);

            mvBtn_KolorTla.AutoSize = true;
            mvBtn_KolorTla.Location = new Point(mvLbl_WziemikKoloruLinii.Right + mvMargines * 2, mvLbl_WziemikKoloruLinii.Top);

            mvLbl_KolorTla.Location = new Point(mvBtn_KolorTla.Right + mvMargines * 2, mvBtn_KolorTla.Top);
            mvBtn_WziemnikKoloruTla.Width = mvLbl_KolorTla.Width;
            mvBtn_WziemnikKoloruTla.Location = new Point(mvLbl_KolorTla.Left, mvLbl_KolorTla.Bottom + mvMargines / 4);

            mvLbl_StylLinii.Location = new Point(mvLbl_KolorTla.Right + mvMargines * 2, mvLbl_KolorTla.Top);
            mvCb_StylLinii.Width = mvLbl_StylLinii.Width;
            mvCb_StylLinii.Location = new Point(mvLbl_StylLinii.Left, mvLbl_StylLinii.Bottom + mvMargines / 4);

            /* Right */
            mvLbl_GruboscLinii.Location = new Point(mvLbl_StylLinii.Right + mvMargines * 2, mvLbl_StylLinii.Top);
            mvTb_GruboscLinii.Width = mvLbl_GruboscLinii.Width;
            mvTb_GruboscLinii.Location = new Point(mvLbl_GruboscLinii.Left, mvLbl_GruboscLinii.Bottom + mvMargines / 4);

            mvLbl_GruboscLiniiLiczbowo.Location = new Point(mvTb_GruboscLinii.Left, mvTb_GruboscLinii.Bottom + mvMargines / 2);
            mvTxt_GruboscLiczbowo.Width = mvLbl_GruboscLiniiLiczbowo.Width;
            mvTxt_GruboscLiczbowo.Location = new Point(mvLbl_GruboscLiniiLiczbowo.Left, mvLbl_GruboscLiniiLiczbowo.Bottom + mvMargines / 4);

            mvLbl_WziemnikWzorcaLinii.Location = new Point(mvTxt_GruboscLiczbowo.Left, mvTxt_GruboscLiczbowo.Bottom + mvMargines / 2);
            mvPb_WziemnikLinii.Width = mvLbl_WziemnikWzorcaLinii.Width;
            mvPb_WziemnikLinii.Location = new Point(mvLbl_WziemnikWzorcaLinii.Left, mvLbl_WziemnikWzorcaLinii.Bottom + mvMargines / 2);

            mvBtn_TabelarycznaPrezentacja.AutoSize = true;
            mvBtn_TabelarycznaPrezentacja.Width = mvPb_WziemnikLinii.Width;
            mvBtn_TabelarycznaPrezentacja.Location = new Point(mvPb_WziemnikLinii.Left, mvPb_WziemnikLinii.Bottom + mvMargines / 2);
            mvBtn_GraficznaPrezentacja.AutoSize = true;
            mvBtn_GraficznaPrezentacja.Width = mvPb_WziemnikLinii.Width;
            mvBtn_GraficznaPrezentacja.Location = new Point(mvBtn_TabelarycznaPrezentacja.Left, mvBtn_TabelarycznaPrezentacja.Bottom + mvMargines / 2);
            mvBtn_Resetuj.AutoSize = true;
            mvBtn_Resetuj.Width = mvPb_WziemnikLinii.Width;
            mvBtn_Resetuj.Location = new Point(mvBtn_GraficznaPrezentacja.Left, mvBtn_GraficznaPrezentacja.Bottom + mvMargines / 2);
            mvBtn_Demo.AutoSize = true;
            mvBtn_Demo.Width = mvPb_WziemnikLinii.Width;
            mvBtn_Demo.Location = new Point(mvBtn_Resetuj.Left, mvBtn_Resetuj.Bottom + mvMargines / 2);

            /* Bottom */

            mvBtn_TablicaPrzedSortowaniem.AutoSize = true;
            mvBtn_TablicaPoSortowaniu.AutoSize = true;
            mvBtn_TablicaPrzedSortowaniem.Location = new Point(Width / 2 - (mvBtn_TablicaPrzedSortowaniem.Width + mvBtn_TablicaPoSortowaniu.Width + mvMargines) / 2, Height - mvBtn_TablicaPrzedSortowaniem.Height - mvMargines * 3);
            mvBtn_TablicaPoSortowaniu.Location = new Point(mvBtn_TablicaPrzedSortowaniem.Right + mvMargines / 2, mvBtn_TablicaPrzedSortowaniem.Top);

            mvChart.Width = mvBtn_Resetuj.Left - mvBtn_AkceptacjaDanych.Right - mvMargines / 2;
            mvChart.Height = mvBtn_TablicaPrzedSortowaniem.Top - mvBtn_WybierzKolorLinii.Bottom - mvMargines / 2;
            mvChart.Location = new Point(mvBtn_AkceptacjaDanych.Right + mvMargines, mvBtn_WybierzKolorLinii.Bottom + mvMargines);
            mvChart.Visible = false;

            mvDgv_Tablica.Size = mvChart.Size;
            mvDgv_Tablica.Location = mvChart.Location;

            mvdgvTabelaWynikow.Size = mvChart.Size;
            mvdgvTabelaWynikow.Location = mvChart.Location;

            //wartości domyślne
            mvTxt_MinProba.Text = PróbaBadawcza.ToString();
            mvTxt_RozmiarTabeli.Text = MaxRozmiarTabl.ToString();
            mvTxt_DolnaGranica.Text = DolnaGranicaWartości.ToString();
            mvTxt_GornaGranica.Text = GórnaGranicaWartości.ToString();
            mvCb_Algorytm.SelectedIndex = 0;

        }

        private void mvBtn_AkceptacjaDanych_Click(object sender, EventArgs e)
        {
            if (!mvPobieranieDanych(out PróbaBadawcza, out MaxRozmiarTabl, out DolnaGranicaWartości, out GórnaGranicaWartości))
            {
                errorProvider1.SetError(mvBtn_AkceptacjaDanych, "ERROR: Wystąpił błąd przy pobieraniu dannych!");
                return;
            }

            Tabl = new double[MaxRozmiarTabl];
            WynikiZpomiaru = new float[MaxRozmiarTabl];
            WynikiAnalityczne = new float[MaxRozmiarTabl];
            TablicaLOD = new int[PróbaBadawcza];
            // uaktywnienie przycisku poleceń
            mvBtn_TablicaPoSortowaniu.Enabled = true;
            // ustawienie stanu braku aktywności dla przycisku akceptacji 
            mvBtn_AkceptacjaDanych.Enabled = false;
        }

        private bool mvPobieranieDanych(out int PróbaBadawcza, out int MaxRozmiarTabl, out double DolnaGranicaWartości, out double GórnaGranicaWartości)
        {
            PróbaBadawcza = 100;
            MaxRozmiarTabl = 50;
            DolnaGranicaWartości = 20.0;
            GórnaGranicaWartości = 30000.0;
            if (!int.TryParse(mvTxt_MinProba.Text, out PróbaBadawcza))
            {
                errorProvider1.SetError(mvTxt_MinProba, "ERROR: Wystąpił błąd przy zapisie minimalnej proby podawczej!");
                return false;
            }

            if (!int.TryParse(mvTxt_RozmiarTabeli.Text, out MaxRozmiarTabl))
            {
                errorProvider1.SetError(mvTxt_RozmiarTabeli, "ERROR: Wystąpił błąd przy zapisie maksymalnego rozmiaru tabeli!");
                return false;
            }

            if (!double.TryParse(mvTxt_DolnaGranica.Text, out DolnaGranicaWartości))
            {
                errorProvider1.SetError(mvTxt_DolnaGranica, "ERROR: Wystąpił błąd przy zapisie dolnej granicy!");
                return false;
            }

            if (!double.TryParse(mvTxt_GornaGranica.Text, out GórnaGranicaWartości))
            {
                errorProvider1.SetError(mvTxt_GornaGranica, "ERROR: Wystąpił błąd przy zapisie górnej granicy!");
                return false;
            }
            return true;
        }

        private void mvBtn_TablicaPoSortowaniu_Click(object sender, EventArgs e)
        {
            int mvLicznikOD;
            float SumaOD, ŚredniaOD;


            Random Rnd = new Random();
            // deklaracja zmiennej refrencyjnej i utworzenie egzemplarza klasy Sortowanie 
            Sortowanie AlgorytmySortowania = new Sortowanie();
            // powtarzanie badania algorytmów dla wszystkich rozmiarów tablic
            for (int l = 0; l < MaxRozmiarTabl; l++)
            {
                // wielokrotne powtarzanie badania kosztów czasowych algorytmu sortowania 
                for (int k = 0; k < PróbaBadawcza; k++)
                {
                    // wylosowanie wartości elementów Tabl
                    for (int i = 0; i < MaxRozmiarTabl; i++)
                        Tabl[i] = Rnd.NextDouble() * (GórnaGranicaWartości - DolnaGranicaWartości) + DolnaGranicaWartości;
                    // wywołanie metody sortowania
                    switch (mvCb_Algorytm.SelectedIndex)
                    {
                        case 0:
                            mvLicznikOD = AlgorytmySortowania.SelectSort(ref Tabl, l+1);
                            break;
                        case 1: mvLicznikOD = AlgorytmySortowania.InsertionSort(ref Tabl, l+1); break;

                        case 2:
                            mvLicznikOD = AlgorytmySortowania.ShellSort(ref Tabl, l+1);
                            break;
                        case 3:
                            mvLicznikOD = AlgorytmySortowania.ShakeSort(ref Tabl, l + 1);
                            break;
                        // Case'y dla kolejnych metod sortowania
                        default:
                            errorProvider1.SetError(mvBtn_TabelarycznaPrezentacja,
                            "UWAGA: jeszcze tej metody nie opracowałem!!!"); return;
                    }
                    // Zapamiętanie LicznikaOD
                    TablicaLOD[k] = mvLicznikOD;
                } // od for (int k = 0; k < PróbaBadawcza; k++)
                  // obliczenie średniej arytmetycznej wykonanych Operacji Dominujących
                SumaOD = 0.0F;  // początkowy stan obliczeń
                for (int j = 0; j < PróbaBadawcza; j++)
                    SumaOD = SumaOD + TablicaLOD[j];
                // obliczenie średniej arytmetycznej
                ŚredniaOD = SumaOD / PróbaBadawcza;
                /* wpisanie średniej liczby wykonanych operacji dominujących w tablicy WynikiZpomiaru */
                WynikiZpomiaru[l] = ŚredniaOD;
                // obliczenie kosztu czasowego ze wzoru analitycznego 
                switch (mvCb_Algorytm.SelectedIndex)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        WynikiAnalityczne[l] = (l * (l - 1)) / 2;
                        break;

                    // Case'y dla kolejnych metod sortowania
                    default:
                        errorProvider1.SetError(mvBtn_TabelarycznaPrezentacja,
               "UWAGA: prace nad tym algorytmem, który został " + "wybrany jeszcze trwają!!!");
                        return;
                }
            }


            // wpisanie danych wynikowych do kontrolki DataGridView
            for (int i = 0; i < MaxRozmiarTabl; i++)
            {
               
                mvDgv_Tablica.Rows.Add();
                // wpisujemy wyniki do poszczególnych komórek 
                mvDgv_Tablica.Rows[i].Cells[0].Value = i;
                mvDgv_Tablica.Rows[i].Cells[1].Value = String.Format("{0, 8:F3}", Tabl[i]);

                // naprzemienna zmiana tła wierszy w kontrolce DataGridView
                if ((i % 2) == 0)
                {
                    mvDgv_Tablica.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    mvDgv_Tablica.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                }
                else
                {
                    mvDgv_Tablica.Rows[i].Cells[0].Style.BackColor = Color.White;
                    mvDgv_Tablica.Rows[i].Cells[1].Style.BackColor = Color.White;
                }
                // wycentrowanie zapisów w poszczególnych komórkach formatowanego wierszy 
                mvDgv_Tablica.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mvDgv_Tablica.Rows[i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            // odsłonięcie kontrolki DataGridView 
            mvDgv_Tablica.Visible = true;
            // wyświetlenie okna dialogowego z potwierdzeniem wybranej metody sortowania 
            MessageBox.Show("Przeprowadzono sortowanie algorytmem: " + mvCb_Algorytm.SelectedIndex);
            // ustawienie stanu braku aktywności dla przycisku poleceń 
            mvBtn_TablicaPoSortowaniu.Enabled = false;
            // uaktywnienie przycisków funkcjonalnych
            mvBtn_TabelarycznaPrezentacja.Enabled = true;
            mvBtn_GraficznaPrezentacja.Enabled = true;
            mvBtn_Resetuj.Enabled = true;
            mvBtn_Demo.Enabled = true;



        }

        
       

       

        private void mvBtn_TabelarycznaPrezentacja_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < MaxRozmiarTabl; i++)
            {
                mvdgvTabelaWynikow.Rows.Add(); // dodanie nowego wiersza do kontrolki // wpisanie wyników 
                mvdgvTabelaWynikow.Rows[i].Cells[0].Value = i;
                mvdgvTabelaWynikow.Rows[i].Cells[1].Value = String.Format("{0:F2}", WynikiZpomiaru[i]);
                mvdgvTabelaWynikow.Rows[i].Cells[2].Value = String.Format("{0:F2}", WynikiAnalityczne[i]); // koszt pamięciowy 
                mvdgvTabelaWynikow.Rows[i].Cells[3].Value = i;
                // ustawienie koloru tła (dla zwiększenia czytelności wyników)
                if (i % 2 == 0)
                {
                    mvdgvTabelaWynikow.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
                    mvdgvTabelaWynikow.Rows[i].Cells[1].Style.BackColor = Color.LightGray;
                    mvdgvTabelaWynikow.Rows[i].Cells[2].Style.BackColor = Color.LightGray;
                    mvdgvTabelaWynikow.Rows[i].Cells[3].Style.BackColor = Color.LightGray;
                }
                else
                {
                    mvdgvTabelaWynikow.Rows[i].Cells[0].Style.BackColor = Color.White;
                    mvdgvTabelaWynikow.Rows[i].Cells[1].Style.BackColor = Color.White;
                    mvdgvTabelaWynikow.Rows[i].Cells[2].Style.BackColor = Color.White;
                    mvdgvTabelaWynikow.Rows[i].Cells[3].Style.BackColor = Color.White;
                }
                // wycentrowanie zapisów w kolumnach 
                mvdgvTabelaWynikow.Rows[i].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mvdgvTabelaWynikow.Rows[i].Cells[1].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mvdgvTabelaWynikow.Rows[i].Cells[2].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mvdgvTabelaWynikow.Rows[i].Cells[3].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }   // od for (int i = 0; i < MaxRozmiarTabl; i++ )
                // osłonięcie kontrolki DataGridView
            mvdgvTabelaWynikow.Visible = true;
            // ukrycie kontrolek z centralnej części formularza
            mvDgv_Tablica.Visible = false;
            // ustawienie stanu braku aktywności dla przycisku tabelaryzacji 
            mvBtn_TabelarycznaPrezentacja.Enabled = false;
        }

        private void mvBtn_GraficznaPrezentacja_Click(object sender, EventArgs e)
        {
            // ukrycie kontrolek DataGridView w centralnej części formularza 
            mvDgv_Tablica.Visible = false;
            mvdgvTabelaWynikow.Visible = false;
            // odsłonięcie kontrolki Chart
            mvChart.Visible = true;
            // ustalenie tytułu wykresu
            mvChart.Titles.Add("Algorytm " + mvCb_Algorytm.SelectedItem);
            //zwymiarowanie i ustawienie kontrolki Chart
            mvChart.BackColor = mvBtn_KolorTla.BackColor;
            mvChart.Legends["Legend1"].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            // utworzenie wektora pomocniczego i wpisanie do niego rozmiarów sortowanych tablic ..
            int[] RozmiarTabeli = new int[MaxRozmiarTabl];
            for (int i = 0; i < MaxRozmiarTabl; i++)
                RozmiarTabeli[i] = i;
            // wykreślenie wykresu z pomiaru kosztów algorytmu SelectSort
            mvChart.Series[0].Name = "Koszt czasowy z pomiaru";
            // ustalenie atrybutów dla kreślonego wykresu funkcji, której
            // dane reprezentuje Seria[0]
            mvChart.Series[0].ChartType =
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            mvChart.Series[0].Color = Color.Black;
            mvChart.Series[0].BorderDashStyle =
            System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            mvChart.Series[0].BorderWidth = 1;
            mvChart.Series[0].Points.DataBindXY(RozmiarTabeli, WynikiZpomiaru);
            /* postępujemy analogicznie dla utworzenia wykresu dla kosztu analitycznego i kosztu pamięci */
            // . . .
            // ustawienie stanu braku aktywności dla przycisku poleceń 
            mvBtn_GraficznaPrezentacja.Enabled = false;
        }

        private void mvTxt_MinProba_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(mvTxt_MinProba.Text, out PróbaBadawcza)) errorProvider1.SetError(mvTxt_MinProba, "ERROR: wpodanej liczności Próby Badawczej wystąpił niedozwolony znak");
        }

        class Sortowanie
        {

            public int SelectSort(ref double[] array, int n)
            {
                int k;
                double KopiaElementuDoWymiany;
                int LicznikOD = 0;  // Licznik Operacji Dominujących
                for (int i = 0; i < n - 1; i++)
                { 
                    k = i;
                    for (int j = i + 1; j < n; j++)
                    {
                        LicznikOD++;
                        if (array[k] > array[j])
                        k = j;
                    }
                    KopiaElementuDoWymiany = array[i];
                    array[i] = array[k];
                    array[k] = KopiaElementuDoWymiany;
                }
                return LicznikOD;
            }



            public int ShakeSort(ref double[] array, int n)
            {
                var mvLicznikOd = 0;
                for (var i = 0; i < n / 2; i++)
                {
                    var swapFlag = false;
                    //проход слева направо
                    for (var j = i; j < n - i - 1; j++)
                    {
                        mvLicznikOd++;
                        if (array[j] > array[j + 1])
                        {
                            Swap(ref array[j], ref array[j + 1]);
                            swapFlag = true;
                        }
                    }

                    //проход справа налево
                    for (var j = n - 2 - i; j > i; j--)
                    {
                        mvLicznikOd++;
                        if (array[j - 1] > array[j])
                        {
                            Swap(ref array[j - 1], ref array[j]);
                            swapFlag = true;
                        }
                    }

                    //если обменов не было выходим
                    if (!swapFlag)
                    {
                        break;
                    }
                }

                return mvLicznikOd;
            }



            public int ShellSort(ref double[] array, int n)
            {
                var mvLicznikOd = 0;
                var d = n / 2;
                while (d >= 1)
                {
                    for (var i = d; i < n; i++)
                    {
                        var j = i;
                        while ((j >= d) && (array[j - d] > array[j]))
                        {
                            mvLicznikOd++;
                            Swap(ref array[j], ref array[j - d]);
                            j = j - d;
                        }
                    }

                    d = d / 2;
                }

                return mvLicznikOd;
            }


            public int InsertionSort(ref double[] T, int n)
            {// deklaracje pomocnicze
                double KopiaElementuDoWymiany;
                int LicznikOD = 0;
                int k; // indeks "chodzenia" po tablicy uporządkowanej: T[0], . . . T[i-1]
                for (int i = 1; i < n; i++)
                {
                    KopiaElementuDoWymiany = T[i];
                     k = i;
	
                    while ((k > 0) && (KopiaElementuDoWymiany < T[k - 1]))
	                {
	                    LicznikOD++;
                        T[k] = T[k - 1];
                        k--;
	                }
	                // uwzględnienie wykonania ostatniej operacji dominującej
                     if (k > 0)
                     LicznikOD++;
                     T[k] = KopiaElementuDoWymiany;
                }
                return LicznikOD;
            }

            private void Swap(ref double a, ref double b)
            {
                var t = a;
                a = b;
                b = t;
            }



        }

        private void mvBtn_WybierzKolorLinii_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            MyDialog.AllowFullOpen = false;
            // Allows the user to get help. (The default is false.)
            MyDialog.ShowHelp = true;
            // Sets the initial color select to the current text color.
            MyDialog.Color = mvBtn_ChangeKolor.BackColor;
            // Update the text box color if the user clicks OK 
            if (MyDialog.ShowDialog() == DialogResult.OK)
                mvBtn_ChangeKolor.BackColor = MyDialog.Color;
        }

        private void mvLbl_MaxProba_Click(object sender, EventArgs e)
        {

        }
    }
}
