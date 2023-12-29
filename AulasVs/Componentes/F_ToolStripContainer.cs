using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
  public partial class F_ToolStripContainer : Form
  {
    public F_ToolStripContainer()
    {
      InitializeComponent();
    }

    private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_Configuracoes f_Configuracoes = new F_Configuracoes();
      f_Configuracoes.ShowDialog();
    }
  }
}
