using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4toBim
{
	public partial class Fomr2 : Form
	{
		public Fomr2()
		{
			InitializeComponent();
		}

		private void BtnProducto_Click(object sender, EventArgs e)
		{
			int Num1 = int.Parse(TextVar1.Text);
			int Num2 = int.Parse(TextVar2.Text);
			int Producto = Num1 * Num2;
			MessageBox.Show("El resultado del Producto es" + Producto);
		}

		private void BtnSuma_Click(object sender, EventArgs e)
		{
			int Num1 = int.Parse(TextVar1.Text);
			int Num2 = int.Parse(TextVar2.Text);
			int Suma = Num1 + Num2;
			MessageBox.Show("El resultado de la suma es" + Suma);
		}

		private void BtnPotencia_Click(object sender, EventArgs e)
		{
			int num1 = int.Parse(TextVar1.Text);
			int num2 = int.Parse(TextVar2.Text);
			int producto = num1 * num2;
			MessageBox.Show("el resultado del producto es" + producto);
		}

		private void BtnDivision_Click(object sender, EventArgs e)
		{
			float Num1 = float.Parse(TextVar1.Text);
			float Num2 = float.Parse(TextVar2.Text);

			if (Num2 > 0)
			{

				float division = Num1 / Num2;
				MessageBox.Show("El resultado es" + division);

			}
			else
			{
				MessageBox.Show("La Division es indefinida");
	}
		}
	}
}
