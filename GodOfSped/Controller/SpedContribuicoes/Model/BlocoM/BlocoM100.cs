
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM100
{
    public String REG { get; } = "1800";
    
    public String COD_CRED { get; set; } = "";
    
    public String IND_CRED_ORI { get; set; } = "";
    
    public String VL_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS { get; set; } = "";
    
    public String QUANT_BC_PIS { get; set; } = "";
    
    public String ALIQ_PIS_QUANT { get; set; } = "";
    
    public String VL_CRED { get; set; } = "";
    
    public String VL_AJUS_ACRES { get; set; } = "";
    
    public String VL_AJUS_REDUC { get; set; } = "";
    
    public String VL_CRED_DIF { get; set; } = "";
    
    public String VL_CRED_DISP { get; set; } = "";
    
    public String IND_DESC_CRED { get; set; } = "";
    
    public String VL_CRED_DESC { get; set; } = "";
    
    public String SLD_CRED { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_CRED}|{IND_CRED_ORI}|{VL_BC_PIS}|{ALIQ_PIS}|{QUANT_BC_PIS}|{ALIQ_PIS_QUANT}|" +
                     $"{VL_CRED}|{VL_AJUS_ACRES}|{VL_AJUS_REDUC}|{VL_CRED_DIF}|{VL_CRED_DISP}|{IND_DESC_CRED}|{VL_CRED_DESC}|{SLD_CRED}|";
        
        return ret;
    }
}