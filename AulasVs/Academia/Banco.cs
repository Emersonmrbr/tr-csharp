﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace Academia
{
  class Banco
  {
    private static SQLiteConnection conexao;
    private static SQLiteConnection ConexaoBanco()
    {
      conexao = new SQLiteConnection("Data Source = D:\\tr-csharp\\AulasVs\\Academia\\db\\db_academia.db");
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
          return dt;
        }
      }
      catch (Exception ex)
      {
        throw ex;
      }
    }

  }
}
