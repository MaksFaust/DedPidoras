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
        int mvProbaBadawcz = 100;
        int mvMaxRozmiarTabl = 50;
        double mvDolnaGranicaWartosci = 20.0;
        double mvGornaGranicaWartosci = 30000.0;
        double[] mvTabl;
        public AnalizatorAlgorytmowSortowania()
        {
            InitializeComponent();
            Width = mvLbl_GruboscLinii.Right + mvMargines*2;
            Height = mvBtn_TablicaPrzedSortowaniem.Bottom + mvMargines;
            CenterToScreen();
        }

        private void AnalizatorAlgorytmowSortowania_Load(object sender, EventArgs e)
        {
            /* Left */

            mvBtn_WybierzKolorLinii.AutoSize = true;
            mvBtn_WybierzKolorLinii.Location = new Point(mvMargines*2, mvMargines*4);

            mvLbl_MinProba.Location = new Point(mvBtn_WybierzKolorLinii.Left, mvBtn_WybierzKolorLinii.Bottom + mvMargines * 2);
            mvTxt_MinProba.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_MinProba.Location = new Point(mvLbl_MinProba.Left, mvLbl_MinProba.Bottom + mvMargines/4);

            mvLbl_MaxProba.Location = new Point(mvTxt_MinProba.Left, mvTxt_MinProba.Bottom + mvMargines / 2);
            mvTxt_MaxProba.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_MaxProba.Location = new Point(mvLbl_MaxProba.Left, mvLbl_MaxProba.Bottom + mvMargines/4);

            mvLbl_DolnaGranica.Location = new Point(mvTxt_MaxProba.Left, mvTxt_MaxProba.Bottom + mvMargines/2);
            mvTxt_DolnaGranica.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_DolnaGranica.Location = new Point(mvLbl_DolnaGranica.Left, mvLbl_DolnaGranica.Bottom + mvMargines/4);

            mvLbl_GornaGranica.Location = new Point(mvTxt_DolnaGranica.Left, mvTxt_DolnaGranica.Bottom + mvMargines / 2);
            mvTxt_GornaGranica.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_GornaGranica.Location = new Point(mvLbl_GornaGranica.Left, mvLbl_GornaGranica.Bottom + mvMargines/4);

            mvLbl_WybierzAlgorytm.Location = new Point(mvTxt_GornaGranica.Left, mvTxt_GornaGranica.Bottom + mvMargines);
            mvCb_Algorytm.Width = mvLbl_WybierzAlgorytm.Width;
            mvCb_Algorytm.Location = new Point(mvLbl_WybierzAlgorytm.Left, mvLbl_WybierzAlgorytm.Bottom + mvMargines/4);
            mvBtn_AkceptacjaDanych.AutoSize = true;
            mvBtn_AkceptacjaDanych.Width = mvLbl_WybierzAlgorytm.Width;
            mvBtn_AkceptacjaDanych.Location = new Point(mvCb_Algorytm.Left, mvCb_Algorytm.Bottom + mvMargines/4);

            mvLbl_Analizator.Location = new Point (Width / 2 - mvLbl_Analizator.Width / 2, mvMargines);

            /* Center */

            mvLbl_WziemikKoloruLinii.Location = new Point(mvBtn_WybierzKolorLinii.Right + mvMargines*2, mvBtn_WybierzKolorLinii.Top);
            mvBtn_ChangeKolor.Width = mvLbl_WziemikKoloruLinii.Width;
            mvBtn_ChangeKolor.Location = new Point(mvLbl_WziemikKoloruLinii.Left, mvLbl_WziemikKoloruLinii.Bottom + mvMargines/4);

            mvBtn_KolorTla.AutoSize = true;
            mvBtn_KolorTla.Location = new Point(mvLbl_WziemikKoloruLinii.Right + mvMargines*2, mvLbl_WziemikKoloruLinii.Top);

            mvLbl_KolorTla.Location = new Point(mvBtn_KolorTla.Right + mvMargines * 2, mvBtn_KolorTla.Top);
            mvBtn_WziemnikKoloruTla.Width = mvLbl_KolorTla.Width;
            mvBtn_WziemnikKoloruTla.Location = new Point(mvLbl_KolorTla.Left, mvLbl_KolorTla.Bottom + mvMargines/4);

            mvLbl_StylLinii.Location = new Point(mvLbl_KolorTla.Right + mvMargines*2, mvLbl_KolorTla.Top);
            mvCb_StylLinii.Width = mvLbl_StylLinii.Width;
            mvCb_StylLinii.Location = new Point(mvLbl_StylLinii.Left, mvLbl_StylLinii.Bottom + mvMargines/4);

            /* Right */
            mvLbl_GruboscLinii.Location = new Point(mvLbl_StylLinii.Right + mvMargines * 2, mvLbl_StylLinii.Top);
            mvTb_GruboscLinii.Width = mvLbl_GruboscLinii.Width;
            mvTb_GruboscLinii.Location = new Point(mvLbl_GruboscLinii.Left, mvLbl_GruboscLinii.Bottom + mvMargines/4);

            mvLbl_GruboscLiniiLiczbowo.Location = new Point(mvTb_GruboscLinii.Left, mvTb_GruboscLinii.Bottom + mvMargines/2);
            mvTxt_GruboscLiczbowo.Width = mvLbl_GruboscLiniiLiczbowo.Width;
            mvTxt_GruboscLiczbowo.Location = new Point(mvLbl_GruboscLiniiLiczbowo.Left, mvLbl_GruboscLiniiLiczbowo.Bottom + mvMargines/4);

            mvLbl_WziemnikWzorcaLinii.Location = new Point(mvTxt_GruboscLiczbowo.Left, mvTxt_GruboscLiczbowo.Bottom + mvMargines/2);
            mvPb_WziemnikLinii.Width = mvLbl_WziemnikWzorcaLinii.Width;
            mvPb_WziemnikLinii.Location = new Point(mvLbl_WziemnikWzorcaLinii.Left, mvLbl_WziemnikWzorcaLinii.Bottom + mvMargines/2);

            mvBtn_TabelarycznaPrezentacja.AutoSize = true;
            mvBtn_TabelarycznaPrezentacja.Width = mvPb_WziemnikLinii.Width;
            mvBtn_TabelarycznaPrezentacja.Location = new Point(mvPb_WziemnikLinii.Left, mvPb_WziemnikLinii.Bottom + mvMargines/2);
            mvBtn_GraficznaPrezentacja.AutoSize = true;
            mvBtn_GraficznaPrezentacja.Width = mvPb_WziemnikLinii.Width;
            mvBtn_GraficznaPrezentacja.Location = new Point(mvBtn_TabelarycznaPrezentacja.Left, mvBtn_TabelarycznaPrezentacja.Bottom + mvMargines/2);
            mvBtn_Resetuj.AutoSize = true;
            mvBtn_Resetuj.Width = mvPb_WziemnikLinii.Width;
            mvBtn_Resetuj.Location = new Point(mvBtn_GraficznaPrezentacja.Left, mvBtn_GraficznaPrezentacja.Bottom + mvMargines/2);
            mvBtn_Demo.AutoSize = true;
            mvBtn_Demo.Width = mvPb_WziemnikLinii.Width;
            mvBtn_Demo.Location = new Point(mvBtn_Resetuj.Left, mvBtn_Resetuj.Bottom + mvMargines/2);

            /* Bottom */

            mvBtn_TablicaPrzedSortowaniem.AutoSize = true;
            mvBtn_TablicaPoSortowaniu.AutoSize = true;
            mvBtn_TablicaPrzedSortowaniem.Location = new Point(Width/2 - (mvBtn_TablicaPrzedSortowaniem.Width + mvBtn_TablicaPoSortowaniu.Width + mvMargines)/2, Height - mvBtn_TablicaPrzedSortowaniem.Height - mvMargines*3);
            mvBtn_TablicaPoSortowaniu.Location = new Point(mvBtn_TablicaPrzedSortowaniem.Right + mvMargines/2, mvBtn_TablicaPrzedSortowaniem.Top);

            mvPb_MainPb.Width = mvBtn_Resetuj.Left - mvBtn_AkceptacjaDanych.Right - mvMargines*2;
            mvPb_MainPb.Height = mvBtn_TablicaPrzedSortowaniem.Top - mvBtn_WybierzKolorLinii.Bottom - mvMargines*2;
            mvPb_MainPb.Location = new Point(mvBtn_AkceptacjaDanych.Right + mvMargines, mvBtn_WybierzKolorLinii.Bottom + mvMargines);
            mvPb_MainPb.Visible = false;

            mvDgv_Tablica.Size = mvPb_MainPb.Size;
            mvDgv_Tablica.Location = mvPb_MainPb.Location;

        }
    }
}
