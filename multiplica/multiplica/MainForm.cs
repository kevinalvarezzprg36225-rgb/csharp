/*
 * Creado por SharpDevelop.
 * Usuario: zavala
 * Fecha: 23/10/2026
 * Hora: 07:33 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace multiplica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void LimpiarToolStripMenuItemClick(object sender, EventArgs e)
		{
			txt1.Text="";
			txt2.Text="";
						
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double num1, num2, resultado;
			resultado=0;
			num1=Convert.ToDouble(txt1.Text);
			num2=Convert.ToDouble(txt2.Text);
			resultado=num1 * num2;
			MessageBox.Show("el resultado es: "+ Convert.ToString(resultado));
			
		}
	}
}
