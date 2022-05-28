
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoP001
{
    public String REG { get; } = "P001";
    
    public String IND_MOV { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{IND_MOV}|";
        
        return ret;
    }
}