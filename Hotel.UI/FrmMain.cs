﻿using Hotel.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.UI
{
    public partial class FrmMain : Form
    {
        private List<Musteri> musteriler=new List<Musteri>();
        private List<OdaRezervasyon> odarezervasyonları=new List<OdaRezervasyon>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
         

    
           
        }

        private void otelDurumuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteri frm = new FormMusteri();
            frm.Show();
        }

     
    }
}
