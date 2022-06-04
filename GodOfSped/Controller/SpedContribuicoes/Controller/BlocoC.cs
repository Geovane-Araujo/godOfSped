using GodOfSped.Model.SpedContribuicoes.Model;

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
    
    public static List<String> BlocoFim(List<String> bloC)
    {
        List<String> retv = new List<string>();
        BlocoC990 blo = new();
        
        blo.QTD_LIN_C = (bloC.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}