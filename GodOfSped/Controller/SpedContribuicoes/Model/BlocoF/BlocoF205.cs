
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF205
{
    public String REG { get; } = "F205";
    
    public String VL_CUS_INC_ACUM_ANT { get; set; } = "";
    
    public String VL_CUS_INC_PER_ESC { get; set; } = "";
    
    public String VL_CUS_INC_ACUM { get; set; } = "";
    
    public String VL_EXC_BC_CUS_INC_ACUM { get; set; } = "";
    
    public String VL_BC_CUS_INC { get; set; } = "";
    
    public String CST_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String VL_CRED_PIS_ACUM { get; set; } = "";
    
    public String VL_CRED_PIS_DESC_ANT { get; set; } = "";
    
    public String VL_CRED_PIS_DESC { get; set; } = "";
    
    public String VL_CRED_PIS_DESC_FUT { get; set; } = "";
    
    public String CST_COFINS { get; set; } = "";
    
    public String ALIQ_COFINS { get; set; } = "";
    
    public String VL_CRED_COFINS_ACUM { get; set; } = "";
    
    public String VL_CRED_COFINS_DESC_ANT { get; set; } = "";
    
    public String VL_CRED_COFINS_DESC { get; set; } = "";
    
    public String VL_CRED_COFINS_DESC_FUT { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_CUS_INC_ACUM_ANT}|{VL_CUS_INC_PER_ESC}|{VL_CUS_INC_ACUM}|{VL_EXC_BC_CUS_INC_ACUM}|{VL_BC_CUS_INC}|{CST_PIS}|" +
                     $"{ALIQ_PIS}|{VL_CRED_PIS_ACUM}|{VL_CRED_PIS_DESC_ANT}|{VL_CRED_PIS_DESC}|{CST_PIS}|{VL_CRED_PIS_DESC_FUT}|{CST_COFINS}|" +
                     $"{ALIQ_COFINS}|{VL_CRED_COFINS_ACUM}|{VL_CRED_COFINS_DESC_ANT}|{VL_CRED_COFINS_DESC}|{VL_CRED_COFINS_DESC_FUT}|";
        return ret;
    }
}