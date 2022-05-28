
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1500
{
    public String REG { get; } = "1500";
    
    public String PER_APU_CRED { get; set; } = "";
    
    public String ORIG_CRED { get; set; } = "";
    
    public String CNPJ_SUC { get; set; } = "";
    
    public String COD_CRED { get; set; } = "";
    
    public String VL_CRED_APU { get; set; } = "";
    
    public String VL_CRED_EXT_APU { get; set; } = "";
    
    public String VL_TOT_CRED_APU { get; set; } = "";
    
    public String VL_CRED_DESC_PA_ANT { get; set; } = "";
    
    public String VL_CRED_PER_PA_ANT { get; set; } = "";
    
    public String VL_CRED_DCOMP_PA_ANT { get; set; } = "";
    
    public String SD_CRED_DISP_EFD { get; set; } = "";
    
    public String VL_CRED_DESC_EFD { get; set; } = "";
    
    public String VL_CRED_PER_EFD { get; set; } = "";
    
    public String VL_CRED_DCOMP_EFD { get; set; } = "";
    
    public String VL_CRED_TRANS { get; set; } = "";
    
    public String VL_CRED_OUT { get; set; } = "";
    
    public String SLD_CRED_FIM { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{PER_APU_CRED}|{ORIG_CRED}|{CNPJ_SUC}|{COD_CRED}|{VL_CRED_APU}|{VL_CRED_EXT_APU}|{VL_TOT_CRED_APU}|{VL_CRED_DESC_PA_ANT}|" +
                     $"{VL_CRED_PER_PA_ANT}|{VL_CRED_DCOMP_PA_ANT}|{SD_CRED_DISP_EFD}|{VL_CRED_DESC_EFD}|{VL_CRED_PER_EFD}|" +
                     $"{VL_CRED_DCOMP_EFD}|{VL_CRED_TRANS}|{VL_CRED_OUT}|{SLD_CRED_FIM}|";
        
        return ret;
    }
}