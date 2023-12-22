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
  public partial class F_ComboBox : Form
  {
    public F_ComboBox()
    {
      InitializeComponent();
    }

    private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
    {
      MessageBox.Show(cb_transportes.Text);
    }

    private void btn_limparElementos_Click(object sender, EventArgs e)
    {
      cb_transportes.Items.Clear();
    }

    private void btn_resetarElementos_Click(object sender, EventArgs e)
    {
      List<string> transportes = new List<string>();
      transportes.Add("Avião");
      transportes.Add("Navio");
      transportes.Add("Carro");
      transportes.Add("Moto");
      transportes.Add("Bike");
      cb_transportes.Items.AddRange(transportes.ToArray());
    }

    private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
    {
      tb_adicionarElemento.Text=cb_transportes.Text;
    }

    private void btnt_adicionarElemento_Click(object sender, EventArgs e)
    {
      if (tb_adicionarElemento.Text != "")
      {
        if (cb_transportes.FindString(tb_adicionarElemento.Text) < 0)
        {
          _ = cb_transportes.Items.Add(tb_adicionarElemento.Text);
          tb_adicionarElemento.Clear();
        }
      }
    }
  }
}
