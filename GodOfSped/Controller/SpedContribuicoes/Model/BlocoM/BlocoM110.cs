
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM110
{
    public String REG { get; } = "M110";
    
    public String IND_AJ { get; set; } = "";
    
    public String VL_AJ { get; set; } = "";
    
    public String COD_AJ { get; set; } = "";
    
    public String NUM_DOC { get; set; } = "";
    
    public String DESCR_AJ { get; set; } = "";
    
    public String DT_REF { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_AJ}|{VL_AJ}|{COD_AJ}|{NUM_DOC}|{DESCR_AJ}|{DT_REF}|";
        
        return ret;
    }
}