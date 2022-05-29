
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM400
{
    public String REG { get; } = "M400";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_TOT_REC { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String DESC_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CST_PIS}|{VL_TOT_REC}|{COD_CTA}|{DESC_COMPL}|";
        
        return ret;
    }
}