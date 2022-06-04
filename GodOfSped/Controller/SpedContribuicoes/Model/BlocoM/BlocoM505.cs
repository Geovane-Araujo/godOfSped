
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM505
{
    public String REG { get; } = "M505";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_BC_COFINS_TOT { get; set; } = "";
    
    public String VL_BC_COFINS_CUM { get; set; } = "";
    
    public String VL_BC_COFINS_NC { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String QUANT_BC_COFINS_TOT { get; set; } = "";
    
    public String QUANT_BC_COFINS { get; set; } = "";
    
    public String DESC_CRED { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NAT_BC_CRED}|{CST_COFINS}|{VL_BC_COFINS_TOT}|{VL_BC_COFINS_CUM}|{VL_BC_COFINS_NC}|{VL_BC_COFINS}|" +
                     $"{QUANT_BC_COFINS_TOT}|{QUANT_BC_COFINS}|{DESC_CRED}|";
        
        return ret;
    }
}