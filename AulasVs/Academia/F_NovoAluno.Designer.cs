namespace Academia
{
  partial class F_NovoAluno
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
      this.label1 = new System.Windows.Forms.Label();
      this.ttb_Nome = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cob_Status = new System.Windows.Forms.ComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_Fechar = new System.Windows.Forms.Button();
      this.btn_Cancelar = new System.Windows.Forms.Button();
      this.btn_Salvar = new System.Windows.Forms.Button();
      this.btn_Novo = new System.Windows.Forms.Button();
      this.ttb_Turma = new System.Windows.Forms.TextBox();
      this.btn_SelecionarTurma = new System.Windows.Forms.Button();
      this.ttb_Plano = new System.Windows.Forms.TextBox();
      this.btn_SelecionarPlano = new System.Windows.Forms.Button();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.ofd_Foto = new System.Windows.Forms.OpenFileDialog();
      this.peb_Foto = new System.Windows.Forms.PictureBox();
      this.btn_Foto = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.peb_Foto)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome";
      // 
      // ttb_Nome
      // 
      this.ttb_Nome.Enabled = false;
      this.ttb_Nome.Location = new System.Drawing.Point(13, 30);
      this.ttb_Nome.Name = "ttb_Nome";
      this.ttb_Nome.Size = new System.Drawing.Size(292, 20);
      this.ttb_Nome.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(328, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(49, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Telefone";
      // 
      // mtb_Telefone
      // 
      this.mtb_Telefone.Enabled = false;
      this.mtb_Telefone.Location = new System.Drawing.Point(328, 29);
      this.mtb_Telefone.Mask = "(00) 0000-0000";
      this.mtb_Telefone.Name = "mtb_Telefone";
      this.mtb_Telefone.Size = new System.Drawing.Size(100, 20);
      this.mtb_Telefone.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Status";
      // 
      // cob_Status
      // 
      this.cob_Status.Enabled = false;
      this.cob_Status.FormattingEnabled = true;
      this.cob_Status.Location = new System.Drawing.Point(13, 100);
      this.cob_Status.Name = "cob_Status";
      this.cob_Status.Size = new System.Drawing.Size(153, 21);
      this.cob_Status.TabIndex = 5;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_Fechar);
      this.panel1.Controls.Add(this.btn_Cancelar);
      this.panel1.Controls.Add(this.btn_Salvar);
      this.panel1.Controls.Add(this.btn_Novo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 213);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(567, 32);
      this.panel1.TabIndex = 6;
      // 
      // btn_Fechar
      // 
      this.btn_Fechar.Location = new System.Drawing.Point(457, 3);
      this.btn_Fechar.Name = "btn_Fechar";
      this.btn_Fechar.Size = new System.Drawing.Size(90, 23);
      this.btn_Fechar.TabIndex = 3;
      this.btn_Fechar.Text = "Fechar";
      this.btn_Fechar.UseVisualStyleBackColor = true;
      this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
      // 
      // btn_Cancelar
      // 
      this.btn_Cancelar.Enabled = false;
      this.btn_Cancelar.Location = new System.Drawing.Point(309, 3);
      this.btn_Cancelar.Name = "btn_Cancelar";
      this.btn_Cancelar.Size = new System.Drawing.Size(90, 23);
      this.btn_Cancelar.TabIndex = 2;
      this.btn_Cancelar.Text = "Cancelar";
      this.btn_Cancelar.UseVisualStyleBackColor = true;
      this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
      // 
      // btn_Salvar
      // 
      this.btn_Salvar.Enabled = false;
      this.btn_Salvar.Location = new System.Drawing.Point(161, 3);
      this.btn_Salvar.Name = "btn_Salvar";
      this.btn_Salvar.Size = new System.Drawing.Size(90, 23);
      this.btn_Salvar.TabIndex = 1;
      this.btn_Salvar.Text = "Salvar";
      this.btn_Salvar.UseVisualStyleBackColor = true;
      this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
      // 
      // btn_Novo
      // 
      this.btn_Novo.Location = new System.Drawing.Point(13, 3);
      this.btn_Novo.Name = "btn_Novo";
      this.btn_Novo.Size = new System.Drawing.Size(90, 23);
      this.btn_Novo.TabIndex = 0;
      this.btn_Novo.Text = "Novo";
      this.btn_Novo.UseVisualStyleBackColor = true;
      this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
      // 
      // ttb_Turma
      // 
      this.ttb_Turma.Location = new System.Drawing.Point(172, 100);
      this.ttb_Turma.Name = "ttb_Turma";
      this.ttb_Turma.ReadOnly = true;
      this.ttb_Turma.Size = new System.Drawing.Size(220, 20);
      this.ttb_Turma.TabIndex = 7;
      this.ttb_Turma.TabStop = false;
      this.ttb_Turma.Tag = "5";
      // 
      // btn_SelecionarTurma
      // 
      this.btn_SelecionarTurma.Enabled = false;
      this.btn_SelecionarTurma.Location = new System.Drawing.Point(398, 100);
      this.btn_SelecionarTurma.Name = "btn_SelecionarTurma";
      this.btn_SelecionarTurma.Size = new System.Drawing.Size(30, 23);
      this.btn_SelecionarTurma.TabIndex = 8;
      this.btn_SelecionarTurma.Text = "...";
      this.btn_SelecionarTurma.UseVisualStyleBackColor = true;
      this.btn_SelecionarTurma.Click += new System.EventHandler(this.btn_SelecionarTurma_Click);
      // 
      // ttb_Plano
      // 
      this.ttb_Plano.Location = new System.Drawing.Point(13, 171);
      this.ttb_Plano.Name = "ttb_Plano";
      this.ttb_Plano.ReadOnly = true;
      this.ttb_Plano.Size = new System.Drawing.Size(379, 20);
      this.ttb_Plano.TabIndex = 9;
      this.ttb_Plano.TabStop = false;
      // 
      // btn_SelecionarPlano
      // 
      this.btn_SelecionarPlano.Enabled = false;
      this.btn_SelecionarPlano.Location = new System.Drawing.Point(398, 171);
      this.btn_SelecionarPlano.Name = "btn_SelecionarPlano";
      this.btn_SelecionarPlano.Size = new System.Drawing.Size(30, 23);
      this.btn_SelecionarPlano.TabIndex = 10;
      this.btn_SelecionarPlano.Text = "...";
      this.btn_SelecionarPlano.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(172, 84);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Turma";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(13, 155);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(34, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Plano";
      // 
      // ofd_Foto
      // 
      this.ofd_Foto.FileName = "ofd_Foto";
      // 
      // peb_Foto
      // 
      this.peb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.peb_Foto.Location = new System.Drawing.Point(463, 91);
      this.peb_Foto.Name = "peb_Foto";
      this.peb_Foto.Size = new System.Drawing.Size(85, 103);
      this.peb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.peb_Foto.TabIndex = 13;
      this.peb_Foto.TabStop = false;
      // 
      // btn_Foto
      // 
      this.btn_Foto.Enabled = false;
      this.btn_Foto.Location = new System.Drawing.Point(463, 27);
      this.btn_Foto.Name = "btn_Foto";
      this.btn_Foto.Size = new System.Drawing.Size(85, 23);
      this.btn_Foto.TabIndex = 14;
      this.btn_Foto.Text = "Foto";
      this.btn_Foto.UseVisualStyleBackColor = true;
      this.btn_Foto.Click += new System.EventHandler(this.btn_Foto_Click);
      // 
      // F_NovoAluno
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(567, 245);
      this.Controls.Add(this.btn_Foto);
      this.Controls.Add(this.peb_Foto);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.btn_SelecionarPlano);
      this.Controls.Add(this.ttb_Plano);
      this.Controls.Add(this.btn_SelecionarTurma);
      this.Controls.Add(this.ttb_Turma);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cob_Status);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.mtb_Telefone);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ttb_Nome);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "F_NovoAluno";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Novo Aluno";
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.peb_Foto)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ttb_Nome;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.MaskedTextBox mtb_Telefone;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cob_Status;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_SelecionarTurma;
    private System.Windows.Forms.TextBox ttb_Plano;
    private System.Windows.Forms.Button btn_SelecionarPlano;
    private System.Windows.Forms.Button btn_Novo;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button btn_Fechar;
    private System.Windows.Forms.Button btn_Cancelar;
    private System.Windows.Forms.Button btn_Salvar;
    public System.Windows.Forms.TextBox ttb_Turma;
    private System.Windows.Forms.OpenFileDialog ofd_Foto;
    private System.Windows.Forms.PictureBox peb_Foto;
    private System.Windows.Forms.Button btn_Foto;
  }
}