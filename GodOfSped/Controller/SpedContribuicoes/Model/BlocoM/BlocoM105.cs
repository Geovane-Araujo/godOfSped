
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM105
{
    public String REG { get; } = "M105";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String VL_BC_PIS_TOT { get; set; } = "";
    
    public String VL_BC_PIS_CUM { get; set; } = "";
    
    public String VL_BC_PIS_NC { get; set; } = "";
    
    public String QUANT_BC_PIS_TOT { get; set; } = "";
    
    public String DESC_CRED { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{NAT_BC_CRED}|{CST_PIS}|{VL_BC_PIS_TOT}|{VL_BC_PIS_CUM}|{VL_BC_PIS_NC}|{QUANT_BC_PIS_TOT}|" +
                     $"{DESC_CRED}|";
        
        return ret;
    }
}