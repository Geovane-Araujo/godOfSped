
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco9999
{
    public String REG { get; } = "9999";
    
    public String QTD_LIN { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN}|";
        
        return ret;
    }
}