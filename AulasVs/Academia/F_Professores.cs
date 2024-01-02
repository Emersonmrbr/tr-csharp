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
  public partial class F_Professores : Form
  {
    public F_Professores()
    {
      InitializeComponent();
    }

    private void F_Professores_Load(object sender, EventArgs e)
    {
      string selectQuery = @"
       SELECT
        N_IDPROFESSOR as 'ID',
        T_NOMEPROFESSOR as 'Nome',
        T_TELEFONE as 'Telefone'
      FROM
       tb_professores
      ORDER BY
        T_NOMEPROFESSOR
      ";
      dgv_Professor.DataSource = Banco.DQL(selectQuery);

      dgv_Professor.Columns["ID"].Width = 60;
      dgv_Professor.Columns["Nome"].Width = 180;
      dgv_Professor.Columns["Telefone"].Width = 100;

    }

    private void dgv_Professor_SelectionChanged(object sender, EventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;

      if (dgv.SelectedRows.Count > 0)
      {
        string id = dgv.SelectedRows[0].Cells["ID"].Value.ToString();
        string selectQuery = $"SELECT * FROM tb_professores WHERE N_IDPROFESSOR={id}";

        DataTable dt = Banco.DQL(selectQuery);

        if (dt.Rows.Count > 0)
        {
          ttb_Id.Text = dt.Rows[0].Field<long>("N_IDPROFESSOR").ToString();
          ttb_Professor.Text = dt.Rows[0].Field<string>("T_NOMEPROFESSOR");
          mtb_Telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
        }
      }
    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_Novo_Click(object sender, EventArgs e)
    {
      ttb_Id.Clear();
      ttb_Professor.Clear();
      mtb_Telefone.Clear();
      ttb_Professor.Focus();
    }

    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      string query;
      if (string.IsNullOrEmpty(ttb_Id.Text))
      {
        query = $"INSERT INTO tb_professores (T_NOMEPROFESSOR, T_TELEFONE) VALUES ('{ttb_Professor.Text}','{mtb_Telefone.Text}')";
      }
      else
      {
        query = $"UPDATE tb_professores SET T_NOMEPROFESSOR='{ttb_Professor.Text}',T_TELEFONE='{mtb_Telefone.Text}' WHERE N_IDPROFESSOR='{ttb_Id.Text}'";
      }
      Banco.DML(query);

      string selectQuery = @"
       SELECT
        N_IDPROFESSOR as 'ID',
        T_NOMEPROFESSOR as 'Nome',
        T_TELEFONE as 'Telefone'
      FROM
       tb_professores
      ORDER BY
        T_NOMEPROFESSOR
      ";
      dgv_Professor.DataSource = Banco.DQL(selectQuery);
    }

    private void btn_Excluir_Click(object sender, EventArgs e)
    {
      DialogResult resposta = MessageBox.Show("Deseja excluir o dado?", "Excluir?", MessageBoxButtons.YesNo);
      if (resposta == DialogResult.Yes)
      {
        if (!string.IsNullOrEmpty(ttb_Id.Text))
        {
          int id = Convert.ToInt32(ttb_Id.Text);
          string deleteQuery = $"DELETE FROM tb_professores WHERE N_IDPROFESSOR= {id}";
          Banco.DML(deleteQuery);

          string selectQuery = @"
          SELECT
            N_IDPROFESSOR as 'ID',
            T_NOMEPROFESSOR as 'Nome',
            T_TELEFONE as 'Telefone'
          FROM
            tb_professores
          ORDER BY
            T_NOMEPROFESSOR
          ";
          dgv_Professor.DataSource = Banco.DQL(selectQuery);
        }
        else
        {
          MessageBox.Show("O ID não pode estar vazio para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

      }
    }
  }
}