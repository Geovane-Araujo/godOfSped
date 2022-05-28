
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco9991
{
    public String REG { get; } = "9991";
    
    public String QTD_LIN_9 { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_9}|";
        
        return ret;
    }
}