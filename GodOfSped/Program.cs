// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.Data.SqlClient;
using GodOfSped;
using GodOfSped.Commom;
using GodOfSped.Model.SpedContribuicoes;
using GodOfSped.Model.SpedContribuicoes.Model;

public class Program
{
   public static void Main(String[] args)
   {
      Console.WriteLine("Olá");

      SqlConnection con = Connection.NewInstanceSqlServer("atmusinf_Control-2220");
      SpedContriConfiguration spedContriConfiguration = new();
      spedContriConfiguration.idpessoa = 0;
      spedContriConfiguration.cnn = con;
      spedContriConfiguration.datafim = DateTime.Now;
      spedContriConfiguration.dataini = DateTime.Now;
      
      

      SpedContribuicoesBlocos spedContribuicoesBlocos = new(spedContriConfiguration);
      List<String> list = spedContribuicoesBlocos.GerarBloco0();

      ExportFile.GenerateFile(list);
   }
   
}
