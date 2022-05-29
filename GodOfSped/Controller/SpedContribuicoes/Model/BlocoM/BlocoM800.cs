
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM800
{
    public String REG { get; } = "M800";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_TOT_REC { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String DESC_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CST_COFINS}|{VL_TOT_REC}|{COD_CTA}|{DESC_COMPL}|";
        
        return ret;
    }
}