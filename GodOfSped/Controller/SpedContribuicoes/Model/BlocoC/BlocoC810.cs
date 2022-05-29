
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC810
{
    public String REG { get; } = "C810";
    
    public String CFOP { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    
    public String COD_ITEM { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CFOP}|{VL_ITEM}|{COD_ITEM}|{CST_PIS}|{VL_BC_PIS}|{ALIQ_PIS}|" +
                     $"{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|" +
                     $"{COD_CTA}|";
        return ret;
    }
}