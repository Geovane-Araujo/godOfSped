using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class BlocoA
{
    public static List<String> BlocoAIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        BlocoA001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoAFim(List<String> bloA)
    {
        List<String> retv = new List<string>();
        BlocoA001 blo = new();
        
        blo.IND_MOV = (bloA.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}