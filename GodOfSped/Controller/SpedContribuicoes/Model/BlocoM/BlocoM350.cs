
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM350
{
    public String REG { get; } = "M350";
    
    public String VL_TOT_FOL { get; set; } = "";
    
    public String VL_EXC_BC { get; set; } = "";
    
    public String VL_TOT_BC { get; set; } = "";
    
    public String ALIQ_PIS_FOL { get; set; } = "";
    
    public String VL_TOT_CONT_FOL { get; set; } = "";
    
   
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_TOT_FOL}|{VL_EXC_BC}|{VL_TOT_BC}|{ALIQ_PIS_FOL}|{VL_TOT_CONT_FOL}|";
        
        return ret;
    }
}