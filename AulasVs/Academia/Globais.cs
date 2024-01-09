using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
  class Globais
  {

    public static string versao { get; } = "1.0";
    public static bool logado { get; set; } = false;
    public static int nivel { get; set; } = 0; // 0 = Básico, 1 = Gerente, 2 = Master
    //public static string caminho { get; } = System.Environment.CurrentDirectory;
    public static string caminho { get; } = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
    public static string nomeBanco { get; } = "db_academia";
    public static string pastaBanco { get; } = @"db\";
    public static string caminhoBanco { get; } = Path.Combine(caminho, pastaBanco, nomeBanco);
    public static string pastaFoto { get; } = @"foto\";
    public static string caminhoFoto { get; } = Path.Combine(caminho, pastaFoto);

    /*
    tb_usuarios
    N_IDUSUARIO, T_NOMEUSUARIO, T_APELIDOUSUARIO, T_SENHAUSUARIO,  T_STATUSUSUARIO, N_NIVELUSUARIO
    */

  }
}
