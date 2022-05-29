
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1102
{
    public String REG { get; } = "1102";
    
    public String VL_CRED_PIS_TRIB_MI { get; set; } = "";
    
    public String VL_CRED_PIS_NT_MI { get; set; } = "";
    
    public String VL_CRED_PIS_EXP { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_CRED_PIS_TRIB_MI}|{VL_CRED_PIS_NT_MI}|{VL_CRED_PIS_EXP}|";
        
        return ret;
    }
}