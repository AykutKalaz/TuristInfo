using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuristInfo
{
    public partial class Form2 : Form
    {
        public string text;
        string[] MagaraAd = new string[6];
        string[] MagaraResim = new string[6];
        string[] TapinakAd = new string[8];
        string[] TapinakResim = new string[8];
        string[] GolAd = new string[6];
        string[] GolResim = new string[6];
        string[] SelaleAd = new string[3];
        string[] SelaleResim = new string[3];
        string[] DogalAd = new string[6];
        string[] DogalResim = new string[6];
        string[] TarihiAd = new string[2];
        string[] TarihiResim = new string[2];

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int no;
            tarihiYerler();
            if (text == "Doğal")
            {
                no = random.Next(0, 6);
                label1.Text = DogalAd[no];
                pctResim.ImageLocation = DogalResim[no];
            }
            else if (text == "Tarihi")
            {
                no = random.Next(0, 2);
                label1.Text = TarihiAd[no];
                pctResim.ImageLocation = TarihiResim[no];
            }
            else if (text == "Tapınaklar")
            {
                no = random.Next(0, 8);
                label1.Text = TapinakAd[no];
                pctResim.ImageLocation = TapinakResim[no];
            }
            else if (text == "Mağaralar")
            {
                no = random.Next(0, 6);
                label1.Text = MagaraAd[no];
                pctResim.ImageLocation = MagaraResim[no];
            }
            else if (text == "Şelaleler")
            {
                no = random.Next(0, 3);
                label1.Text = SelaleAd[no];
                pctResim.ImageLocation = SelaleResim[no];
            }
            else if (text == "Göller")
            {
                no = random.Next(0, 6);
                label1.Text = GolAd[no];
                pctResim.ImageLocation = GolResim[no];
            }
            else
                MessageBox.Show("Anlamadım");
        }
        public void tarihiYerler()
        {
            MagaraAd[0] = "Ballica Mağarası / TOKAT";
            MagaraAd[1] = "DupNisa Mağarası / KIRKLARELİ";
            MagaraAd[2] = "Kral Kaya Mezarları / AMASYA";
            MagaraAd[3] = "Nemrut / ADIYAMAN";
            MagaraAd[4] = "Peri Bacaları / NEVŞEHİR";
            MagaraAd[5] = "Yedi Uyuyanlar Mağarası / MERSİN";

            MagaraResim[0] = AppDomain.CurrentDomain.BaseDirectory+"turistInfo\\tarihiYerler\\magaralar\\ballicaMagarasi.jpg";
            MagaraResim[1] = AppDomain.CurrentDomain.BaseDirectory+"turistInfo\\tarihiYerler\\magaralar\\dupnisaMagarasi.jpg";
            MagaraResim[2] = AppDomain.CurrentDomain.BaseDirectory+"turistInfo\\tarihiYerler\\magaralar\\KralKaya.jpg";
            MagaraResim[3] = AppDomain.CurrentDomain.BaseDirectory+"turistInfo\\tarihiYerler\\magaralar\\nemrut.jpg";
            MagaraResim[4] = AppDomain.CurrentDomain.BaseDirectory+"turistInfo\\tarihiYerler\\magaralar\\periBacalari.jpg";
            MagaraResim[5] = AppDomain.CurrentDomain.BaseDirectory+"turistInfo\\tarihiYerler\\magaralar\\yediUyuyanlar.jpg";

            TapinakAd[0] = "Galata Kulesi / İSTANBUL";
            TapinakAd[1] = "Göbekli Tepe Tapınağı / ŞANLIURFA";
            TapinakAd[2] = "Kadife Kale / İZMİR";
            TapinakAd[3] = "Kız Kalesi / MERSİN";
            TapinakAd[4] = "Laodikeia Kenti / DENİZLİ";
            TapinakAd[5] = "Sümela Manastırı / TRABZON";
            TapinakAd[6] = "Yerebatan Sarnıcı / İSTANBUL";
            TapinakAd[7] = "Zeugma Antik Kenti / GAZİANTEP";

            TapinakResim[0] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\tarihiYerler\\tapinaklar\\galataKulesi.jpg";
            TapinakResim[1] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\tarihiYerler\\tapinaklar\\gobeklitepe.jpg";
            TapinakResim[2] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\tarihiYerler\\tapinaklar\\kadifekale.jpg";
            TapinakResim[3] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\tarihiYerler\\tapinaklar\\kizkalesi.jpg";
            TapinakResim[4] = AppDomain.CurrentDomain.BaseDirectory + "\\turistInfo\\tarihiYerler\\tapinaklar\\LaodikeiaKenti.jpg";
            TapinakResim[5] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\tarihiYerler\\tapinaklar\\SumelaManastiri.jpg.jpg";
            TapinakResim[6] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\tarihiYerler\\tapinaklar\\yerebatanSarnici.jpg";
            TapinakResim[7] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\tarihiYerler\\tapinaklar\\zeugmaAntikKenti.jpg";

            GolAd[0] = "Balıklı Göl / ŞANLIURFA";
            GolAd[1] = "Gök Pınar Gölü / SİVAS";
            GolAd[2] = "Gölcük Tabiat Parkı / BOLU";
            GolAd[3] = "Salda Gölü / BURDUR";
            GolAd[4] = "Uzun Göl / TRABZON";
            GolAd[5] = "Yedigöller Milli Parkı / BOLU";

            GolResim[0] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\goller\\balikliGol.jpg";
            GolResim[1] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\goller\\gokpinarGolu.jpg";
            GolResim[2] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\goller\\golcukParki.jpg";
            GolResim[3] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\goller\\saldaGolu.jpg";
            GolResim[4] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\goller\\uzunGol.jpg";
            GolResim[5] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\goller\\yediGoller.jpg";

            SelaleAd[0] = "Düden Şelalesi / ANTALYA";
            SelaleAd[1] = "Göksu Şelalesi / KONYA";
            SelaleAd[2] = "Erfelek Şelalesi / SİNOP";

            SelaleResim[0] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\selaleler\\dudenSelalesi.jpg";
            SelaleResim[1] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\selaleler\\goksuSelalesi.jpg";
            SelaleResim[2] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\golVeSelale\\selaleler\\erfelekSelale.jpg";

            DogalAd[0] = "Ayder Yaylası / RİZE";
            DogalAd[1] = "Gölyazı Köyü / BURSA";
            DogalAd[2] = "Ihlara Vadisi / AKSARAY";
            DogalAd[3] = "Kelebekler Vadisi / MUĞLA";
            DogalAd[4] = "Pamukkale Travertenleri / DENİZLİ";
            DogalAd[5] = "Saklı Kent / MUĞLA";

            DogalResim[0] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\dogal\\ayderYaylasi.jpg";
            DogalResim[1] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\dogal\\golyaziKoyu.jpg";
            DogalResim[2] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\dogal\\ihlaraVadisi.jpg";
            DogalResim[3] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\dogal\\kelebeklerVadisi.jpg";
            DogalResim[4] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\dogal\\pamukkaleTraverten.jpg";
            DogalResim[5] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\dogal\\sakliKent.jpg";

            TarihiAd[0] = "Ataturk Arboretumu / İSTANBUL";
            TarihiAd[1] = "Pier Loti Tepesi / İSTANBUL";

            TarihiResim[0] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\tarihi\\AtaturkArboretumu.jpg";
            TarihiResim[1] = AppDomain.CurrentDomain.BaseDirectory + "turistInfo\\doga\\tarihi\\pierreloti.jpg";
        }

        private void btnYeniden_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int no;
            tarihiYerler();
            if (text == "Doğal")
            {
                no = random.Next(0, 6);
                label1.Text = DogalAd[no];
                pctResim.ImageLocation = DogalResim[no];
            }
            else if (text == "Tarihi")
            {
                no = random.Next(0, 2);
                label1.Text = TarihiAd[no];
                pctResim.ImageLocation = TarihiResim[no];
            }
            else if (text == "Tapınaklar")
            {
                no = random.Next(0, 8);
                label1.Text = TapinakAd[no];
                pctResim.ImageLocation = TapinakResim[no];
            }
            else if (text == "Mağaralar")
            {
                no = random.Next(0, 6);
                label1.Text = MagaraAd[no];
                pctResim.ImageLocation = MagaraResim[no];
            }
            else if (text == "Şelaleler")
            {
                no = random.Next(0, 3);
                label1.Text = SelaleAd[no];
                pctResim.ImageLocation = SelaleResim[no];
            }
            else if (text == "Göller")
            {
                no = random.Next(0, 6);
                label1.Text = GolAd[no];
                pctResim.ImageLocation = GolResim[no];
            }
            else
                MessageBox.Show("Anlamadım");
        }
    }
}
