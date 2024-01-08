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
  public partial class F_GestaoAlunos : Form
  {
    private string idSelecionado;
    private bool novoAluno = false;
    public F_GestaoAlunos()
    {
      InitializeComponent();
    }

    private void F_GestaoAlunos_Load(object sender, EventArgs e)
    {
      CarregarAlunos();
      CarregarTurmas();
      CarregarStatus();
    }

    private void CarregarAlunos()
    {
      string selectQuery = @"
        SELECT
          N_IDALUNO as 'ID',
          T_NOMEALUNO as 'Aluno'
        FROM
          tb_alunos
        ORDER BY
          T_NOMEALUNO
      ";
      dgv_Alunos.DataSource = Banco.DQL(selectQuery);
      dgv_Alunos.Columns[0].Width = 40;
      dgv_Alunos.Columns[1].Width = 120;
      ttb_Nome.Text = dgv_Alunos.Rows[dgv_Alunos.SelectedRows[0].Index].Cells[1].Value.ToString();
    }

    private void CarregarTurmas()
    {
      string query = @"
      SELECT
        N_IDTURMA,
        ('Vagas: '||(
                      (N_MAXALUNOS)-(
                        SELECT
                          count(tba.N_IDALUNO)
                        FROM
                          tb_alunos as tba
                        WHERE
                          tba.T_STATUS='A' and tba.N_IDTURMA=N_IDTURMA
                      )
                    ) || ' / Turmas: ' || T_DSCTURMA
        )as 'Turma'
      FROM
        tb_turmas
      ORDER BY
        N_IDTURMA";
      cob_Turmas.Items.Clear();
      cob_Turmas.DataSource = Banco.DQL(query);
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
    }
  }
}
