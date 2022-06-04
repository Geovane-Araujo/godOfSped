
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM600
{
    public String REG { get; } = "M600";
    
    public String VL_TOT_CONT_NC_PER { get; set; } = "";
    
    public String VL_TOT_CRED_DESC { get; set; } = "";
    
    public String VL_TOT_CRED_DESC_ANT { get; set; } = "";
    
    public String VL_TOT_CONT_NC_DEV { get; set; } = "";
    
    public String VL_RET_NC { get; set; } = "";
    
    public String VL_OUT_DED_NC { get; set; } = "";
    
    public String VL_CONT_NC_REC { get; set; } = "";
    
    public String VL_TOT_CONT_CUM_PER { get; set; } = "";
    
    public String VL_RET_CUM { get; set; } = "";
    
    public String VL_OUT_DED_CUM { get; set; } = "";
    
    public String VL_CONT_CUM_REC { get; set; } = "";
    
    public String VL_TOT_CONT_REC { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_TOT_CONT_NC_PER}|{VL_TOT_CRED_DESC}|{VL_TOT_CRED_DESC_ANT}|{VL_TOT_CONT_NC_DEV}|{VL_RET_NC}|{VL_OUT_DED_NC}|" +
                     $"{VL_CONT_NC_REC}|{VL_TOT_CONT_CUM_PER}|{VL_RET_CUM}|{VL_OUT_DED_CUM}|{VL_CONT_CUM_REC}|{VL_TOT_CONT_REC}|";
        
        return ret;
    }
}