
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoI300
{
    public String REG { get; } = "I300";
    
    public String COD_COMP { get; set; } = "";
    
    public String DET_VALOR { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";

    public String INFO_COMPL { get; set; } = "";

    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_COMP}|{DET_VALOR}|{COD_CTA}|{INFO_COMPL}|";
        
        return ret;
    }
}