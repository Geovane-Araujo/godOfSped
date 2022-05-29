
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF150
{
    public String REG { get; } = "F150";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String VL_TOT_EST { get; set; } = "";
    
    public String EST_IMP { get; set; } = "";
    
    public String VL_BC_EST { get; set; } = "";
    
    public String VL_BC_MEN_EST { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_CRED_PIS { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_CRED_COFINS { get; set; } = "";
    
    public String DESC_EST { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
   
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NAT_BC_CRED}|{VL_TOT_EST}|{EST_IMP}|{VL_BC_EST}|{VL_BC_MEN_EST}|{CST_PIS}|" +
                     $"{ALIQ_PIS}|{VL_CRED_PIS}|{CST_COFINS}|{ALIQ_COFINS}|{VL_CRED_COFINS}|{DESC_EST}|{COD_CTA}|";
        
        return ret;
    }
}