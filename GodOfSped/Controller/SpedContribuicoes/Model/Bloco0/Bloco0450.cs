
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0450
{
    public String REG { get; } = "0450";
    
    public String COD_INF { get; set; }
    
    public String TXT { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_INF}|{TXT}|";
        
        return ret;
    }
}