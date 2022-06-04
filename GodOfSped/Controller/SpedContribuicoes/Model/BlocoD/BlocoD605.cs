
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD605
{
    public String REG { get; } = "D605";
    
    public String COD_CLASS { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_CLASS}|{VL_ITEM}|{VL_DESC}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|" +
                     $"{VL_COFINS}|{COD_CTA}|";
        return ret;
    }
}