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
  public partial class F_GestaoAlunos : Form
  {
    private string idSelecionado { get; set; } = string.Empty;
    private string turma { get; set; } = string.Empty;
    private string turmaAtual { get; set; } = string.Empty;
    private int linha { get; set; } = 0;
    string origemFoto { get; set; } = string.Empty;
    string destinoFoto { get; set; } = string.Empty;
    bool fotoSelecionada { get; set; } = false;
    public F_GestaoAlunos()
    {
      InitializeComponent();
      ofd_Foto.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
    }

    private void F_GestaoAlunos_Load(object sender, EventArgs e)
    {
      CarregarAlunos();
      CarregarTurmas();
      CarregarStatus();
    }

    private void CarregarAlunos()
    {
      var selectQuery = new StringBuilder();
      selectQuery.AppendLine("SELECT");
      selectQuery.AppendLine("N_IDALUNO as 'ID',");
      selectQuery.AppendLine("T_NOMEALUNO as 'Aluno'");
      selectQuery.AppendLine("FROM");
      selectQuery.AppendLine("tb_alunos");
      selectQuery.AppendLine("ORDER BY");
      selectQuery.AppendLine("T_NOMEALUNO");
      dgv_Alunos.DataSource = Banco.DQL(selectQuery.ToString());
      dgv_Alunos.Columns[0].Width = 40;
      dgv_Alunos.Columns[1].Width = 120;
      ttb_Nome.Text = dgv_Alunos.Rows[dgv_Alunos.SelectedRows[0].Index].Cells[1].Value.ToString();
    }

    private void CarregarTurmas()
    {
      string queryTurmas = @"
      SELECT
        N_IDTURMA,
        ('Vagas: '|| (
                       (N_MAXALUNOS) - (
                                          SELECT
                                            count(tba.N_IDALUNO)
                                          FROM
                                            tb_alunos as tba
                                          WHERE
                                            tba.T_STATUS='A' AND tba.N_IDTURMA=tbt.N_IDTURMA
                                        )
                      ) || ' / Turmas: ' || T_DSCTURMA
        ) as 'Turma'
      FROM
        tb_turmas as tbt
      ORDER BY
        N_IDTURMA";
      cob_Turmas.Items.Clear();
      cob_Turmas.DataSource = Banco.DQL(queryTurmas);
      cob_Turmas.DisplayMember = "Turma";
      cob_Turmas.ValueMember = "N_IDTURMA";
    }
    private void CarregarStatus()
    {
      Dictionary<string, string> st = new Dictionary<string, string>
            {
                { "A", "Ativo" },
                { "B", "Bloqueado" },
                { "C", "Cancelado" }
            };
      cbb_Status.DataSource = new BindingSource(st, null);
      cbb_Status.DisplayMember = "Value";
      cbb_Status.ValueMember = "Key";

      turma = cob_Turmas.Text;
      turmaAtual = cob_Turmas.Text;
      idSelecionado = dgv_Alunos.Rows[0].Cells[1].Value.ToString();
    }

    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      if (!fotoSelecionada && MessageBox.Show("Sem foto do aluno selecionada, deseja continuar?", "Alerta", MessageBoxButtons.YesNo) == DialogResult.No)
      {
        return;
      }

      turma = cob_Turmas.Text;
      if (turmaAtual != turma || peb_Foto.ImageLocation != destinoFoto)
      {
        string[] t = turma.Split(' ');
        if (int.TryParse(t[1], out int vagas) && vagas < 1)
        {
          MessageBox.Show("Não há vagas na turma selecionada, seleciona outra turma");
          cob_Turmas.Focus();
          return;
        }
        linha = dgv_Alunos.SelectedRows[0].Index;
        string query = string.Format(@"
          UPDATE
            tb_alunos
          SET
            T_NOMEALUNO='{0}',
            T_TELEFONE='{1}',
            T_STATUS='{2}',
            N_IDTURMA='{3}',
            T_FOTO='{4}'
          WHERE
            N_IDALUNO={5}", ttb_Nome.Text, mtb_Telefone.Text, cbb_Status.SelectedValue, cob_Turmas.SelectedValue, destinoFoto, idSelecionado);
        Banco.DML(query);
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
        dgv_Alunos[1, linha].Value = ttb_Nome.Text;
      }
    }

    private void btn_Excluir_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("Deseja excluir o item?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
      {
        if (File.Exists(peb_Foto.ImageLocation))
        {
          File.Delete(peb_Foto.ImageLocation);
        }
        string query = String.Format(@"
          DELETE FROM
            tb_alunos
          WHERE
            N_IDALUNO={0}", idSelecionado);
        Banco.DML(query);
        dgv_Alunos.Rows.Remove(dgv_Alunos.CurrentRow);
      }
    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void dgv_Alunos_SelectionChanged(object sender, EventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;
      if (dgv.SelectedRows.Count > 0)
      {
        idSelecionado = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
        string query = String.Format(@"
          SELECT
            N_IDALUNO,
            T_NOMEALUNO,
            T_TELEFONE,
            T_STATUS,
            N_IDTURMA,
            T_FOTO
          FROM
            tb_alunos
          WHERE N_IDALUNO={0}", idSelecionado);
        DataTable dt = Banco.DQL(query);
        ttb_Nome.Text = dt.Rows[0]["T_NOMEALUNO"].ToString();
        mtb_Telefone.Text = dt.Rows[0]["T_TELEFONE"].ToString();
        cbb_Status.SelectedValue = dt.Rows[0]["T_STATUS"].ToString();
        cob_Turmas.SelectedValue = Convert.ToInt32(dt.Rows[0]["N_IDTURMA"]);
        turmaAtual = cob_Turmas.Text;
        peb_Foto.ImageLocation = dt.Rows[0]["T_FOTO"].ToString();
      }
    }

    private void peb_Foto_DoubleClick(object sender, EventArgs e)
    {

      while (ofd_Foto.ShowDialog() == DialogResult.OK)
      {
        if (File.Exists(peb_Foto.ImageLocation))
        {
          File.Delete(peb_Foto.ImageLocation);
        }
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
