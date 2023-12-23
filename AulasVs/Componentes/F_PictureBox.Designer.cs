namespace Componentes
{
  partial class F_PictureBox
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_PictureBox));
      this.lbl_empresa = new System.Windows.Forms.Label();
      this.lbl_url = new System.Windows.Forms.Label();
      this.peb_logo1 = new System.Windows.Forms.PictureBox();
      this.peb_logo2 = new System.Windows.Forms.PictureBox();
      this.btn_logo1 = new System.Windows.Forms.Button();
      this.btn_logo2 = new System.Windows.Forms.Button();
      this.btn_logo3 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.peb_logo1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.peb_logo2)).BeginInit();
      this.SuspendLayout();
      // 
      // lbl_empresa
      // 
      this.lbl_empresa.AutoSize = true;
      this.lbl_empresa.Location = new System.Drawing.Point(200, 9);
      this.lbl_empresa.Name = "lbl_empresa";
      this.lbl_empresa.Size = new System.Drawing.Size(35, 13);
      this.lbl_empresa.TabIndex = 0;
      this.lbl_empresa.Text = "label1";
      this.lbl_empresa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lbl_url
      // 
      this.lbl_url.AutoSize = true;
      this.lbl_url.Location = new System.Drawing.Point(200, 26);
      this.lbl_url.Name = "lbl_url";
      this.lbl_url.Size = new System.Drawing.Size(35, 13);
      this.lbl_url.TabIndex = 1;
      this.lbl_url.Text = "label2";
      this.lbl_url.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // peb_logo1
      // 
      this.peb_logo1.Image = global::Componentes.Properties.Resources.logoCompelto;
      this.peb_logo1.Location = new System.Drawing.Point(12, 60);
      this.peb_logo1.Name = "peb_logo1";
      this.peb_logo1.Size = new System.Drawing.Size(410, 67);
      this.peb_logo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.peb_logo1.TabIndex = 2;
      this.peb_logo1.TabStop = false;
      // 
      // peb_logo2
      // 
      this.peb_logo2.Location = new System.Drawing.Point(175, 164);
      this.peb_logo2.Name = "peb_logo2";
      this.peb_logo2.Size = new System.Drawing.Size(85, 85);
      this.peb_logo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.peb_logo2.TabIndex = 3;
      this.peb_logo2.TabStop = false;
      // 
      // btn_logo1
      // 
      this.btn_logo1.Location = new System.Drawing.Point(12, 164);
      this.btn_logo1.Name = "btn_logo1";
      this.btn_logo1.Size = new System.Drawing.Size(75, 23);
      this.btn_logo1.TabIndex = 4;
      this.btn_logo1.Text = "Logo 1";
      this.btn_logo1.UseVisualStyleBackColor = true;
      this.btn_logo1.Click += new System.EventHandler(this.btn_logo1_Click);
      // 
      // btn_logo2
      // 
      this.btn_logo2.Location = new System.Drawing.Point(12, 197);
      this.btn_logo2.Name = "btn_logo2";
      this.btn_logo2.Size = new System.Drawing.Size(75, 23);
      this.btn_logo2.TabIndex = 5;
      this.btn_logo2.Text = "Logo 2";
      this.btn_logo2.UseVisualStyleBackColor = true;
      this.btn_logo2.Click += new System.EventHandler(this.btn_logo2_Click);
      // 
      // btn_logo3
      // 
      this.btn_logo3.Location = new System.Drawing.Point(13, 226);
      this.btn_logo3.Name = "btn_logo3";
      this.btn_logo3.Size = new System.Drawing.Size(75, 23);
      this.btn_logo3.TabIndex = 6;
      this.btn_logo3.Text = "Logo 3";
      this.btn_logo3.UseVisualStyleBackColor = true;
      this.btn_logo3.Click += new System.EventHandler(this.btn_logo3_Click);
      // 
      // F_PictureBox
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(434, 261);
      this.Controls.Add(this.btn_logo3);
      this.Controls.Add(this.btn_logo2);
      this.Controls.Add(this.btn_logo1);
      this.Controls.Add(this.peb_logo2);
      this.Controls.Add(this.peb_logo1);
      this.Controls.Add(this.lbl_url);
      this.Controls.Add(this.lbl_empresa);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "F_PictureBox";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Picture Box";
      this.Load += new System.EventHandler(this.F_PictureBox_Load);
      ((System.ComponentModel.ISupportInitialize)(this.peb_logo1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.peb_logo2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_empresa;
    private System.Windows.Forms.Label lbl_url;
    private System.Windows.Forms.PictureBox peb_logo1;
    private System.Windows.Forms.PictureBox peb_logo2;
    private System.Windows.Forms.Button btn_logo1;
    private System.Windows.Forms.Button btn_logo2;
    private System.Windows.Forms.Button btn_logo3;
  }
}