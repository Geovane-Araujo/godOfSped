
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD505
{
    public String REG { get; } = "D505";
    
    public String CST_COFINS { get; set; } = "";
    
    public String VL_ITEM { get; set; } = "";
    
    public String NAT_BC_CRED { get; set; } = "";
    
    public String VL_BC_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_COFINS { get; set; } = "";
    
    public String COD_CTA { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{CST_COFINS}|{VL_ITEM}|{NAT_BC_CRED}|{VL_BC_COFINS}|{ALIQ_COFINS}|{VL_COFINS}|" +
                     $"{COD_CTA}|";
        return ret;
    }
}