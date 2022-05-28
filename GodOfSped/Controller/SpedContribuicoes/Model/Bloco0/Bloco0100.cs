
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0100
{
    public String REG { get; } = "0100";
    
    public String COD_SCP { get; set; }
    
    public String DESC_SCP { get; set; }
    
    public String INF_COMP { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_SCP}|{DESC_SCP}|{INF_COMP}|";
        
        return ret;
    }
}