
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1001
{
    public String REG { get; } = "1001";
    
    public String IND_MOV { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
}