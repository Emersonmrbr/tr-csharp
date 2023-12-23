namespace Componentes
{
  partial class F_MaskedTextBox
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
      this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
      this.btn_mostrar = new System.Windows.Forms.Button();
      this.ckb_somenteTexto = new System.Windows.Forms.CheckBox();
      this.ckb_mostrar = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // mtb_cpf
      // 
      this.mtb_cpf.Location = new System.Drawing.Point(12, 55);
      this.mtb_cpf.Mask = "000,000,000-00";
      this.mtb_cpf.Name = "mtb_cpf";
      this.mtb_cpf.Size = new System.Drawing.Size(184, 20);
      this.mtb_cpf.TabIndex = 0;
      this.mtb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Senha";
      // 
      // mtb_senha
      // 
      this.mtb_senha.Location = new System.Drawing.Point(12, 29);
      this.mtb_senha.Name = "mtb_senha";
      this.mtb_senha.PasswordChar = '#';
      this.mtb_senha.Size = new System.Drawing.Size(100, 20);
      this.mtb_senha.TabIndex = 2;
      // 
      // btn_mostrar
      // 
      this.btn_mostrar.Location = new System.Drawing.Point(303, 55);
      this.btn_mostrar.Name = "btn_mostrar";
      this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
      this.btn_mostrar.TabIndex = 3;
      this.btn_mostrar.Text = "Mostrar";
      this.btn_mostrar.UseVisualStyleBackColor = true;
      this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
      // 
      // ckb_somenteTexto
      // 
      this.ckb_somenteTexto.AutoSize = true;
      this.ckb_somenteTexto.Location = new System.Drawing.Point(203, 57);
      this.ckb_somenteTexto.Name = "ckb_somenteTexto";
      this.ckb_somenteTexto.Size = new System.Drawing.Size(94, 17);
      this.ckb_somenteTexto.TabIndex = 4;
      this.ckb_somenteTexto.Text = "Somente texto";
      this.ckb_somenteTexto.UseVisualStyleBackColor = true;
      // 
      // ckb_mostrar
      // 
      this.ckb_mostrar.AutoSize = true;
      this.ckb_mostrar.Location = new System.Drawing.Point(119, 29);
      this.ckb_mostrar.Name = "ckb_mostrar";
      this.ckb_mostrar.Size = new System.Drawing.Size(61, 17);
      this.ckb_mostrar.TabIndex = 5;
      this.ckb_mostrar.Text = "Mostrar";
      this.ckb_mostrar.UseVisualStyleBackColor = true;
      this.ckb_mostrar.CheckedChanged += new System.EventHandler(this.ckb_mostrar_CheckedChanged);
      // 
      // F_MaskedTextBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.ckb_mostrar);
      this.Controls.Add(this.ckb_somenteTexto);
      this.Controls.Add(this.btn_mostrar);
      this.Controls.Add(this.mtb_senha);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.mtb_cpf);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_MaskedTextBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Masked Text Box";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MaskedTextBox mtb_cpf;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MaskedTextBox mtb_senha;
    private System.Windows.Forms.Button btn_mostrar;
    private System.Windows.Forms.CheckBox ckb_somenteTexto;
    private System.Windows.Forms.CheckBox ckb_mostrar;
  }
}