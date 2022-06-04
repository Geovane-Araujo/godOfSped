
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC395
{
    public String REG { get; } = "C395";
    
    public String COD_MOD { get; set; } = "";
    
    public String COD_PART { get; set; } = "";
    
    
    public String SER { get; set; } = "";
    
    public String SUB_SER { get; set; } = "";
    
    public String NUM_DOC { get; set; } = "";
    
    public String DT_DOC { get; set; } = "";
    
    public String VL_DOC { get; set; } = "";
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{COD_PART}|{SER}|{SUB_SER}|{NUM_DOC}|{DT_DOC}|" +
                     $"{VL_DOC}|";
        return ret;
    }
}