
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoF800
{
    public String REG { get; } = "F800";
    
    public String IND_NAT_EVEN { get; set; } = "";
    
    public String DT_EVEN { get; set; } = "";
    
    public String CNPJ_SUCED { get; set; } = "";
    
    public String PA_CONT_CRED { get; set; } = "";
    
    public String COD_CRED { get; set; } = "";
    
    public String VL_CRED_PIS { get; set; } = "";
    
    public String VL_CRED_COFINS { get; set; } = "";
    
    public String PER_CRED_CIS { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_NAT_EVEN}|{DT_EVEN}|{CNPJ_SUCED}|{PA_CONT_CRED}|{COD_CRED}|{VL_CRED_PIS}|" +
                     $"{VL_CRED_COFINS}|{PER_CRED_CIS}|";
        return ret;
    }
}