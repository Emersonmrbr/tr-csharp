namespace Componentes
{
  partial class F_TreeView
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
      System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("HRV");
      System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Civic");
      System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Honda", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
      System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Imprenzza");
      System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("WRX");
      System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Subaru", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
      this.Tev_Itens = new System.Windows.Forms.TreeView();
      this.Btn_adicoonar = new System.Windows.Forms.Button();
      this.Btn_remover = new System.Windows.Forms.Button();
      this.Btn_removerSelecionado = new System.Windows.Forms.Button();
      this.Ttb_selecionado = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // Tev_Itens
      // 
      this.Tev_Itens.Location = new System.Drawing.Point(13, 13);
      this.Tev_Itens.Name = "Tev_Itens";
      treeNode19.Name = "Hrv";
      treeNode19.Text = "HRV";
      treeNode20.Name = "Civic";
      treeNode20.Text = "Civic";
      treeNode21.Name = "Honda";
      treeNode21.Text = "Honda";
      treeNode22.Name = "Imprenzza";
      treeNode22.Text = "Imprenzza";
      treeNode23.Name = "Wrx";
      treeNode23.Text = "WRX";
      treeNode24.Name = "Subaru";
      treeNode24.Text = "Subaru";
      this.Tev_Itens.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24});
      this.Tev_Itens.Size = new System.Drawing.Size(220, 219);
      this.Tev_Itens.TabIndex = 0;
      this.Tev_Itens.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Tev_Itens_AfterSelect);
      // 
      // Btn_adicoonar
      // 
      this.Btn_adicoonar.Location = new System.Drawing.Point(239, 13);
      this.Btn_adicoonar.Name = "Btn_adicoonar";
      this.Btn_adicoonar.Size = new System.Drawing.Size(183, 23);
      this.Btn_adicoonar.TabIndex = 1;
      this.Btn_adicoonar.Text = "Adicionar";
      this.Btn_adicoonar.UseVisualStyleBackColor = true;
      this.Btn_adicoonar.Click += new System.EventHandler(this.Btn_adicoonar_Click);
      // 
      // Btn_remover
      // 
      this.Btn_remover.Location = new System.Drawing.Point(240, 43);
      this.Btn_remover.Name = "Btn_remover";
      this.Btn_remover.Size = new System.Drawing.Size(182, 23);
      this.Btn_remover.TabIndex = 2;
      this.Btn_remover.Text = "Remover";
      this.Btn_remover.UseVisualStyleBackColor = true;
      this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
      // 
      // Btn_removerSelecionado
      // 
      this.Btn_removerSelecionado.Location = new System.Drawing.Point(239, 73);
      this.Btn_removerSelecionado.Name = "Btn_removerSelecionado";
      this.Btn_removerSelecionado.Size = new System.Drawing.Size(183, 23);
      this.Btn_removerSelecionado.TabIndex = 3;
      this.Btn_removerSelecionado.Text = "Remover selecionado";
      this.Btn_removerSelecionado.UseVisualStyleBackColor = true;
      this.Btn_removerSelecionado.Click += new System.EventHandler(this.Btn_removerSelecionado_Click);
      // 
      // Ttb_selecionado
      // 
      this.Ttb_selecionado.Location = new System.Drawing.Point(239, 103);
      this.Ttb_selecionado.Name = "Ttb_selecionado";
      this.Ttb_selecionado.Size = new System.Drawing.Size(183, 20);
      this.Ttb_selecionado.TabIndex = 4;
      // 
      // F_TreeView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.Ttb_selecionado);
      this.Controls.Add(this.Btn_removerSelecionado);
      this.Controls.Add(this.Btn_remover);
      this.Controls.Add(this.Btn_adicoonar);
      this.Controls.Add(this.Tev_Itens);
      this.MaximizeBox = false;
      this.Name = "F_TreeView";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "F_TreeView";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView Tev_Itens;
    private System.Windows.Forms.Button Btn_adicoonar;
    private System.Windows.Forms.Button Btn_remover;
    private System.Windows.Forms.Button Btn_removerSelecionado;
    private System.Windows.Forms.TextBox Ttb_selecionado;
  }
}