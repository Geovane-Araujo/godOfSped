using GodOfSped.Model.SpedContribuicoes.Model;
using GodOfSped.Model.SpedContribuicoes.Repository;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class BlocoC
{
    public static List<String> BlocoIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        BlocoC001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> Bloco010(SpedContriConfiguration config)
    {
        List<String> retv = new List<string>();
        BlocoC010 blo = new();

        blo.CNPJ = config.cnpjEmpresa;
        blo.IND_ESCRI = config.IND_ESCRI;
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoC100(SpedContriConfiguration config,List<String> blC100List,List<String> blC170List)
    {
        List<String> retv = new List<string>();
        BlocoC100 bloC100 = new();
        BlocoC170 bloC170 = new();
        
        String sqlC100 = Sql.sqlBlocoC100.Replace("{@@IDEmpresa}", config.idpessoa.ToString());
        sqlC100 = sqlC100.Replace("{@@dataini}", config.dataini.ToString("yyyy-MM-dd"));
        sqlC100 = sqlC100.Replace("{@@datafim}", config.datafim.ToString("yyyy-MM-dd"));
        
        List<BlocoC100> bloC100List = Persistense.FindByAll<BlocoC100>(config.cnn, sqlC100);
        
        String sqlC170 = Sql.sqlBlocoC170.Replace("{@@IDEmpresa}", config.idpessoa.ToString());
        sqlC170 = sqlC170.Replace("{@@dataini}", config.dataini.ToString("yyyy-MM-dd"));
        sqlC170 = sqlC170.Replace("{@@datafim}", config.datafim.ToString("yyyy-MM-dd"));
        
        List<BlocoC170> bloC170List = Persistense.FindByAll<BlocoC170>(config.cnn, sqlC170);
        
        bloC100List.ForEach(item =>
        {
            retv.Add(item.ToString());
            blC100List.Add(item.ToString());
            bloC170List.FindAll(obj => obj.IDNOTA == item.IDNOTA).ForEach(index =>
            {
                retv.Add(index.ToString());
                blC170List.Add(index.ToString());
            });
        });
        
        return retv;
    }
    
    public static List<String> BlocoFim(List<String> bloC)
    {
        List<String> retv = new List<string>();
        BlocoC990 blo = new();
        
        blo.QTD_LIN_C = (bloC.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}