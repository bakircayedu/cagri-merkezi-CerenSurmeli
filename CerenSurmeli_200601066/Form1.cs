using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖdevBaslangic
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int CagriIDSayac = 1;

        MusteriTemsilcisi Ticari_MT1 = new MusteriTemsilcisi {
            TemsilciTuru = "Ticari",
            MusteriTemsilcisiTanimlayici = 100,
            UygunMu = true
        };
        MusteriTemsilcisi Ticari_MT2 = new MusteriTemsilcisi
        {
            TemsilciTuru = "Ticari",
            MusteriTemsilcisiTanimlayici = 101,
            UygunMu = true,
        };
        MusteriTemsilcisi Bireysel_MT1 = new MusteriTemsilcisi
        {
            TemsilciTuru = "Bireysel",
            MusteriTemsilcisiTanimlayici = 102,
            UygunMu = true,
        };
        MusteriTemsilcisi Bireysel_MT2 = new MusteriTemsilcisi
        {
            TemsilciTuru = "Bireysel",
            MusteriTemsilcisiTanimlayici = 103,
            UygunMu = true,
        };

        
       
        private void btnAramaYap_Click(object sender, EventArgs e)
        {
            Musteri musteri = new Musteri();

            musteri.MusteriTanimlayicisi = txtMusteriID.Text;
            if (musteri.MusteriTanimlayicisi == null)
            {
                MessageBox.Show("Musteri Tanımlayıcısı girmeden işlem yapamazsınız!");
                Environment.Exit(0);
            }

            Cagri aramaCagrisi = new Cagri
            {
                CagriTanimlayicisi = CagriIDSayac++,
                musteri = musteri,
                aramaBaslangic = DateTime.Now
            };

            if (rbtnBireyselMusteri.Checked == true)  
            {
                    musteri.MusteriTuru = "Bireysel Müşteri";
                
                    if (Bireysel_MT1.cagrilar.count <= Bireysel_MT2.cagrilar.count) // En az sayıda kişi içeren temsilciye atama yapılmasını sağlıyor.
                    {
                        Bireysel_MT1.cagrilar.Insert(aramaCagrisi);
                        MessageBox.Show("İşlem başarılı." +"\n" +
                                        "Uygun Bireysel Müşteri Temsilcimizin listesindeki sıranız: " + Bireysel_MT1.cagrilar.count);

                        CagriList.Items.Add("Başlangıç Tarihi:" + aramaCagrisi.aramaBaslangic + " | Tanımlayıcısı:" + aramaCagrisi.CagriTanimlayicisi);
                    }
                    else
                    {
                        Bireysel_MT2.cagrilar.Insert(aramaCagrisi);
                        MessageBox.Show("İşlem başarılı." + "\n" +
                                        "Uygun Bireysel Müşteri Temsilcimizin listesindeki sıranız: " + Bireysel_MT2.cagrilar.count);
                        CagriList.Items.Add("Başlangıç Tarihi:" + aramaCagrisi.aramaBaslangic + " | Tanımlayıcısı:" + aramaCagrisi.CagriTanimlayicisi);
                    }
                
            }
            else if (rbtnTicariMusteri.Checked == true)
            {
                    musteri.MusteriTuru = "Ticari Müşteri";
                    if (Ticari_MT1.cagrilar.count <= Ticari_MT2.cagrilar.count) // En az sayıda kişi içeren temsilciye atama yapılmasını sağlıyor.
                    {
                        Ticari_MT1.cagrilar.Insert(musteri);
                        MessageBox.Show("İşlem başarılı." + "\n" +
                                        "Uygun Ticari Müşteri Temsilcimizin listesindeki sıranız: " + Ticari_MT1.cagrilar.count);
                        CagriList.Items.Add("Başlangıç Tarihi:" + aramaCagrisi.aramaBaslangic + " | Tanımlayıcısı:" + aramaCagrisi.CagriTanimlayicisi);
                    }
                    else
                    {
                        Ticari_MT2.cagrilar.Insert(musteri);
                        MessageBox.Show("İşlem başarılı." + "\n" +
                                        "Uygun Ticari Müşteri Temsilcimizin listesindeki sıranız: " + Ticari_MT2.cagrilar.count);
                        CagriList.Items.Add("Başlangıç Tarihi:" + aramaCagrisi.aramaBaslangic + " | Tanımlayıcısı:" + aramaCagrisi.CagriTanimlayicisi);
                    }
            }
            else
            {
                MessageBox.Show("Müşteri Türü Seçimi Yapmadınız! Tekrar deneyin.");

            }
   
        }

        private void btnCagriyiAta_Click(object sender, EventArgs e)
        {
           
            if (rbtnBireyselTemsilci1.Checked == true)
            {
                Bireysel_MT1.cagrilar.Peek();
  
            }

            else if (rbtnBireyselTemsilci2.Checked == true )
            {
                Bireysel_MT2.cagrilar.Peek();
            }

            else if (rbtnTicariTemsilci1.Checked == true)
            {
                Ticari_MT1.cagrilar.Peek();
            }
            else if (rbtnTicariTemsilci2.Checked == true)
            {
                Ticari_MT2.cagrilar.Peek();
  
            }
            else
            {
                MessageBox.Show("Müşteri türünüze uygun seçim yapmadınız! Lütfen deneyin.");
            }

        }

        // Her arama bittiğinde kaçıncı sırada olduğu söyleniyor.
        private void btnCagriyiBitir_Click(object sender, EventArgs e)
        {
            if (rbtnBireyselTemsilci1.Checked == true)
            {
                Bireysel_MT1.cagrilar.Remove();
                MessageBox.Show("Bir Arama Bitti." + "\n" +
                                   "Ticari Müşteri Temsilcimizin listesinde şimdiki sıranız: " + Bireysel_MT1.cagrilar.count); 
            }

            else if (rbtnBireyselTemsilci2.Checked == true )
            {
                Bireysel_MT2.cagrilar.Remove();
                MessageBox.Show("Bir Arama Bitti." + "\n" +
                                   "Ticari Müşteri Temsilcimizin listesinde şimdiki sıranız: " + Bireysel_MT2.cagrilar.count);
            }

            else if (rbtnTicariTemsilci1.Checked == true )
            {
                Ticari_MT1.cagrilar.Remove();
                MessageBox.Show("Bir Arama Bitti." + "\n" +
                                   "Ticari Müşteri Temsilcimizin listesinde şimdiki sıranız: " + Ticari_MT1.cagrilar.count);
            }
            else if (rbtnTicariTemsilci2.Checked == true )
            {
                Ticari_MT2.cagrilar.Remove();
                MessageBox.Show("Bir Arama Bitti." + "\n" +
                                   "Ticari Müşteri Temsilcimizin listesinde şimdiki sıranız: " + Ticari_MT2.cagrilar.count);
            }
            else
            {
                MessageBox.Show("Müşteri türünüze uygun seçim yapmadınız! Lütfen deneyin.");
            }
        }
    }
}
