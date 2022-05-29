using System.Collections;
using System.Data.SqlClient;
using GodOfSped.Model.SpedContribuicoes.Model;
using GodOfSped.Model.SpedContribuicoes.Repository;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class Bloco0
{
    public static List<String> Bloco0Ini(SpedContriConfiguration config)
    {
        Bloco0000 h = Persistense.FindByOne<Bloco0000>(config.cnn, Sql.sqlBloco000.Replace("{@@IDPessoa}",config.idpessoa.ToString()));
        
        List<String> retv = new List<string>();
        h.IND_NAT_PJ = $"0{h.IND_NAT_PJ}";
        h.DT_INI = config.dataini.ToString("ddMMyyyy");
        h.DT_FIN = config.datafim.ToString("ddMMyyyy");
        if (h.CNPJ == "" && h.NOME == "")
            return retv;
        
        retv.Add(h.ToString());
        return retv;
    }
    public static List<String> Bloco0001(List<String> blo0)
    {
        Bloco0001 blo001 = new();
        if (blo0.Count > 0)
            blo001.IND_MOV = "0";
        else
            blo001.IND_MOV = "1";
        
        List<String> retv = new List<string>();
        
        retv.Add(blo001.ToString());
        return retv;
    }
    
    public static List<String> Bloco0100(SpedContriConfiguration config)
    {

        Bloco0100 blo100 = Persistense.FindByOne<Bloco0100>(config.cnn, Sql.sqlBloco0100.Replace("{@@IDPessoa}",config.idpessoa.ToString()));
        
        List<String> retv = new List<string>();
        
        retv.Add(blo100.ToString());
        return retv;
    }
    
    public static List<String> Bloco0110(SpedContriConfiguration config)
    {
        Bloco0110 blo110 = Persistense.FindByOne<Bloco0110>(config.cnn, Sql.sqlBloco0100.Replace("{@@IDPessoa}",config.idpessoa.ToString()));

        List<String> retv = new List<string>();
        
        retv.Add(blo110.ToString());
        
        return retv;
    }
}