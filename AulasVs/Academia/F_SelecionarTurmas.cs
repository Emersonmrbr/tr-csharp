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
  public partial class F_SelecionarTurmas : Form
  {
    F_NovoAluno f_NovoAluno;
    public F_SelecionarTurmas(F_NovoAluno f)
    {
      InitializeComponent();
      f_NovoAluno = f;
    }

    private void F_SelecionarTurmas_Load(object sender, EventArgs e)
    {
      string query = string.Format(@"
        SELECT
          tbt.N_IDTURMA as 'ID',
          tbt.T_DSCTURMA as 'Turma',
          tbh.T_DSCHORARIO as 'Horario',
          tbp.T_NOMEPROFESSOR as 'Professor',
          tbt.N_MAXALUNOS as 'Máximo alunos',
          ( SELECT
              count(N_IDALUNO)
            FROM
              tb_alunos as tba
            WHERE
              tba.N_IDTURMA = tbt.N_IDTURMA and T_STATUS='A'          
          )as 'QTD alunos'

        FROM
          tb_turmas as tbt
        INNER JOIN
          tb_professores as tbp on tbp.N_IDPROFESSOR = tbt.N_IDPROFESSOR
        INNER JOIN
          tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO
      ");
      dgv_Turmas.DataSource = Banco.DQL(query);
    }

    private void dgv_Turmas_DoubleClick(object sender, EventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;

      if (dgv.SelectedRows.Count > 0)
      {
        int maximoAlunos = Convert.ToInt32(dgv.SelectedRows[0].Cells["Máximo alunos"].Value);
        int quantidadeAlunos = Convert.ToInt32(dgv.SelectedRows[0].Cells["QTD alunos"].Value);

        if (quantidadeAlunos >= maximoAlunos)
        {
          MessageBox.Show("Não há vagas nessa turma");
        }
        else
        {
          f_NovoAluno.ttb_Turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells["ID"].Value.ToString();
          f_NovoAluno.ttb_Turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells["Turma"].Value.ToString();
          Close();
        }
      }
    }
  }
}
