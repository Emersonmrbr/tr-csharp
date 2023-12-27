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
  public partial class F_WebBrowser : Form
  {
    string home;
    public F_WebBrowser()
    {
      InitializeComponent();
    }
    private void Navegar()
    {
      if (!string.IsNullOrEmpty(ttb_barraPesquisa.Text))
      {
        Wbb_browser.Navigate(ttb_barraPesquisa.Text);
      }
      else
      {
        MessageBox.Show("Digite uma URL");
        ttb_barraPesquisa.Focus();
      }
    }

    private void Btnt_ir_Click(object sender, EventArgs e)
    {
      Navegar();
    }

    private void ttb_barraPesquisa_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        Navegar();
      }
    }

    private void Btnt_home_Click(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(home))
      {

        Wbb_browser.GoHome();
      }
      else
      {
        Wbb_browser.Navigate(ttb_barraPesquisa.Text);
      }
    }

    private void Btnt_voltar_Click(object sender, EventArgs e)
    {
      Wbb_browser.GoBack();

    }

    private void Btn_avancar_Click(object sender, EventArgs e)
    {
      Wbb_browser.GoForward();
    }
    private void wbb_browser_CanGoForwardChange(object sender, EventArgs e)
    {
      Btn_avancar.Enabled = Wbb_browser.CanGoForward;
    }
    private void wbb_browser_CanGoBackChange(object sender, EventArgs e)
    {
      Btn_voltar.Enabled = Wbb_browser.CanGoBack;
    }

    private void Btn_parar_Click(object sender, EventArgs e)
    {
      Wbb_browser.Stop();
    }

    private void Btn_atualizar_Click(object sender, EventArgs e)
    {
      Wbb_browser.Refresh();
    }

    private void Btn_pesquisar_Click(object sender, EventArgs e)
    {
      Wbb_browser.GoSearch();
    }

    private void Btn_definirHome_Click(object sender, EventArgs e)
    {
      home = ttb_barraPesquisa.Text;

    }
  }
}
