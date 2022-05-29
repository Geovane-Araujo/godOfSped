
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM611
{
    public String REG { get; } = "M611";
    
    public String IND_TIP_COOP { get; set; } = "";
    
    public String VL_BC_CONT_ANT_EXC_COOP { get; set; } = "";
    
    public String VL_EXC_COOP_GER { get; set; } = "";
    
    public String VL_EXC_ESP_COOP { get; set; } = "";
    
    public String VL_BC_CONT { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_TIP_COOP}|{VL_BC_CONT_ANT_EXC_COOP}|{VL_EXC_COOP_GER}|{VL_EXC_ESP_COOP}|{VL_BC_CONT}|";
        
        return ret;
    }
}