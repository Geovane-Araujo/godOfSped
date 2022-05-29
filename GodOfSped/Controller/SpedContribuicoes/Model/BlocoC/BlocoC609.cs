
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC609
{
    public String REG { get; } = "C609";
    
    public String NUM_PROC { get; set; } = "";
    
    public String IND_PROC { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{NUM_PROC}|{IND_PROC}|";
        
        return ret;
    }
}