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
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
      this.listView1 = new System.Windows.Forms.ListView();
      this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.col_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.SuspendLayout();
      // 
      // listView1
      // 
      this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produto,
            this.col_quantidade,
            this.col_preco});
      this.listView1.FullRowSelect = true;
      this.listView1.HideSelection = false;
      this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
      this.listView1.Location = new System.Drawing.Point(13, 13);
      this.listView1.MultiSelect = false;
      this.listView1.Name = "listView1";
      this.listView1.Size = new System.Drawing.Size(409, 97);
      this.listView1.TabIndex = 0;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.Details;
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
      // F_ListView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.listView1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_ListView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "F_ListView";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader col_id;
    private System.Windows.Forms.ColumnHeader col_produto;
    private System.Windows.Forms.ColumnHeader col_quantidade;
    private System.Windows.Forms.ColumnHeader col_preco;
  }
}