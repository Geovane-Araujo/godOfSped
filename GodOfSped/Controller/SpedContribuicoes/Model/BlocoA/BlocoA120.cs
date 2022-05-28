
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoA120
{
    public String REG { get; } = "A120";
    
    public String VL_TOT_SERV { get; set; }
    
    public String VL_BC_PIS { get; set; }
    
    public String VL_PIS_IMP { get; set; }
    
    public String DT_PAG_PIS { get; set; }
    
    public String VL_BC_COFINS { get; set; }
    
    public String VL_COFINS_IMP { get; set; }
    
    public String DT_PAG_COFINS { get; set; }
    
    public String LOC_EXE_SERV { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{VL_TOT_SERV}|{VL_BC_PIS}|{VL_PIS_IMP}|{DT_PAG_PIS}|{VL_BC_COFINS}|{VL_COFINS_IMP}|{DT_PAG_COFINS}|{LOC_EXE_SERV}|";
        
        return ret;
    }
}