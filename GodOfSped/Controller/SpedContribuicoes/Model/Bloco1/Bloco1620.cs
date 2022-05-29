
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1620
{
    public String REG { get; } = "1620";
    
    public String PER_APU_CRED { get; set; } = "";
    
    public String ORIG_CRED { get; set; } = "";
    
    public String COD_CRED { get; set; } = "";
    
    public String VL_CRED { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{PER_APU_CRED}|{ORIG_CRED}|{COD_CRED}|{VL_CRED}|";
        
        return ret;
    }
}