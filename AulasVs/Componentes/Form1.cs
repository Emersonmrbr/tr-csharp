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
  public partial class F_Principal : Form
  {
    public int num;
    public F_Principal()
    {
      InitializeComponent();
      num = 0;
    }

    private void Btn_Adicionar_Click(object sender, EventArgs e)
    {
            if (Tb_Veiculo.Text == "")
            {
              MessageBox.Show("Digite um veículo");
              Tb_Veiculo.Focus();
              return;
            }

      Tb_listaVeiculos.Text += Tb_Veiculo.Text + ", ";
      Tb_Veiculo.Clear();
      Tb_Veiculo.Focus();
        }

    private void Btn_Limpar_Click(object sender, EventArgs e)
    {
      Tb_listaVeiculos.Clear();
      Tb_Veiculo.Clear();
      Tb_Veiculo.Focus();
    }

    private void Btn_Mostrar_Click(object sender, EventArgs e)
    {
      F_Veiculos f_Veiculos = new F_Veiculos(Tb_listaVeiculos.Text,this);
      f_Veiculos.ShowDialog();
    }

    private void Btn_valNum_Click(object sender, EventArgs e)
    {
      MessageBox.Show(num.ToString());
    }

    private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_Checkbox f_Checkbox = new F_Checkbox();
      f_Checkbox.ShowDialog();
    }

    private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
      f_CheckedListBox.ShowDialog();
    }

    private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_ComboBox f_ComboBox = new F_ComboBox();
      f_ComboBox.ShowDialog();
    }
  }
}
