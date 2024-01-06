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
  public partial class F_NovoAluno : Form
  {
    public F_NovoAluno()
    {
      InitializeComponent();
    }

    private void F_NovoAluno_Load(object sender, EventArgs e)
    {
      Dictionary<string, string> st = new Dictionary<string, string>
            {
                { "A", "Ativa" },
                { "B", "Bloqueado" },
                { "C", "Cancelado" }
            };
      cob_Status.DataSource = new BindingSource(st, null);
      cob_Status.DisplayMember = "Value";
      cob_Status.ValueMember = "Key";
    }

    private void btn_Novo_Click(object sender, EventArgs e)
    {
      ttb_Nome.Enabled = true;
      mtb_Telefone.Enabled = true;
      cob_Status.Enabled = true;
      btn_SelecionarPlano.Enabled = true;
      btn_SelecionarTurma.Enabled = true;
      btn_Salvar.Enabled = true;
      ttb_Nome.Clear();
      mtb_Telefone.Clear();
      cob_Status.SelectedIndex = 0;
      ttb_Nome.Focus();
      btn_Cancelar.Enabled = true;
      btn_Novo.Enabled = false;
    }

    private void btn_Cancelar_Click(object sender, EventArgs e)
    {
      ttb_Nome.Enabled = false;
      mtb_Telefone.Enabled = false;
      cob_Status.Enabled = false;
      btn_SelecionarPlano.Enabled = false;
      btn_SelecionarTurma.Enabled = false;
      ttb_Nome.Clear();
      mtb_Telefone.Clear();
      cob_Status.SelectedIndex = 0;
      btn_Salvar.Enabled = false;
      btn_Cancelar.Enabled = false;
      btn_Novo.Enabled = true;
    }

    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      string query = string.Format(@"
        INSERT INTO tb_alunos
          (T_NOMEALUNO,T_TELEFONE,T_STATUS,N_IDTURMA)
        VALUES ('{0}','{1}','{2}',{3})", ttb_Nome.Text, mtb_Telefone.Text, cob_Status.SelectedValue, ttb_Turma.Tag.ToString());
      Banco.DML(query);


      ttb_Nome.Enabled = false;
      mtb_Telefone.Enabled = false;
      cob_Status.Enabled = false;
      btn_SelecionarPlano.Enabled = false;
      btn_SelecionarTurma.Enabled = false;
      ttb_Nome.Clear();
      mtb_Telefone.Clear();
      cob_Status.SelectedIndex = 0;
      btn_Salvar.Enabled = false;
      btn_Cancelar.Enabled = false;
      btn_Novo.Enabled = true;
    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
