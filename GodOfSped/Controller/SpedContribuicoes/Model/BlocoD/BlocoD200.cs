
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD200
{
    public String REG { get; } = "D200";
    
    public String COD_MOD { get; set; } = "";
    
    public String COD_SIT { get; set; } = "";
    
    public String SER { get; set; } = "";
    
    public String SUB { get; set; } = "";
    
    public String NUM_DOC_INI { get; set; } = "";
    
    public String NUM_DOC_FIN { get; set; } = "";
    
    public String CFOP { get; set; } = "";
    
    public String DT_REF { get; set; } = "";
    
    public String VL_DOC { get; set; } = "";
    
    public String VL_DESC { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{COD_SIT}|{SER}|{SUB}|{NUM_DOC_INI}|{NUM_DOC_FIN}|" +
                     $"{CFOP}|{DT_REF}|{VL_DOC}|{VL_DESC}|";
        return ret;
    }
}