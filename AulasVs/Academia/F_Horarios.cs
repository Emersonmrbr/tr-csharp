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
  public partial class F_Horarios : Form
  {
    public F_Horarios()
    {
      InitializeComponent();
    }

    private void F_Horarios_Load(object sender, EventArgs e)
    {
      string selectQuery = @"
    SELECT
        N_IDHORARIO as 'ID',
        T_DSCHORARIO as 'Horário'
    FROM
        tb_horarios
    ORDER BY
        T_DSCHORARIO
    ";

      dgv_Horario.DataSource = Banco.DQL(selectQuery);
      dgv_Horario.Columns["ID"].Width = 60;
      dgv_Horario.Columns["Horário"].Width = 250;

    }

    private void dgv_Horario_SelectionChanged(object sender, EventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;

      if (dgv.SelectedRows.Count > 0)
      {
        string id = dgv.SelectedRows[0].Cells["ID"].Value.ToString();
        string query = $"SELECT * FROM tb_horarios WHERE N_IDHORARIO={id}";

        DataTable dt = Banco.DQL(query);

        if (dt.Rows.Count > 0)
        {
          ttb_ID.Text = dt.Rows[0].Field<long>("N_IDHORARIO").ToString();
          mtb_Horario.Text = dt.Rows[0].Field<string>("T_DSCHORARIO");
        }
      }

    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btn_Novo_Click(object sender, EventArgs e)
    {
      ttb_ID.Clear();
      mtb_Horario.Clear();
      mtb_Horario.Focus();
    }


    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      string query;

      if (string.IsNullOrEmpty(ttb_ID.Text))
      {
        query = $"INSERT INTO tb_horarios (T_DSCHORARIO) VALUES ('{mtb_Horario.Text}')";
      }
      else
      {
        query = $"UPDATE tb_horarios SET T_DSCHORARIO='{mtb_Horario.Text}' WHERE N_IDHORARIO={ttb_ID.Text}";
      }

      Banco.DML(query);

      string selectQuery = @"
        SELECT
          N_IDHORARIO as 'ID',
          T_DSCHORARIO as 'Horário'
        FROM
          tb_horarios
        ORDER BY
          T_DSCHORARIO
    ";

      dgv_Horario.DataSource = Banco.DQL(selectQuery);
    }


    private void btn_Excluir_Click(object sender, EventArgs e)
    {
      DialogResult resposta = MessageBox.Show("Deseja excluir o dado?", "Excluir?", MessageBoxButtons.YesNo);

      if (resposta == DialogResult.Yes)
      {
        if (!string.IsNullOrEmpty(ttb_ID.Text))
        {
          int id = Convert.ToInt32(ttb_ID.Text);

          string deleteQuery = $"DELETE FROM tb_horarios WHERE N_IDHORARIO={id}";
          Banco.DML(deleteQuery);

          string selectQuery = @"
            SELECT
                N_IDHORARIO as 'ID',
                T_DSCHORARIO as 'Horário'
            FROM
                tb_horarios
            ORDER BY
                T_DSCHORARIO
        ";

          dgv_Horario.DataSource = Banco.DQL(selectQuery);
        }
        else
        {
          MessageBox.Show("O ID não pode estar vazio para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
      }


    }
  }
}
