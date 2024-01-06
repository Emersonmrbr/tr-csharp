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
    private void AbreFormulario(int nivel, Form form)
    {
      if (Globais.logado)
      {
        if (Globais.nivel >= nivel)
        {
          form.ShowDialog();
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
      //AbreFormulario();
    }

    private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
      AbreFormulario(1, f_NovoUsuario);
    }

    private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_GestaoUsuarios f_GestaoUsuarios = new F_GestaoUsuarios();
      AbreFormulario(1, f_GestaoUsuarios);
    }

    private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_NovoAluno f_NovoAluno = new F_NovoAluno();
      AbreFormulario(1, f_NovoAluno);
    }

    private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_Horarios f_Horarios = new F_Horarios();
      AbreFormulario(2, f_Horarios);
    }

    private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_Professores f_Professores = new F_Professores();
      AbreFormulario(2, f_Professores);
    }

    private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
      AbreFormulario(2, f_GestaoTurmas);
    }

  }
}
