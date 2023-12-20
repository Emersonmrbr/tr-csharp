namespace Aula60
{
    partial class Janela1
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
            this.bt_Send = new System.Windows.Forms.Button();
            this.lb_NomeCurso = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Send
            // 
            this.bt_Send.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_Send.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Send.Location = new System.Drawing.Point(62, 56);
            this.bt_Send.Name = "bt_Send";
            this.bt_Send.Size = new System.Drawing.Size(143, 56);
            this.bt_Send.TabIndex = 0;
            this.bt_Send.Text = "Send";
            this.bt_Send.UseVisualStyleBackColor = false;
            // 
            // lb_NomeCurso
            // 
            this.lb_NomeCurso.AutoSize = true;
            this.lb_NomeCurso.Location = new System.Drawing.Point(62, 31);
            this.lb_NomeCurso.Name = "lb_NomeCurso";
            this.lb_NomeCurso.Size = new System.Drawing.Size(51, 13);
            this.lb_NomeCurso.TabIndex = 1;
            this.lb_NomeCurso.Text = "Curso C#";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(65, 129);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(143, 20);
            this.tb_Nome.TabIndex = 2;
            // 
            // Janela1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.lb_NomeCurso);
            this.Controls.Add(this.bt_Send);
            this.Name = "Janela1";
            this.Text = "Curso de C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Send;
        private System.Windows.Forms.Label lb_NomeCurso;
        private System.Windows.Forms.TextBox tb_Nome;
    }
}

