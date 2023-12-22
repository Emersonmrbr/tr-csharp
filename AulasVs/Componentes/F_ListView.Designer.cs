namespace Componentes
{
  partial class F_ListView
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
      System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
      System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
      System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
      this.lsv_produtos = new System.Windows.Forms.ListView();
      this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.col_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.tb_id = new System.Windows.Forms.TextBox();
      this.tb_produto = new System.Windows.Forms.TextBox();
      this.tb_quantidade = new System.Windows.Forms.TextBox();
      this.tb_preco = new System.Windows.Forms.TextBox();
      this.btn_adicionar = new System.Windows.Forms.Button();
      this.btn_remover = new System.Windows.Forms.Button();
      this.btn_obter = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lsv_produtos
      // 
      this.lsv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_quantidade,
            this.col_preco});
      this.lsv_produtos.FullRowSelect = true;
      this.lsv_produtos.HideSelection = false;
      this.lsv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem10,
            listViewItem11,
            listViewItem12});
      this.lsv_produtos.Location = new System.Drawing.Point(13, 13);
      this.lsv_produtos.MultiSelect = false;
      this.lsv_produtos.Name = "lsv_produtos";
      this.lsv_produtos.Size = new System.Drawing.Size(409, 97);
      this.lsv_produtos.TabIndex = 0;
      this.lsv_produtos.UseCompatibleStateImageBehavior = false;
      this.lsv_produtos.View = System.Windows.Forms.View.Details;
      // 
      // col_id
      // 
      this.col_id.Text = "ID";
      this.col_id.Width = 52;
      // 
      // col_produto
      // 
      this.col_produto.Text = "Produto";
      this.col_produto.Width = 184;
      // 
      // col_quantidade
      // 
      this.col_quantidade.Text = "Quantidade";
      this.col_quantidade.Width = 83;
      // 
      // col_preco
      // 
      this.col_preco.Text = "Preço";
      this.col_preco.Width = 85;
      // 
      // tb_id
      // 
      this.tb_id.Location = new System.Drawing.Point(13, 116);
      this.tb_id.Name = "tb_id";
      this.tb_id.Size = new System.Drawing.Size(52, 20);
      this.tb_id.TabIndex = 1;
      // 
      // tb_produto
      // 
      this.tb_produto.Location = new System.Drawing.Point(66, 116);
      this.tb_produto.Name = "tb_produto";
      this.tb_produto.Size = new System.Drawing.Size(184, 20);
      this.tb_produto.TabIndex = 2;
      // 
      // tb_quantidade
      // 
      this.tb_quantidade.Location = new System.Drawing.Point(251, 116);
      this.tb_quantidade.Name = "tb_quantidade";
      this.tb_quantidade.Size = new System.Drawing.Size(83, 20);
      this.tb_quantidade.TabIndex = 3;
      // 
      // tb_preco
      // 
      this.tb_preco.Location = new System.Drawing.Point(335, 116);
      this.tb_preco.Name = "tb_preco";
      this.tb_preco.Size = new System.Drawing.Size(85, 20);
      this.tb_preco.TabIndex = 4;
      // 
      // btn_adicionar
      // 
      this.btn_adicionar.Location = new System.Drawing.Point(13, 226);
      this.btn_adicionar.Name = "btn_adicionar";
      this.btn_adicionar.Size = new System.Drawing.Size(120, 23);
      this.btn_adicionar.TabIndex = 5;
      this.btn_adicionar.Text = "Adicionar";
      this.btn_adicionar.UseVisualStyleBackColor = true;
      this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
      // 
      // btn_remover
      // 
      this.btn_remover.Location = new System.Drawing.Point(157, 226);
      this.btn_remover.Name = "btn_remover";
      this.btn_remover.Size = new System.Drawing.Size(120, 23);
      this.btn_remover.TabIndex = 6;
      this.btn_remover.Text = "Remover";
      this.btn_remover.UseVisualStyleBackColor = true;
      this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
      // 
      // btn_obter
      // 
      this.btn_obter.Location = new System.Drawing.Point(301, 226);
      this.btn_obter.Name = "btn_obter";
      this.btn_obter.Size = new System.Drawing.Size(120, 23);
      this.btn_obter.TabIndex = 7;
      this.btn_obter.Text = "Obter";
      this.btn_obter.UseVisualStyleBackColor = true;
      this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
      // 
      // F_ListView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.btn_obter);
      this.Controls.Add(this.btn_remover);
      this.Controls.Add(this.btn_adicionar);
      this.Controls.Add(this.tb_preco);
      this.Controls.Add(this.tb_quantidade);
      this.Controls.Add(this.tb_produto);
      this.Controls.Add(this.tb_id);
      this.Controls.Add(this.lsv_produtos);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_ListView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "F_ListView";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView lsv_produtos;
    private System.Windows.Forms.ColumnHeader col_id;
    private System.Windows.Forms.ColumnHeader col_produto;
    private System.Windows.Forms.ColumnHeader col_quantidade;
    private System.Windows.Forms.ColumnHeader col_preco;
    private System.Windows.Forms.TextBox tb_id;
    private System.Windows.Forms.TextBox tb_produto;
    private System.Windows.Forms.TextBox tb_quantidade;
    private System.Windows.Forms.TextBox tb_preco;
    private System.Windows.Forms.Button btn_adicionar;
    private System.Windows.Forms.Button btn_remover;
    private System.Windows.Forms.Button btn_obter;
  }
}