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
  public partial class F_Login : Form
  {
    F_Main f_Main;
    DataTable dt = new DataTable();
    public F_Login(F_Main form)
    {
      InitializeComponent();
      f_Main = form;
    }

    private void btn_Logar_Click(object sender, EventArgs e)
    {
      string usuario = ttb_ApelidoUsuario.Text;
      string senha = ttb_Senha.Text;
      if (usuario == string.Empty)
      {
        MessageBox.Show("Usuário inválido");
        ttb_ApelidoUsuario.Focus();
        return;
      }
      if (senha == string.Empty)
      {
        MessageBox.Show("Senha inválida");
        ttb_Senha.Focus();
        return;
      }
      string sql = "SELECT * FROM tb_usuarios WHERE T_APELIDOUSUARIO = '" + usuario + "' AND T_SENHAUSUARIO = '" + senha + "'";
      dt = Banco.Consulta(sql);
      if (dt.Rows.Count > 0)
      {
        f_Main.lbl_Acesso.Text = dt.Rows[0].ItemArray[5].ToString();//Uma maneira de fazer, buscando nivel do usuário
        f_Main.lbl_NomeUsuario.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO");//Outra maneira de fazer, essa eu achei melhor
        f_Main.img_Logado.Image = Properties.Resources.ledVerde;
        Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVELUSUARIO").ToString());
        Globais.logado = true;
        this.Close();
      }
      else
      {
        MessageBox.Show("Usuário não encontrado");
      }
    }

    private void btn_Cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
