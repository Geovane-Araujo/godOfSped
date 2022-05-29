// See https://aka.ms/new-console-template for more information


using System.Collections;
using System.Data.SqlClient;
using GodOfSped;
using GodOfSped.Commom;
using GodOfSped.Model.SpedContribuicoes;

public class Program
{
   public static void Main(String[] args)
   {
      Console.WriteLine("Olá");

      SqlConnection con = Connection.NewInstanceSqlServer("atmusinf_Control-2220");

      List<Hashtable> h = (List<Hashtable>)Persistense.FindByAll(con, "SELECT * FROM nfe");


      List<String> retv = new List<string>();
      
      h.ForEach(item =>
      {
         String a = "";
         foreach (var vr in item.Cast<DictionaryEntry>())
         {
            a +=  $"{vr.Key}|{vr.Value}\n";
         }
         retv.Add(a);
      });
      
      ExportFile.GenerateFile(retv);
      
   }
}
