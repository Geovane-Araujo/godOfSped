
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoI100
{
    public String REG { get; } = "I100";
    
    public String VL_REC { get; set; } = "";
    
    public String CST_PIS_COFINS { get; set; } = "";
    
    public String VL_TOT_DED_GER { get; set; } = "";
    
    public String VL_TOT_DED_ESP { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_REC}|{CST_PIS_COFINS}|{VL_TOT_DED_GER}|{VL_TOT_DED_ESP}|{VL_BC_PIS}|{ALIQ_PIS}|" +
                     $"{VL_PIS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|{INFO_COMPL}|";
        
        return ret;
    }
}