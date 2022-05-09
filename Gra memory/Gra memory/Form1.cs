using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gra_memory
{
    public partial class Form1 : Form
    {
        private UstawieniaGry _ustawieniaGry;
        private Karta _pierwsza, _druga;
        public Form1()
        {
            InitializeComponent();                      
            nowaGra();
            
        }

        private void nowaGra()
        {
            _ustawieniaGry = new UstawieniaGry();
            UstawKontrolki();
            GenerujKarty();

        }

        private void UstawKontrolki()
        {
            TimerCzasPodglandu.Start(); 
            PanelKart.Width = _ustawieniaGry.BokObrazka * _ustawieniaGry.IloscKolumn;
            PanelKart.Height = _ustawieniaGry.BokObrazka * _ustawieniaGry.IloscWierszy;

            Width = PanelKart.Width + 50;
            Height = PanelKart.Height + 150;

            lblStartInfo.Text = $"Początek gry za: {_ustawieniaGry.CzasPodgladu}";
            lblPunktyWartosc.Text = _ustawieniaGry.Punkty.ToString();
            lblCzasWartosc.Text = _ustawieniaGry.CzasGry.ToString();
            lblStartInfo.Visible = true;  //pamietac zeby pozniej to ukryc
        }

        private void GenerujKarty()
        {
            //tworzymy sobie liste plikow ktore sa w jakims naszym folderze
            //pętla, ustawiamy obrazki do obiektów klasy karty

            string[] tablicaObrazkow = Directory.GetFiles($@"{AppDomain.CurrentDomain.BaseDirectory}\obrazki\Karty");
            var karty = new List<Karta>();
            string sciezkaDoLogo = $@"{AppDomain.CurrentDomain.BaseDirectory}\obrazki\logo.jpg";

            foreach (var sciezkaObrazka in tablicaObrazkow)
            {
                var id = Guid.NewGuid();

                var karta1 = new Karta(id, sciezkaDoLogo, sciezkaObrazka, _ustawieniaGry.BokObrazka);
                karta1.Click += Btn_Clieck;
                var karta2 = new Karta(id, sciezkaDoLogo, sciezkaObrazka, _ustawieniaGry.BokObrazka);
                karta2.Click += Btn_Clieck;
                karty.Add(karta1);
                karty.Add(karta2);
            }

            Random random = new Random();
            PanelKart.Controls.Clear();

            for (int x = 0; x < _ustawieniaGry.IloscKolumn; x++)
            {
                for (int y = 0; y < _ustawieniaGry.IloscWierszy; y++)
                {
                    var losowyIndeks = random.Next(0, karty.Count);
                    var wylosowanaKarta = karty[losowyIndeks];
                    int margines = 4;
                    wylosowanaKarta.Location = new Point(
                        (x * _ustawieniaGry.BokObrazka) + (x * margines),
                        (y * _ustawieniaGry.BokObrazka) + (y * margines));

                    wylosowanaKarta.Width = _ustawieniaGry.BokObrazka;
                    wylosowanaKarta.Height = _ustawieniaGry.BokObrazka;
                    wylosowanaKarta.Odkryj();

                    PanelKart.Controls.Add(wylosowanaKarta);
                    karty.Remove(wylosowanaKarta);
                }
            }

            
        }

        private void TimerCzasGry_Tick(object sender, EventArgs e)
        {
            _ustawieniaGry.CzasGry--;
            lblCzasWartosc.Text = _ustawieniaGry.CzasGry.ToString();
            if (_ustawieniaGry.CzasGry <= 0 && _ustawieniaGry.Punkty < _ustawieniaGry.MaxPunkty)
            {
                ZakonczRozgrywke(false);
            }
            else if (_ustawieniaGry.Punkty == _ustawieniaGry.MaxPunkty)
            {
                ZakonczRozgrywke(true);
            }
        }

        private void ZakonczRozgrywke(bool wygrana)
        {
            TimerCzasGry.Stop();
            TimerZakrywacz.Stop();
            string tekst = wygrana ? "Wygrałeś!!! " : "Przegrałeś ";
            tekst += "Czy chcesz zagrać ponownie";

            var czyNowaGra = MessageBox.Show(tekst, "Koniec gry", MessageBoxButtons.YesNo);
            TimerCzasGry.Stop();
            TimerZakrywacz.Stop();

            if (czyNowaGra == DialogResult.Yes)
            {
                nowaGra();
            }
            else
            {
                Application.Exit();
            }

        }

        private void TimerCzasPodglandu_Tick(object sender, EventArgs e)
        {
            _ustawieniaGry.CzasPodgladu--;

            lblStartInfo.Text = $"Poczatek gry za: {_ustawieniaGry.CzasPodgladu}";

            if (_ustawieniaGry.CzasPodgladu <= 0)
            {
                foreach(var kontrolka in PanelKart.Controls)
                {
                    Karta karta = (Karta)kontrolka;
                    karta.Zakryj(); 
                }

                TimerCzasGry.Start();
                TimerCzasPodglandu.Stop();
                lblStartInfo.Visible = false;
            }

            
        }

        private void TimerZakrywacz_Tick(object sender, EventArgs e)
        {
            _pierwsza.Zakryj();
            _druga.Zakryj();

            _pierwsza = null;
            _druga = null;

            PanelKart.Enabled = true;
            TimerZakrywacz.Stop();
        }

        private void PanelKart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Clieck(object sender, EventArgs e)
        {
            Karta kliknietaKarta = (Karta)sender;
            
            if (_pierwsza == null)
            {
                _pierwsza = kliknietaKarta;
                _pierwsza.Odkryj();
            }
            else
            {
                _druga = kliknietaKarta;
                _druga.Odkryj();
                PanelKart.Enabled = false;

                if (_pierwsza.Id == _druga.Id)
                {
                    _ustawieniaGry.Punkty++;
                    lblPunktyWartosc.Text = _ustawieniaGry.Punkty.ToString();
                    PanelKart.Enabled = true;
                    _pierwsza = null;
                    _druga = null;
                }
                else
                {
                    TimerZakrywacz.Start();
                }

            }
        }
    }
}
