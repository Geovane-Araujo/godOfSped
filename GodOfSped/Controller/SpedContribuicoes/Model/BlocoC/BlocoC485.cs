
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC485
{
    public String REG { get; } = "C485";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS_QUANT { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_ITEM { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CST_COFINS}|{VL_ITEM}|{VL_BC_COFINS}|{ALIQ_COFINS}|{QUANT_BC_COFINS}|{ALIQ_COFINS_QUANT}|" +
                     $"{VL_COFINS}|{COD_ITEM}|{COD_CTA}|";
        return ret;
    }
}