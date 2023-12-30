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
      this.ttb_ApelidoUsuario = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ttb_Senha = new System.Windows.Forms.TextBox();
      this.btn_Logar = new System.Windows.Forms.Button();
      this.btn_Cancelar = new System.Windows.Forms.Button();
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
      // ttb_ApelidoUsuario
      // 
      this.ttb_ApelidoUsuario.Location = new System.Drawing.Point(13, 38);
      this.ttb_ApelidoUsuario.Name = "ttb_ApelidoUsuario";
      this.ttb_ApelidoUsuario.Size = new System.Drawing.Size(199, 20);
      this.ttb_ApelidoUsuario.TabIndex = 1;
      this.ttb_ApelidoUsuario.Text = "emersonmrbr";
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
      // ttb_Senha
      // 
      this.ttb_Senha.Location = new System.Drawing.Point(13, 95);
      this.ttb_Senha.Name = "ttb_Senha";
      this.ttb_Senha.PasswordChar = '#';
      this.ttb_Senha.Size = new System.Drawing.Size(199, 20);
      this.ttb_Senha.TabIndex = 3;
      this.ttb_Senha.Text = "1234";
      // 
      // btn_Logar
      // 
      this.btn_Logar.Location = new System.Drawing.Point(13, 127);
      this.btn_Logar.Name = "btn_Logar";
      this.btn_Logar.Size = new System.Drawing.Size(199, 23);
      this.btn_Logar.TabIndex = 4;
      this.btn_Logar.Text = "Logar";
      this.btn_Logar.UseVisualStyleBackColor = true;
      this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
      // 
      // btn_Cancelar
      // 
      this.btn_Cancelar.Location = new System.Drawing.Point(13, 162);
      this.btn_Cancelar.Name = "btn_Cancelar";
      this.btn_Cancelar.Size = new System.Drawing.Size(199, 23);
      this.btn_Cancelar.TabIndex = 5;
      this.btn_Cancelar.Text = "Cancelar";
      this.btn_Cancelar.UseVisualStyleBackColor = true;
      this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
      // 
      // F_Login
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(224, 200);
      this.Controls.Add(this.btn_Cancelar);
      this.Controls.Add(this.btn_Logar);
      this.Controls.Add(this.ttb_Senha);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.ttb_ApelidoUsuario);
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
    private System.Windows.Forms.TextBox ttb_ApelidoUsuario;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ttb_Senha;
    private System.Windows.Forms.Button btn_Logar;
    private System.Windows.Forms.Button btn_Cancelar;
  }
}