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
        const int margines = 20;
        public AnalizatorAlgorytmowSortowania()
        {
            InitializeComponent();
            Width = (int) (Screen.PrimaryScreen.Bounds.Width * 0.9);
            Height = (int) (Screen.PrimaryScreen.Bounds.Height * 0.8);
            CenterToScreen();
        }

        private void AnalizatorAlgorytmowSortowania_Load(object sender, EventArgs e)
        {
            mvBtn_WybierzKolorLinii.AutoSize = true;
            mvBtn_WybierzKolorLinii.Location = new Point(margines*2, margines*4);

            mvLbl_MinProba.Location = new Point(mvBtn_WybierzKolorLinii.Left, mvBtn_WybierzKolorLinii.Bottom + margines * 2);
            mvTxt_MinProba.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_MinProba.Location = new Point(mvLbl_MinProba.Left, mvLbl_MinProba.Bottom + margines/4);

            mvLbl_MaxProba.Location = new Point(mvTxt_MinProba.Left, mvTxt_MinProba.Bottom + margines / 2);
            mvTxt_MaxProba.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_MaxProba.Location = new Point(mvLbl_MaxProba.Left, mvLbl_MaxProba.Bottom + margines/4);

            mvLbl_DolnaGranica.Location = new Point(mvTxt_MaxProba.Left, mvTxt_MaxProba.Bottom + margines/2);
            mvTxt_DolnaGranica.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_DolnaGranica.Location = new Point(mvLbl_DolnaGranica.Left, mvLbl_DolnaGranica.Bottom + margines/4);

            mvLbl_GornaGranica.Location = new Point(mvTxt_DolnaGranica.Left, mvTxt_DolnaGranica.Bottom + margines / 2);
            mvTxt_GornaGranica.Width = mvBtn_WybierzKolorLinii.Width;
            mvTxt_GornaGranica.Location = new Point(mvLbl_GornaGranica.Left, mvLbl_GornaGranica.Bottom + margines/4);

            mvLbl_WybierzAlgorytm.Location = new Point(mvTxt_GornaGranica.Left, mvTxt_GornaGranica.Bottom + margines);
            mvCb_Algorytm.Width = mvLbl_WybierzAlgorytm.Width;
            mvCb_Algorytm.Location = new Point(mvLbl_WybierzAlgorytm.Left, mvLbl_WybierzAlgorytm.Bottom + margines/4);
            mvBtn_AkceptacjaDanych.AutoSize = true;
            mvBtn_AkceptacjaDanych.Width = mvLbl_WybierzAlgorytm.Width;
            mvBtn_AkceptacjaDanych.Location = new Point(mvCb_Algorytm.Left, mvCb_Algorytm.Bottom + margines/4);


        }

        private void mvBtn_AkceptacjaDanych_Click(object sender, EventArgs e)
        {

        }
    }
}
