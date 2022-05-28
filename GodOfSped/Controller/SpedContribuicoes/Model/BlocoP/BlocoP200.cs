
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoP200
{
    public String REG { get; } = "P200";
    
    public String PER_REF { get; set; }
    
    public String VL_TOT_CONT_APU { get; set; }
    
    public String VL_TOT_AJ_REDUC { get; set; }
    
    public String VL_TOT_AJ_ACRES { get; set; }
    
    public String VL_TOT_CONT_DEV { get; set; }
    
    public String COD_REC { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{PER_REF}|{VL_TOT_CONT_APU}|{VL_TOT_AJ_REDUC}|{VL_TOT_AJ_ACRES}|{VL_TOT_CONT_DEV}|{COD_REC}|";
        
        return ret;
    }
}