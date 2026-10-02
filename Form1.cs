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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnIngresar_Click(object sender, EventArgs e)
		{
			if (TextUsuario.Text == "Dayana" && TextContraseña.Text == "60")
			{
				this.Hide();
				Fomr2 app = new Fomr2();
				app.Show();
			}

			else
			{


				MessageBox.Show("datos incorrectos ");

			}
		}
	}
}
