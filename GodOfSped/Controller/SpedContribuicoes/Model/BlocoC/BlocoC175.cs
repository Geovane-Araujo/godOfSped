
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC175
{
    public String REG { get; } = "C175";
    
    public String CFOP { get; set; } = "";
    
    public String VL_OPR { get; set; } = "";
    
    
    public String VL_DESC { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS_QUANT { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CFOP}|{VL_OPR}|{VL_DESC}|{CST_PIS}|{VL_BC_PIS}|{ALIQ_PIS}|" +
                     $"{QUANT_BC_PIS}|{ALIQ_PIS_QUANT}|{VL_PIS}|{CST_COFINS}|" +
                     $"{VL_BC_COFINS}|{ALIQ_COFINS}|{QUANT_BC_COFINS}|{ALIQ_COFINS_QUANT}|{VL_COFINS}|" +
                     $"{COD_CTA}|{INFO_COMPL}|";
        return ret;
    }
}