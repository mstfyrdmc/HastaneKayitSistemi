using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHastaneKayıtSistemi.Models;

namespace WFAHastaneKayıtSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Hekim> Hekimler = new List<Hekim>() {

        new Hekim() {Unvan="Doç.Dr", AdSoyad="Mehmet Güngör",Uzmanlik="Genel Cerrahi"},
        new Hekim() {Unvan="Operatör",AdSoyad="Vecihi Hükuş", Uzmanlik="Göz Doktoru"},
        new Hekim() {Unvan="Uzman Doktor",AdSoyad=" Gamze Ergül",Uzmanlik="Çocuk Doktoru"},
        new Hekim () {Unvan="Uzman Doktor",AdSoyad="Taner Baş",Uzmanlik="Ortopedi" },
        new Hekim () {Unvan="Uzman Doktor" ,AdSoyad="Ayşe Öztürk",Uzmanlik="KBB"},
        new Hekim () {Unvan="Uzman Doktor",AdSoyad="Aylin Koca", Uzmanlik="Diş Hekimi"},
        };

        List<Il> Iller = new List<Il>()
        {
            new Il() {Ad="İstanbul"},
            new Il() {Ad="Ankara"},
            new Il() {Ad="İzmir"},
            new Il() {Ad="Bursa"},
            new Il() {Ad="Zonguldak"}
        };
        /*
        List<Hastane> Hastaneler = new List<Hastane>()
        {
            new Hastane() { AdSoyad ="İstanbul Devlet Hastanesi"},
            new Hastane() {AdSoyad="Ankara Devlet Hastanesi"},
            new Hastane() {AdSoyad="İzmir Devlet Hastanesi"},
            new Hastane() {AdSoyad="Bursa Devlet Hastanesi"},
            new Hastane() {AdSoyad="Zonguldak Devlet Hastanesi"}
        }; */
        List<Saat> Saatler = new List<Saat>()
        {
            new Saat() {Saatler="08:00"},
            new Saat() {Saatler="08:30"},
            new Saat() {Saatler="09:00"},
            new Saat() {Saatler="09:30"},
            new Saat() {Saatler="10:00"},
            new Saat() {Saatler="10:30"},
            new Saat() {Saatler="11:00"},
            new Saat() {Saatler="11:30"},
            new Saat() {Saatler="12:00"},
            new Saat() {Saatler="12:30"},
            new Saat() {Saatler="13:30"},
            new Saat() {Saatler="14:00"},
            new Saat() {Saatler="14:30"},
            new Saat() {Saatler="15:00"},
            new Saat() {Saatler="15:30"},
            new Saat() {Saatler="16:00"},
            new Saat() {Saatler="16:30"},
            new Saat() {Saatler="17:00"},
            new Saat() {Saatler="17:30"}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            cbHekimler.Items.AddRange(Hekimler.ToArray());
            cbHekimler.SelectedIndex = 0;
            cbIller.Items.AddRange(Iller.ToArray());
            cbIller.SelectedIndex = 0;
           // cbHastaneler.Items.AddRange(Hastaneler.ToArray());
          //  cbHastaneler.SelectedIndex = 0;
            cbSaatler.Items.AddRange(Saatler.ToArray());
            cbSaatler.SelectedIndex = 0;
        }
        private void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbHastaneler.Items.Clear();
            if (cbIller.SelectedIndex == 0)
            {
                cbHastaneler.Items.Add("İstanbul Devlet Hastanesi");
                cbHastaneler.Items.Add("İstanbul Eğitim ve Araştırma Hastanesi");
                cbHastaneler.Items.Add("İstanbul Level Hastanesi");
                cbHastaneler.Items.Add("İstanbul Emergency Hastanesi");
                cbHastaneler.Items.Add("İstanbul Özel bla bla Hastanesi");
            }
            else if (cbIller.SelectedIndex == 1)
            {
                cbHastaneler.Items.Add("Ankara Devlet Hastanesi");
                cbHastaneler.Items.Add("Ankara Eğitim ve Araştırma Hastanesi");
                cbHastaneler.Items.Add("Ankara Level Hastanesi");
                cbHastaneler.Items.Add("Ankara Emergency Hastanesi");
                cbHastaneler.Items.Add("Ankara Özel bla bla Hastanesi");
            }
            else if (cbIller.SelectedIndex == 2)
            {
                cbHastaneler.Items.Add("İzmir Devlet Hastanesi");
                cbHastaneler.Items.Add("İzmir Eğitim ve Araştırma Hastanesi");
                cbHastaneler.Items.Add("İzmir Level Hastanesi");
                cbHastaneler.Items.Add("İzmir Emergency Hastanesi");
                cbHastaneler.Items.Add("İzmir Özel bla bla Hastanesi");
            }
            else if (cbIller.SelectedIndex == 3)
            {
                cbHastaneler.Items.Add("Bursa Devlet Hastanesi");
                cbHastaneler.Items.Add("Bursa Eğitim ve Araştırma Hastanesi");
                cbHastaneler.Items.Add("Bursa Level Hastanesi");
                cbHastaneler.Items.Add("Bursa Emergency Hastanesi");
            }
            else if (cbIller.SelectedIndex == 4)
            {
                cbHastaneler.Items.Add("Zonguldak Devlet Hastanesi");
                cbHastaneler.Items.Add("Zonguldak Eğitim ve Araştırma Hastanesi");
                cbHastaneler.Items.Add("Zonguldak Level Hastanesi");
            }

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            string AdSoyad, TcNo;
            AdSoyad = txtAdSoyad.Text;
            TcNo = txtTc.Text;
            
            Randevu randevu = new Randevu();
           // randevu.SeciliHastane = (Hastane)cbHastaneler.SelectedItem;
            randevu.SeciliHekim = (Hekim)cbHekimler.SelectedItem;
            randevu.SeciliIl = (Il)cbIller.SelectedItem;
            randevu.SeciliSaat = (Saat)cbSaatler.SelectedItem;

            //yeni satırlar

            
                
             lstHasta.Items.Add("Adı-Soyadı: " + AdSoyad + " " + "TC Kimlik Numarası: " + TcNo + " " + cbHastaneler.SelectedItem + " " + randevu.SeciliHekim + " "); //+randevu
             lstHasta.Items.Add("Randevu Tarihi: " + dtpGun.Text.ToString() + " " + "Randevu saati: " + " " + randevu.SeciliSaat);
                
           



            //Buraya kadar
            //lstHasta.Items.Add("Adı-Soyadı: " + AdSoyad + " " + "TC Kimlik Numarası: " + TcNo + " " +cbHastaneler.SelectedItem + " " +randevu.SeciliHekim + " " ); //+randevu
            //lstHasta.Items.Add("Randevu Tarihi: " + dtpGun.Text.ToString()+" " + "Randevu saati: " +" " +randevu.SeciliSaat);
             
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lstHasta.Items.Clear();
        }

       
    }
}
