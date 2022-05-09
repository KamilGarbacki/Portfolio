using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirynt
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Odnowa();
		}
		void Odnowa()
		{
			Point start = panelgry.Location;
			start.Offset(10, 10);
			Cursor.Position = PointToScreen(start);
		}

		private void label2_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label1_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label5_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label13_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label4_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label9_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label8_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label14_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label11_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void label3_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Przegrałeś!");
			Odnowa();
		}

		private void LBLmeta_MouseEnter(object sender, EventArgs e)
		{
			MessageBox.Show("Gratulacje!");
			Close();
		}
	}
}
