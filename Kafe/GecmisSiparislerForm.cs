﻿using KafeOnline6.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafe
{
    public partial class GecmisSiparislerForm : Form
    {
        private readonly KafeVeri _db;
        public GecmisSiparislerForm(KafeVeri db)
        {
            InitializeComponent();
            _db = db;
            dgvSiparisler.DataSource = _db.GecmisSiparisler;
        }

        private void dgvSiparisler_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSiparisler.SelectedRows.Count > 0)
            {
                Siparis siparis = (Siparis)dgvSiparisler.SelectedRows[0].DataBoundItem;
                dgvSiparisDetaylar.DataSource = siparis.SiparisDetaylar;
            }
            else
            {
                dgvSiparisDetaylar.DataSource= null;
            }

        }
    }
}
