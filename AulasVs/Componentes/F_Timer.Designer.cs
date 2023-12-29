namespace Componentes
{
  partial class F_Timer
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Timer));
      this.tmr_Principal = new System.Windows.Forms.Timer(this.components);
      this.btn_IniciarTimerRpincipal = new System.Windows.Forms.Button();
      this.btn_PararTimerRpincipal = new System.Windows.Forms.Button();
      this.btn_ReiniciarTimerRpincipal = new System.Windows.Forms.Button();
      this.lbl_TimerTimerRpincipal = new System.Windows.Forms.Label();
      this.img_Carro = new System.Windows.Forms.PictureBox();
      this.tmr_Carro = new System.Windows.Forms.Timer(this.components);
      this.btn_IniciarCarro = new System.Windows.Forms.Button();
      this.btnt_PararCarro = new System.Windows.Forms.Button();
      this.btn_ReiniciarCarro = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).BeginInit();
      this.SuspendLayout();
      // 
      // tmr_Principal
      // 
      this.tmr_Principal.Tick += new System.EventHandler(this.tmr_Principal_Tick);
      // 
      // btn_IniciarTimerRpincipal
      // 
      this.btn_IniciarTimerRpincipal.Location = new System.Drawing.Point(13, 13);
      this.btn_IniciarTimerRpincipal.Name = "btn_IniciarTimerRpincipal";
      this.btn_IniciarTimerRpincipal.Size = new System.Drawing.Size(75, 23);
      this.btn_IniciarTimerRpincipal.TabIndex = 0;
      this.btn_IniciarTimerRpincipal.Text = "Iniciar";
      this.btn_IniciarTimerRpincipal.UseVisualStyleBackColor = true;
      this.btn_IniciarTimerRpincipal.Click += new System.EventHandler(this.btn_IniciarTimerRpincipal_Click);
      // 
      // btn_PararTimerRpincipal
      // 
      this.btn_PararTimerRpincipal.Location = new System.Drawing.Point(95, 12);
      this.btn_PararTimerRpincipal.Name = "btn_PararTimerRpincipal";
      this.btn_PararTimerRpincipal.Size = new System.Drawing.Size(75, 23);
      this.btn_PararTimerRpincipal.TabIndex = 1;
      this.btn_PararTimerRpincipal.Text = "Parar";
      this.btn_PararTimerRpincipal.UseVisualStyleBackColor = true;
      this.btn_PararTimerRpincipal.Click += new System.EventHandler(this.btn_PararTimerRpincipal_Click);
      // 
      // btn_ReiniciarTimerRpincipal
      // 
      this.btn_ReiniciarTimerRpincipal.Location = new System.Drawing.Point(177, 11);
      this.btn_ReiniciarTimerRpincipal.Name = "btn_ReiniciarTimerRpincipal";
      this.btn_ReiniciarTimerRpincipal.Size = new System.Drawing.Size(75, 23);
      this.btn_ReiniciarTimerRpincipal.TabIndex = 2;
      this.btn_ReiniciarTimerRpincipal.Text = "Reiniciar";
      this.btn_ReiniciarTimerRpincipal.UseVisualStyleBackColor = true;
      this.btn_ReiniciarTimerRpincipal.Click += new System.EventHandler(this.btn_ReiniciarTimerRpincipal_Click);
      // 
      // lbl_TimerTimerRpincipal
      // 
      this.lbl_TimerTimerRpincipal.AutoSize = true;
      this.lbl_TimerTimerRpincipal.Location = new System.Drawing.Point(13, 53);
      this.lbl_TimerTimerRpincipal.Name = "lbl_TimerTimerRpincipal";
      this.lbl_TimerTimerRpincipal.Size = new System.Drawing.Size(35, 13);
      this.lbl_TimerTimerRpincipal.TabIndex = 3;
      this.lbl_TimerTimerRpincipal.Text = "label1";
      // 
      // img_Carro
      // 
      this.img_Carro.Image = ((System.Drawing.Image)(resources.GetObject("img_Carro.Image")));
      this.img_Carro.Location = new System.Drawing.Point(684, 388);
      this.img_Carro.Name = "img_Carro";
      this.img_Carro.Size = new System.Drawing.Size(104, 50);
      this.img_Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.img_Carro.TabIndex = 4;
      this.img_Carro.TabStop = false;
      // 
      // tmr_Carro
      // 
      this.tmr_Carro.Interval = 10;
      this.tmr_Carro.Tick += new System.EventHandler(this.tmr_Carro_Tick);
      // 
      // btn_IniciarCarro
      // 
      this.btn_IniciarCarro.Location = new System.Drawing.Point(16, 113);
      this.btn_IniciarCarro.Name = "btn_IniciarCarro";
      this.btn_IniciarCarro.Size = new System.Drawing.Size(75, 23);
      this.btn_IniciarCarro.TabIndex = 5;
      this.btn_IniciarCarro.Text = "Iniciar";
      this.btn_IniciarCarro.UseVisualStyleBackColor = true;
      this.btn_IniciarCarro.Click += new System.EventHandler(this.btn_IniciarCarro_Click);
      // 
      // btnt_PararCarro
      // 
      this.btnt_PararCarro.Location = new System.Drawing.Point(97, 113);
      this.btnt_PararCarro.Name = "btnt_PararCarro";
      this.btnt_PararCarro.Size = new System.Drawing.Size(75, 23);
      this.btnt_PararCarro.TabIndex = 6;
      this.btnt_PararCarro.Text = "Parar";
      this.btnt_PararCarro.UseVisualStyleBackColor = true;
      this.btnt_PararCarro.Click += new System.EventHandler(this.btnt_PararCarro_Click);
      // 
      // btn_ReiniciarCarro
      // 
      this.btn_ReiniciarCarro.Location = new System.Drawing.Point(177, 113);
      this.btn_ReiniciarCarro.Name = "btn_ReiniciarCarro";
      this.btn_ReiniciarCarro.Size = new System.Drawing.Size(75, 23);
      this.btn_ReiniciarCarro.TabIndex = 7;
      this.btn_ReiniciarCarro.Text = "Reiniciar";
      this.btn_ReiniciarCarro.UseVisualStyleBackColor = true;
      this.btn_ReiniciarCarro.Click += new System.EventHandler(this.button1_Click);
      // 
      // F_Timer
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btn_ReiniciarCarro);
      this.Controls.Add(this.btnt_PararCarro);
      this.Controls.Add(this.btn_IniciarCarro);
      this.Controls.Add(this.img_Carro);
      this.Controls.Add(this.lbl_TimerTimerRpincipal);
      this.Controls.Add(this.btn_ReiniciarTimerRpincipal);
      this.Controls.Add(this.btn_PararTimerRpincipal);
      this.Controls.Add(this.btn_IniciarTimerRpincipal);
      this.Name = "F_Timer";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Timer";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.F_Timer_Load);
      ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer tmr_Principal;
    private System.Windows.Forms.Button btn_IniciarTimerRpincipal;
    private System.Windows.Forms.Button btn_PararTimerRpincipal;
    private System.Windows.Forms.Button btn_ReiniciarTimerRpincipal;
    private System.Windows.Forms.Label lbl_TimerTimerRpincipal;
    private System.Windows.Forms.PictureBox img_Carro;
    private System.Windows.Forms.Timer tmr_Carro;
    private System.Windows.Forms.Button btn_IniciarCarro;
    private System.Windows.Forms.Button btnt_PararCarro;
    private System.Windows.Forms.Button btn_ReiniciarCarro;
  }
}