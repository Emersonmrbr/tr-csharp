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
  public partial class F_Veiculos : Form
  {
    F_Principal form_principal;
    public F_Veiculos(string V,F_Principal f_Principal)
    {
      InitializeComponent();
      Tb_ListaVeiculos.Text = V;
      form_principal = f_Principal;
      f_Principal.num = 10;
    }

    private void F_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
    {
      form_principal.Tb_listaVeiculos.Text = Tb_ListaVeiculos.Text;
    }
  }
}
