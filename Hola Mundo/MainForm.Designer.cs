/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 18:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Hola_Mundo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Label lbl_mostrar;
		private System.Windows.Forms.TextBox txt_nombre;
		
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
			this.btn_ok = new System.Windows.Forms.Button();
			this.lbl_mostrar = new System.Windows.Forms.Label();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(78, 93);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(130, 64);
			this.btn_ok.TabIndex = 0;
			this.btn_ok.Text = "Ok";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.Button1Click);
			// 
			// lbl_mostrar
			// 
			this.lbl_mostrar.Location = new System.Drawing.Point(59, 185);
			this.lbl_mostrar.Name = "lbl_mostrar";
			this.lbl_mostrar.Size = new System.Drawing.Size(160, 48);
			this.lbl_mostrar.TabIndex = 1;
			this.lbl_mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_nombre
			// 
			this.txt_nombre.Location = new System.Drawing.Point(22, 35);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(234, 20);
			this.txt_nombre.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.lbl_mostrar);
			this.Controls.Add(this.btn_ok);
			this.Name = "MainForm";
			this.Text = "Hola Mundo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
