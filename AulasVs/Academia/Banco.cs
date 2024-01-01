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
      conexao = new SQLiteConnection("Data Source =" + Globais.caminhoBanco + Globais.nomeBanco);
      conexao.Open();
      return conexao;
    }

    public static DataTable ObterTodosUsuarios()
    {
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM tb_usuarios";
          var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
          var dt = new DataTable();
          da.Fill(dt);
          ConexaoLocal.Close();
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

    //Funçoes do FORM F_NovoUsuario

    public static void NovoUsuario(Usuario usuario)
    {
      if (ExisteApelido(usuario)) { MessageBox.Show("Apelido já existe"); return; }
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = "INSERT INTO tb_usuarios (T_NOMEUSUARIO,T_APELIDOUSUARIO, T_SENHAUSUARIO,T_STATUSUSUARIO,N_NIVELUSUARIO) VALUES (@nome, @apelido, @senha, @status, @nivel)";
          cmd.Parameters.AddWithValue("@nome", usuario.T_NOMEUSUARIO);
          cmd.Parameters.AddWithValue("@apelido", usuario.T_APELIDOUSUARIO);
          cmd.Parameters.AddWithValue("@senha", usuario.T_SENHAUSUARIO);
          cmd.Parameters.AddWithValue("@status", usuario.T_STATUSUSUARIO);
          cmd.Parameters.AddWithValue("@nivel", usuario.N_NIVELUSUARIO);
          cmd.ExecuteNonQuery();
          MessageBox.Show("Novo usuário inserido com sucesso");
          ConexaoLocal.Close();
        }
      }
      catch
      {
        MessageBox.Show("Erro ao gravar novo usuário");
      }
    }

    public static bool ExisteApelido(Usuario usuario)
    {
      var ConexaoLocal = ConexaoBanco();
      using (var cmd = ConexaoLocal.CreateCommand())
      {
        cmd.CommandText = "SELECT T_APELIDOUSUARIO FROM tb_usuarios WHERE T_APELIDOUSUARIO= '" + usuario.T_APELIDOUSUARIO + "'";
        cmd.Parameters.AddWithValue("@apelido", usuario.T_APELIDOUSUARIO);
        var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
        var dt = new DataTable();
        da.Fill(dt);
        ConexaoLocal.Close();
        return dt.Rows.Count > 0;
      }
    }
    //FIM - Funçoes do FORM F_NovoUsuario

    //Funções do FORM F_GestaoUsuarios
    public static DataTable ObterTodosUsuariosIdNome()
    {
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = "SELECT N_IDUSUARIO as 'ID', T_NOMEUSUARIO as 'Nome' FROM tb_usuarios";
          var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
          var dt = new DataTable();
          da.Fill(dt);
          ConexaoLocal.Close();
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static DataTable ObterDadosUsuario(string id)
    {
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO='" + id + "'";
          var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
          var dt = new DataTable();
          da.Fill(dt);
          ConexaoLocal.Close();
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void AtualizarUsuario(Usuario usuario)
    {
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = "UPDATE tb_usuarios SET T_NOMEUSUARIO='" + usuario.T_NOMEUSUARIO + "', T_APELIDOUSUARIO='" + usuario.T_APELIDOUSUARIO + "', T_SENHAUSUARIO='" + usuario.T_SENHAUSUARIO + "',  T_STATUSUSUARIO='" + usuario.T_STATUSUSUARIO + "', N_NIVELUSUARIO=" + usuario.N_NIVELUSUARIO + " WHERE N_IDUSUARIO=" + usuario.N_IDUSUARIO;
          var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
          var dt = new DataTable();
          cmd.ExecuteNonQuery();
          ConexaoLocal.Close();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void DeletarUsuario(string id)
    {
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = "DELETE FROM tb_usuarios WHERE N_IDUSUARIO=" + id;
          var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
          var dt = new DataTable();
          cmd.ExecuteNonQuery();
          ConexaoLocal.Close();
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    //FIM - Funções do FORM F_GestaoUsuarios

    //Funçoes genericas
    public static DataTable Dql(string q)//Data Query Language (SELECT)
    {
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = q;
          var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
          var dt = new DataTable();
          da.Fill(dt);
          ConexaoLocal.Close();
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }
    public static void Dml(string q, string msgOK = null, string msgERRO = null)//Data Manipulation Language (INSERT, DELETE e UPDATE)
    {
      try
      {
        var ConexaoLocal = ConexaoBanco();
        using (var cmd = ConexaoLocal.CreateCommand())
        {
          cmd.CommandText = q;
          var da = new SQLiteDataAdapter(cmd.CommandText, ConexaoLocal);
          var dt = new DataTable();
          cmd.ExecuteNonQuery();
          ConexaoLocal.Close();
          if (msgOK != null)
          {
            MessageBox.Show(msgOK);
          }
        }
      }
      catch (Exception ex)
      {
        if (msgERRO != null)
        {
          MessageBox.Show(msgERRO + "\n" + ex.Message);
        }
        throw ex;
      }
    }

    //FIM - Funçoes genericas

  }
}
