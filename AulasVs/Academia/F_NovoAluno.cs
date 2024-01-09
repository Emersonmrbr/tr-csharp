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
    string origemFoto { get; set; } = string.Empty;
    string destinoFoto { get; set; } = string.Empty;
    bool fotoSelecionada { get; set; } = false;
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
      btn_Foto.Enabled = salvarHabilitado;
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
      if (!fotoSelecionada && MessageBox.Show("Sem foto do aluno selecionada, deseja continuar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.No)
      {
        return;
      }

      try
      {
        System.IO.File.Copy(origemFoto, destinoFoto, true);

        if (File.Exists(destinoFoto))
        {
          peb_Foto.ImageLocation = destinoFoto;
        }
        else
        {
          if (MessageBox.Show("Erro ao localizar foto, deseja continuar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.No)
          {
            return;
          }
        }

        string query = $@"
            INSERT INTO tb_alunos
                (T_NOMEALUNO, T_TELEFONE, T_STATUS, N_IDTURMA, T_FOTO)
            VALUES ('{ttb_Nome.Text}', '{mtb_Telefone.Text}', '{cob_Status.SelectedValue}', {ttb_Turma.Tag},'{destinoFoto}')";

        Banco.DML(query);

        ConfigurarControles(true, false, false);
      }
      catch (Exception ex)
      {
        MessageBox.Show($"Erro ao salvar aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
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
      while (ofd_Foto.ShowDialog() == DialogResult.OK)
      {
        origemFoto = ofd_Foto.FileName;
        destinoFoto = Path.Combine(Globais.caminhoFoto, ofd_Foto.SafeFileName);
        if (File.Exists(destinoFoto))
        {
          if (MessageBox.Show("Arquivo existe, deseja substituir", "Substituir", MessageBoxButtons.YesNo) == DialogResult.Yes)
          {
            peb_Foto.ImageLocation = origemFoto;
            fotoSelecionada = true;
            return;
          }
          else
          {
            fotoSelecionada = false;
          }
        }
        else
        {
          peb_Foto.ImageLocation = origemFoto;
          fotoSelecionada = true;
          return;
        }
      }
    }
  }
}
