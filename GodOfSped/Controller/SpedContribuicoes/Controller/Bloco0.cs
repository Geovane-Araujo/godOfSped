using System.Collections;
using System.Data.SqlClient;
using GodOfSped.Controller.SpedFiscal.Model.Bloco0;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class Bloco0
{
    public static List<String> Bloco0Ini(SqlConnection con,String sql)
    {
        
        Bloco0000 h = Persistense.FindByOne<Bloco0000>(con, sql);
        
        List<String> retv = new List<string>();
        
        return retv;
    }
    public static List<String> Bloco0001(SqlConnection con,String sql)
    {
        
        // List<Hashtable> h = (List<Hashtable>)Persistense.GetAll(con, sql);
        return null;
    }
}