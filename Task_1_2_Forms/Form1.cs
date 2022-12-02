using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_2_Forms
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int a;

			a = Convert.ToInt32(textBox1.Text);

			if ((a <= 9 || a >= 100) && (a >= -9 || a <= -100))
			{
				textBox3.Text = String.Format("a должно быть двузначным числом");
				return;
			}

			string aS = a.ToString();

			if (a < 0)
			{
				aS = aS.Remove(0, 1);
			}

			if (aS[0] == aS[1])
			{
				textBox3.Text = String.Format("у данного числа цифры равны");
			}
			else
			{
				textBox3.Text = String.Format("у данного числа цифры неравны");
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox3.Text = "";
		}
	}
}
