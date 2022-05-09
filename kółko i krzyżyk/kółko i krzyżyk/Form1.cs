using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kółko_i_krzyżyk
{
	public partial class Form1 : Form
	{
		private bool czyj_ruch = true; //true - X false - O

		public Form1()
		{
			InitializeComponent();
			WlaczPrzyciskiIResetuj();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);

		}

		private void wstawZnak(object przycisk)
		{
			//throw new NotImplementedException();
			Button wcisnietyPrzycisk = (Button)przycisk;
			if (czyj_ruch)
			{
				wcisnietyPrzycisk.Text = "X";
			}
			else
			{
				wcisnietyPrzycisk.Text = "O";
			}
			wcisnietyPrzycisk.Enabled = false;
			bool wynik = SprawdzWygrana();
			if (wynik == true)
			{
				string tekst_wygranej;

				if(czyj_ruch == true)
				{
					tekst_wygranej = "Wygrał gracz X! Gramy jeszcze raz?";
				}
				else
				{
					tekst_wygranej = "Wygrał gracz O! Gramy jeszcze raz?";
				}
				DialogResult odpowiedz = MessageBox.Show(tekst_wygranej, "Wygrana", MessageBoxButtons.YesNo);

				if(odpowiedz == DialogResult.No)
				{
					wylaczPrzyciski();
				}
				else
				{
					WlaczPrzyciskiIResetuj();
				}
			}
			czyj_ruch = !czyj_ruch;

			if(czyj_ruch)
			{
				lblCzyjRuch.Text = "X";
			}
			else
			{
				lblCzyjRuch.Text = "O";
			}
		}
		private void wylaczPrzyciski()
		{
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
			button8.Enabled = false;
			button9.Enabled = false;
		}
		private bool SprawdzWygrana()
		{
			if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != " ") //1
			{
				return true;
			}
			else if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != " ")//2
			{
				return true;
			}
			else if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != " ")//3
			{
				return true;
			}
			else if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != " ")//4
			{
				return true;
			}
			else if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != " ")//5
			{
				return true;
			}
			else if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != " ")//6
			{
				return true;
			}
			else if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != " ")//7
			{
				return true;
			}
			else if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != " ")//8
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void wstawZnak(object sender, EventArgs e)
		{

		}
		private void WlaczPrzyciskiIResetuj()
		{
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;

			button1.Text = " ";
			button2.Text = " ";
			button3.Text = " ";
			button4.Text = " ";
			button5.Text = " ";
			button6.Text = " ";
			button7.Text = " ";
			button8.Text = " ";
			button9.Text = " ";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			wstawZnak(sender);
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
