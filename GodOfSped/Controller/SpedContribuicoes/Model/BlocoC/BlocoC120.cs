
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC120
{
    public String REG { get; } = "C120";
    
    public String COD_DOC_IMP { get; set; } = "";
    
    public String NUM_DOC_IMP { get; set; } = "";
    
    public String PIS_IMP { get; set; } = "";
    
    public String COFINS_IMP { get; set; } = "";
    
    public String NUM_ACDRAW { get; set; } = "";

    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_DOC_IMP}|{NUM_DOC_IMP}|{PIS_IMP}|{COFINS_IMP}|{NUM_ACDRAW}|";
        
        return ret;
    }
}