namespace Componentes
{
  partial class F_ListBox
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
      this.lt_carros = new System.Windows.Forms.ListBox();
      this.lb_inserirCarro = new System.Windows.Forms.Label();
      this.tb_inserirCarro = new System.Windows.Forms.TextBox();
      this.btn_adicionarCarro = new System.Windows.Forms.Button();
      this.btn_remover = new System.Windows.Forms.Button();
      this.btn_obter = new System.Windows.Forms.Button();
      this.btn_limpar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lt_carros
      // 
      this.lt_carros.FormattingEnabled = true;
      this.lt_carros.Location = new System.Drawing.Point(13, 13);
      this.lt_carros.Name = "lt_carros";
      this.lt_carros.Size = new System.Drawing.Size(120, 160);
      this.lt_carros.TabIndex = 0;
      // 
      // lb_inserirCarro
      // 
      this.lb_inserirCarro.AutoSize = true;
      this.lb_inserirCarro.Location = new System.Drawing.Point(140, 13);
      this.lb_inserirCarro.Name = "lb_inserirCarro";
      this.lb_inserirCarro.Size = new System.Drawing.Size(62, 13);
      this.lb_inserirCarro.TabIndex = 1;
      this.lb_inserirCarro.Text = "Inserir carro";
      // 
      // tb_inserirCarro
      // 
      this.tb_inserirCarro.Location = new System.Drawing.Point(140, 30);
      this.tb_inserirCarro.Name = "tb_inserirCarro";
      this.tb_inserirCarro.Size = new System.Drawing.Size(282, 20);
      this.tb_inserirCarro.TabIndex = 2;
      // 
      // btn_adicionarCarro
      // 
      this.btn_adicionarCarro.Location = new System.Drawing.Point(140, 57);
      this.btn_adicionarCarro.Name = "btn_adicionarCarro";
      this.btn_adicionarCarro.Size = new System.Drawing.Size(282, 23);
      this.btn_adicionarCarro.TabIndex = 3;
      this.btn_adicionarCarro.Text = "Adicionar";
      this.btn_adicionarCarro.UseVisualStyleBackColor = true;
      this.btn_adicionarCarro.Click += new System.EventHandler(this.btn_adicionarCarro_Click);
      // 
      // btn_remover
      // 
      this.btn_remover.Location = new System.Drawing.Point(140, 87);
      this.btn_remover.Name = "btn_remover";
      this.btn_remover.Size = new System.Drawing.Size(282, 23);
      this.btn_remover.TabIndex = 4;
      this.btn_remover.Text = "Remover";
      this.btn_remover.UseVisualStyleBackColor = true;
      this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
      // 
      // btn_obter
      // 
      this.btn_obter.Location = new System.Drawing.Point(140, 117);
      this.btn_obter.Name = "btn_obter";
      this.btn_obter.Size = new System.Drawing.Size(282, 23);
      this.btn_obter.TabIndex = 5;
      this.btn_obter.Text = "Obter";
      this.btn_obter.UseVisualStyleBackColor = true;
      this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
      // 
      // btn_limpar
      // 
      this.btn_limpar.Location = new System.Drawing.Point(140, 147);
      this.btn_limpar.Name = "btn_limpar";
      this.btn_limpar.Size = new System.Drawing.Size(282, 23);
      this.btn_limpar.TabIndex = 6;
      this.btn_limpar.Text = "Limpar";
      this.btn_limpar.UseVisualStyleBackColor = true;
      this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
      // 
      // F_ListBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.btn_limpar);
      this.Controls.Add(this.btn_obter);
      this.Controls.Add(this.btn_remover);
      this.Controls.Add(this.btn_adicionarCarro);
      this.Controls.Add(this.tb_inserirCarro);
      this.Controls.Add(this.lb_inserirCarro);
      this.Controls.Add(this.lt_carros);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_ListBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "List Box";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lt_carros;
    private System.Windows.Forms.Label lb_inserirCarro;
    private System.Windows.Forms.TextBox tb_inserirCarro;
    private System.Windows.Forms.Button btn_adicionarCarro;
    private System.Windows.Forms.Button btn_remover;
    private System.Windows.Forms.Button btn_obter;
    private System.Windows.Forms.Button btn_limpar;
  }
}