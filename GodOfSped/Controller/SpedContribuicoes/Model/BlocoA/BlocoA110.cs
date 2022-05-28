
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoA110
{
    public String REG { get; } = "A110";
    
    public String COD_INF { get; set; }
    
    public String TXT_COMPL { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_INF}|{TXT_COMPL}|";
        
        return ret;
    }
}