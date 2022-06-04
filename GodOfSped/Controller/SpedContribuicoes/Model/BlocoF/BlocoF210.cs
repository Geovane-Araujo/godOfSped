
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF210
{
    public String REG { get; } = "F210";
    
    public String VL_CUS_ORC { get; set; } = "";
    
    public String VL_EXC { get; set; } = "";
    
    public String VL_CUS_ORC_AJU { get; set; } = "";
    
    public String VL_BC_CRED { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_CRED_PIS_UTIL { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_CRED_COFINS_UTIL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_CUS_ORC}|{VL_EXC}|{VL_CUS_ORC_AJU}|{VL_BC_CRED}|{CST_PIS}|{ALIQ_PIS}|" +
                     $"{VL_CRED_PIS_UTIL}|{CST_COFINS}|{ALIQ_COFINS}|{VL_CRED_COFINS_UTIL}|";
        return ret;
    }
}