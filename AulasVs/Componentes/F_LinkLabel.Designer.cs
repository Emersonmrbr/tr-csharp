namespace Componentes
{
  partial class F_LinkLabel
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
      this.lb_nome = new System.Windows.Forms.Label();
      this.tb_nome = new System.Windows.Forms.TextBox();
      this.ll_canal = new System.Windows.Forms.LinkLabel();
      this.ll_programa = new System.Windows.Forms.LinkLabel();
      this.ll_multiplosLinks = new System.Windows.Forms.LinkLabel();
      this.tb_busca = new System.Windows.Forms.TextBox();
      this.lb_busca = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lb_nome
      // 
      this.lb_nome.AutoSize = true;
      this.lb_nome.Location = new System.Drawing.Point(13, 13);
      this.lb_nome.Name = "lb_nome";
      this.lb_nome.Size = new System.Drawing.Size(83, 13);
      this.lb_nome.TabIndex = 0;
      this.lb_nome.Text = "Digite seu nome";
      // 
      // tb_nome
      // 
      this.tb_nome.Location = new System.Drawing.Point(13, 36);
      this.tb_nome.Name = "tb_nome";
      this.tb_nome.Size = new System.Drawing.Size(259, 20);
      this.tb_nome.TabIndex = 1;
      // 
      // ll_canal
      // 
      this.ll_canal.AutoSize = true;
      this.ll_canal.Location = new System.Drawing.Point(10, 141);
      this.ll_canal.Name = "ll_canal";
      this.ll_canal.Size = new System.Drawing.Size(34, 13);
      this.ll_canal.TabIndex = 2;
      this.ll_canal.TabStop = true;
      this.ll_canal.Text = "Canal";
      this.ll_canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_canal_LinkClicked);
      // 
      // ll_programa
      // 
      this.ll_programa.AutoSize = true;
      this.ll_programa.Location = new System.Drawing.Point(72, 141);
      this.ll_programa.Name = "ll_programa";
      this.ll_programa.Size = new System.Drawing.Size(57, 13);
      this.ll_programa.TabIndex = 3;
      this.ll_programa.TabStop = true;
      this.ll_programa.Text = "Caluladora";
      this.ll_programa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_programa_LinkClicked);
      // 
      // ll_multiplosLinks
      // 
      this.ll_multiplosLinks.AutoSize = true;
      this.ll_multiplosLinks.Location = new System.Drawing.Point(10, 164);
      this.ll_multiplosLinks.Name = "ll_multiplosLinks";
      this.ll_multiplosLinks.Size = new System.Drawing.Size(126, 13);
      this.ll_multiplosLinks.TabIndex = 4;
      this.ll_multiplosLinks.TabStop = true;
      this.ll_multiplosLinks.Text = "Google - Canal - Youtube";
      this.ll_multiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_multiplosLinks_LinkClicked);
      // 
      // tb_busca
      // 
      this.tb_busca.Location = new System.Drawing.Point(12, 96);
      this.tb_busca.Name = "tb_busca";
      this.tb_busca.Size = new System.Drawing.Size(259, 20);
      this.tb_busca.TabIndex = 6;
      // 
      // lb_busca
      // 
      this.lb_busca.AutoSize = true;
      this.lb_busca.Location = new System.Drawing.Point(12, 73);
      this.lb_busca.Name = "lb_busca";
      this.lb_busca.Size = new System.Drawing.Size(86, 13);
      this.lb_busca.TabIndex = 5;
      this.lb_busca.Text = "Digite sua busca";
      // 
      // F_LinkLabel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
      this.ClientSize = new System.Drawing.Size(284, 411);
      this.Controls.Add(this.tb_busca);
      this.Controls.Add(this.lb_busca);
      this.Controls.Add(this.ll_multiplosLinks);
      this.Controls.Add(this.ll_programa);
      this.Controls.Add(this.ll_canal);
      this.Controls.Add(this.tb_nome);
      this.Controls.Add(this.lb_nome);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_LinkLabel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Link / Label";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lb_nome;
    private System.Windows.Forms.TextBox tb_nome;
    private System.Windows.Forms.LinkLabel ll_canal;
    private System.Windows.Forms.LinkLabel ll_programa;
    private System.Windows.Forms.LinkLabel ll_multiplosLinks;
    private System.Windows.Forms.TextBox tb_busca;
    private System.Windows.Forms.Label lb_busca;
  }
}