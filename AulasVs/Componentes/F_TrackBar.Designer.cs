namespace Componentes
{
  partial class F_TrackBar
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
      this.Tkb_Valor = new System.Windows.Forms.TrackBar();
      this.Ttb_Valor = new System.Windows.Forms.TextBox();
      this.Lbl_Valor = new System.Windows.Forms.Label();
      this.Btn_Definir = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.Tkb_Valor)).BeginInit();
      this.SuspendLayout();
      // 
      // Tkb_Valor
      // 
      this.Tkb_Valor.Location = new System.Drawing.Point(13, 13);
      this.Tkb_Valor.Maximum = 100;
      this.Tkb_Valor.Name = "Tkb_Valor";
      this.Tkb_Valor.Size = new System.Drawing.Size(409, 45);
      this.Tkb_Valor.TabIndex = 0;
      this.Tkb_Valor.Value = 25;
      this.Tkb_Valor.Scroll += new System.EventHandler(this.Tkb_Valor_Scroll);
      // 
      // Ttb_Valor
      // 
      this.Ttb_Valor.Location = new System.Drawing.Point(13, 65);
      this.Ttb_Valor.Name = "Ttb_Valor";
      this.Ttb_Valor.Size = new System.Drawing.Size(100, 20);
      this.Ttb_Valor.TabIndex = 1;
      // 
      // Lbl_Valor
      // 
      this.Lbl_Valor.AutoSize = true;
      this.Lbl_Valor.Location = new System.Drawing.Point(13, 92);
      this.Lbl_Valor.Name = "Lbl_Valor";
      this.Lbl_Valor.Size = new System.Drawing.Size(35, 13);
      this.Lbl_Valor.TabIndex = 2;
      this.Lbl_Valor.Text = "label1";
      // 
      // Btn_Definir
      // 
      this.Btn_Definir.Location = new System.Drawing.Point(120, 61);
      this.Btn_Definir.Name = "Btn_Definir";
      this.Btn_Definir.Size = new System.Drawing.Size(75, 23);
      this.Btn_Definir.TabIndex = 3;
      this.Btn_Definir.Text = "Definir";
      this.Btn_Definir.UseVisualStyleBackColor = true;
      this.Btn_Definir.Click += new System.EventHandler(this.Btn_Definir_Click);
      // 
      // F_TrackBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.Btn_Definir);
      this.Controls.Add(this.Lbl_Valor);
      this.Controls.Add(this.Ttb_Valor);
      this.Controls.Add(this.Tkb_Valor);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_TrackBar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Track Bar";
      this.Load += new System.EventHandler(this.F_TrackBar_Load);
      ((System.ComponentModel.ISupportInitialize)(this.Tkb_Valor)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TrackBar Tkb_Valor;
    private System.Windows.Forms.TextBox Ttb_Valor;
    private System.Windows.Forms.Label Lbl_Valor;
    private System.Windows.Forms.Button Btn_Definir;
  }
}