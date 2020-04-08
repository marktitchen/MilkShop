namespace MilkShop
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.coffeeQty = new System.Windows.Forms.NumericUpDown();
			this.chocolateQty = new System.Windows.Forms.NumericUpDown();
			this.vanillaQty = new System.Windows.Forms.NumericUpDown();
			this.mangoQty = new System.Windows.Forms.NumericUpDown();
			this.strawberryQty = new System.Windows.Forms.NumericUpDown();
			this.chkCoffee = new System.Windows.Forms.CheckBox();
			this.chkChocolate = new System.Windows.Forms.CheckBox();
			this.chkVanilla = new System.Windows.Forms.CheckBox();
			this.chkMango = new System.Windows.Forms.CheckBox();
			this.chkStrawberry = new System.Windows.Forms.CheckBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBalance = new System.Windows.Forms.TextBox();
			this.txtPayment = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnPriceInvoice = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.coffeeQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chocolateQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vanillaQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mangoQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.strawberryQty)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(1, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(974, 100);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(131, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(694, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Milk Shop Point Of Sales System";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.coffeeQty);
			this.groupBox1.Controls.Add(this.chocolateQty);
			this.groupBox1.Controls.Add(this.vanillaQty);
			this.groupBox1.Controls.Add(this.mangoQty);
			this.groupBox1.Controls.Add(this.strawberryQty);
			this.groupBox1.Controls.Add(this.chkCoffee);
			this.groupBox1.Controls.Add(this.chkChocolate);
			this.groupBox1.Controls.Add(this.chkVanilla);
			this.groupBox1.Controls.Add(this.chkMango);
			this.groupBox1.Controls.Add(this.chkStrawberry);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 120);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(401, 311);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Milk";
			// 
			// coffeeQty
			// 
			this.coffeeQty.Location = new System.Drawing.Point(191, 258);
			this.coffeeQty.Name = "coffeeQty";
			this.coffeeQty.Size = new System.Drawing.Size(120, 30);
			this.coffeeQty.TabIndex = 9;
			// 
			// chocolateQty
			// 
			this.chocolateQty.Location = new System.Drawing.Point(191, 211);
			this.chocolateQty.Name = "chocolateQty";
			this.chocolateQty.Size = new System.Drawing.Size(120, 30);
			this.chocolateQty.TabIndex = 8;
			// 
			// vanillaQty
			// 
			this.vanillaQty.Location = new System.Drawing.Point(191, 160);
			this.vanillaQty.Name = "vanillaQty";
			this.vanillaQty.Size = new System.Drawing.Size(120, 30);
			this.vanillaQty.TabIndex = 7;
			// 
			// mangoQty
			// 
			this.mangoQty.Location = new System.Drawing.Point(191, 101);
			this.mangoQty.Name = "mangoQty";
			this.mangoQty.Size = new System.Drawing.Size(120, 30);
			this.mangoQty.TabIndex = 6;
			// 
			// strawberryQty
			// 
			this.strawberryQty.Location = new System.Drawing.Point(191, 50);
			this.strawberryQty.Name = "strawberryQty";
			this.strawberryQty.Size = new System.Drawing.Size(120, 30);
			this.strawberryQty.TabIndex = 5;
			// 
			// chkCoffee
			// 
			this.chkCoffee.AutoSize = true;
			this.chkCoffee.Location = new System.Drawing.Point(28, 258);
			this.chkCoffee.Name = "chkCoffee";
			this.chkCoffee.Size = new System.Drawing.Size(98, 29);
			this.chkCoffee.TabIndex = 4;
			this.chkCoffee.Text = "Coffee";
			this.chkCoffee.UseVisualStyleBackColor = true;
			// 
			// chkChocolate
			// 
			this.chkChocolate.AutoSize = true;
			this.chkChocolate.Location = new System.Drawing.Point(28, 211);
			this.chkChocolate.Name = "chkChocolate";
			this.chkChocolate.Size = new System.Drawing.Size(132, 29);
			this.chkChocolate.TabIndex = 2;
			this.chkChocolate.Text = "Chocolate";
			this.chkChocolate.UseVisualStyleBackColor = true;
			// 
			// chkVanilla
			// 
			this.chkVanilla.AutoSize = true;
			this.chkVanilla.Location = new System.Drawing.Point(28, 161);
			this.chkVanilla.Name = "chkVanilla";
			this.chkVanilla.Size = new System.Drawing.Size(100, 29);
			this.chkVanilla.TabIndex = 3;
			this.chkVanilla.Text = "Vanilla";
			this.chkVanilla.UseVisualStyleBackColor = true;
			// 
			// chkMango
			// 
			this.chkMango.AutoSize = true;
			this.chkMango.Location = new System.Drawing.Point(28, 102);
			this.chkMango.Name = "chkMango";
			this.chkMango.Size = new System.Drawing.Size(100, 29);
			this.chkMango.TabIndex = 2;
			this.chkMango.Text = "Mango";
			this.chkMango.UseVisualStyleBackColor = true;
			// 
			// chkStrawberry
			// 
			this.chkStrawberry.AutoSize = true;
			this.chkStrawberry.Location = new System.Drawing.Point(28, 44);
			this.chkStrawberry.Name = "chkStrawberry";
			this.chkStrawberry.Size = new System.Drawing.Size(138, 29);
			this.chkStrawberry.TabIndex = 1;
			this.chkStrawberry.Text = "Strawberry";
			this.chkStrawberry.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.delete});
			this.dataGridView1.Location = new System.Drawing.Point(12, 495);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(681, 150);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Item";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Price";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.Width = 125;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Qty";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.Width = 125;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Total";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			this.Column4.Width = 125;
			// 
			// delete
			// 
			this.delete.HeaderText = "Delete";
			this.delete.MinimumWidth = 6;
			this.delete.Name = "delete";
			this.delete.Text = "Delete";
			this.delete.UseColumnTextForButtonValue = true;
			this.delete.Width = 125;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.txtBalance);
			this.groupBox2.Controls.Add(this.txtPayment);
			this.groupBox2.Controls.Add(this.txtTotal);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(742, 357);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(305, 205);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 0;
			// 
			// txtBalance
			// 
			this.txtBalance.Location = new System.Drawing.Point(152, 153);
			this.txtBalance.Name = "txtBalance";
			this.txtBalance.Size = new System.Drawing.Size(100, 22);
			this.txtBalance.TabIndex = 5;
			// 
			// txtPayment
			// 
			this.txtPayment.Location = new System.Drawing.Point(152, 99);
			this.txtPayment.Name = "txtPayment";
			this.txtPayment.Size = new System.Drawing.Size(100, 22);
			this.txtPayment.TabIndex = 4;
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(152, 50);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 22);
			this.txtTotal.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(32, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 25);
			this.label4.TabIndex = 2;
			this.label4.Text = "Balance";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Total";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(779, 169);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(110, 31);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
			// 
			// btnPriceInvoice
			// 
			this.btnPriceInvoice.Location = new System.Drawing.Point(779, 264);
			this.btnPriceInvoice.Name = "btnPriceInvoice";
			this.btnPriceInvoice.Size = new System.Drawing.Size(110, 31);
			this.btnPriceInvoice.TabIndex = 5;
			this.btnPriceInvoice.Text = "Print Invoice";
			this.btnPriceInvoice.UseVisualStyleBackColor = true;
			this.btnPriceInvoice.Click += new System.EventHandler(this.BtnPriceInvoice_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(39, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(96, 25);
			this.label6.TabIndex = 7;
			this.label6.Text = "Payment";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1101, 673);
			this.Controls.Add(this.btnPriceInvoice);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Milk POS";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.coffeeQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chocolateQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vanillaQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mangoQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.strawberryQty)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.NumericUpDown coffeeQty;
		private System.Windows.Forms.NumericUpDown chocolateQty;
		private System.Windows.Forms.NumericUpDown vanillaQty;
		private System.Windows.Forms.NumericUpDown mangoQty;
		private System.Windows.Forms.NumericUpDown strawberryQty;
		private System.Windows.Forms.CheckBox chkCoffee;
		private System.Windows.Forms.CheckBox chkChocolate;
		private System.Windows.Forms.CheckBox chkVanilla;
		private System.Windows.Forms.CheckBox chkMango;
		private System.Windows.Forms.CheckBox chkStrawberry;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewButtonColumn delete;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBalance;
		private System.Windows.Forms.TextBox txtPayment;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnPriceInvoice;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}

