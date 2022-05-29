
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM410
{
    public String REG { get; } = "M410";
    
    public String NAT_REC { get; set; } = "";
    
    public String VL_REC { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String DESC_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NAT_REC}|{VL_REC}|{COD_CTA}|{DESC_COMPL}|";
        
        return ret;
    }
}