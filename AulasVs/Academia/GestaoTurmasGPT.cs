using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

//namespace Academia
//{
//  public partial class F_GestaoTurmas : Form
//  {
//    //private string idSelecionado;
//    //private bool novaTurma = false;

//    public F_GestaoTurmas()
//    {
//      InitializeComponent();
//    }

//    private void F_GestaoTurmas_Load(object sender, EventArgs e)
//    {
//      CarregarTurmas();
//      CarregarProfessores();
//      CarregarStatus();
//      CarregarHorarios();
//    }

//    private void CarregarTurmas()
//    {
//      string selectQuery = @"
//                SELECT
//                    tbt.N_IDTURMA as 'ID',
//                    tbt.T_DSCTURMA as 'Nome',
//                    tbh.T_DSCHORARIO as 'Horário'
//                FROM
//                    tb_turmas as tbt
//                INNER JOIN
//                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
//                ORDER BY
//                    T_DSCTURMA
//            ";
//      dgv_Turmas.DataSource = Banco.DQL(selectQuery);
//      dgv_Turmas.Columns[0].Width = 60;
//      dgv_Turmas.Columns[1].Width = 190;
//      dgv_Turmas.Columns[2].Width = 90;
//    }

//    private void CarregarProfessores()
//    {
//      string queryProfessor = @"
//                SELECT
//                    N_IDPROFESSOR,
//                    T_NOMEPROFESSOR
//                FROM
//                    tb_professores
//                ORDER BY
//                    T_NOMEPROFESSOR
//            ";

//      cbb_Professor.DataSource = Banco.DQL(queryProfessor);
//      cbb_Professor.DisplayMember = "T_NOMEPROFESSOR";
//      cbb_Professor.ValueMember = "N_IDPROFESSOR";
//    }

//    private void CarregarStatus()
//    {
//      Dictionary<string, string> st = new Dictionary<string, string>
//            {
//                { "A", "Ativa" },
//                { "P", "Paralisada" },
//                { "C", "Cancelar" }
//            };
//      cbb_Status.DataSource = new BindingSource(st, null);
//      cbb_Status.DisplayMember = "Value";
//      cbb_Status.ValueMember = "Key";
//    }

//    private void CarregarHorarios()
//    {
//      string queryHorario = @"
//                SELECT
//                    *
//                FROM
//                    tb_horarios
//                ORDER BY
//                    T_DSCHORARIO
//            ";

//      cbb_Horario.DataSource = Banco.DQL(queryHorario);
//      cbb_Horario.DisplayMember = "T_DSCHORARIO";
//      cbb_Horario.ValueMember = "N_IDHORARIO";
//    }

//    private void dgv_Turmas_SelectionChanged(object sender, EventArgs e)
//    {
//      DataGridView dgv = (DataGridView)sender;
//      if (dgv.SelectedRows.Count > 0)
//      {
//        novaTurma = false;
//        idSelecionado = dgv_Turmas.Rows[dgv_Turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
//        PreencherCamposTurma();
//      }
//    }

//    private void PreencherCamposTurma()
//    {
//      string selectQuery = $"SELECT * FROM tb_turmas WHERE N_IDTURMA='{idSelecionado}'";

//      DataTable dt = Banco.DQL(selectQuery);
//      if (dt.Rows.Count > 0)
//      {
//        ttb_Nome.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
//        cbb_Professor.SelectedValue = dt.Rows[0].Field<long>("N_IDPROFESSOR").ToString();
//        nud_MaximoAluno.Value = dt.Rows[0].Field<long>("N_MAXALUNOS");
//        cbb_Status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
//        cbb_Horario.SelectedValue = dt.Rows[0].Field<long>("N_IDHORARIO").ToString();
//      }
//    }

//    private void btn_Fechar_Click(object sender, EventArgs e)
//    {
//      Close();
//    }

//    private void btn_Novo_Click(object sender, EventArgs e)
//    {
//      LimparCamposTurma();
//      novaTurma = true;
//    }

//    private void LimparCamposTurma()
//    {
//      ttb_Nome.Clear();
//      cbb_Professor.SelectedIndex = -1;
//      nud_MaximoAluno.Value = 0;
//      cbb_Horario.SelectedIndex = -1;
//      cbb_Status.SelectedIndex = -1;
//      ttb_Nome.Focus();
//    }

//    private void btn_Salvar_Click(object sender, EventArgs e)
//    {
//      if (novaTurma)
//      {
//        InserirTurma();
//      }
//      else
//      {
//        AtualizarTurma();
//      }
//      CarregarTurmas();
//    }

//    private void InserirTurma()
//    {
//      string query = string.Format(@"
//                INSERT INTO tb_turmas
//                (T_DSCTURMA,N_IDPROFESSOR,N_IDHORARIO,N_MAXALUNOS,T_STATUS)
//                VALUES ('{0}',{1},{2},{3},'{4}')",
//          ttb_Nome.Text,
//          cbb_Professor.SelectedValue,
//          cbb_Horario.SelectedValue,
//          int.Parse(Math.Round(nud_MaximoAluno.Value, 0).ToString()),
//          cbb_Status.SelectedValue);
//      Banco.DML(query);
//      novaTurma = false;
//    }

//    private void AtualizarTurma()
//    {
//      string query = string.Format(@"
//                UPDATE
//                    tb_turmas
//                SET
//                    T_DSCTURMA='{0}',
//                    N_IDPROFESSOR={1},
//                    N_IDHORARIO={2},
//                    N_MAXALUNOS={3},
//                    T_STATUS='{4}'
//                WHERE
//                    N_IDTURMA='{5}'",
//          ttb_Nome.Text,
//          cbb_Professor.SelectedValue,
//          cbb_Horario.SelectedValue,
//          int.Parse(Math.Round(nud_MaximoAluno.Value, 0).ToString()),
//          cbb_Status.SelectedValue.ToString(),
//          idSelecionado);
//      Banco.DML(query);
//    }

//    private void btn_Excluir_Click(object sender, EventArgs e)
//    {
//      DialogResult resposta = MessageBox.Show("Deseja excluir o dado?", "Excluir?", MessageBoxButtons.YesNo);
//      if (resposta == DialogResult.Yes)
//      {
//        ExcluirTurma();
//        CarregarTurmas();
//      }
//    }

//    private void ExcluirTurma()
//    {
//      string queryDelete = string.Format(@"
//                DELETE
//                FROM
//                    tb_turmas
//                WHERE
//                    N_IDTURMA={0}", idSelecionado);
//      Banco.DML(queryDelete);
//    }
//  }
//}
