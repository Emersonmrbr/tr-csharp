namespace Componentes
{
  partial class F_FilhoCheckBox
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
      this.cb_onibus = new System.Windows.Forms.CheckBox();
      this.cb_navio = new System.Windows.Forms.CheckBox();
      this.cb_aviao = new System.Windows.Forms.CheckBox();
      this.cb_carro = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // cb_onibus
      // 
      this.cb_onibus.Appearance = System.Windows.Forms.Appearance.Button;
      this.cb_onibus.AutoSize = true;
      this.cb_onibus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
      this.cb_onibus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.cb_onibus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cb_onibus.Location = new System.Drawing.Point(29, 158);
      this.cb_onibus.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
      this.cb_onibus.Name = "cb_onibus";
      this.cb_onibus.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cb_onibus.Size = new System.Drawing.Size(50, 23);
      this.cb_onibus.TabIndex = 7;
      this.cb_onibus.Text = "Ônibus";
      this.cb_onibus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.cb_onibus.UseVisualStyleBackColor = true;
      this.cb_onibus.CheckedChanged += new System.EventHandler(this.cb_onibus_CheckedChanged);
      // 
      // cb_navio
      // 
      this.cb_navio.Appearance = System.Windows.Forms.Appearance.Button;
      this.cb_navio.AutoSize = true;
      this.cb_navio.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
      this.cb_navio.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.cb_navio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cb_navio.Location = new System.Drawing.Point(29, 115);
      this.cb_navio.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
      this.cb_navio.MinimumSize = new System.Drawing.Size(50, 0);
      this.cb_navio.Name = "cb_navio";
      this.cb_navio.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cb_navio.Size = new System.Drawing.Size(50, 23);
      this.cb_navio.TabIndex = 6;
      this.cb_navio.Text = "Navio";
      this.cb_navio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.cb_navio.UseVisualStyleBackColor = true;
      this.cb_navio.CheckedChanged += new System.EventHandler(this.cb_navio_CheckedChanged);
      // 
      // cb_aviao
      // 
      this.cb_aviao.Appearance = System.Windows.Forms.Appearance.Button;
      this.cb_aviao.AutoSize = true;
      this.cb_aviao.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
      this.cb_aviao.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.cb_aviao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cb_aviao.Location = new System.Drawing.Point(29, 72);
      this.cb_aviao.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
      this.cb_aviao.MinimumSize = new System.Drawing.Size(50, 0);
      this.cb_aviao.Name = "cb_aviao";
      this.cb_aviao.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cb_aviao.Size = new System.Drawing.Size(50, 23);
      this.cb_aviao.TabIndex = 5;
      this.cb_aviao.Text = "Avião";
      this.cb_aviao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.cb_aviao.UseVisualStyleBackColor = true;
      this.cb_aviao.CheckedChanged += new System.EventHandler(this.cb_aviao_CheckedChanged);
      // 
      // cb_carro
      // 
      this.cb_carro.Appearance = System.Windows.Forms.Appearance.Button;
      this.cb_carro.AutoSize = true;
      this.cb_carro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
      this.cb_carro.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption;
      this.cb_carro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cb_carro.Location = new System.Drawing.Point(29, 29);
      this.cb_carro.Margin = new System.Windows.Forms.Padding(20, 20, 3, 3);
      this.cb_carro.MinimumSize = new System.Drawing.Size(50, 0);
      this.cb_carro.Name = "cb_carro";
      this.cb_carro.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cb_carro.Size = new System.Drawing.Size(50, 23);
      this.cb_carro.TabIndex = 4;
      this.cb_carro.Text = "Carro";
      this.cb_carro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.cb_carro.UseVisualStyleBackColor = true;
      this.cb_carro.CheckedChanged += new System.EventHandler(this.cb_carro_CheckedChanged);
      // 
      // F_FilhoCheckBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 436);
      this.Controls.Add(this.cb_onibus);
      this.Controls.Add(this.cb_navio);
      this.Controls.Add(this.cb_aviao);
      this.Controls.Add(this.cb_carro);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MinimizeBox = false;
      this.Name = "F_FilhoCheckBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Filho Check Box";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox cb_onibus;
    private System.Windows.Forms.CheckBox cb_navio;
    private System.Windows.Forms.CheckBox cb_aviao;
    private System.Windows.Forms.CheckBox cb_carro;
  }
}