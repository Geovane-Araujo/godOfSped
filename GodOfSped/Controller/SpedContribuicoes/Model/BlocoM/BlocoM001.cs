
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoM001
{
    public String REG { get; } = "M001";
    
    public String IND_MOV { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
}