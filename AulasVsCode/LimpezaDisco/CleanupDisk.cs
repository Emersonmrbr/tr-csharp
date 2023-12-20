using System;
using System.Diagnostics;
using System.IO;
  class CleanupDisk
  {
    static void Main(){
    // Variables
    // Path to windows temp folder
      string temp = @"C:\Windows\Temp";
      // Path to user temp folder
      string userTemp = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\AppData\Local\Temp");
      // Path to prefectch folder
      string prefetch = @"C:\Windows\Prefetch";
      Console.WriteLine(userTemp);
      try
      {
        Directory.Delete(temp, true);
        Directory.Delete(userTemp, true);
        Directory.Delete(prefetch, true);
      }
       catch (System.Exception e)
      {
        Console.WriteLine("Falha ao deletar: {0}", e.Message);
      }
      Process.Start("cleanmgr.exe", "/verylowdisk");
      Process.Start("cleanmgr.exe", "/sageset:1");
      Process.Start("cleanmgr.exe", "/sagerun:1");
    }
  }