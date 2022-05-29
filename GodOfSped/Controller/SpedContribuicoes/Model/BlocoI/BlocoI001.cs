
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoI001
{
    public String REG { get; } = "I001";
    
    public String IND_MOV { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
}