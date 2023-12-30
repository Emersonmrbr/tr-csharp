using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
  public partial class F_NovoUsuario : Form
  {
    public F_NovoUsuario()
    {
      InitializeComponent();
    }

    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      Usuario usuario = new Usuario();
      usuario.T_NOMEUSUARIO = ttb_Nome.Text;
      usuario.T_APELIDOUSUARIO = ttb_Apelido.Text;
      usuario.T_SENHAUSUARIO = ttb_Senha.Text;
      usuario.N_NIVELUSUARIO = Convert.ToInt32(Math.Round(nud_Nivel.Value, 0));
      usuario.T_STATUSUSUARIO = cob_Status.Text;

      Banco.NovoUsuario(usuario);
    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_Cancelar_Click(object sender, EventArgs e)
    {
      ttb_Nome.Clear();
      ttb_Apelido.Clear();
      ttb_Senha.Clear();
      cob_Status.Text = string.Empty;
      nud_Nivel.Value = 0;
      ttb_Nome.Focus();
    }

    private void btn_Novo_Click(object sender, EventArgs e)
    {
      ttb_Nome.Clear();
      ttb_Apelido.Clear();
      ttb_Senha.Clear();
      cob_Status.Text = string.Empty;
      nud_Nivel.Value = 0;
      ttb_Nome.Focus();
    }
  }
}
