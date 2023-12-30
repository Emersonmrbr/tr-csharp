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

  }
}
