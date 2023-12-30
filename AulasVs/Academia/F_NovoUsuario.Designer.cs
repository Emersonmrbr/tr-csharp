namespace Academia
{
  partial class F_NovoUsuario
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
      this.ttb_Nome = new System.Windows.Forms.TextBox();
      this.ttb_Apelido = new System.Windows.Forms.TextBox();
      this.ttb_Senha = new System.Windows.Forms.TextBox();
      this.cob_Status = new System.Windows.Forms.ComboBox();
      this.nud_Nivel = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_Novo = new System.Windows.Forms.Button();
      this.btn_Salvar = new System.Windows.Forms.Button();
      this.btn_Cancelar = new System.Windows.Forms.Button();
      this.btn_Fechar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.nud_Nivel)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ttb_Nome
      // 
      this.ttb_Nome.Location = new System.Drawing.Point(12, 22);
      this.ttb_Nome.Name = "ttb_Nome";
      this.ttb_Nome.Size = new System.Drawing.Size(248, 20);
      this.ttb_Nome.TabIndex = 0;
      // 
      // ttb_Apelido
      // 
      this.ttb_Apelido.Location = new System.Drawing.Point(266, 22);
      this.ttb_Apelido.Name = "ttb_Apelido";
      this.ttb_Apelido.Size = new System.Drawing.Size(121, 20);
      this.ttb_Apelido.TabIndex = 1;
      // 
      // ttb_Senha
      // 
      this.ttb_Senha.Location = new System.Drawing.Point(393, 22);
      this.ttb_Senha.Name = "ttb_Senha";
      this.ttb_Senha.PasswordChar = '#';
      this.ttb_Senha.Size = new System.Drawing.Size(121, 20);
      this.ttb_Senha.TabIndex = 2;
      // 
      // cob_Status
      // 
      this.cob_Status.FormattingEnabled = true;
      this.cob_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
      this.cob_Status.Location = new System.Drawing.Point(12, 73);
      this.cob_Status.Name = "cob_Status";
      this.cob_Status.Size = new System.Drawing.Size(121, 21);
      this.cob_Status.TabIndex = 3;
      // 
      // nud_Nivel
      // 
      this.nud_Nivel.Location = new System.Drawing.Point(140, 73);
      this.nud_Nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nud_Nivel.Name = "nud_Nivel";
      this.nud_Nivel.Size = new System.Drawing.Size(120, 20);
      this.nud_Nivel.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 6);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Nome";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(266, 6);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Apelido";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(393, 6);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Senha";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 57);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Status";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(140, 56);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Nível";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(12, 112);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(50, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "A = Ativo";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(85, 112);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(77, 13);
      this.label7.TabIndex = 11;
      this.label7.Text = "B = Bloqueado";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(185, 112);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(74, 13);
      this.label8.TabIndex = 12;
      this.label8.Text = "D = Desligado";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_Fechar);
      this.panel1.Controls.Add(this.btn_Cancelar);
      this.panel1.Controls.Add(this.btn_Salvar);
      this.panel1.Controls.Add(this.btn_Novo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 139);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(524, 32);
      this.panel1.TabIndex = 13;
      // 
      // btn_Novo
      // 
      this.btn_Novo.Location = new System.Drawing.Point(12, 4);
      this.btn_Novo.Name = "btn_Novo";
      this.btn_Novo.Size = new System.Drawing.Size(75, 23);
      this.btn_Novo.TabIndex = 0;
      this.btn_Novo.Text = "Novo";
      this.btn_Novo.UseVisualStyleBackColor = true;
      this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
      // 
      // btn_Salvar
      // 
      this.btn_Salvar.Location = new System.Drawing.Point(98, 4);
      this.btn_Salvar.Name = "btn_Salvar";
      this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
      this.btn_Salvar.TabIndex = 1;
      this.btn_Salvar.Text = "Salvar";
      this.btn_Salvar.UseVisualStyleBackColor = true;
      this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
      // 
      // btn_Cancelar
      // 
      this.btn_Cancelar.Location = new System.Drawing.Point(184, 4);
      this.btn_Cancelar.Name = "btn_Cancelar";
      this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
      this.btn_Cancelar.TabIndex = 2;
      this.btn_Cancelar.Text = "Cancelar";
      this.btn_Cancelar.UseVisualStyleBackColor = true;
      this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
      // 
      // btn_Fechar
      // 
      this.btn_Fechar.Location = new System.Drawing.Point(439, 3);
      this.btn_Fechar.Name = "btn_Fechar";
      this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
      this.btn_Fechar.TabIndex = 3;
      this.btn_Fechar.Text = "Fechar";
      this.btn_Fechar.UseVisualStyleBackColor = true;
      this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
      // 
      // F_NovoUsuario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(524, 171);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nud_Nivel);
      this.Controls.Add(this.cob_Status);
      this.Controls.Add(this.ttb_Senha);
      this.Controls.Add(this.ttb_Apelido);
      this.Controls.Add(this.ttb_Nome);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "F_NovoUsuario";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "F_NovoUsuario";
      ((System.ComponentModel.ISupportInitialize)(this.nud_Nivel)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ttb_Nome;
    private System.Windows.Forms.TextBox ttb_Apelido;
    private System.Windows.Forms.TextBox ttb_Senha;
    private System.Windows.Forms.ComboBox cob_Status;
    private System.Windows.Forms.NumericUpDown nud_Nivel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_Cancelar;
    private System.Windows.Forms.Button btn_Salvar;
    private System.Windows.Forms.Button btn_Novo;
    private System.Windows.Forms.Button btn_Fechar;
  }
}