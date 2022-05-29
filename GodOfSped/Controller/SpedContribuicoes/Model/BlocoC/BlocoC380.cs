
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC380
{
    public String REG { get; } = "C380";
    
    public String COD_MOD { get; set; } = "";
    
    public String DT_DOC_INI { get; set; } = "";
    
    
    public String DT_DOC_FIN { get; set; } = "";
    
    public String NUM_DOC_INI { get; set; } = "";
    
    public String NUM_DOC_FIN { get; set; } = "";
    
    public String VL_DOC { get; set; } = "";
    
    public String VL_DOC_CANC { get; set; } = "";
    
   
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{DT_DOC_INI}|{DT_DOC_FIN}|{NUM_DOC_INI}|{NUM_DOC_FIN}|{VL_DOC}|" +
                     $"{VL_DOC_CANC}|";
        return ret;
    }
}