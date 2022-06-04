
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1300
{
    public String REG { get; } = "1300";
    
    public String IND_NAT_RET { get; set; } = "";
    
    public String PR_REC_RET { get; set; } = "";
    
    public String VL_RET_APU { get; set; } = "";
    
    public String VL_RET_DED { get; set; } = "";
    
    public String VL_RET_PER { get; set; } = "";
    
    public String VL_RET_DCOMP { get; set; } = "";
    
    public String SLD_RET { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_NAT_RET}|{PR_REC_RET}|{VL_RET_APU}|{VL_RET_DED}|{VL_RET_PER}|{VL_RET_DCOMP}|{SLD_RET}|";
        
        return ret;
    }
}