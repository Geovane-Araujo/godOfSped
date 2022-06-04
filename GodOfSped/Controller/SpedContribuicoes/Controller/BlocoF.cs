using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class BlocoF
{
    public static List<String> BlocoIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        BlocoF001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoFim(List<String> bloF)
    {
        List<String> retv = new List<string>();
        BlocoF990 blo = new();
        
        blo.QTD_LIN_F = (bloF.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}