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
  public partial class F_TreeView : Form
  {
    public F_TreeView()
    {
      InitializeComponent();
    }

    private void Tev_Itens_AfterSelect(object sender, TreeViewEventArgs e)
    {
      Ttb_selecionado.Text = Tev_Itens.SelectedNode.Text;
    }

    private void Btn_adicoonar_Click(object sender, EventArgs e)
    {
      TreeNode EstadosRaiz = Tev_Itens.Nodes.Add("Estados");
      EstadosRaiz.Name = "Estados";

      TreeNode CoresRaiz = Tev_Itens.Nodes.Add("Cores");
      CoresRaiz.Name = "Cores";

      TreeNode Estado1 = EstadosRaiz.Nodes.Add("Paraná");
      Estado1.Name = "Paraná";

      TreeNode Estado2 = EstadosRaiz.Nodes.Add("Minas Gerais");
      Estado2.Name = "Minas Gerais";

      TreeNode Estado3 = EstadosRaiz.Nodes.Add("Bahia");
      Estado3.Name = "Bahia";
    }

    private void Btn_remover_Click(object sender, EventArgs e)
    {
      try
      {
        Tev_Itens.Nodes.Remove(Tev_Itens.Nodes["Estados"]);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Não existe: " + ex.Message);
      }
    }

    private void Btn_removerSelecionado_Click(object sender, EventArgs e)
    {
      try
      {
        Tev_Itens.Nodes.Remove(Tev_Itens.SelectedNode);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Não existe: " + ex.Message);
      }
    }
  }
}
