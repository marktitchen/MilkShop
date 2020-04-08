using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilkShop
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
		private void BtnAdd_Click(object sender, EventArgs e)
		{
			string name;
			int price;
			int qty;
			int total;

			if(chkStrawberry.Checked)
			{
				name = "Strawberry Milk";
				qty = int.Parse(strawberryQty.Value.ToString());
				price = 100;
				total = qty * price;
				this.dataGridView1.Rows.Add(name, price, qty, total);
			}
			if (chkMango.Checked)
			{
				name = "Mango Milk";
				qty = int.Parse(mangoQty.Value.ToString());
				price = 200;
				total = qty * price;
				this.dataGridView1.Rows.Add(name, price, qty, total);
			}
			if (chkVanilla.Checked)
			{
				name = "Vanilla Milk";
				qty = int.Parse(vanillaQty.Value.ToString());
				price = 300;
				total = qty * price;
				this.dataGridView1.Rows.Add(name, price, qty, total);
			}
			if (chkChocolate.Checked)
			{
				name = "Chocolate Milk";
				qty = int.Parse(chocolateQty.Value.ToString());
				price = 400;
				total = qty * price;
				this.dataGridView1.Rows.Add(name, price, qty, total);
			}
			if (chkCoffee.Checked)
			{
				name = "Coffee Milk";
				qty = int.Parse(coffeeQty.Value.ToString());
				price = 500;
				total = qty * price;
				this.dataGridView1.Rows.Add(name, price, qty, total);
			}

			int sum = 0;

			for(int row = 0; row<dataGridView1.Rows.Count; row++)
			{
				sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
			}

			txtTotal.Text = sum.ToString();



		}

		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex == dataGridView1.Columns["delete"].Index && e.RowIndex >= 0)
			{
				dataGridView1.Rows.Remove(dataGridView1.Rows[e.RowIndex]);

				int sum = 0;

				for (int row = 0; row < dataGridView1.Rows.Count; row++)
				{
					sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
				}

				txtTotal.Text = sum.ToString();

			}
		}







		private void BtnPriceInvoice_Click(object sender, EventArgs e)
		{
			int pay = int.Parse(txtPayment.Text);
			int total = int.Parse(txtTotal.Text);
			int balance = pay - total;
			
			txtBalance.Text = balance.ToString();
		}

		
	}
}
