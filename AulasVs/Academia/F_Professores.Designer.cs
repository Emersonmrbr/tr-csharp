namespace Academia
{
  partial class F_Professores
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lbl_Telefone = new System.Windows.Forms.Label();
      this.ttb_Id = new System.Windows.Forms.TextBox();
      this.ttb_Professor = new System.Windows.Forms.TextBox();
      this.mtb_Telefone = new System.Windows.Forms.MaskedTextBox();
      this.dgv_Professor = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_Fechar = new System.Windows.Forms.Button();
      this.btn_Excluir = new System.Windows.Forms.Button();
      this.btn_Salvar = new System.Windows.Forms.Button();
      this.btn_Novo = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Professor)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(18, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "ID";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(68, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(51, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Professor";
      // 
      // lbl_Telefone
      // 
      this.lbl_Telefone.AutoSize = true;
      this.lbl_Telefone.Location = new System.Drawing.Point(324, 13);
      this.lbl_Telefone.Name = "lbl_Telefone";
      this.lbl_Telefone.Size = new System.Drawing.Size(49, 13);
      this.lbl_Telefone.TabIndex = 2;
      this.lbl_Telefone.Text = "Telefone";
      // 
      // ttb_Id
      // 
      this.ttb_Id.Location = new System.Drawing.Point(12, 29);
      this.ttb_Id.Name = "ttb_Id";
      this.ttb_Id.ReadOnly = true;
      this.ttb_Id.Size = new System.Drawing.Size(50, 20);
      this.ttb_Id.TabIndex = 3;
      this.ttb_Id.TabStop = false;
      // 
      // ttb_Professor
      // 
      this.ttb_Professor.Location = new System.Drawing.Point(68, 29);
      this.ttb_Professor.Name = "ttb_Professor";
      this.ttb_Professor.Size = new System.Drawing.Size(250, 20);
      this.ttb_Professor.TabIndex = 4;
      // 
      // mtb_Telefone
      // 
      this.mtb_Telefone.Location = new System.Drawing.Point(324, 29);
      this.mtb_Telefone.Mask = "(00) 00000-0000";
      this.mtb_Telefone.Name = "mtb_Telefone";
      this.mtb_Telefone.Size = new System.Drawing.Size(90, 20);
      this.mtb_Telefone.TabIndex = 5;
      this.mtb_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // dgv_Professor
      // 
      this.dgv_Professor.AllowUserToAddRows = false;
      this.dgv_Professor.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      this.dgv_Professor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_Professor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.dgv_Professor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv_Professor.DefaultCellStyle = dataGridViewCellStyle3;
      this.dgv_Professor.Location = new System.Drawing.Point(12, 55);
      this.dgv_Professor.MultiSelect = false;
      this.dgv_Professor.Name = "dgv_Professor";
      this.dgv_Professor.RowHeadersVisible = false;
      this.dgv_Professor.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
      this.dgv_Professor.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      this.dgv_Professor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Professor.Size = new System.Drawing.Size(402, 359);
      this.dgv_Professor.TabIndex = 6;
      this.dgv_Professor.SelectionChanged += new System.EventHandler(this.dgv_Professor_SelectionChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_Fechar);
      this.panel1.Controls.Add(this.btn_Excluir);
      this.panel1.Controls.Add(this.btn_Salvar);
      this.panel1.Controls.Add(this.btn_Novo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 420);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(426, 30);
      this.panel1.TabIndex = 7;
      // 
      // btn_Fechar
      // 
      this.btn_Fechar.Location = new System.Drawing.Point(314, 3);
      this.btn_Fechar.Name = "btn_Fechar";
      this.btn_Fechar.Size = new System.Drawing.Size(100, 23);
      this.btn_Fechar.TabIndex = 3;
      this.btn_Fechar.Text = "Fechar";
      this.btn_Fechar.UseVisualStyleBackColor = true;
      this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
      // 
      // btn_Excluir
      // 
      this.btn_Excluir.Location = new System.Drawing.Point(212, 3);
      this.btn_Excluir.Name = "btn_Excluir";
      this.btn_Excluir.Size = new System.Drawing.Size(100, 23);
      this.btn_Excluir.TabIndex = 2;
      this.btn_Excluir.Text = "Excluir";
      this.btn_Excluir.UseVisualStyleBackColor = true;
      this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
      // 
      // btn_Salvar
      // 
      this.btn_Salvar.Location = new System.Drawing.Point(112, 3);
      this.btn_Salvar.Name = "btn_Salvar";
      this.btn_Salvar.Size = new System.Drawing.Size(100, 23);
      this.btn_Salvar.TabIndex = 1;
      this.btn_Salvar.Text = "Salvar";
      this.btn_Salvar.UseVisualStyleBackColor = true;
      this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
      // 
      // btn_Novo
      // 
      this.btn_Novo.Location = new System.Drawing.Point(12, 3);
      this.btn_Novo.Name = "btn_Novo";
      this.btn_Novo.Size = new System.Drawing.Size(100, 23);
      this.btn_Novo.TabIndex = 0;
      this.btn_Novo.Text = "Novo";
      this.btn_Novo.UseVisualStyleBackColor = true;
      this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
      // 
      // F_Professores
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dgv_Professor);
      this.Controls.Add(this.mtb_Telefone);
      this.Controls.Add(this.ttb_Professor);
      this.Controls.Add(this.ttb_Id);
      this.Controls.Add(this.lbl_Telefone);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "F_Professores";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "F_Professores";
      this.Load += new System.EventHandler(this.F_Professores_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Professor)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lbl_Telefone;
    private System.Windows.Forms.TextBox ttb_Id;
    private System.Windows.Forms.TextBox ttb_Professor;
    private System.Windows.Forms.MaskedTextBox mtb_Telefone;
    private System.Windows.Forms.DataGridView dgv_Professor;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_Fechar;
    private System.Windows.Forms.Button btn_Excluir;
    private System.Windows.Forms.Button btn_Salvar;
    private System.Windows.Forms.Button btn_Novo;
  }
}