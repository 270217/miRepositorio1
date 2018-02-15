namespace Calculadora2
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.labelResultado = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNum1
			// 
			this.txtNum1.Location = new System.Drawing.Point(55, 65);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(100, 20);
			this.txtNum1.TabIndex = 0;
			// 
			// txtNum2
			// 
			this.txtNum2.Location = new System.Drawing.Point(55, 116);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(100, 20);
			this.txtNum2.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(72, 190);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Suma";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.btnSuma);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(200, 190);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Resta";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.btnResta);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(0, 0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 8;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(0, 0);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 7;
			// 
			// labelResultado
			// 
			this.labelResultado.AutoSize = true;
			this.labelResultado.Location = new System.Drawing.Point(72, 301);
			this.labelResultado.Name = "labelResultado";
			this.labelResultado.Size = new System.Drawing.Size(55, 13);
			this.labelResultado.TabIndex = 6;
			this.labelResultado.Text = "Resultado";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(72, 245);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(83, 23);
			this.button5.TabIndex = 9;
			this.button5.Text = "Multiplicacion";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Multiplicacion);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(200, 245);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 10;
			this.button6.Text = "Division";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.btnDivision);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 338);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.labelResultado);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label labelResultado;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
	}
}

