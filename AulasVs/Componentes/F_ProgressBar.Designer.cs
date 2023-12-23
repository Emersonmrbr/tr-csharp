namespace Componentes
{
  partial class F_ProgressBar
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
      this.ttb_definirValor = new System.Windows.Forms.TextBox();
      this.btn_definirValor = new System.Windows.Forms.Button();
      this.ttb_valorPreencher = new System.Windows.Forms.TextBox();
      this.ttb_progresso = new System.Windows.Forms.TextBox();
      this.psb_estado = new System.Windows.Forms.ProgressBar();
      this.btn_preencher = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ttb_definirValor
      // 
      this.ttb_definirValor.Location = new System.Drawing.Point(13, 13);
      this.ttb_definirValor.Name = "ttb_definirValor";
      this.ttb_definirValor.Size = new System.Drawing.Size(100, 20);
      this.ttb_definirValor.TabIndex = 0;
      // 
      // btn_definirValor
      // 
      this.btn_definirValor.Location = new System.Drawing.Point(13, 40);
      this.btn_definirValor.Name = "btn_definirValor";
      this.btn_definirValor.Size = new System.Drawing.Size(100, 23);
      this.btn_definirValor.TabIndex = 1;
      this.btn_definirValor.Text = "Definir valor";
      this.btn_definirValor.UseVisualStyleBackColor = true;
      this.btn_definirValor.Click += new System.EventHandler(this.btn_definirValor_Click);
      // 
      // ttb_valorPreencher
      // 
      this.ttb_valorPreencher.Location = new System.Drawing.Point(322, 114);
      this.ttb_valorPreencher.Name = "ttb_valorPreencher";
      this.ttb_valorPreencher.Size = new System.Drawing.Size(100, 20);
      this.ttb_valorPreencher.TabIndex = 2;
      // 
      // ttb_progresso
      // 
      this.ttb_progresso.Location = new System.Drawing.Point(167, 114);
      this.ttb_progresso.Name = "ttb_progresso";
      this.ttb_progresso.Size = new System.Drawing.Size(100, 20);
      this.ttb_progresso.TabIndex = 3;
      // 
      // psb_estado
      // 
      this.psb_estado.Location = new System.Drawing.Point(13, 147);
      this.psb_estado.Name = "psb_estado";
      this.psb_estado.Size = new System.Drawing.Size(409, 23);
      this.psb_estado.TabIndex = 4;
      // 
      // btn_preencher
      // 
      this.btn_preencher.Location = new System.Drawing.Point(13, 114);
      this.btn_preencher.Name = "btn_preencher";
      this.btn_preencher.Size = new System.Drawing.Size(100, 23);
      this.btn_preencher.TabIndex = 5;
      this.btn_preencher.Text = "Preencher";
      this.btn_preencher.UseVisualStyleBackColor = true;
      this.btn_preencher.Click += new System.EventHandler(this.btn_preencher_Click);
      // 
      // F_ProgressBar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.btn_preencher);
      this.Controls.Add(this.psb_estado);
      this.Controls.Add(this.ttb_progresso);
      this.Controls.Add(this.ttb_valorPreencher);
      this.Controls.Add(this.btn_definirValor);
      this.Controls.Add(this.ttb_definirValor);
      this.MaximizeBox = false;
      this.Name = "F_ProgressBar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Progress Bar";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox ttb_definirValor;
    private System.Windows.Forms.Button btn_definirValor;
    private System.Windows.Forms.TextBox ttb_valorPreencher;
    private System.Windows.Forms.TextBox ttb_progresso;
    private System.Windows.Forms.ProgressBar psb_estado;
    private System.Windows.Forms.Button btn_preencher;
  }
}