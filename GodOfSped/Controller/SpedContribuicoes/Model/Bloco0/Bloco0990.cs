
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0990
{
    public String REG { get; } = "0990";
    
    public String QTD_LIN_0 { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_0}|";
        
        return ret;
    }
}