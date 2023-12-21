namespace Componentes
{
  partial class F_Principal
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
      this.Btn_Adicionar = new System.Windows.Forms.Button();
      this.Tb_Veiculo = new System.Windows.Forms.TextBox();
      this.Lb_Titulo = new System.Windows.Forms.Label();
      this.Tb_listaVeiculos = new System.Windows.Forms.TextBox();
      this.Btn_Limpar = new System.Windows.Forms.Button();
      this.Btn_Mostrar = new System.Windows.Forms.Button();
      this.Btn_valNum = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Btn_Adicionar
      // 
      this.Btn_Adicionar.Location = new System.Drawing.Point(188, 26);
      this.Btn_Adicionar.Name = "Btn_Adicionar";
      this.Btn_Adicionar.Size = new System.Drawing.Size(75, 23);
      this.Btn_Adicionar.TabIndex = 0;
      this.Btn_Adicionar.Text = "Adicionar";
      this.Btn_Adicionar.UseVisualStyleBackColor = true;
      this.Btn_Adicionar.Click += new System.EventHandler(this.Btn_Adicionar_Click);
      // 
      // Tb_Veiculo
      // 
      this.Tb_Veiculo.Location = new System.Drawing.Point(12, 28);
      this.Tb_Veiculo.Name = "Tb_Veiculo";
      this.Tb_Veiculo.Size = new System.Drawing.Size(170, 20);
      this.Tb_Veiculo.TabIndex = 1;
      // 
      // Lb_Titulo
      // 
      this.Lb_Titulo.AutoSize = true;
      this.Lb_Titulo.Location = new System.Drawing.Point(12, 10);
      this.Lb_Titulo.Name = "Lb_Titulo";
      this.Lb_Titulo.Size = new System.Drawing.Size(90, 13);
      this.Lb_Titulo.TabIndex = 2;
      this.Lb_Titulo.Text = "Digite um veículo";
      // 
      // Tb_listaVeiculos
      // 
      this.Tb_listaVeiculos.Location = new System.Drawing.Point(12, 54);
      this.Tb_listaVeiculos.Multiline = true;
      this.Tb_listaVeiculos.Name = "Tb_listaVeiculos";
      this.Tb_listaVeiculos.ReadOnly = true;
      this.Tb_listaVeiculos.Size = new System.Drawing.Size(251, 231);
      this.Tb_listaVeiculos.TabIndex = 3;
      // 
      // Btn_Limpar
      // 
      this.Btn_Limpar.Location = new System.Drawing.Point(12, 302);
      this.Btn_Limpar.Name = "Btn_Limpar";
      this.Btn_Limpar.Size = new System.Drawing.Size(251, 23);
      this.Btn_Limpar.TabIndex = 4;
      this.Btn_Limpar.Text = "Limpar";
      this.Btn_Limpar.UseVisualStyleBackColor = true;
      this.Btn_Limpar.Click += new System.EventHandler(this.Btn_Limpar_Click);
      // 
      // Btn_Mostrar
      // 
      this.Btn_Mostrar.Location = new System.Drawing.Point(12, 332);
      this.Btn_Mostrar.Name = "Btn_Mostrar";
      this.Btn_Mostrar.Size = new System.Drawing.Size(251, 23);
      this.Btn_Mostrar.TabIndex = 5;
      this.Btn_Mostrar.Text = "Mostrar veiculos";
      this.Btn_Mostrar.UseVisualStyleBackColor = true;
      this.Btn_Mostrar.Click += new System.EventHandler(this.Btn_Mostrar_Click);
      // 
      // Btn_valNum
      // 
      this.Btn_valNum.Location = new System.Drawing.Point(12, 362);
      this.Btn_valNum.Name = "Btn_valNum";
      this.Btn_valNum.Size = new System.Drawing.Size(251, 23);
      this.Btn_valNum.TabIndex = 6;
      this.Btn_valNum.Text = "Valor da variável num";
      this.Btn_valNum.UseVisualStyleBackColor = true;
      this.Btn_valNum.Click += new System.EventHandler(this.Btn_valNum_Click);
      // 
      // F_Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 407);
      this.Controls.Add(this.Btn_valNum);
      this.Controls.Add(this.Btn_Mostrar);
      this.Controls.Add(this.Btn_Limpar);
      this.Controls.Add(this.Tb_listaVeiculos);
      this.Controls.Add(this.Lb_Titulo);
      this.Controls.Add(this.Tb_Veiculo);
      this.Controls.Add(this.Btn_Adicionar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_Principal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Componentes";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button Btn_Adicionar;
    private System.Windows.Forms.TextBox Tb_Veiculo;
    private System.Windows.Forms.Label Lb_Titulo;
    private System.Windows.Forms.Button Btn_Limpar;
    private System.Windows.Forms.Button Btn_Mostrar;
    private System.Windows.Forms.Button Btn_valNum;
    public System.Windows.Forms.TextBox Tb_listaVeiculos;
  }
}

