
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD601
{
    public String REG { get; } = "D601";
    
    public String COD_CLASS { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_CLASS}|{VL_ITEM}|{VL_DESC}|{CST_PIS}|{VL_BC_PIS}|{ALIQ_PIS}|" +
                     $"{VL_PIS}|{COD_CTA}|";
        return ret;
    }
}