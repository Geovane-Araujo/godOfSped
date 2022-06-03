using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class BlocoP
{
    public static List<String> BlocoIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        BlocoP001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoFim(List<String> bloP)
    {
        List<String> retv = new List<string>();
        BlocoP990 blo = new();
        
        blo.QTD_LIN_P = (bloP.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}