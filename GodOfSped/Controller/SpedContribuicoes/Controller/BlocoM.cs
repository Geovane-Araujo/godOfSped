using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class BlocoM
{
    public static List<String> BlocoIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        BlocoM001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoFim(List<String> bloM)
    {
        List<String> retv = new List<string>();
        BlocoM990 blo = new();
        
        blo.QTD_LIN_M = (bloM.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}