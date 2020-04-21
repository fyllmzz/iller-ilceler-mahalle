using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iller_ilçeler_mahalleler
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'ds_tabloilişkilendirme.mahalleler' table. You can move, or remove it, as needed.
			this.mahallelerTableAdapter.Fill(this.ds_tabloilişkilendirme.mahalleler);
			// TODO: This line of code loads data into the 'ds_tabloilişkilendirme.ilçeler' table. You can move, or remove it, as needed.
			this.ilçelerTableAdapter.Fill(this.ds_tabloilişkilendirme.ilçeler);
			// TODO: This line of code loads data into the 'ds_tabloilişkilendirme.iller' table. You can move, or remove it, as needed.
			this.illerTableAdapter.Fill(this.ds_tabloilişkilendirme.iller);

		}
	}
}
