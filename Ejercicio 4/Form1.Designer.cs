/*
 * Created by SharpDevelop.
 * User: IPPESSI
 * Date: 30/8/2021
 * Time: 20:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_4
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_salir;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_salir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_salir
			// 
			this.btn_salir.Location = new System.Drawing.Point(99, 111);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.Size = new System.Drawing.Size(75, 23);
			this.btn_salir.TabIndex = 0;
			this.btn_salir.Text = "Salir";
			this.btn_salir.UseVisualStyleBackColor = true;
			this.btn_salir.Click += new System.EventHandler(this.Btn_salirClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btn_salir);
			this.Name = "Form1";
			this.Text = "Form1";
			
			this.ResumeLayout(false);

		}
	}
}
