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
  public partial class F_ListBox : Form
  {
    List<string> carros = new List<string>();
    public F_ListBox()
    {
      InitializeComponent();
      carros.Add("GTR");
      carros.Add("Imprenzza");
      carros.Add("Lancer");

      lt_carros.DataSource = carros;
    }

    private void btn_adicionarCarro_Click(object sender, EventArgs e)
    {
      if (tb_inserirCarro.Text == string.Empty)
      {
        _ = MessageBox.Show("Digite o carro desejado");
      }
      else
      {
        carros.Add(tb_inserirCarro.Text);
        lt_carros.DataSource = null;
        lt_carros.DataSource = carros;
      }
    }

    private void btn_remover_Click(object sender, EventArgs e)
    {
      carros.RemoveAt(lt_carros.SelectedIndex);
      lt_carros.DataSource = null;
      lt_carros.DataSource = carros;
    }

    private void btn_obter_Click(object sender, EventArgs e)
    {
      tb_inserirCarro.Text = lt_carros.SelectedItem.ToString();
    }

    private void btn_limpar_Click(object sender, EventArgs e)
    {
      carros.Clear();
      lt_carros.DataSource = null;
      lt_carros.DataSource = carros;
    }
  }
}
