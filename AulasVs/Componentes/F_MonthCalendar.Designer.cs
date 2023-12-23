namespace Componentes
{
  partial class F_MonthCalendar
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
      this.mhc_calendario = new System.Windows.Forms.MonthCalendar();
      this.btn_obter = new System.Windows.Forms.Button();
      this.ttb_inicio = new System.Windows.Forms.TextBox();
      this.ttb_fim = new System.Windows.Forms.TextBox();
      this.ttb_atual = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // mhc_calendario
      // 
      this.mhc_calendario.Location = new System.Drawing.Point(13, 13);
      this.mhc_calendario.MaxSelectionCount = 365;
      this.mhc_calendario.Name = "mhc_calendario";
      this.mhc_calendario.TabIndex = 0;
      this.mhc_calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mhc_calendario_DateChanged);
      // 
      // btn_obter
      // 
      this.btn_obter.Location = new System.Drawing.Point(253, 13);
      this.btn_obter.Name = "btn_obter";
      this.btn_obter.Size = new System.Drawing.Size(169, 23);
      this.btn_obter.TabIndex = 1;
      this.btn_obter.Text = "Obter";
      this.btn_obter.UseVisualStyleBackColor = true;
      this.btn_obter.Click += new System.EventHandler(this.btn_obter_Click);
      // 
      // ttb_inicio
      // 
      this.ttb_inicio.Location = new System.Drawing.Point(253, 43);
      this.ttb_inicio.Name = "ttb_inicio";
      this.ttb_inicio.Size = new System.Drawing.Size(169, 20);
      this.ttb_inicio.TabIndex = 2;
      // 
      // ttb_fim
      // 
      this.ttb_fim.Location = new System.Drawing.Point(253, 69);
      this.ttb_fim.Name = "ttb_fim";
      this.ttb_fim.Size = new System.Drawing.Size(169, 20);
      this.ttb_fim.TabIndex = 3;
      // 
      // ttb_atual
      // 
      this.ttb_atual.Location = new System.Drawing.Point(253, 95);
      this.ttb_atual.Name = "ttb_atual";
      this.ttb_atual.Size = new System.Drawing.Size(169, 20);
      this.ttb_atual.TabIndex = 4;
      // 
      // F_MonthCalendar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.ttb_atual);
      this.Controls.Add(this.ttb_fim);
      this.Controls.Add(this.ttb_inicio);
      this.Controls.Add(this.btn_obter);
      this.Controls.Add(this.mhc_calendario);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "F_MonthCalendar";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Month Calendar";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MonthCalendar mhc_calendario;
    private System.Windows.Forms.Button btn_obter;
    private System.Windows.Forms.TextBox ttb_inicio;
    private System.Windows.Forms.TextBox ttb_fim;
    private System.Windows.Forms.TextBox ttb_atual;
  }
}