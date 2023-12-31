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

    private void btn_Novo_Click(object sender, EventArgs e)
    {
      F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
      f_NovoUsuario.ShowDialog();
      dgv_Usuarios.DataSource = Banco.ObterTodosUsuariosIdNome();
    }

    private void btn_Salvar_Click(object sender, EventArgs e)
    {
      int linha = dgv_Usuarios.SelectedRows[0].Index;
      Usuario usuario = new Usuario
      {
        N_IDUSUARIO = Convert.ToInt32(ttb_ID.Text),
        T_NOMEUSUARIO = ttb_Nome.Text,
        T_APELIDOUSUARIO = ttb_Apelido.Text,
        T_SENHAUSUARIO = ttb_Senha.Text,
        T_STATUSUSUARIO = cob_Status.Text,
        N_NIVELUSUARIO = Convert.ToInt32(Math.Round(nud_Nivel.Value, 0)),
      };
      Banco.AtualizarUsuario(usuario);
      dgv_Usuarios.DataSource = Banco.ObterTodosUsuariosIdNome();
      dgv_Usuarios.CurrentCell = dgv_Usuarios[0, linha];
    }

    private void btn_Excluir_Click(object sender, EventArgs e)
    {
      DialogResult resultado = MessageBox.Show("Tem serteza que deseja excluir?", "Excluir dados", MessageBoxButtons.YesNo);
      if (resultado == DialogResult.Yes)
      {
        Banco.DeletarUsuario(ttb_ID.Text);
        dgv_Usuarios.Rows.Remove(dgv_Usuarios.CurrentRow);
      }
    }
  }
}
