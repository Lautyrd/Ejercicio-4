using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_4
{
	
	public partial class MainForm : Form
	{

		Form1 myform;

			
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Btn_mostrarClick(object sender, EventArgs e)
		{
			if (myform==null) {
				myform=new Form1();
			}
			myform.Show();
		}
		void Btn_ocultarClick(object sender, EventArgs e)
		{
			if (myform==null) {
				myform=new Form1();
			}
			myform.Hide();
		}
		
	}
}
