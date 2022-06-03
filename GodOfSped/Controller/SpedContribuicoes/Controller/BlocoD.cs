using GodOfSped.Model.SpedContribuicoes.Model;

namespace GodOfSped.Model.SpedContribuicoes.Controller;

public class BlocoD
{
    public static List<String> BlocoIni(int contemRegistro)
    {
        List<String> retv = new List<string>();
        BlocoD001 blo = new();

        blo.IND_MOV = (contemRegistro).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
    
    public static List<String> BlocoFim(List<String> bloD)
    {
        List<String> retv = new List<string>();
        BlocoD990 blo = new();
        
        blo.QTD_LIN_D = (bloD.Count + 1).ToString();
        
        retv.Add(blo.ToString());
        return retv;
    }
}