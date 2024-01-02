namespace Academia
{
  partial class F_Horarios
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.ttb_ID = new System.Windows.Forms.TextBox();
      this.mtb_Horario = new System.Windows.Forms.MaskedTextBox();
      this.dgv_Horario = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_Novo = new System.Windows.Forms.Button();
      this.btn_Salvar = new System.Windows.Forms.Button();
      this.btn_Excluir = new System.Windows.Forms.Button();
      this.btn_Fechar = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Horario)).BeginInit();
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
      this.label2.Location = new System.Drawing.Point(120, 13);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Horário";
      // 
      // ttb_ID
      // 
      this.ttb_ID.Location = new System.Drawing.Point(13, 30);
      this.ttb_ID.Name = "ttb_ID";
      this.ttb_ID.ReadOnly = true;
      this.ttb_ID.Size = new System.Drawing.Size(100, 20);
      this.ttb_ID.TabIndex = 2;
      this.ttb_ID.TabStop = false;
      // 
      // mtb_Horario
      // 
      this.mtb_Horario.Location = new System.Drawing.Point(120, 30);
      this.mtb_Horario.Mask = "99:99 - 99:99";
      this.mtb_Horario.Name = "mtb_Horario";
      this.mtb_Horario.Size = new System.Drawing.Size(100, 20);
      this.mtb_Horario.TabIndex = 3;
      // 
      // dgv_Horario
      // 
      this.dgv_Horario.AllowUserToAddRows = false;
      this.dgv_Horario.AllowUserToDeleteRows = false;
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv_Horario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
      this.dgv_Horario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_Horario.EnableHeadersVisualStyles = false;
      this.dgv_Horario.Location = new System.Drawing.Point(13, 57);
      this.dgv_Horario.MultiSelect = false;
      this.dgv_Horario.Name = "dgv_Horario";
      this.dgv_Horario.RowHeadersVisible = false;
      this.dgv_Horario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
      this.dgv_Horario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.WindowText;
      this.dgv_Horario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv_Horario.Size = new System.Drawing.Size(321, 355);
      this.dgv_Horario.TabIndex = 4;
      this.dgv_Horario.SelectionChanged += new System.EventHandler(this.dgv_Horario_SelectionChanged);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_Fechar);
      this.panel1.Controls.Add(this.btn_Excluir);
      this.panel1.Controls.Add(this.btn_Salvar);
      this.panel1.Controls.Add(this.btn_Novo);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(0, 418);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(351, 32);
      this.panel1.TabIndex = 5;
      // 
      // btn_Novo
      // 
      this.btn_Novo.Location = new System.Drawing.Point(13, 4);
      this.btn_Novo.Name = "btn_Novo";
      this.btn_Novo.Size = new System.Drawing.Size(75, 23);
      this.btn_Novo.TabIndex = 0;
      this.btn_Novo.Text = "Novo";
      this.btn_Novo.UseVisualStyleBackColor = true;
      this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
      // 
      // btn_Salvar
      // 
      this.btn_Salvar.Location = new System.Drawing.Point(95, 4);
      this.btn_Salvar.Name = "btn_Salvar";
      this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
      this.btn_Salvar.TabIndex = 1;
      this.btn_Salvar.Text = "Salvar";
      this.btn_Salvar.UseVisualStyleBackColor = true;
      this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
      // 
      // btn_Excluir
      // 
      this.btn_Excluir.Location = new System.Drawing.Point(177, 4);
      this.btn_Excluir.Name = "btn_Excluir";
      this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
      this.btn_Excluir.TabIndex = 2;
      this.btn_Excluir.Text = "Excluir";
      this.btn_Excluir.UseVisualStyleBackColor = true;
      this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
      // 
      // btn_Fechar
      // 
      this.btn_Fechar.Location = new System.Drawing.Point(259, 4);
      this.btn_Fechar.Name = "btn_Fechar";
      this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
      this.btn_Fechar.TabIndex = 3;
      this.btn_Fechar.Text = "Fechar";
      this.btn_Fechar.UseVisualStyleBackColor = true;
      this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
      // 
      // F_Horarios
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(351, 450);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dgv_Horario);
      this.Controls.Add(this.mtb_Horario);
      this.Controls.Add(this.ttb_ID);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "F_Horarios";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Horarios";
      this.Load += new System.EventHandler(this.F_Horarios_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_Horario)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ttb_ID;
    private System.Windows.Forms.MaskedTextBox mtb_Horario;
    private System.Windows.Forms.DataGridView dgv_Horario;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_Fechar;
    private System.Windows.Forms.Button btn_Excluir;
    private System.Windows.Forms.Button btn_Salvar;
    private System.Windows.Forms.Button btn_Novo;
  }
}