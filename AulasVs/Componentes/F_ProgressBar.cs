using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes
{
  public partial class F_ProgressBar : Form
  {
    public F_ProgressBar()
    {
      InitializeComponent();
    }

    private void btn_definirValor_Click(object sender, EventArgs e)
    {
            if (int.Parse(ttb_definirValor.Text) <= psb_estado.Maximum & int.Parse(ttb_definirValor.Text) >= psb_estado.Minimum)
            {
            psb_estado.Value = int.Parse(ttb_definirValor.Text);
            }
    }

    private void btn_preencher_Click(object sender, EventArgs e)
    {
      psb_estado.Value = 0;
      ttb_progresso.Text = string.Empty;
      psb_estado.Maximum = int.Parse(ttb_valorPreencher.Text);
      for (int i = 0; i <= int.Parse(ttb_valorPreencher.Text); i++)
      {
        psb_estado.Value = i;
        ttb_progresso.Text = i.ToString();
        ttb_progresso.Update();
        Thread.Sleep(100);
      }
    }
  }
}
