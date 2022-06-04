
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC880
{
    public String REG { get; } = "C880";
    
    public String COD_ITEM { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS_QUANT { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM}|{CFOP}|{VL_ITEM}|{VL_DESC}|{CST_PIS}|{QUANT_BC_PIS}|" +
                     $"{ALIQ_PIS_QUANT}|{VL_PIS}|{CST_COFINS}|{QUANT_BC_COFINS}|{ALIQ_COFINS_QUANT}|" +
                     $"{VL_COFINS}|{COD_CTA}|";
        return ret;
    }
}