
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF510
{
    public String REG { get; } = "F510";
    
    public String VL_REC_CAIXA { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_DESC_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_DESC_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS_QUANT { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_MOD { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_REC_CAIXA}|{CST_PIS}|{VL_DESC_PIS}|{QUANT_BC_PIS}|{ALIQ_PIS_QUANT}|{VL_PIS}|" +
                     $"{CST_COFINS}|{VL_DESC_COFINS}|{QUANT_BC_COFINS}|{ALIQ_COFINS_QUANT}|" +
                     $"{VL_COFINS}|{COD_MOD}|{CFOP}|{COD_CTA}|{INFO_COMPL}|";
        return ret;
    }
}