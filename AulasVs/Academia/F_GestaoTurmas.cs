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
  public partial class F_GestaoTurmas : Form
  {
    string idSelecionado = string.Empty;
    public F_GestaoTurmas()
    {
      InitializeComponent();
    }

    private void F_GestaoTurmas_Load(object sender, EventArgs e)
    {
      string selectQuery = @"
       SELECT
        tbt.N_IDTURMA as 'ID',
        tbt.T_DSCTURMA as 'Nome',
        tbh.T_DSCHORARIO as 'Horário'
      FROM
        tb_turmas as tbt
      INNER JOIN
        tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
      ORDER BY
        T_DSCTURMA
      ";
      dgv_Turmas.DataSource = Banco.DQL(selectQuery);
      dgv_Turmas.Columns[0].Width = 60;
      dgv_Turmas.Columns[1].Width = 190;
      dgv_Turmas.Columns[2].Width = 90;

      //Popular ComboBox Professores
      string queryProfessor = @"
       SELECT
        N_IDPROFESSOR,
        T_NOMEPROFESSOR
      FROM
       tb_professores
      ORDER BY
        T_NOMEPROFESSOR
      ";

      cbb_Professor.Items.Clear();
      cbb_Professor.DataSource = Banco.DQL(queryProfessor);
      cbb_Professor.DisplayMember = "T_NOMEPROFESSOR";
      cbb_Professor.ValueMember = "N_IDPROFESSOR";
      Console.WriteLine("Professores carregado");

      //Popular ComboBox Status (Ativa = A, Paralisada = P, Cancelada = C)
      Dictionary<string, string> st = new Dictionary<string, string>
      {
        { "A", "Ativa" },
        { "P", "Paralisada" },
        { "C", "Cancelar" }
      };
      cbb_Status.Items.Clear();
      cbb_Status.DataSource = new BindingSource(st, null);
      cbb_Status.DisplayMember = "Value";
      cbb_Status.ValueMember = "Key";

      //Popular ComboBos Horários
      string queryHorario = @"
       SELECT
        *
      FROM
        tb_horarios
      ORDER BY
        T_DSCHORARIO
      ";

      cbb_Horario.Items.Clear();
      cbb_Horario.DataSource = Banco.DQL(queryHorario);
      cbb_Horario.DisplayMember = "T_DSCHORARIO";
      cbb_Horario.ValueMember = "N_IDHORARIO";
    }

    private void dgv_Turmas_SelectionChanged(object sender, EventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;
      if (dgv.SelectedRows.Count > 0)
      {
        string id = dgv.SelectedRows[0].Cells["ID"].Value.ToString();
        string selectQuery = $"SELECT * FROM tb_turmas WHERE N_IDTURMA={id}";

        DataTable dt = Banco.DQL(selectQuery);
        if (dt.Rows.Count > 0)
        {
          ttb_Nome.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
          cbb_Professor.SelectedValue = dt.Rows[0].Field<long>("N_IDPROFESSOR").ToString();
          nud_MaximoAluno.Value = dt.Rows[0].Field<long>("N_MAXALUNOS");
          cbb_Status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
          cbb_Horario.SelectedValue = dt.Rows[0].Field<long>("N_IDHORARIO").ToString();
        }
      }
    }
  }
}
