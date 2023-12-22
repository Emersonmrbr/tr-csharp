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
  public partial class F_ListView : Form
  {
    public F_ListView()
    {
      InitializeComponent();
    }
    private void limpar()
    {
      tb_id.Clear();
      tb_produto.Clear();
      tb_quantidade.Clear();
      tb_preco.Clear();
      tb_id.Focus();
    }

    private void obter()
    {
      tb_id.Text = lsv_produtos.SelectedItems[0].SubItems[0].Text;
      tb_produto.Text = lsv_produtos.SelectedItems[0].SubItems[1].Text;
      tb_quantidade.Text = lsv_produtos.SelectedItems[0].SubItems[2].Text;
      tb_preco.Text = lsv_produtos.SelectedItems[0].SubItems[3].Text;
    }

    private void btn_adicionar_Click(object sender, EventArgs e)
    {
      if (tb_id.Text == string.Empty)
      {
        MessageBox.Show("ID não pode ser vazio");
        tb_id.Focus();
        return;
      }
      if (tb_produto.Text == string.Empty)
      {
        MessageBox.Show("Produto não pode ser vazio");
        tb_produto.Focus();
        return;
      }
      if (tb_quantidade.Text == string.Empty)
      {
        MessageBox.Show("Quantidade não pode ser vazio");
        tb_quantidade.Focus();
        return;
      }
      if (tb_preco.Text == string.Empty)
      {
        MessageBox.Show("Preço não pode ser vazio");
        tb_preco.Focus();
        return;
      }
      string[] produto = new string[4];
      produto[0] = tb_id.Text;
      produto[1] = tb_produto.Text;
      produto[2] = tb_quantidade.Text;
      produto[3] = tb_preco.Text;
      ListViewItem lista = new ListViewItem(produto);
      lsv_produtos.Items.Add(lista);
      limpar();
    }

    private void btn_remover_Click(object sender, EventArgs e)
    {
      lsv_produtos.Items.RemoveAt(lsv_produtos.SelectedIndices[0]);
    }

    private void btn_obter_Click(object sender, EventArgs e)
    {
      obter();
    }

    private void lsv_produtos_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lsv_produtos.SelectedItems.Count > 0)
      {
        obter();
      }
    }
  }
}
