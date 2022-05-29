
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC199
{
    public String REG { get; } = "C199";
    
    public String COD_DOC_IMP { get; set; } = "";
    
    public String NUM_DOC__IMP { get; set; } = "";
    
    public String VL_PIS_IMP { get; set; } = "";
    
    public String VL_COFINS_IMP { get; set; } = "";
    
    public String NUM_ACDRAW { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_DOC_IMP}|{NUM_DOC__IMP}|" +
                     $"{VL_PIS_IMP}|{VL_PIS_IMP}|{VL_COFINS_IMP}|{NUM_ACDRAW}|";
        
        return ret;
    }
}