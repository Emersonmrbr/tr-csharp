using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Academia
{
  public partial class F_GestaoTurmas : Form
  {
    private string idSelecionado;
    private bool novaTurma = false;

    public F_GestaoTurmas()
    {
      InitializeComponent();
    }

    private void F_GestaoTurmas_Load(object sender, EventArgs e)
    {
      CarregarTurmas();
      CarregarProfessores();
      CarregarStatus();
      CarregarHorarios();
    }

    private void CarregarTurmas()
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
    }

    private void CarregarProfessores()
    {
      string queryProfessor = @"
                SELECT
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    T_NOMEPROFESSOR
            ";

      cbb_Professor.DataSource = Banco.DQL(queryProfessor);
      cbb_Professor.DisplayMember = "T_NOMEPROFESSOR";
      cbb_Professor.ValueMember = "N_IDPROFESSOR";
    }

    private void CarregarStatus()
    {
      Dictionary<string, string> st = new Dictionary<string, string>
            {
                { "A", "Ativa" },
                { "P", "Paralisada" },
                { "C", "Cancelada" }
            };
      cbb_Status.DataSource = new BindingSource(st, null);
      cbb_Status.DisplayMember = "Value";
      cbb_Status.ValueMember = "Key";
    }

    private void CarregarHorarios()
    {
      string queryHorario = @"
                SELECT
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";

      cbb_Horario.DataSource = Banco.DQL(queryHorario);
      cbb_Horario.DisplayMember = "T_DSCHORARIO";
      cbb_Horario.ValueMember = "N_IDHORARIO";
    }

    private void dgv_Turmas_SelectionChanged(object sender, EventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;
      if (dgv.SelectedRows.Count > 0)
      {
        novaTurma = false;
        idSelecionado = dgv_Turmas.Rows[dgv_Turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
        PreencherCamposTurma();
        ttb_Vagas.Text = AtualizarQuantidadeVagas();
      }
    }

    private void PreencherCamposTurma()
    {
      string selectQuery = $"SELECT * FROM tb_turmas WHERE N_IDTURMA='{idSelecionado}'";

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

    private string AtualizarQuantidadeVagas()
    {
      string selectQuery = $@"
        SELECT
            COUNT(N_IDALUNO) AS QuantidadeVagas
        FROM
            tb_alunos
        WHERE
            T_STATUS='A' AND N_IDTURMA={idSelecionado}";

      DataTable dt = Banco.DQL(selectQuery);

      int vagasTotais = (int)Math.Round(nud_MaximoAluno.Value, 0);
      int vagasOcupadas = Convert.ToInt32(dt.Rows[0]["QuantidadeVagas"]);
      int vagasDisponiveis = vagasTotais - vagasOcupadas;

      return vagasDisponiveis.ToString();
    }


    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_Novo_Click(object sender, EventArgs e)
    {
      LimparCamposTurma();
      novaTurma = true;
    }

    private void LimparCamposTurma()
    {
      ttb_Nome.Clear();
      cbb_Professor.SelectedIndex = -1;
      nud_MaximoAluno.Value = 0;
      cbb_Horario.SelectedIndex = -1;
      cbb_Status.SelectedIndex = -1;
      ttb_Nome.Focus();
    }

    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      if (novaTurma)
      {
        InserirTurma();
      }
      else
      {
        AtualizarTurma();
      }
      CarregarTurmas();
    }

    private void InserirTurma()
    {
      string query = string.Format(@"
                INSERT INTO tb_turmas
                (T_DSCTURMA,N_IDPROFESSOR,N_IDHORARIO,N_MAXALUNOS,T_STATUS)
                VALUES ('{0}',{1},{2},{3},'{4}')",
          ttb_Nome.Text,
          cbb_Professor.SelectedValue,
          cbb_Horario.SelectedValue,
          int.Parse(Math.Round(nud_MaximoAluno.Value, 0).ToString()),
          cbb_Status.SelectedValue);
      Banco.DML(query);
      novaTurma = false;
    }

    private void AtualizarTurma()
    {
      string query = string.Format(@"
                UPDATE
                    tb_turmas
                SET
                    T_DSCTURMA='{0}',
                    N_IDPROFESSOR={1},
                    N_IDHORARIO={2},
                    N_MAXALUNOS={3},
                    T_STATUS='{4}'
                WHERE
                    N_IDTURMA='{5}'",
          ttb_Nome.Text,
          cbb_Professor.SelectedValue,
          cbb_Horario.SelectedValue,
          int.Parse(Math.Round(nud_MaximoAluno.Value, 0).ToString()),
          cbb_Status.SelectedValue.ToString(),
          idSelecionado);
      Banco.DML(query);
    }

    private void btn_Excluir_Click(object sender, EventArgs e)
    {
      DialogResult resposta = MessageBox.Show("Deseja excluir o dado?", "Excluir?", MessageBoxButtons.YesNo);
      if (resposta == DialogResult.Yes)
      {
        ExcluirTurma();
        CarregarTurmas();
      }
    }

    private void ExcluirTurma()
    {
      string queryDelete = string.Format(@"
                DELETE
                FROM
                    tb_turmas
                WHERE
                    N_IDTURMA={0}", idSelecionado);
      Banco.DML(queryDelete);
    }

    private void btn_Imprimir_Click(object sender, EventArgs e)
    {
      string nomeArquivo = Globais.caminho + @"\turmas.pdf";
      FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
      Document doc = new Document(PageSize.A4);
      PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

      iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\Logo.png");
      logo.ScaleToFit(140f, 120f);
      logo.Alignment = Element.ALIGN_LEFT;
      //logo.SetAbsolutePosition(100f, 600f);

      string dados = string.Empty;

      Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
      paragrafo1.Alignment = Element.ALIGN_CENTER;
      paragrafo1.Add("Relatório de turmas\n\n");

      Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12, (int)System.Drawing.FontStyle.Bold));
      paragrafo2.Alignment = Element.ALIGN_CENTER;
      paragrafo2.Add("Núcleo MAP - Curso de C#");

      PdfPTable tabela = new PdfPTable(3);
      tabela.DefaultCell.FixedHeight = 20;

      tabela.AddCell("ID");
      tabela.AddCell("Turma");
      tabela.AddCell("Horário");

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
      DataTable dt = Banco.DQL(selectQuery);

      for (int i = 0; i < dt.Rows.Count; i++)
      {
        tabela.AddCell(dt.Rows[i]["ID"].ToString());
        tabela.AddCell(dt.Rows[i]["Nome"].ToString());
        tabela.AddCell(dt.Rows[i]["Horário"].ToString());
      }

      doc.Open();
      doc.Add(logo);
      doc.Add(paragrafo1);
      doc.Add(tabela);
      doc.Add(paragrafo2);
      doc.Close();

      DialogResult resposta = MessageBox.Show("Desja abrir o relatório?", "Relatório", MessageBoxButtons.YesNo);
      if (resposta == DialogResult.Yes)
      {
        System.Diagnostics.Process.Start(Globais.caminho + @"\turmas.pdf");
      }

    }
  }
}