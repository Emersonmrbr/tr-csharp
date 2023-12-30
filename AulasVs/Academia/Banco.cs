using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Academia
{
  class Banco
  {
    private static SQLiteConnection conexao;
    private static SQLiteConnection ConexaoBanco()
    {
      conexao = new SQLiteConnection("Data Source = D:\\tr-csharp\\AulasVs\\Academia\\db\\db_academia");
      conexao.Open();
      return conexao;
    }

    public static DataTable ObterTodosUsuarios()
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = ConexaoBanco().CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM tb_usuarios";
          da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
          da.Fill(dt);
          ConexaoBanco();
          return dt;
        }
      }
      catch (Exception ex)
      {
        ConexaoBanco();
        throw ex;
      }
    }
    public static DataTable Consulta(string sql)
    {
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();
      try
      {
        using (var cmd = ConexaoBanco().CreateCommand())
        {
          cmd.CommandText = sql;
          da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
          da.Fill(dt);
          ConexaoBanco();
          return dt;
        }
      }
      catch (Exception ex)
      {
        ConexaoBanco();
        throw ex;
      }
    }
    //Funçoes do FORM F_NovoUsuario

    public static void NovoUsuario(Usuario usuario)
    {
      if (ExisteApelido(usuario)) { MessageBox.Show("Apelido já existe"); return; }
      try
      {
        var cmd = ConexaoBanco().CreateCommand();
        cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO,T_APELIDOUSUARIO, T_SENHAUSUARIO,T_STATUSUSUARIO,N_NIVELUSUARIO) VALUES (@nome, @apelido, @senha, @status, @nivel)";
        cmd.Parameters.AddWithValue("@nome", usuario.T_NOMEUSUARIO);
        cmd.Parameters.AddWithValue("@apelido", usuario.T_APELIDOUSUARIO);
        cmd.Parameters.AddWithValue("@senha", usuario.T_SENHAUSUARIO);
        cmd.Parameters.AddWithValue("@status", usuario.T_STATUSUSUARIO);
        cmd.Parameters.AddWithValue("@nivel", usuario.N_NIVELUSUARIO);
        cmd.ExecuteNonQuery();
        MessageBox.Show("Novo usuário inserido com sucesso");
        ConexaoBanco().Close();
      }
      catch
      {
        MessageBox.Show("Erro ao gravar novo usuário");
        ConexaoBanco().Close();
      }
    }

    public static bool ExisteApelido(Usuario usuario)
    {
      bool resultado;
      SQLiteDataAdapter da = null;
      DataTable dt = new DataTable();

      var cmd = ConexaoBanco().CreateCommand();
      cmd.CommandText = "SELECT T_APELIDOUSUARIO FROM tb_usuarios WHERE T_APELIDOUSUARIO= '" + usuario.T_APELIDOUSUARIO + "'";
      da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
      da.Fill(dt);
      if (dt.Rows.Count > 0) { resultado = true; } else { resultado = false; }

      return resultado;
    }

    //FIM - Funçoes do FORM F_NovoUsuario

  }
}
