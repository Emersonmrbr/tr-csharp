﻿namespace Componentes
{
    partial class F_Veiculos
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
      this.Tb_ListaVeiculos = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // Tb_ListaVeiculos
      // 
      this.Tb_ListaVeiculos.Location = new System.Drawing.Point(12, 9);
      this.Tb_ListaVeiculos.Multiline = true;
      this.Tb_ListaVeiculos.Name = "Tb_ListaVeiculos";
      this.Tb_ListaVeiculos.Size = new System.Drawing.Size(260, 340);
      this.Tb_ListaVeiculos.TabIndex = 0;
      // 
      // F_Veiculos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 361);
      this.Controls.Add(this.Tb_ListaVeiculos);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_Veiculos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Lista de Veículos";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Veiculos_FormClosed);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.TextBox Tb_ListaVeiculos;
  }
}