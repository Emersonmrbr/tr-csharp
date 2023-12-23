namespace Componentes
{
  partial class F_NumericUpDown
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
      this.nud_numero = new System.Windows.Forms.NumericUpDown();
      this.ttb_numero = new System.Windows.Forms.TextBox();
      this.btn_definirValor = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nud_numero)).BeginInit();
      this.SuspendLayout();
      // 
      // nud_numero
      // 
      this.nud_numero.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nud_numero.Location = new System.Drawing.Point(12, 12);
      this.nud_numero.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.nud_numero.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.nud_numero.Name = "nud_numero";
      this.nud_numero.Size = new System.Drawing.Size(120, 20);
      this.nud_numero.TabIndex = 0;
      this.nud_numero.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // ttb_numero
      // 
      this.ttb_numero.Location = new System.Drawing.Point(152, 12);
      this.ttb_numero.Name = "ttb_numero";
      this.ttb_numero.Size = new System.Drawing.Size(120, 20);
      this.ttb_numero.TabIndex = 1;
      // 
      // btn_definirValor
      // 
      this.btn_definirValor.Location = new System.Drawing.Point(12, 50);
      this.btn_definirValor.Name = "btn_definirValor";
      this.btn_definirValor.Size = new System.Drawing.Size(260, 23);
      this.btn_definirValor.TabIndex = 2;
      this.btn_definirValor.Text = "Definir valor";
      this.btn_definirValor.UseVisualStyleBackColor = true;
      this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
      // 
      // F_NumericUpDown
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 411);
      this.Controls.Add(this.btn_definirValor);
      this.Controls.Add(this.ttb_numero);
      this.Controls.Add(this.nud_numero);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_NumericUpDown";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "F_NumericUpDown";
      ((System.ComponentModel.ISupportInitialize)(this.nud_numero)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown nud_numero;
    private System.Windows.Forms.TextBox ttb_numero;
    private System.Windows.Forms.Button btn_definirValor;
  }
}