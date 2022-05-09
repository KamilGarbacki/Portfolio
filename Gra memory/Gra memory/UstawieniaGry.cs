namespace Gra_memory
{
    public class UstawieniaGry
    {
        public int IloscKolumn;
        public int IloscWierszy;
        private int _iloscObrazkow; //?

        public int CzasGry;
        public int CzasPodgladu;
        private int _czasZakrycia;

        public int Punkty;
        public int BokObrazka;

        public int MaxPunkty;

        public UstawieniaGry()
        {
            CzasPodgladu = 10;
            CzasGry = 120;
            Punkty = 0;
            IloscWierszy = 4;
            IloscKolumn = 6;
            BokObrazka = 150;
            MaxPunkty = (IloscKolumn * IloscWierszy) / 2;
        }
    }
}
