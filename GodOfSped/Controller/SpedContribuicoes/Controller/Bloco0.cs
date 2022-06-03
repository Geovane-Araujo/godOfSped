using System.Collections;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using GodOfSped.Model.SpedContribuicoes.Model;
using GodOfSped.Model.SpedContribuicoes.Repository;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class Bloco0
{
    public static List<String> Bloco0Ini(SpedContriConfiguration config)
    {
        Bloco0000 h = Persistense.FindByOne<Bloco0000>(config.cnn, Sql.sqlBloco000.Replace("{@@IDEmpresa}",config.idpessoa.ToString()));
        
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
        Bloco0001 blo = new();
        if (blo0.Count > 0)
            blo.IND_MOV = "0";
        else
            blo.IND_MOV = "1";
        
        List<String> retv = new List<string>();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> Bloco0100(SpedContriConfiguration config)
    {

        Bloco0100 blo = Persistense.FindByOne<Bloco0100>(config.cnn, Sql.sqlBloco0100.Replace("{@@IDEmpresa}",config.idpessoa.ToString()));
        
        List<String> retv = new List<string>();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> Bloco0110(SpedContriConfiguration config)
    {
        Bloco0110 blo = Persistense.FindByOne<Bloco0110>(config.cnn, Sql.sqlBloco0110.Replace("{@@IDEmpresa}",config.idpessoa.ToString()));

        List<String> retv = new List<string>();
        
        retv.Add(blo.ToString());
        
        return retv;
    }
    
    public static List<String> Bloco0140(SpedContriConfiguration config)
    {
        Bloco0140 blo = Persistense.FindByOne<Bloco0140>(config.cnn, Sql.sqlBloco0140.Replace("{@@IDEmpresa}",config.idpessoa.ToString()));

        List<String> retv = new List<string>();
        
        retv.Add(blo.ToString());
        
        return retv;
    }
    
    public static List<String> Bloco0150(SpedContriConfiguration config)
    {
        String sql = Sql.sqlBloco0150.Replace("{@@IDEmpresa}", config.idpessoa.ToString());
        sql = sql.Replace("{@@dataini}", config.dataini.ToString("yyyy-MM-dd"));
        sql = sql.Replace("{@@datafim}", config.datafim.ToString("yyyy-MM-dd"));
        
        List<Bloco0150> blo = Persistense.FindByAll<Bloco0150>(config.cnn, sql);

        List<String> retv = new List<string>();
        
        blo.ForEach(item =>
        {
            retv.Add(item.ToString());
        });
        
        return retv;
    }
    
    public static List<String> Bloco0190(SpedContriConfiguration config)
    {
        String sql = Sql.sqlBloco0190.Replace("{@@IDEmpresa}", config.idpessoa.ToString());
        sql = sql.Replace("{@@dataini}", config.dataini.ToString("yyyy-MM-dd"));
        sql = sql.Replace("{@@datafim}", config.datafim.ToString("yyyy-MM-dd"));
        
        List<Bloco0190> blo = Persistense.FindByAll<Bloco0190>(config.cnn, sql);
        List<String> retv = new List<string>();
        
        blo.ForEach(item =>
        {
            retv.Add(item.ToString());
        });
        
        return retv;
    }
    
    public static List<String> Bloco0200(SpedContriConfiguration config)
    {
        String sql = Sql.sqlBloco0200.Replace("{@@IDEmpresa}", config.idpessoa.ToString());
        sql = sql.Replace("{@@dataini}", config.dataini.ToString("yyyy-MM-dd"));
        sql = sql.Replace("{@@datafim}", config.datafim.ToString("yyyy-MM-dd"));
        
        List<Bloco0200> blo = Persistense.FindByAll<Bloco0200>(config.cnn, sql);

        List<String> retv = new List<string>();
        
        blo.ForEach(item =>
        {
            retv.Add(item.ToString());
        });
        
        return retv;
    }
    
    public static List<String> Bloco0500(SpedContriConfiguration config)
    {
        String sql = Sql.sqlBloco0500.Replace("{@@IDEmpresa}", config.idpessoa.ToString());
        sql = sql.Replace("{@@dataini}", config.dataini.ToString("yyyy-MM-dd"));
        sql = sql.Replace("{@@datafim}", config.datafim.ToString("yyyy-MM-dd"));
        
        List<Bloco0500> blo = Persistense.FindByAll<Bloco0500>(config.cnn, sql);

        List<String> retv = new List<string>();
        
        blo.ForEach(item =>
        {
            retv.Add(item.ToString());
        });
        
        return retv;
    }
    
    public static List<String> Bloco0Fim(List<String> totalBloco0)
    {
        Bloco0990 blo = new Bloco0990();
        List<String> retv = new List<string>();

        blo.QTD_LIN_0 = (totalBloco0.Count + 1).ToString();
        retv.Add(blo.ToString());
        return retv;
    }
}