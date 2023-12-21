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
  public partial class F_CheckedListBox : Form
  {
    public F_CheckedListBox()
    {
      InitializeComponent();
    }

    private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
    {
      string txt = null;
      foreach (string t in clb_veiculos.CheckedItems)
      {
        txt += t + ", ";
      }
      MessageBox.Show(txt);
    }

    private void btn_limparLista_Click(object sender, EventArgs e)
    {
      clb_veiculos.Items.Clear();
    }

    private void btn_resetLista_Click(object sender, EventArgs e)
    {
      clb_veiculos.Items.Clear();
      List<string> veiculos = new List<string>();
      veiculos.Add("Avião");
      veiculos.Add("Navio");
      veiculos.Add("Carro");
      veiculos.Add("Moto");
      veiculos.Add("Bicicleta");
      clb_veiculos.Items.AddRange(veiculos.ToArray());
    }

    private void btn_adicionarTransporte_Click(object sender, EventArgs e)
    {
      if (tb_adicionaTransporte.Text != "")
      {
        clb_veiculos.Items.Add(tb_adicionaTransporte.Text);
        tb_adicionaTransporte.Clear();
        tb_adicionaTransporte.Focus();
      }
    }

    private void tb_adicionaTransporte_Click(object sender, EventArgs e)
    {
      tb_adicionaTransporte.Clear();
    }
  }
}
