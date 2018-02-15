using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSuma(object sender, EventArgs e)
		{
			Double n1, n2, Suma;
			n1 = Convert.ToDouble(txtNum1.Text);
			n2 = Convert.ToDouble(txtNum2.Text);
			Suma = n1 + n2;
			labelResultado.Text = Suma.ToString();
			if (txtNum1.Text == "") { labelResultado.Text = "No hay numero 1"; }
			else if (txtNum2.Text == "") { labelResultado.Text = "No hay numero 2"; }
		}

		private void btnResta(object sender, EventArgs e)
		{
			Double n1, n2, Resta;
			n1 = Convert.ToDouble(txtNum1.Text);
			n2 = Convert.ToDouble(txtNum2.Text);
			Resta = n1 - n2;
			labelResultado.Text = Resta.ToString();
			if (txtNum1.Text == "") { labelResultado.Text = "No hay numero 1"; }
			else if (txtNum2.Text == "") { labelResultado.Text = "No hay numero 2"; }
		}

		private void Multiplicacion(object sender, EventArgs e)
		{
			Double n1, n2, Mult;
			n1 = Convert.ToDouble(txtNum1.Text);
			n2 = Convert.ToDouble(txtNum2.Text);
			Mult = n1 * n2;
			labelResultado.Text = Mult.ToString();
			if (txtNum1.Text == "") { labelResultado.Text = "No hay numero 1"; }
			else if (txtNum2.Text == "") { labelResultado.Text = "No hay numero 2"; }
		}

		private void btnDivision(object sender, EventArgs e)
		{
			Double n1, n2, Div;
			n1 = Convert.ToDouble(txtNum1.Text);
			n2 = Convert.ToDouble(txtNum2.Text);
			Div = n1 / n2;
			labelResultado.Text = Div.ToString();
			if (txtNum1.Text == "") { labelResultado.Text = "No hay numero 1"; }
			else if (txtNum2.Text == "") { labelResultado.Text = "No hay numero 2"; }
			else if (txtNum2.Text == "") { labelResultado.Text = "No se puede dividir entre 0"; }
		}
	}
	}
