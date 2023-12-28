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
  public partial class F_TabControl : Form
  {
    public F_TabControl()
    {
      InitializeComponent();
    }

    private void Btn_novaGuia_Click(object sender, EventArgs e)
    {
      if (Ttb_novaGuia.Text != string.Empty)
      {
        TabPage pagina = new TabPage();
        pagina.Text = Ttb_novaGuia.Text;
        pagina.Name = Ttb_novaGuia.Text;
        pagina.TabIndex = tabControl1.TabPages.Count;
        tabControl1.TabPages.Add(pagina);
        Ttb_novaGuia.Clear();
        DefinirMaximo();
      }
      else
      {
        MessageBox.Show("Digite o nome da guia");
        Ttb_novaGuia.Focus();
      }
    }

    private void Btn_RemoverGuiaAtual_Click(object sender, EventArgs e)
    {
      tabControl1.TabPages.Remove(tabControl1.SelectedTab);
      DefinirMaximo();
    }

    private void Btn_PosicionarGuia_Click(object sender, EventArgs e)
    {
      tabControl1.SelectedIndex = Int32.Parse(Nud_Guia.Value.ToString());
    }
    private void DefinirMaximo()
    {
      Nud_Guia.Maximum = tabControl1.TabPages.Count - 1;
    }

    private void F_TabControl_Load(object sender, EventArgs e)
    {
      DefinirMaximo();
    }
  }
}
