
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoA170
{
    public String REG { get; } = "A170";
    
    public String NUM_ITEM { get; set; }
    
    public String COD_ITEM { get; set; }
    
    public String DESCR_COMPL { get; set; }
    
    public String VL_ITEM { get; set; }
    
    public String VL_DESC { get; set; }
    
    public String NAT_BC_CRED { get; set; }
    
    public String IND_ORIG_CRED { get; set; }
    
    public String CST_PIS { get; set; }
    
    public String VL_BC_PIS { get; set; }
    
    public String ALIQ_PIS { get; set; }
    
    public String VL_PIS { get; set; }
    
    public String CST_COFINS { get; set; }
    
    public String VL_BC_COFINS { get; set; }
    
    public String ALIQ_COFINS { get; set; }
    
    public String VL_COFINS { get; set; }
    
    public String COD_CTA { get; set; }
    
    public String COD_CCUS { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_ITEM}|{COD_ITEM}|{DESCR_COMPL}|{VL_ITEM}|{VL_DESC}|{NAT_BC_CRED}|{IND_ORIG_CRED}|{CST_PIS}|" +
                     $"{VL_BC_PIS}|{ALIQ_PIS}|{VL_PIS}|{CST_COFINS}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|{COD_CTA}|{COD_CCUS}|";
        
        return ret;
    }
}