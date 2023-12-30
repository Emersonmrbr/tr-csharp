using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
  internal class BancoGPT
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
      try
      {
        var conexaoLocal = ConexaoBanco();
        using (var cmd = conexaoLocal.CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM tb_usuarios";
          var da = new SQLiteDataAdapter(cmd.CommandText, conexaoLocal);
          var dt = new DataTable();
          da.Fill(dt);
          conexaoLocal.Close();
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    public static DataTable Consulta(string sql)
    {
      try
      {
        var conexaoLocal = ConexaoBanco();
        using (var cmd = conexaoLocal.CreateCommand())
        {
          cmd.CommandText = sql;
          var da = new SQLiteDataAdapter(cmd.CommandText, conexaoLocal);
          var dt = new DataTable();
          da.Fill(dt);
          conexaoLocal.Close();
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    // Functions for FORM F_NovoUsuario

    public static void NovoUsuario(Usuario usuario)
    {
      if (ExisteApelido(usuario))
      {
        MessageBox.Show("Apelido já existe");
        return;
      }

      try
      {
        var conexaoLocal = ConexaoBanco();
        using (var cmd = conexaoLocal.CreateCommand())
        {
          cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO,T_APELIDOUSUARIO, T_SENHAUSUARIO,T_STATUSUSUARIO,N_NIVELUSUARIO) VALUES (@nome, @apelido, @senha, @status, @nivel)";
          cmd.Parameters.AddWithValue("@nome", usuario.T_NOMEUSUARIO);
          cmd.Parameters.AddWithValue("@apelido", usuario.T_APELIDOUSUARIO);
          cmd.Parameters.AddWithValue("@senha", usuario.T_SENHAUSUARIO);
          cmd.Parameters.AddWithValue("@status", usuario.T_STATUSUSUARIO);
          cmd.Parameters.AddWithValue("@nivel", usuario.N_NIVELUSUARIO);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Novo usuário inserido com sucesso");
          conexaoLocal.Close();
        }
      }
      catch
      {
        MessageBox.Show("Erro ao gravar novo usuário");
      }
    }

    public static bool ExisteApelido(Usuario usuario)
    {
      var conexaoLocal = ConexaoBanco();
      using (var cmd = conexaoLocal.CreateCommand())
      {
        cmd.CommandText = "SELECT T_APELIDOUSUARIO FROM tb_usuarios WHERE T_APELIDOUSUARIO= @apelido";
        cmd.Parameters.AddWithValue("@apelido", usuario.T_APELIDOUSUARIO);

        var da = new SQLiteDataAdapter(cmd.CommandText, conexaoLocal);
        var dt = new DataTable();
        da.Fill(dt);

        conexaoLocal.Close();
        return dt.Rows.Count > 0;
      }
    }
    // END - Functions for FORM F_NovoUsuario
  }
}
