
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoI200
{
    public String REG { get; } = "I200";
    
    public String NUM_CAMPO { get; set; } = "";
    
    public String COD_DET { get; set; } = "";
    
    public String DET_VALOR { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_CAMPO}|{COD_DET}|{DET_VALOR}|{COD_CTA}|{INFO_COMPL}|";
        
        return ret;
    }
}