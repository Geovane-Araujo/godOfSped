
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0206
{
    public String REG { get; } = "0206";
    
    public String COD_COMB { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_COMB}|";
        
        return ret;
    }
}