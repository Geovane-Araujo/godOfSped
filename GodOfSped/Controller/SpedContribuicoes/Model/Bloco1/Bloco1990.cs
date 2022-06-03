
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco1990
{
    public String REG { get; } = "1990";
    
    public String QTD_LIN_1 { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_1}|";
        
        return ret;
    }
}