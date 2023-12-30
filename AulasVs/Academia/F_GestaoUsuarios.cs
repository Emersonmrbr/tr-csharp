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
  public partial class F_GestaoUsuarios : Form
  {
    public F_GestaoUsuarios()
    {
      InitializeComponent();
    }

    private void btn_Fechar_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void F_GestaoUsuarios_Load(object sender, EventArgs e)
    {
      dgv_Usuarios.DataSource = Banco.ObterTodosUsuariosIdNome();
      dgv_Usuarios.Columns[0].Width = 80;
      dgv_Usuarios.Columns[1].Width = 250;
    }

    private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
    {
      DataGridView dgv = (DataGridView)sender;
      int quantidadeLinhas = dgv.SelectedRows.Count;
      if (quantidadeLinhas > 0)
      {
        DataTable dt = new DataTable();
        string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
        dt = Banco.ObterDadosUsuario(vid);
        ttb_ID.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
        ttb_Nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");
        ttb_Apelido.Text = dt.Rows[0].Field<string>("T_APELIDOUSUARIO");
        ttb_Senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO");
        cob_Status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO");
        nud_Nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");

      }
    }
  }
}
