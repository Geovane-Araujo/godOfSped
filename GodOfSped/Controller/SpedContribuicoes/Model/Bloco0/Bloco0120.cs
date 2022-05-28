
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0120
{
    public String REG { get; } = "0120";
    
    public String MES_DISPENSA { get; set; }
    
    public String INF_COMP { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{MES_DISPENSA}|{INF_COMP}|";
        
        return ret;
    }
}