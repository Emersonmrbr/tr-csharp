namespace Componentes
{
  partial class F_ComboBox
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
      this.cb_transportes = new System.Windows.Forms.ComboBox();
      this.btn_mostrarSelecionados = new System.Windows.Forms.Button();
      this.btn_limparElementos = new System.Windows.Forms.Button();
      this.btn_resetarElementos = new System.Windows.Forms.Button();
      this.btnt_adicionarElemento = new System.Windows.Forms.Button();
      this.tb_adicionarElemento = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // cb_transportes
      // 
      this.cb_transportes.FormattingEnabled = true;
      this.cb_transportes.Items.AddRange(new object[] {
            "Avião",
            "Navio",
            "Carro",
            "Moto",
            "Bike"});
      this.cb_transportes.Location = new System.Drawing.Point(12, 12);
      this.cb_transportes.Name = "cb_transportes";
      this.cb_transportes.Size = new System.Drawing.Size(186, 21);
      this.cb_transportes.TabIndex = 0;
      this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
      // 
      // btn_mostrarSelecionados
      // 
      this.btn_mostrarSelecionados.Location = new System.Drawing.Point(236, 12);
      this.btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
      this.btn_mostrarSelecionados.Size = new System.Drawing.Size(186, 23);
      this.btn_mostrarSelecionados.TabIndex = 1;
      this.btn_mostrarSelecionados.Text = "Mostrar selecionados";
      this.btn_mostrarSelecionados.UseVisualStyleBackColor = true;
      this.btn_mostrarSelecionados.Click += new System.EventHandler(this.btn_mostrarSelecionados_Click);
      // 
      // btn_limparElementos
      // 
      this.btn_limparElementos.Location = new System.Drawing.Point(236, 42);
      this.btn_limparElementos.Name = "btn_limparElementos";
      this.btn_limparElementos.Size = new System.Drawing.Size(186, 23);
      this.btn_limparElementos.TabIndex = 2;
      this.btn_limparElementos.Text = "Limpar elementos";
      this.btn_limparElementos.UseVisualStyleBackColor = true;
      this.btn_limparElementos.Click += new System.EventHandler(this.btn_limparElementos_Click);
      // 
      // btn_resetarElementos
      // 
      this.btn_resetarElementos.Location = new System.Drawing.Point(236, 72);
      this.btn_resetarElementos.Name = "btn_resetarElementos";
      this.btn_resetarElementos.Size = new System.Drawing.Size(186, 23);
      this.btn_resetarElementos.TabIndex = 3;
      this.btn_resetarElementos.Text = "Resetar elementos";
      this.btn_resetarElementos.UseVisualStyleBackColor = true;
      this.btn_resetarElementos.Click += new System.EventHandler(this.btn_resetarElementos_Click);
      // 
      // btnt_adicionarElemento
      // 
      this.btnt_adicionarElemento.Location = new System.Drawing.Point(236, 226);
      this.btnt_adicionarElemento.Name = "btnt_adicionarElemento";
      this.btnt_adicionarElemento.Size = new System.Drawing.Size(186, 23);
      this.btnt_adicionarElemento.TabIndex = 4;
      this.btnt_adicionarElemento.Text = "Adicionar elemento";
      this.btnt_adicionarElemento.UseVisualStyleBackColor = true;
      this.btnt_adicionarElemento.Click += new System.EventHandler(this.btnt_adicionarElemento_Click);
      // 
      // tb_adicionarElemento
      // 
      this.tb_adicionarElemento.Location = new System.Drawing.Point(236, 200);
      this.tb_adicionarElemento.Name = "tb_adicionarElemento";
      this.tb_adicionarElemento.Size = new System.Drawing.Size(186, 20);
      this.tb_adicionarElemento.TabIndex = 5;
      // 
      // F_ComboBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.tb_adicionarElemento);
      this.Controls.Add(this.btnt_adicionarElemento);
      this.Controls.Add(this.btn_resetarElementos);
      this.Controls.Add(this.btn_limparElementos);
      this.Controls.Add(this.btn_mostrarSelecionados);
      this.Controls.Add(this.cb_transportes);
      this.Name = "F_ComboBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Combo box";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cb_transportes;
    private System.Windows.Forms.Button btn_mostrarSelecionados;
    private System.Windows.Forms.Button btn_limparElementos;
    private System.Windows.Forms.Button btn_resetarElementos;
    private System.Windows.Forms.Button btnt_adicionarElemento;
    private System.Windows.Forms.TextBox tb_adicionarElemento;
  }
}