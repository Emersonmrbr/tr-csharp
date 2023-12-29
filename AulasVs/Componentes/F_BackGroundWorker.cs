using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
  public partial class F_BackGroundWorker : Form
  {
    int Contador = 0;
    int Maximo = 1000;
    public F_BackGroundWorker()
    {
      InitializeComponent();
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      for (int i = 0; i < Maximo; i++)
      {
        Contador++;
        backgroundWorker1.ReportProgress(0);
        Thread.Sleep(10);
      }
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      MessageBox.Show("Trabalho terminado");
      lbl_Status.Text = "W1 terminado";
    }

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      lbl_Status.Text = "W1 Trabalhando";
      lbl_Progresso.Text = Contador.ToString();
    }

    private void btn_Iniciar_Click(object sender, EventArgs e)
    {
      if (!backgroundWorker1.IsBusy)
      {
        Contador = 0;
        backgroundWorker1.RunWorkerAsync();
      }
    }
  }
}
