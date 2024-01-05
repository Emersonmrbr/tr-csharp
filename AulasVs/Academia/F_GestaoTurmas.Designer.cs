namespace Academia
{
  partial class F_GestaoTurmas
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgv_Turmas = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_Fechar = new System.Windows.Forms.Button();
      this.btn_Imprimir = new System.Windows.Forms.Button();
      this.btn_Excluir = new System.Windows.Forms.Button();
      this.btn_Salvar = new System.Windows.Forms.Button();
      this.btn_Novo = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.cbb_Professor = new System.Windows.Forms.ComboBox();
      this.nud_MaximoAluno = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.cbb_Status = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cbb_Horario = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.ttb_Nome = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.ttb_Vagas = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nud_MaximoAluno)).BeginInit();
      this.SuspendLayout();
      // 
      // dgv_Turmas
      // 
      this.dgv_Turmas.AllowUserToAddRows = false;
      this.dgv_Turmas.AllowUserToDeleteRows = false;
      dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      this.dgv_Turmas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
      this.dgv_Turmas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
      this.dgv_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv_Turmas.DefaultCellStyle = dataGridViewCellStyle6;
      this.dgv_Turmas.Location = new System.Drawing.Point(12, 12);
      this.dgv_Turmas.MultiSelect = false;
      this.dgv_Turmas.Name = "dgv_Turmas";
      this.dgv_Turmas.RowHeadersVisible = false;
      this.dgv_Turmas.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
      this.dgv_Turmas.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      this.dgv_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Turmas.Size = new System.Drawing.Size(402, 531);
      this.dgv_Turmas.TabIndex = 7;
      this.dgv_Turmas.SelectionChanged += new System.EventHandler(this.dgv_Turmas_SelectionChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_Fechar);
      this.panel1.Controls.Add(this.btn_Imprimir);
      this.panel1.Controls.Add(this.btn_Excluir);
      this.panel1.Controls.Add(this.btn_Salvar);
      this.panel1.Controls.Add(this.btn_Novo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 549);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(679, 30);
      this.panel1.TabIndex = 8;
      // 
      // btn_Fechar
      // 
      this.btn_Fechar.Location = new System.Drawing.Point(551, 3);
      this.btn_Fechar.Name = "btn_Fechar";
      this.btn_Fechar.Size = new System.Drawing.Size(120, 23);
      this.btn_Fechar.TabIndex = 4;
      this.btn_Fechar.Text = "Fechar";
      this.btn_Fechar.UseVisualStyleBackColor = true;
      this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
      // 
      // btn_Imprimir
      // 
      this.btn_Imprimir.Location = new System.Drawing.Point(414, 3);
      this.btn_Imprimir.Name = "btn_Imprimir";
      this.btn_Imprimir.Size = new System.Drawing.Size(120, 23);
      this.btn_Imprimir.TabIndex = 3;
      this.btn_Imprimir.Text = "Imprimir";
      this.btn_Imprimir.UseVisualStyleBackColor = true;
      // 
      // btn_Excluir
      // 
      this.btn_Excluir.Location = new System.Drawing.Point(280, 3);
      this.btn_Excluir.Name = "btn_Excluir";
      this.btn_Excluir.Size = new System.Drawing.Size(120, 23);
      this.btn_Excluir.TabIndex = 2;
      this.btn_Excluir.Text = "Excluir";
      this.btn_Excluir.UseVisualStyleBackColor = true;
      this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
      // 
      // btn_Salvar
      // 
      this.btn_Salvar.Location = new System.Drawing.Point(146, 3);
      this.btn_Salvar.Name = "btn_Salvar";
      this.btn_Salvar.Size = new System.Drawing.Size(120, 23);
      this.btn_Salvar.TabIndex = 1;
      this.btn_Salvar.Text = "Salvar";
      this.btn_Salvar.UseVisualStyleBackColor = true;
      this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
      // 
      // btn_Novo
      // 
      this.btn_Novo.Location = new System.Drawing.Point(12, 3);
      this.btn_Novo.Name = "btn_Novo";
      this.btn_Novo.Size = new System.Drawing.Size(120, 23);
      this.btn_Novo.TabIndex = 0;
      this.btn_Novo.Text = "Novo";
      this.btn_Novo.UseVisualStyleBackColor = true;
      this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(421, 84);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(51, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Professor";
      // 
      // cbb_Professor
      // 
      this.cbb_Professor.FormattingEnabled = true;
      this.cbb_Professor.Location = new System.Drawing.Point(421, 101);
      this.cbb_Professor.Name = "cbb_Professor";
      this.cbb_Professor.Size = new System.Drawing.Size(250, 21);
      this.cbb_Professor.TabIndex = 2;
      // 
      // nud_MaximoAluno
      // 
      this.nud_MaximoAluno.Location = new System.Drawing.Point(421, 173);
      this.nud_MaximoAluno.Name = "nud_MaximoAluno";
      this.nud_MaximoAluno.Size = new System.Drawing.Size(123, 20);
      this.nud_MaximoAluno.TabIndex = 3;
      this.nud_MaximoAluno.ValueChanged += new System.EventHandler(this.nud_MaximoAluno_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(421, 154);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(77, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Máximo alunos";
      // 
      // cbb_Status
      // 
      this.cbb_Status.FormattingEnabled = true;
      this.cbb_Status.Location = new System.Drawing.Point(548, 173);
      this.cbb_Status.Name = "cbb_Status";
      this.cbb_Status.Size = new System.Drawing.Size(123, 21);
      this.cbb_Status.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(548, 154);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(37, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Status";
      // 
      // cbb_Horario
      // 
      this.cbb_Horario.FormattingEnabled = true;
      this.cbb_Horario.Location = new System.Drawing.Point(421, 243);
      this.cbb_Horario.Name = "cbb_Horario";
      this.cbb_Horario.Size = new System.Drawing.Size(250, 21);
      this.cbb_Horario.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(421, 224);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 13);
      this.label4.TabIndex = 16;
      this.label4.Text = "Horário";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(421, 12);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(79, 13);
      this.label5.TabIndex = 17;
      this.label5.Text = "Nome da turma";
      // 
      // ttb_Nome
      // 
      this.ttb_Nome.Location = new System.Drawing.Point(421, 29);
      this.ttb_Nome.Name = "ttb_Nome";
      this.ttb_Nome.Size = new System.Drawing.Size(246, 20);
      this.ttb_Nome.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(421, 286);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(37, 13);
      this.label6.TabIndex = 18;
      this.label6.Text = "Vagas";
      // 
      // ttb_Vagas
      // 
      this.ttb_Vagas.Cursor = System.Windows.Forms.Cursors.No;
      this.ttb_Vagas.Location = new System.Drawing.Point(421, 303);
      this.ttb_Vagas.Name = "ttb_Vagas";
      this.ttb_Vagas.ReadOnly = true;
      this.ttb_Vagas.Size = new System.Drawing.Size(120, 20);
      this.ttb_Vagas.TabIndex = 19;
      this.ttb_Vagas.TabStop = false;
      // 
      // F_GestaoTurmas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(679, 579);
      this.Controls.Add(this.ttb_Vagas);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.ttb_Nome);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.cbb_Horario);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cbb_Status);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.nud_MaximoAluno);
      this.Controls.Add(this.cbb_Professor);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dgv_Turmas);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "F_GestaoTurmas";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Gestao de Turmas";
      this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).EndInit();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.nud_MaximoAluno)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv_Turmas;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_Fechar;
    private System.Windows.Forms.Button btn_Imprimir;
    private System.Windows.Forms.Button btn_Excluir;
    private System.Windows.Forms.Button btn_Salvar;
    private System.Windows.Forms.Button btn_Novo;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbb_Professor;
    private System.Windows.Forms.NumericUpDown nud_MaximoAluno;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cbb_Status;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbb_Horario;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox ttb_Nome;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox ttb_Vagas;
  }
}