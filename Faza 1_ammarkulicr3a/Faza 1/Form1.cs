using HotelLibb;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Faza_1
{
    public partial class Form1 : Form
    {
        private Hotel hotel1;
        private Hotel hotel2;

        private List<Rezervacija> vseRezervacije = new List<Rezervacija>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbGost.Checked = true;
            cmbSpol.SelectedIndex = 0;

            cmbHotel.DisplayMember = "Ime";
            cmbGostRezervacija.DisplayMember = null;
            cmbSobaRezervacija.DisplayMember = null;

            hotel1 = new Hotel("Hotel A");
            hotel2 = new Hotel("Hotel B");

            hotel1.SobaDodana += PrikaziSporocilo;
            hotel2.SobaDodana += PrikaziSporocilo;

            hotel1.DodajSobo(new Soba(101, 2, 80));
            hotel1.DodajSobo(new LuksuznaSoba(102, 2, 150, true));

            hotel2.DodajSobo(new Soba(201, 3, 90));
            hotel2.DodajSobo(new LuksuznaSoba(202, 4, 200, false));

            cmbHotel.Items.Add(hotel1);
            cmbHotel.Items.Add(hotel2);

            txtDokument.Enabled = true;
            txtDelo.Enabled = false;
        }



        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSobaRezervacija.Items.Clear();

            if (cmbHotel.SelectedItem == null)
                return;

            Hotel izbran = (Hotel)cmbHotel.SelectedItem;

            foreach (var s in izbran.Sobe)
                cmbSobaRezervacija.Items.Add(s);
        }

        private void btnDodajOsebo_Click(object sender, EventArgs e)
        {
            if (rbGost.Checked)
            {
                Gost g = new Gost(
                    Guid.NewGuid().ToString(),
                    txtIme.Text,
                    txtPriimek.Text,
                    cmbSpol.Text,
                    txtTelefon.Text,
                    txtDokument.Text
                );

                dgvGostje.Items.Add(g);
                cmbGostRezervacija.Items.Add(g);
            }
            else
            {
                Zaposleni z = new Zaposleni(
                    Guid.NewGuid().ToString(),
                    txtIme.Text,
                    txtPriimek.Text,
                    cmbSpol.Text,
                    txtTelefon.Text,
                    txtDelo.Text
                );

                dgvZaposleni.Items.Add(z);
            }

            txtIme.Clear();
            txtPriimek.Clear();
            txtTelefon.Clear();
            txtDokument.Clear();
            txtDelo.Clear();
        }

        private void btnDodajRezervacijo_Click(object sender, EventArgs e)
        {
            if (cmbGostRezervacija.SelectedItem == null ||
                cmbSobaRezervacija.SelectedItem == null)
            {
                MessageBox.Show("Izberi gosta in sobo!");
                return;
            }

            Gost gost = (Gost)cmbGostRezervacija.SelectedItem;
            Soba soba = (Soba)cmbSobaRezervacija.SelectedItem;

            foreach (Rezervacija r in vseRezervacije)
            {
                if (r.Soba.Stevilka == soba.Stevilka &&
                    r.Od < dtpDatumDo.Value &&
                    r.Do > dtpDatumOd.Value)
                {
                    MessageBox.Show("Soba je že zasedena!");
                    return;
                }
            }

            Rezervacija nova = new Rezervacija(
                gost,
                soba,
                dtpDatumOd.Value,
                dtpDatumDo.Value
            );

            vseRezervacije.Add(nova);
            dgvRezervacije.Items.Add(nova);
        }

        private void btnIzbrisiRezervacijo_Click(object sender, EventArgs e)
        {
            if (dgvRezervacije.SelectedItem == null)
                return;

            Rezervacija r = (Rezervacija)dgvRezervacije.SelectedItem;
            vseRezervacije.Remove(r);
            dgvRezervacije.Items.Remove(r);
        }

        private void rbGost_CheckedChanged(object sender, EventArgs e)
        {
            txtDokument.Enabled = rbGost.Checked;
            txtDelo.Enabled = !rbGost.Checked;
        }

        private void rbZaposleni_CheckedChanged(object sender, EventArgs e)
        {
            txtDelo.Enabled = rbZaposleni.Checked;
            txtDokument.Enabled = !rbZaposleni.Checked;
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            List<Oseba> osebe = new List<Oseba>();

            osebe.Add(new Gost("G1", "Marko", "Kovac", "M", "123456789", ""));
            osebe.Add(new Zaposleni("Z1", "Miha", "Kovac", "M", "123456789", "Recepcija"));

            foreach (Oseba o in osebe)
            {
                MessageBox.Show(o.Opis());
                MessageBox.Show(o.Pozdrav());
            }
            MessageBox.Show("Skupno zaposlenih: " + Zaposleni.SteviloZaposlenih);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel hotel = new Hotel("Hotel");

            hotel.SobaDodana += PrikaziSporocilo;

            hotel.DodajSobo(new Soba(101, 2, 80));
            hotel.DodajSobo(new Soba(102, 2, 100));

            MessageBox.Show("Cena sobe 1: " + hotel[0].CenaNaNoc);

            double skupaj = hotel[0] + hotel[1];
            MessageBox.Show("Skupna vrednost vseh sob: " + skupaj);

            MessageBox.Show("Število hotelov: 2 ");
        }

        private void PrikaziSporocilo(string msg)
        {
            MessageBox.Show(msg);
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            hotel1.Izpisi(PrikaziSporocilo);
        }
    }
}