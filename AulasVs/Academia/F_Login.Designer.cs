namespace Academia
{
  partial class F_Login
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
      this.ttb_usuario = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ttb_senha = new System.Windows.Forms.TextBox();
      this.btn_logar = new System.Windows.Forms.Button();
      this.btn_cancelar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Usuário";
      // 
      // ttb_usuario
      // 
      this.ttb_usuario.Location = new System.Drawing.Point(13, 38);
      this.ttb_usuario.Name = "ttb_usuario";
      this.ttb_usuario.Size = new System.Drawing.Size(199, 20);
      this.ttb_usuario.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Senha";
      // 
      // ttb_senha
      // 
      this.ttb_senha.Location = new System.Drawing.Point(13, 95);
      this.ttb_senha.Name = "ttb_senha";
      this.ttb_senha.PasswordChar = '#';
      this.ttb_senha.Size = new System.Drawing.Size(199, 20);
      this.ttb_senha.TabIndex = 3;
      // 
      // btn_logar
      // 
      this.btn_logar.Location = new System.Drawing.Point(13, 127);
      this.btn_logar.Name = "btn_logar";
      this.btn_logar.Size = new System.Drawing.Size(199, 23);
      this.btn_logar.TabIndex = 4;
      this.btn_logar.Text = "Logar";
      this.btn_logar.UseVisualStyleBackColor = true;
      // 
      // btn_cancelar
      // 
      this.btn_cancelar.Location = new System.Drawing.Point(13, 162);
      this.btn_cancelar.Name = "btn_cancelar";
      this.btn_cancelar.Size = new System.Drawing.Size(199, 23);
      this.btn_cancelar.TabIndex = 5;
      this.btn_cancelar.Text = "Cancelar";
      this.btn_cancelar.UseVisualStyleBackColor = true;
      // 
      // F_Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(224, 200);
      this.Controls.Add(this.btn_cancelar);
      this.Controls.Add(this.btn_logar);
      this.Controls.Add(this.ttb_senha);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ttb_usuario);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "F_Login";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox ttb_usuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ttb_senha;
    private System.Windows.Forms.Button btn_logar;
    private System.Windows.Forms.Button btn_cancelar;
  }
}