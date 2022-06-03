
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco9990
{
    public String REG { get; } = "9990";
    
    public String QTD_LIN_9 { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_9}|";
        
        return ret;
    }
}