namespace Componentes
{
  partial class F_WebBrowser
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
      this.Wbb_browser = new System.Windows.Forms.WebBrowser();
      this.ttb_barraPesquisa = new System.Windows.Forms.TextBox();
      this.Btnt_ir = new System.Windows.Forms.Button();
      this.Btnt_home = new System.Windows.Forms.Button();
      this.Btn_voltar = new System.Windows.Forms.Button();
      this.Btn_avancar = new System.Windows.Forms.Button();
      this.Btn_parar = new System.Windows.Forms.Button();
      this.Btn_atualizar = new System.Windows.Forms.Button();
      this.Btn_pesquisar = new System.Windows.Forms.Button();
      this.Btn_definirHome = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Wbb_browser
      // 
      this.Wbb_browser.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.Wbb_browser.Location = new System.Drawing.Point(0, 42);
      this.Wbb_browser.MinimumSize = new System.Drawing.Size(20, 20);
      this.Wbb_browser.Name = "Wbb_browser";
      this.Wbb_browser.Size = new System.Drawing.Size(892, 408);
      this.Wbb_browser.TabIndex = 0;
      // 
      // ttb_barraPesquisa
      // 
      this.ttb_barraPesquisa.Location = new System.Drawing.Point(13, 14);
      this.ttb_barraPesquisa.Name = "ttb_barraPesquisa";
      this.ttb_barraPesquisa.Size = new System.Drawing.Size(223, 20);
      this.ttb_barraPesquisa.TabIndex = 1;
      this.ttb_barraPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ttb_barraPesquisa_KeyDown);
      // 
      // Btnt_ir
      // 
      this.Btnt_ir.Location = new System.Drawing.Point(243, 13);
      this.Btnt_ir.Name = "Btnt_ir";
      this.Btnt_ir.Size = new System.Drawing.Size(75, 23);
      this.Btnt_ir.TabIndex = 2;
      this.Btnt_ir.Text = "Ir";
      this.Btnt_ir.UseVisualStyleBackColor = true;
      this.Btnt_ir.Click += new System.EventHandler(this.Btnt_ir_Click);
      // 
      // Btnt_home
      // 
      this.Btnt_home.Location = new System.Drawing.Point(324, 13);
      this.Btnt_home.Name = "Btnt_home";
      this.Btnt_home.Size = new System.Drawing.Size(75, 23);
      this.Btnt_home.TabIndex = 3;
      this.Btnt_home.Text = "Home";
      this.Btnt_home.UseVisualStyleBackColor = true;
      this.Btnt_home.Click += new System.EventHandler(this.Btnt_home_Click);
      // 
      // Btn_voltar
      // 
      this.Btn_voltar.Location = new System.Drawing.Point(405, 13);
      this.Btn_voltar.Name = "Btn_voltar";
      this.Btn_voltar.Size = new System.Drawing.Size(75, 23);
      this.Btn_voltar.TabIndex = 4;
      this.Btn_voltar.Text = "Voltar";
      this.Btn_voltar.UseVisualStyleBackColor = true;
      this.Btn_voltar.Click += new System.EventHandler(this.Btnt_voltar_Click);
      // 
      // Btn_avancar
      // 
      this.Btn_avancar.Location = new System.Drawing.Point(486, 13);
      this.Btn_avancar.Name = "Btn_avancar";
      this.Btn_avancar.Size = new System.Drawing.Size(75, 23);
      this.Btn_avancar.TabIndex = 5;
      this.Btn_avancar.Text = "Avançar";
      this.Btn_avancar.UseVisualStyleBackColor = true;
      this.Btn_avancar.Click += new System.EventHandler(this.Btn_avancar_Click);
      // 
      // Btn_parar
      // 
      this.Btn_parar.Location = new System.Drawing.Point(567, 13);
      this.Btn_parar.Name = "Btn_parar";
      this.Btn_parar.Size = new System.Drawing.Size(75, 23);
      this.Btn_parar.TabIndex = 6;
      this.Btn_parar.Text = "Parar";
      this.Btn_parar.UseVisualStyleBackColor = true;
      this.Btn_parar.Click += new System.EventHandler(this.Btn_parar_Click);
      // 
      // Btn_atualizar
      // 
      this.Btn_atualizar.Location = new System.Drawing.Point(648, 13);
      this.Btn_atualizar.Name = "Btn_atualizar";
      this.Btn_atualizar.Size = new System.Drawing.Size(75, 23);
      this.Btn_atualizar.TabIndex = 7;
      this.Btn_atualizar.Text = "Atualizar";
      this.Btn_atualizar.UseVisualStyleBackColor = true;
      this.Btn_atualizar.Click += new System.EventHandler(this.Btn_atualizar_Click);
      // 
      // Btn_pesquisar
      // 
      this.Btn_pesquisar.Location = new System.Drawing.Point(729, 13);
      this.Btn_pesquisar.Name = "Btn_pesquisar";
      this.Btn_pesquisar.Size = new System.Drawing.Size(75, 23);
      this.Btn_pesquisar.TabIndex = 8;
      this.Btn_pesquisar.Text = "Pesquisar";
      this.Btn_pesquisar.UseVisualStyleBackColor = true;
      this.Btn_pesquisar.Click += new System.EventHandler(this.Btn_pesquisar_Click);
      // 
      // Btn_definirHome
      // 
      this.Btn_definirHome.Location = new System.Drawing.Point(810, 13);
      this.Btn_definirHome.Name = "Btn_definirHome";
      this.Btn_definirHome.Size = new System.Drawing.Size(75, 23);
      this.Btn_definirHome.TabIndex = 9;
      this.Btn_definirHome.Text = "Definir home";
      this.Btn_definirHome.UseVisualStyleBackColor = true;
      this.Btn_definirHome.Click += new System.EventHandler(this.Btn_definirHome_Click);
      // 
      // F_WebBrowser
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(892, 450);
      this.Controls.Add(this.Btn_definirHome);
      this.Controls.Add(this.Btn_pesquisar);
      this.Controls.Add(this.Btn_atualizar);
      this.Controls.Add(this.Btn_parar);
      this.Controls.Add(this.Btn_avancar);
      this.Controls.Add(this.Btn_voltar);
      this.Controls.Add(this.Btnt_home);
      this.Controls.Add(this.Btnt_ir);
      this.Controls.Add(this.ttb_barraPesquisa);
      this.Controls.Add(this.Wbb_browser);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "F_WebBrowser";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Web Browser";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.WebBrowser Wbb_browser;
    private System.Windows.Forms.TextBox ttb_barraPesquisa;
    private System.Windows.Forms.Button Btnt_ir;
    private System.Windows.Forms.Button Btnt_home;
    private System.Windows.Forms.Button Btn_voltar;
    private System.Windows.Forms.Button Btn_avancar;
    private System.Windows.Forms.Button Btn_parar;
    private System.Windows.Forms.Button Btn_atualizar;
    private System.Windows.Forms.Button Btn_pesquisar;
    private System.Windows.Forms.Button Btn_definirHome;
  }
}