using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAdizideKaldigimYer.Model;

namespace WFAdizideKaldigimYer
{
    public partial class Form1 : Form
    {
        DiziTakipContext db = new DiziTakipContext();
        Dizi duzenlenenDizi;
        public Form1()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            string ara = txtAra.Text.Trim();
            if (ara == "")
            {
                dgvDiziler.DataSource = db.Diziler.ToList();
            }
            else
            {
                dgvDiziler.DataSource = db.Diziler.Where(x => x.DiziAd.Contains(ara)).ToList();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (duzenlenenDizi == null)
            {
                Dizi dizi = new Dizi()
                {
                    DiziAd = txtDiziAd.Text,
                    SezonNo = (int)numSezonNo.Value,
                    BolumNo = (int)numBolumNo.Value,
                    BittiMi = cboBittiMi.Checked
                };
                db.Diziler.Add(dizi);
            }
            else
            {
                duzenlenenDizi.DiziAd = txtDiziAd.Text;
                duzenlenenDizi.SezonNo = (int)numSezonNo.Value;
                duzenlenenDizi.BolumNo = (int)numBolumNo.Value;
                duzenlenenDizi.BittiMi = cboBittiMi.Checked;
            }
            FormuResetle();
            db.SaveChanges();
            Listele();
        }

        private void FormuResetle()
        {
            duzenlenenDizi = null;
            txtDiziAd.Clear();
            numSezonNo.Value = 0;
            numBolumNo.Value = 0;
            cboBittiMi.Checked = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvDiziler.SelectedRows.Count != 1) return;

            Dizi seciliDizi = (Dizi)dgvDiziler.SelectedRows[0].DataBoundItem;
            db.Diziler.Remove(seciliDizi);
            db.SaveChanges();
            Listele();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvDiziler.SelectedRows.Count != 1) return;

            duzenlenenDizi = (Dizi)dgvDiziler.SelectedRows[0].DataBoundItem;
            txtDiziAd.Text = duzenlenenDizi.DiziAd;
            numSezonNo.Value = duzenlenenDizi.SezonNo;
            numBolumNo.Value = duzenlenenDizi.BolumNo;
            cboBittiMi.Checked = duzenlenenDizi.BittiMi;
            btnEkle.Text = "KAYDET";
            btnIptal.Show();

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            Listele();
        }
    }
}
