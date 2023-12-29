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
  public partial class F_Configuracoes : Form
  {
    public F_Configuracoes()
    {
      InitializeComponent();
    }

    private void F_Configuracoes_Load(object sender, EventArgs e)
    {
      List<ToolStrip> barraFerramentas = new List<ToolStrip>();
      int num = tsc_Configuracoes.TopToolStripPanel.Controls.Count;
      for (int i = 0; i < num; i++)
      {
        clb_OpcaoFerramentas.Items.Add(tsc_Configuracoes.TopToolStripPanel.Controls[i].Name);
        clb_OpcaoFerramentas.SetItemChecked(i, true);
      }
    }

    private void clb_OpcaoFerramentas_SelectedIndexChanged(object sender, EventArgs e)
    {
      int num = tsc_Configuracoes.TopToolStripPanel.Controls.Count;
      for (int i = 0; i < num; i++)
      {
        tsc_Configuracoes.TopToolStripPanel.Controls[i].Visible = clb_OpcaoFerramentas.GetItemChecked(i);
      }
    }
  }
}
