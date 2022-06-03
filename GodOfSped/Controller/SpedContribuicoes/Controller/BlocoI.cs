using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class BlocoI
{
    public static List<String> BlocoIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        BlocoI001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoFim(List<String> bloI)
    {
        List<String> retv = new List<string>();
        BlocoI990 blo = new();
        
        blo.QTD_LIN_I = (bloI.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}