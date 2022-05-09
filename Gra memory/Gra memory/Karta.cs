using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gra_memory
{
    public class Karta : Label
    {
        public readonly Guid Id;
        private Image _TylKarty;
        private Image _obrazekKarty;

        public Karta(Guid id, string tylKartySciezka, string obrazekKartySciezka, int bokObrazka)
        {
            Id = id;
            _TylKarty = Image.FromFile(tylKartySciezka);
            _obrazekKarty = Image.FromFile(obrazekKartySciezka);
            ZmienRozmiarObrazkow(bokObrazka);
        }

        private void ZmienRozmiarObrazkow(int bokObrazka)
        {
            var bitmap = new Bitmap(_obrazekKarty, new Size(bokObrazka, bokObrazka));
            _obrazekKarty = bitmap;

            bitmap = new Bitmap(_TylKarty, new Size(bokObrazka, bokObrazka));
            _TylKarty = bitmap;
        }

        public void Zakryj()
        {
            BackgroundImage = _TylKarty;
            Enabled = true;
        }

        public void Odkryj()
        {
            BackgroundImage = _obrazekKarty;
            Enabled = false;
        }
    }
}
