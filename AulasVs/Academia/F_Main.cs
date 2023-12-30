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
  public partial class F_Main : Form
  {
    public F_Main()
    {
      InitializeComponent();
      F_Login f_Login = new F_Login(this);
      f_Login.ShowDialog();
    }

    private void logonToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_Login f_Login = new F_Login(this);
      f_Login.ShowDialog();
    }

    private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
    {
      lbl_Acesso.Text = "0";
      lbl_NomeUsuario.Text = "---";
      img_Logado.Image = Properties.Resources.ledVermelho;
      Globais.nivel = 0;
      Globais.logado = false;
    }

    private void bancoDeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Globais.logado)
      {
        if (Globais.nivel >= 2)
        {
        }
        else
        {
          MessageBox.Show("Acesso negado");
        }
      }
      else
      {
        MessageBox.Show("É necessário estar logado");
      }
    }

    private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Globais.logado)
      {
        if (Globais.nivel >= 1)
        {
          F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
          f_NovoUsuario.ShowDialog();
        }
        else
        {
          MessageBox.Show("Acesso negado");
        }
      }
      else
      {
        MessageBox.Show("É necessário estar logado");
      }
    }

    private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Globais.logado)
      {
        if (Globais.nivel >= 1)
        {
          F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
          f_GestaoUsuarios.ShowDialog();
        }
        else
        {
          MessageBox.Show("Acesso negado");
        }
      }
      else
      {
        MessageBox.Show("É necessário estar logado");
      }
    }

    private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (Globais.logado)
      {

      }
      else
      {
        MessageBox.Show("É necessário estar logado");
      }
    }
  }
}
