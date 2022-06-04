
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF550
{
    public String REG { get; } = "F550";
    
    public String VL_REC_COMP { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_DESC_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_DESC_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_MOD { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_REC_COMP}|{CST_PIS}|{VL_DESC_PIS}|{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|" +
                     $"{CST_COFINS}|{VL_DESC_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|" +
                     $"{VL_COFINS}|{COD_MOD}|{CFOP}|{COD_CTA}|{INFO_COMPL}|";
        return ret;
    }
}