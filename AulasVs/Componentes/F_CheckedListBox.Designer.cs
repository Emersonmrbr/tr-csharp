namespace Componentes
{
  partial class F_CheckedListBox
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
      this.clb_veiculos = new System.Windows.Forms.CheckedListBox();
      this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
      this.btn_limparLista = new System.Windows.Forms.Button();
      this.btn_resetLista = new System.Windows.Forms.Button();
      this.tb_adicionaTransporte = new System.Windows.Forms.TextBox();
      this.btn_adicionarTransporte = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // clb_veiculos
      // 
      this.clb_veiculos.BackColor = System.Drawing.SystemColors.Menu;
      this.clb_veiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.clb_veiculos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.clb_veiculos.FormattingEnabled = true;
      this.clb_veiculos.Items.AddRange(new object[] {
            "Avião",
            "Navio",
            "Carro",
            "Moto",
            "Bicicleta"});
      this.clb_veiculos.Location = new System.Drawing.Point(13, 13);
      this.clb_veiculos.Name = "clb_veiculos";
      this.clb_veiculos.Size = new System.Drawing.Size(120, 220);
      this.clb_veiculos.TabIndex = 0;
      // 
      // btn_mostrarSelecionados
      // 
      this.btn_mostrarSelecionados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_mostrarSelecionados.Location = new System.Drawing.Point(140, 13);
      this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
      this.btn_mostrarSelecionados.Size = new System.Drawing.Size(307, 23);
      this.btn_mostrarSelecionados.TabIndex = 1;
      this.btn_mostrarSelecionados.Text = "Mostrar selecionados";
      this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
      this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
      // 
      // btn_limparLista
      // 
      this.btn_limparLista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_limparLista.Location = new System.Drawing.Point(140, 43);
      this.btn_limparLista.Name = "btn_limparLista";
      this.btn_limparLista.Size = new System.Drawing.Size(307, 23);
      this.btn_limparLista.TabIndex = 2;
      this.btn_limparLista.Text = "Limpar lista";
      this.btn_limparLista.UseVisualStyleBackColor = true;
      this.btn_limparLista.Click += new System.EventHandler(this.btn_limparLista_Click);
      // 
      // btn_resetLista
      // 
      this.btn_resetLista.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_resetLista.Location = new System.Drawing.Point(140, 73);
      this.btn_resetLista.Name = "btn_resetLista";
      this.btn_resetLista.Size = new System.Drawing.Size(307, 23);
      this.btn_resetLista.TabIndex = 3;
      this.btn_resetLista.Text = "Resetar lista";
      this.btn_resetLista.UseVisualStyleBackColor = true;
      this.btn_resetLista.Click += new System.EventHandler(this.btn_resetLista_Click);
      // 
      // tb_adicionaTransporte
      // 
      this.tb_adicionaTransporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.tb_adicionaTransporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tb_adicionaTransporte.Location = new System.Drawing.Point(139, 193);
      this.tb_adicionaTransporte.Name = "tb_adicionaTransporte";
      this.tb_adicionaTransporte.Size = new System.Drawing.Size(307, 20);
      this.tb_adicionaTransporte.TabIndex = 4;
      this.tb_adicionaTransporte.TabStop = false;
      this.tb_adicionaTransporte.Text = "Digite um novo tranposrte...";
      this.tb_adicionaTransporte.Click += new System.EventHandler(this.tb_adicionaTransporte_Click);
      // 
      // btn_adicionarTransporte
      // 
      this.btn_adicionarTransporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_adicionarTransporte.Location = new System.Drawing.Point(139, 219);
      this.btn_adicionarTransporte.Name = "btn_adicionarTransporte";
      this.btn_adicionarTransporte.Size = new System.Drawing.Size(307, 23);
      this.btn_adicionarTransporte.TabIndex = 5;
      this.btn_adicionarTransporte.Text = "Adicionar novo transporte";
      this.btn_adicionarTransporte.UseVisualStyleBackColor = true;
      this.btn_adicionarTransporte.Click += new System.EventHandler(this.btn_adicionarTransporte_Click);
      // 
      // F_CheckedListBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(459, 261);
      this.Controls.Add(this.btn_adicionarTransporte);
      this.Controls.Add(this.tb_adicionaTransporte);
      this.Controls.Add(this.btn_resetLista);
      this.Controls.Add(this.btn_limparLista);
      this.Controls.Add(this.btn_mostrarSelecionados);
      this.Controls.Add(this.clb_veiculos);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_CheckedListBox";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "CheckedListBox";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckedListBox clb_veiculos;
    private System.Windows.Forms.Button btn_mostrarSelecionados;
    private System.Windows.Forms.Button btn_limparLista;
    private System.Windows.Forms.Button btn_resetLista;
    private System.Windows.Forms.TextBox tb_adicionaTransporte;
    private System.Windows.Forms.Button btn_adicionarTransporte;
  }
}