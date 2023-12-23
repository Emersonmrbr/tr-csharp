namespace EditorTexto
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Principal));
      this.rht_editor = new System.Windows.Forms.RichTextBox();
      this.mus_menu = new System.Windows.Forms.MenuStrip();
      this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.abiriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.centralizadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.justificadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tls_ferramentas = new System.Windows.Forms.ToolStrip();
      this.tsb_novo = new System.Windows.Forms.ToolStripButton();
      this.tsb_abrir = new System.Windows.Forms.ToolStripButton();
      this.tsb_salvar = new System.Windows.Forms.ToolStripButton();
      this.tss_seprador1 = new System.Windows.Forms.ToolStripSeparator();
      this.tsb_copiar = new System.Windows.Forms.ToolStripButton();
      this.tsb_colar = new System.Windows.Forms.ToolStripButton();
      this.tss_separador2 = new System.Windows.Forms.ToolStripSeparator();
      this.tsb_negrito = new System.Windows.Forms.ToolStripButton();
      this.tsb_italico = new System.Windows.Forms.ToolStripButton();
      this.tsb_sublinhado = new System.Windows.Forms.ToolStripButton();
      this.tsb_fonte = new System.Windows.Forms.ToolStripButton();
      this.tss_separador3 = new System.Windows.Forms.ToolStripSeparator();
      this.tsb_esquerda = new System.Windows.Forms.ToolStripButton();
      this.tsb_centro = new System.Windows.Forms.ToolStripButton();
      this.tsb_direita = new System.Windows.Forms.ToolStripButton();
      this.tsb_justificado = new System.Windows.Forms.ToolStripButton();
      this.fbd_procurar = new System.Windows.Forms.FolderBrowserDialog();
      this.ofd_abrir = new System.Windows.Forms.OpenFileDialog();
      this.sfd_salvar = new System.Windows.Forms.SaveFileDialog();
      this.ptd_imprimir = new System.Windows.Forms.PrintDialog();
      this.ptd_imprimirDocumento = new System.Drawing.Printing.PrintDocument();
      this.mus_menu.SuspendLayout();
      this.tls_ferramentas.SuspendLayout();
      this.SuspendLayout();
      // 
      // rht_editor
      // 
      this.rht_editor.Location = new System.Drawing.Point(0, 52);
      this.rht_editor.Name = "rht_editor";
      this.rht_editor.Size = new System.Drawing.Size(800, 386);
      this.rht_editor.TabIndex = 0;
      this.rht_editor.Text = "";
      // 
      // mus_menu
      // 
      this.mus_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
      this.mus_menu.Location = new System.Drawing.Point(0, 0);
      this.mus_menu.Name = "mus_menu";
      this.mus_menu.Size = new System.Drawing.Size(800, 24);
      this.mus_menu.TabIndex = 1;
      this.mus_menu.Text = "menuStrip1";
      // 
      // arquivoToolStripMenuItem
      // 
      this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abiriToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
      this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
      this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.arquivoToolStripMenuItem.Text = "Arquivo";
      // 
      // novoToolStripMenuItem
      // 
      this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
      this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.novoToolStripMenuItem.Text = "Novo";
      this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
      // 
      // abiriToolStripMenuItem
      // 
      this.abiriToolStripMenuItem.Name = "abiriToolStripMenuItem";
      this.abiriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.abiriToolStripMenuItem.Text = "Abrir";
      this.abiriToolStripMenuItem.Click += new System.EventHandler(this.abiriToolStripMenuItem_Click);
      // 
      // salvarToolStripMenuItem
      // 
      this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
      this.salvarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.salvarToolStripMenuItem.Text = "Salvar";
      this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
      // 
      // imprimirToolStripMenuItem
      // 
      this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
      this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.imprimirToolStripMenuItem.Text = "Imprimir";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // sairToolStripMenuItem
      // 
      this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
      this.sairToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.sairToolStripMenuItem.Text = "Sair";
      // 
      // editarToolStripMenuItem
      // 
      this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem,
            this.desfazerToolStripMenuItem,
            this.refazerToolStripMenuItem});
      this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
      this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
      this.editarToolStripMenuItem.Text = "Editar";
      // 
      // copiarToolStripMenuItem
      // 
      this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
      this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.copiarToolStripMenuItem.Text = "Copiar";
      // 
      // colarToolStripMenuItem
      // 
      this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
      this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.colarToolStripMenuItem.Text = "Colar";
      // 
      // desfazerToolStripMenuItem
      // 
      this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
      this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.desfazerToolStripMenuItem.Text = "Desfazer";
      // 
      // refazerToolStripMenuItem
      // 
      this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
      this.refazerToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
      this.refazerToolStripMenuItem.Text = "Refazer";
      // 
      // formatarToolStripMenuItem
      // 
      this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
      this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
      this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
      this.formatarToolStripMenuItem.Text = "Formatar";
      // 
      // negritoToolStripMenuItem
      // 
      this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
      this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.negritoToolStripMenuItem.Text = "Negrito";
      // 
      // itálicoToolStripMenuItem
      // 
      this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
      this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.itálicoToolStripMenuItem.Text = "Itálico";
      // 
      // sublinhadoToolStripMenuItem
      // 
      this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
      this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
      // 
      // alinhamentoToolStripMenuItem
      // 
      this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizadoToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem,
            this.justificadoToolStripMenuItem});
      this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
      this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
      // 
      // centralizadoToolStripMenuItem
      // 
      this.centralizadoToolStripMenuItem.Name = "centralizadoToolStripMenuItem";
      this.centralizadoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.centralizadoToolStripMenuItem.Text = "Centralizado";
      // 
      // esquerdaToolStripMenuItem
      // 
      this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
      this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.esquerdaToolStripMenuItem.Text = "Esquerda";
      // 
      // direitaToolStripMenuItem
      // 
      this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
      this.direitaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.direitaToolStripMenuItem.Text = "Direita";
      // 
      // justificadoToolStripMenuItem
      // 
      this.justificadoToolStripMenuItem.Name = "justificadoToolStripMenuItem";
      this.justificadoToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
      this.justificadoToolStripMenuItem.Text = "Justificado";
      // 
      // tls_ferramentas
      // 
      this.tls_ferramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_novo,
            this.tsb_abrir,
            this.tsb_salvar,
            this.tss_seprador1,
            this.tsb_copiar,
            this.tsb_colar,
            this.tss_separador2,
            this.tsb_negrito,
            this.tsb_italico,
            this.tsb_sublinhado,
            this.tsb_fonte,
            this.tss_separador3,
            this.tsb_esquerda,
            this.tsb_centro,
            this.tsb_direita,
            this.tsb_justificado});
      this.tls_ferramentas.Location = new System.Drawing.Point(0, 24);
      this.tls_ferramentas.Name = "tls_ferramentas";
      this.tls_ferramentas.Size = new System.Drawing.Size(800, 25);
      this.tls_ferramentas.TabIndex = 2;
      this.tls_ferramentas.Text = "Ferramentas";
      // 
      // tsb_novo
      // 
      this.tsb_novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_novo.Image = global::EditorTexto.Properties.Resources.editing;
      this.tsb_novo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_novo.Name = "tsb_novo";
      this.tsb_novo.Size = new System.Drawing.Size(23, 22);
      this.tsb_novo.Text = "Novo";
      this.tsb_novo.Click += new System.EventHandler(this.tsb_novo_Click);
      // 
      // tsb_abrir
      // 
      this.tsb_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_abrir.Image = global::EditorTexto.Properties.Resources.folder;
      this.tsb_abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_abrir.Name = "tsb_abrir";
      this.tsb_abrir.Size = new System.Drawing.Size(23, 22);
      this.tsb_abrir.Text = "Abrir";
      this.tsb_abrir.Click += new System.EventHandler(this.tsb_abrir_Click);
      // 
      // tsb_salvar
      // 
      this.tsb_salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_salvar.Image = global::EditorTexto.Properties.Resources.floppy;
      this.tsb_salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_salvar.Name = "tsb_salvar";
      this.tsb_salvar.Size = new System.Drawing.Size(23, 22);
      this.tsb_salvar.Text = "Salvar";
      this.tsb_salvar.Click += new System.EventHandler(this.tsb_salvar_Click);
      // 
      // tss_seprador1
      // 
      this.tss_seprador1.Name = "tss_seprador1";
      this.tss_seprador1.Size = new System.Drawing.Size(6, 25);
      // 
      // tsb_copiar
      // 
      this.tsb_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_copiar.Image = global::EditorTexto.Properties.Resources.copy;
      this.tsb_copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_copiar.Name = "tsb_copiar";
      this.tsb_copiar.Size = new System.Drawing.Size(23, 22);
      this.tsb_copiar.Text = "Copiar";
      // 
      // tsb_colar
      // 
      this.tsb_colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_colar.Image = global::EditorTexto.Properties.Resources.paste;
      this.tsb_colar.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_colar.Name = "tsb_colar";
      this.tsb_colar.Size = new System.Drawing.Size(23, 22);
      this.tsb_colar.Text = "Colar";
      // 
      // tss_separador2
      // 
      this.tss_separador2.Name = "tss_separador2";
      this.tss_separador2.Size = new System.Drawing.Size(6, 25);
      // 
      // tsb_negrito
      // 
      this.tsb_negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_negrito.Image = global::EditorTexto.Properties.Resources.bold;
      this.tsb_negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_negrito.Name = "tsb_negrito";
      this.tsb_negrito.Size = new System.Drawing.Size(23, 22);
      this.tsb_negrito.Text = "Negrito";
      // 
      // tsb_italico
      // 
      this.tsb_italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_italico.Image = global::EditorTexto.Properties.Resources.italic;
      this.tsb_italico.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_italico.Name = "tsb_italico";
      this.tsb_italico.Size = new System.Drawing.Size(23, 22);
      this.tsb_italico.Text = "Itálico";
      // 
      // tsb_sublinhado
      // 
      this.tsb_sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_sublinhado.Image = global::EditorTexto.Properties.Resources.strikethrough;
      this.tsb_sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_sublinhado.Name = "tsb_sublinhado";
      this.tsb_sublinhado.Size = new System.Drawing.Size(23, 22);
      this.tsb_sublinhado.Text = "Sublinhado";
      // 
      // tsb_fonte
      // 
      this.tsb_fonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_fonte.Image = global::EditorTexto.Properties.Resources.size;
      this.tsb_fonte.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_fonte.Name = "tsb_fonte";
      this.tsb_fonte.Size = new System.Drawing.Size(23, 22);
      this.tsb_fonte.Text = "Fonte";
      // 
      // tss_separador3
      // 
      this.tss_separador3.Name = "tss_separador3";
      this.tss_separador3.Size = new System.Drawing.Size(6, 25);
      // 
      // tsb_esquerda
      // 
      this.tsb_esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_esquerda.Image = global::EditorTexto.Properties.Resources.align_left;
      this.tsb_esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_esquerda.Name = "tsb_esquerda";
      this.tsb_esquerda.Size = new System.Drawing.Size(23, 22);
      this.tsb_esquerda.Text = "Esquerda";
      // 
      // tsb_centro
      // 
      this.tsb_centro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_centro.Image = global::EditorTexto.Properties.Resources.align_center;
      this.tsb_centro.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_centro.Name = "tsb_centro";
      this.tsb_centro.Size = new System.Drawing.Size(23, 22);
      this.tsb_centro.Text = "Centro";
      // 
      // tsb_direita
      // 
      this.tsb_direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_direita.Image = global::EditorTexto.Properties.Resources.align_right;
      this.tsb_direita.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_direita.Name = "tsb_direita";
      this.tsb_direita.Size = new System.Drawing.Size(23, 22);
      this.tsb_direita.Text = "Direita";
      // 
      // tsb_justificado
      // 
      this.tsb_justificado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tsb_justificado.Image = global::EditorTexto.Properties.Resources.justify;
      this.tsb_justificado.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsb_justificado.Name = "tsb_justificado";
      this.tsb_justificado.Size = new System.Drawing.Size(23, 22);
      this.tsb_justificado.Text = "Justificado";
      // 
      // sfd_salvar
      // 
      this.sfd_salvar.DefaultExt = "map";
      this.sfd_salvar.Filter = "(*.map)|*.map";
      this.sfd_salvar.InitialDirectory = "@\"C:\\Users\\emers\\Documents\\VirtualMachines\"";
      // 
      // ptd_imprimir
      // 
      this.ptd_imprimir.UseEXDialog = true;
      // 
      // F_Principal
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tls_ferramentas);
      this.Controls.Add(this.rht_editor);
      this.Controls.Add(this.mus_menu);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mus_menu;
      this.MaximizeBox = false;
      this.Name = "F_Principal";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Editor de texto - Núcleo MAP";
      this.mus_menu.ResumeLayout(false);
      this.mus_menu.PerformLayout();
      this.tls_ferramentas.ResumeLayout(false);
      this.tls_ferramentas.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rht_editor;
    private System.Windows.Forms.MenuStrip mus_menu;
    private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem abiriToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem centralizadoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem justificadoToolStripMenuItem;
    private System.Windows.Forms.ToolStrip tls_ferramentas;
    private System.Windows.Forms.ToolStripButton tsb_novo;
    private System.Windows.Forms.ToolStripButton tsb_abrir;
    private System.Windows.Forms.ToolStripButton tsb_salvar;
    private System.Windows.Forms.ToolStripSeparator tss_seprador1;
    private System.Windows.Forms.ToolStripButton tsb_copiar;
    private System.Windows.Forms.ToolStripButton tsb_colar;
    private System.Windows.Forms.ToolStripSeparator tss_separador2;
    private System.Windows.Forms.ToolStripButton tsb_negrito;
    private System.Windows.Forms.ToolStripButton tsb_italico;
    private System.Windows.Forms.ToolStripButton tsb_sublinhado;
    private System.Windows.Forms.ToolStripButton tsb_fonte;
    private System.Windows.Forms.ToolStripSeparator tss_separador3;
    private System.Windows.Forms.ToolStripButton tsb_esquerda;
    private System.Windows.Forms.ToolStripButton tsb_centro;
    private System.Windows.Forms.ToolStripButton tsb_direita;
    private System.Windows.Forms.ToolStripButton tsb_justificado;
    private System.Windows.Forms.FolderBrowserDialog fbd_procurar;
    private System.Windows.Forms.OpenFileDialog ofd_abrir;
    private System.Windows.Forms.SaveFileDialog sfd_salvar;
    private System.Windows.Forms.PrintDialog ptd_imprimir;
    private System.Drawing.Printing.PrintDocument ptd_imprimirDocumento;
  }
}

