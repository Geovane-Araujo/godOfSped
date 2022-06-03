using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class Bloco1
{
    public static List<String> BlocoIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        Bloco1001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoFim(List<String> blo1)
    {
        List<String> retv = new List<string>();
        Bloco1990 blo = new();
        
        blo.QTD_LIN_1 = (blo1.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}