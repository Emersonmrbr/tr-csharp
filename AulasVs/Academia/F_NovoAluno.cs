using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Academia
{
  public partial class F_NovoAluno : Form
  {
    public F_NovoAluno()
    {
      InitializeComponent();
      InicializarComboBoxStatus();
      ofd_Foto.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
    }

    private void InicializarComboBoxStatus()
    {
      Dictionary<string, string> status = new Dictionary<string, string>
            {
                { "A", "Ativa" },
                { "B", "Bloqueado" },
                { "C", "Cancelado" }
            };
      cob_Status.DataSource = new BindingSource(status, null);
      cob_Status.DisplayMember = "Value";
      cob_Status.ValueMember = "Key";
    }

    private void ConfigurarControles(bool novoHabilitado, bool salvarHabilitado, bool cancelarHabilitado)
    {
      btn_Cancelar.Enabled = cancelarHabilitado;
      btn_Novo.Enabled = novoHabilitado;
      btn_Salvar.Enabled = salvarHabilitado;
      btn_SelecionarPlano.Enabled = salvarHabilitado;
      btn_SelecionarTurma.Enabled = salvarHabilitado;
      cob_Status.Enabled = salvarHabilitado;
      cob_Status.SelectedIndex = 0;
      mtb_Telefone.Clear();
      mtb_Telefone.Enabled = salvarHabilitado;
      ttb_Nome.Clear();
      ttb_Nome.Enabled = salvarHabilitado;
      ttb_Nome.Focus();
      ttb_Plano.Clear();
      ttb_Turma.Clear();
    }

    private void btn_Novo_Click(object sender, EventArgs e)
    {
      ConfigurarControles(false, true, true);
    }

    private void btn_Cancelar_Click(object sender, EventArgs e)
    {
      ConfigurarControles(true, false, false);
    }

    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      string query = $@"
                INSERT INTO tb_alunos
                    (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA)
                VALUES ('{ttb_Nome.Text}', '{mtb_Telefone.Text}', '{cob_Status.SelectedValue}', {ttb_Turma.Tag})";

      Banco.DML(query);

      ConfigurarControles(true, false, false);
    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_SelecionarTurma_Click(object sender, EventArgs e)
    {
      F_SelecionarTurmas f_SelecionarTurmas = new F_SelecionarTurmas(this);
      f_SelecionarTurmas.ShowDialog();
    }

    private void btn_Foto_Click(object sender, EventArgs e)
    {
      if (ofd_Foto.ShowDialog() == DialogResult.OK)
      {
        if (File.Exists(Path.Combine(Globais.caminhoFoto, ofd_Foto.SafeFileName)))
        {
          if (MessageBox.Show("Arquivo existe, deseja substituir", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
          {
            return;
          }
        }
        System.IO.File.Copy(ofd_Foto.FileName, Path.Combine(Globais.caminhoFoto, ofd_Foto.SafeFileName), true);
        if (File.Exists(Path.Combine(Globais.caminhoFoto, ofd_Foto.SafeFileName)))
        {
          peb_Foto.ImageLocation = Path.Combine(Globais.caminhoFoto, ofd_Foto.FileName);
        }
        else
        {
          MessageBox.Show("Arquivo não copiado");
        }
      }
    }
  }
}
