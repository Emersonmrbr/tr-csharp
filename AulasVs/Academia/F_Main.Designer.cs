namespace Academia
{
  partial class F_Main
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.lbl_Acesso = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_NomeUsuario = new System.Windows.Forms.Label();
      this.img_Logado = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_Logado)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.panel1.Controls.Add(this.lbl_NomeUsuario);
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.lbl_Acesso);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.img_Logado);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 417);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 33);
      this.panel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(37, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Acesso:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_Acesso
      // 
      this.lbl_Acesso.AutoSize = true;
      this.lbl_Acesso.Location = new System.Drawing.Point(77, 10);
      this.lbl_Acesso.Name = "lbl_Acesso";
      this.lbl_Acesso.Size = new System.Drawing.Size(13, 13);
      this.lbl_Acesso.TabIndex = 2;
      this.lbl_Acesso.Text = "0";
      this.lbl_Acesso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(105, 10);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Usuário:";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbl_NomeUsuario
      // 
      this.lbl_NomeUsuario.AutoSize = true;
      this.lbl_NomeUsuario.Location = new System.Drawing.Point(146, 10);
      this.lbl_NomeUsuario.Name = "lbl_NomeUsuario";
      this.lbl_NomeUsuario.Size = new System.Drawing.Size(16, 13);
      this.lbl_NomeUsuario.TabIndex = 4;
      this.lbl_NomeUsuario.Text = "---";
      this.lbl_NomeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // img_Logado
      // 
      this.img_Logado.Image = global::Academia.Properties.Resources.ledVermelho;
      this.img_Logado.Location = new System.Drawing.Point(0, 1);
      this.img_Logado.Name = "img_Logado";
      this.img_Logado.Size = new System.Drawing.Size(30, 30);
      this.img_Logado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.img_Logado.TabIndex = 0;
      this.img_Logado.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // loginToolStripMenuItem
      // 
      this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem,
            this.logoffToolStripMenuItem});
      this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
      this.loginToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
      this.loginToolStripMenuItem.Text = "LOGIN";
      // 
      // logonToolStripMenuItem
      // 
      this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
      this.logonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.logonToolStripMenuItem.Text = "Logon";
      this.logonToolStripMenuItem.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
      // 
      // logoffToolStripMenuItem
      // 
      this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
      this.logoffToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.logoffToolStripMenuItem.Text = "Logoff";
      this.logoffToolStripMenuItem.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
      // 
      // F_Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "F_Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Academia - v1.0";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.img_Logado)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    public System.Windows.Forms.PictureBox img_Logado;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    public System.Windows.Forms.Label lbl_Acesso;
    public System.Windows.Forms.Label lbl_NomeUsuario;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
  }
}

