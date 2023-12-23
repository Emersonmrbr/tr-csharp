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
      _ = f_Veiculos.ShowDialog();
    }

    private void Btn_valNum_Click(object sender, EventArgs e)
    {
      MessageBox.Show(num.ToString());
    }

    private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_Checkbox f_Checkbox = new F_Checkbox();
      _ = f_Checkbox.ShowDialog();
    }

    private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
      _ = f_CheckedListBox.ShowDialog();
    }

    private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_ComboBox f_ComboBox = new F_ComboBox();
      _ = f_ComboBox.ShowDialog();
    }

    private void dataTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
      _ = f_DateTimePicker.ShowDialog();
    }

    private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_LinkLabel f_LinkLabel = new F_LinkLabel();
      _ = f_LinkLabel.ShowDialog();
    }

    private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_ListBox f_ListBox = new F_ListBox();
      f_ListBox.ShowDialog();
    }

    private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_ListView f_ListView = new F_ListView();
      f_ListView.ShowDialog();
    }

    private void makedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();
      f_MaskedTextBox.ShowDialog();
    }
  }
}
