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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.dgv_Turmas = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_Imprimir = new System.Windows.Forms.Button();
      this.btn_Excluir = new System.Windows.Forms.Button();
      this.btn_Salvar = new System.Windows.Forms.Button();
      this.btn_Novo = new System.Windows.Forms.Button();
      this.btn_Fechar = new System.Windows.Forms.Button();
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
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).BeginInit();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nud_MaximoAluno)).BeginInit();
      this.SuspendLayout();
      // 
      // dgv_Turmas
      // 
      this.dgv_Turmas.AllowUserToAddRows = false;
      this.dgv_Turmas.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      this.dgv_Turmas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgv_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv_Turmas.DefaultCellStyle = dataGridViewCellStyle3;
      this.dgv_Turmas.Location = new System.Drawing.Point(12, 12);
      this.dgv_Turmas.MultiSelect = false;
      this.dgv_Turmas.Name = "dgv_Turmas";
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
      // 
      // btn_Salvar
      // 
      this.btn_Salvar.Location = new System.Drawing.Point(146, 3);
      this.btn_Salvar.Name = "btn_Salvar";
      this.btn_Salvar.Size = new System.Drawing.Size(120, 23);
      this.btn_Salvar.TabIndex = 1;
      this.btn_Salvar.Text = "Salvar";
      this.btn_Salvar.UseVisualStyleBackColor = true;
      // 
      // btn_Novo
      // 
      this.btn_Novo.Location = new System.Drawing.Point(12, 3);
      this.btn_Novo.Name = "btn_Novo";
      this.btn_Novo.Size = new System.Drawing.Size(120, 23);
      this.btn_Novo.TabIndex = 0;
      this.btn_Novo.Text = "Novo";
      this.btn_Novo.UseVisualStyleBackColor = true;
      // 
      // btn_Fechar
      // 
      this.btn_Fechar.Location = new System.Drawing.Point(551, 3);
      this.btn_Fechar.Name = "btn_Fechar";
      this.btn_Fechar.Size = new System.Drawing.Size(120, 23);
      this.btn_Fechar.TabIndex = 4;
      this.btn_Fechar.Text = "Fechar";
      this.btn_Fechar.UseVisualStyleBackColor = true;
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
      // F_GestaoTurmas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(679, 579);
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
  }
}