namespace Componentes
{
  partial class F_BackGroundWorker
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
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.btn_Iniciar = new System.Windows.Forms.Button();
      this.lbl_Status = new System.Windows.Forms.Label();
      this.lbl_Progresso = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // btn_Iniciar
      // 
      this.btn_Iniciar.Location = new System.Drawing.Point(13, 13);
      this.btn_Iniciar.Name = "btn_Iniciar";
      this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
      this.btn_Iniciar.TabIndex = 0;
      this.btn_Iniciar.Text = "Iniciar";
      this.btn_Iniciar.UseVisualStyleBackColor = true;
      this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
      // 
      // lbl_Status
      // 
      this.lbl_Status.AutoSize = true;
      this.lbl_Status.Location = new System.Drawing.Point(115, 22);
      this.lbl_Status.Name = "lbl_Status";
      this.lbl_Status.Size = new System.Drawing.Size(35, 13);
      this.lbl_Status.TabIndex = 1;
      this.lbl_Status.Text = "label1";
      // 
      // lbl_Progresso
      // 
      this.lbl_Progresso.AutoSize = true;
      this.lbl_Progresso.Location = new System.Drawing.Point(118, 39);
      this.lbl_Progresso.Name = "lbl_Progresso";
      this.lbl_Progresso.Size = new System.Drawing.Size(35, 13);
      this.lbl_Progresso.TabIndex = 2;
      this.lbl_Progresso.Text = "label2";
      // 
      // F_BackGroundWorker
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lbl_Progresso);
      this.Controls.Add(this.lbl_Status);
      this.Controls.Add(this.btn_Iniciar);
      this.Name = "F_BackGroundWorker";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Back Ground Worker";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.Button btn_Iniciar;
    private System.Windows.Forms.Label lbl_Status;
    private System.Windows.Forms.Label lbl_Progresso;
  }
}