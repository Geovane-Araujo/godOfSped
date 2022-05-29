
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC400
{
    public String REG { get; } = "C400";
    
    public String COD_MOD { get; set; } = "";
    
    public String ECF_MOD { get; set; } = "";
    
    public String ECF_FAB { get; set; } = "";
    
    public String ECF_CX { get; set; } = "";
    
    public String NUM_ACDRAW { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{ECF_MOD}|" +
                     $"{ECF_FAB}|{ECF_CX}|";
        
        return ret;
    }
}